﻿using LostSongDesktopAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostSongDesktopAppBackend.DataAccess
{
    public class FileTagger : IFileTagger
    {
        public void TagFile(string filePath, LookupResponseModel lookupResponse)
        {
            var tfile = TagLib.File.Create(filePath);

            ModelValidator modelValidator = new ModelValidator(lookupResponse);

            bool isValidResults = false;
            List<LookupResultModel> validResults = modelValidator.TryGetValidLookupResults(out isValidResults);

            if (isValidResults)
            {
                bool isValidRecordings = false;
                List<RecordingModel> validRecordings = modelValidator.TryGetValidRecordings(validResults.First().Recordings, out isValidRecordings);
                if (isValidRecordings)
                {
                    // At this point we can tag properties checked inside TryGetValidRecordings() method
                    RecordingModel firstValidRecording = validRecordings.First();

                    tfile.Tag.Performers = firstValidRecording.GetAllArtistsNames();
                    tfile.Tag.Title = firstValidRecording.Title;

                    List<ReleaseGroupModel> foundSongReleaseGroups = modelValidator.GetReleaseGroupsBySpecificArtists(firstValidRecording.ReleaseGroups, firstValidRecording.Artists);

                    if (foundSongReleaseGroups.Count > 0)
                    {
                        ReleaseGroupModel foundSongFirstReleaseGroup = foundSongReleaseGroups.First();

                        if (foundSongFirstReleaseGroup.Type.Equals("Album"))
                        {
                            if (foundSongFirstReleaseGroup.Title != null)
                            {
                                //At this point we can tag info about an album
                                tfile.Tag.Album = foundSongFirstReleaseGroup.Title;
                            }
                        }
                        bool isValidReleases = false;
                        List<ReleaseModel> validReleases = modelValidator.TryGetValidReleases(foundSongFirstReleaseGroup.Releases, out isValidReleases);

                        if (isValidReleases)
                        {
                            // At this point we can tag info about the year of the release
                            ReleaseModel firstValidRelease = validReleases.First();
                            tfile.Tag.Year = uint.Parse(firstValidRelease.Date.Year);
                        }
                    }
                    tfile.Save();
                }
            }
        }
    }
}
