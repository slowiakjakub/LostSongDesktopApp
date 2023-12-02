﻿using AcoustID;
using LostSongDesktopAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

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
    }
}
