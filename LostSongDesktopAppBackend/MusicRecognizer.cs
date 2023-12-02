using LostSongDesktopAppBackend.AudioProcessing;
using LostSongDesktopAppBackend.DataAccess;
using LostSongDesktopAppBackend.Exceptions;
using LostSongDesktopAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostSongDesktopAppBackend
{
    public class MusicRecognizer
    {
        IFileTagger _fileTagger;
        public string RecognizedSongName { get; private set; }

        public MusicRecognizer(IFileTagger fileTagger)
        {
            _fileTagger = fileTagger;
        }

        public async Task RunMusicTagForAudioFileAsync(string filePath) // TODO - make task fully asynchronous
        {
            LookupResponseModel lookupResponse;

            NAudioDecoder decodedFile = new NAudioDecoder(filePath);
            if (decodedFile.Length >= FingerprintProcessor.MinimumLengthForGeneratingFingerprint)
            {
                string fingerprint = await (Task.Run(() => FingerprintProcessor.GetFingerprintFromFile(decodedFile)));
                lookupResponse = await AudioAPIDataProcessor.LoadLookupData(fingerprint, decodedFile.Length);
            }
            else
            {
                throw new AudioTooShortException("Audio file's duration is too small.");
            }

            if (lookupResponse.Results.Count > 0) // In case we got results from the lookup
            {
                _fileTagger.TagFile(filePath, lookupResponse);

                RecognizedSongName = lookupResponse.CreateBasicFileName();
                FileProcessor.RenameFile(ref filePath, RecognizedSongName);
            }
            else
            {
                throw new ResultsArrayEmptyException("There is no matching song in a database.");
            }
        }
    }
}
