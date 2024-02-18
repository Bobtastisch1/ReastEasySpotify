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

        public async Task<string> GetSearchAsync(string q, string typ, bool fehler, string fehlermeldung)
        {
            const string Methode = "GetSearch";

            fehler = false;
            fehlermeldung = "";

            try
            {
                HttpClient client = new();
                string URL = $"search/?{q}&type={typ}";

                HttpResponseMessage response = await client.GetAsync(URL);

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
