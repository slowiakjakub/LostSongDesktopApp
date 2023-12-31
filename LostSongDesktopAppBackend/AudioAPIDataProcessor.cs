﻿using AcoustID;
using LostSongDesktopAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace LostSongDesktopAppBackend
{
    public class AudioAPIDataProcessor
    {
        /// <summary>
        /// Sends a request to AcoustID API.
        /// </summary>
        /// <param name="fingerprint">Audio fingerprint data</param>
        /// <param name="duration">Duration of the whole audio file in seconds</param>
        /// <returns>Information about audio stored in data models</returns>
        public static async Task<LookupResponseModel> LoadLookupData(string fingerprint, int duration)
        {
            var body = new Dictionary<string, string>();
            body.Add("client", Configuration.ClientKey);
            body.Add("fingerprint", fingerprint);
            body.Add("duration", $"{duration}");
            var content = new FormUrlEncodedContent(body);

            string url = $"https://api.acoustid.org/v2/lookup?&meta=recordings+releasegroups+releases";

            using (HttpResponseMessage response = await APIHelper.ApiClient.PostAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    LookupResponseModel lookupResponse = await response.Content.ReadAsAsync<LookupResponseModel>();
                    return lookupResponse;
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
        }

        public static async Task PostSongToDb(string artist, string title)
        {

            string url = $"https://lostsong-backend-144649aa504e.herokuapp.com/api/songs";

            var songData = new
            {
                artist = artist,
                title = title
            };

            var json = JsonConvert.SerializeObject(songData);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await APIHelper.ApiClient.PostAsync(url, data);

        }
    }
}
