using Newtonsoft.Json.Linq;
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

        public async Task<string> GetSearchAsync(string q, string typ, bool fehler = false, string fehlermeldung = "")
        {
            const string Methode = "GetSearch";

            try
            {
                HttpClient client = new();
                string values = $"search/?{q}&type={typ}";
                Url baseUrl = new();
                string url = baseUrl.GetUrl(values);

                client.DefaultRequestHeaders.Add("Accept", "application/json");

                GetTokenQuery GetToken = new();

                string token = GetToken.GetToken();

                if (string.IsNullOrWhiteSpace(token)) 
                {
                    fehler = true;
                    fehlermeldung = Methode + ": Fehler bei getToken";

                    return "";
                };

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await client.GetAsync(url);

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
