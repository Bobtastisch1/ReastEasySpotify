using Newtonsoft.Json.Linq;
using ReastEasySpotify.Model;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Query
{
    internal class Query
    {

        public async Search GetSearch(string q, string typ, bool fehler = false, string fehlermeldung = "")
        {
            const string Methode = "GetSearch";
            string values = $"search/?{q}&type={typ}";
            Url baseUrl = new();
            string url = baseUrl.GetUrl(values);

            ISpotifyAPI client = RestClient.For<ISpotifyAPI>(url);

            GetTokenQuery GetToken = new();
            string token = GetToken.SetAuthorization();

            if (string.IsNullOrWhiteSpace(token))
            {
                fehler = true;
                fehlermeldung = Methode + ": Fehler bei getToken";

                return "";
            };

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {                                           

                var response = await client.GetSearch(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    fehler = true;
                    fehlermeldung = $"Error: {response.StatusCode}";
                    return fehlermeldung;
                }
            }
            catch (Exception e)
            {
                fehler = true;
                fehlermeldung = $"Error: " + e.Message;
                return fehlermeldung;
            }
        }


    }
}
