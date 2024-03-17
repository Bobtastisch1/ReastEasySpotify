﻿using Newtonsoft.Json.Linq;
using ReastEasySpotify.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static ReastEasySpotify.Models.Search;

namespace ReastEasySpotify.Controllers
{
    internal class GetSearch
    {
        public async Task<SearchDTO> GetSearchs(string q, string type)
        {
            Url baseUrl = new();
            string url = baseUrl.GetBaseUrl();

            ISpotifyAPI client = RestClient.For<ISpotifyAPI>(url);

            GetTokenQuery GetToken = new();
            string token = GetToken.SetAuthorization();

            if (string.IsNullOrWhiteSpace(token))
            {
                // Handle error or return null
                return null;
            }

            client.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                Response<object> response = await client.GetSearchAsync(q, type);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    SearchDTO searchResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchDTO>(response.StringContent);
                    // Parse and return search result
                    return searchResponse;
                }
                else
                {
                    // Handle error or return null
                    return null;
                }
            }
            catch (Exception e)
            {
                // Handle exception or return null
                return null;
            }
        }
    }
}