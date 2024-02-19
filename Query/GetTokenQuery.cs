using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Query
{
    internal class GetTokenQuery
    {

        public string GetToken()
        {
            Task<string> tokenTask = GetTokenAsync();

            return tokenTask.Result;
        }

        public async Task<String> GetTokenAsync()
        {
            string tokenUrl = "https://accounts.spotify.com/authorize";

            FormUrlEncodedContent tokenRequestContent = GetTokenRequestContent();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpReponse = null;
            try
            {
                httpReponse = await httpClient.PostAsync(tokenUrl, tokenRequestContent).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler bei PostAsync: " + ex.Message);
            }
            string result = "";
            try
            {
                result = await httpReponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler bei ReadAsStringAsync: " + ex.Message);
            }

            string token = GetAccessToken(result);

            return token;
        }

        private static string GetAccessToken(string res)
        {
            TokenResponse TokenResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenResponse>(res);
            return TokenResponse?.access_token;
        }

        private FormUrlEncodedContent  GetTokenRequestContent()
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues["grant_type"] = "client_credentials";
            keyValues["client_id"] = TokenSecret.GetToken_Client();
            keyValues["scope"] = "playlist-modify-public playlist-read-private playlist-modify-private";
            keyValues["client_secret"] = TokenSecret.GetToken_Secret();

            FormUrlEncodedContent tokenRequestContent = new FormUrlEncodedContent(keyValues);

            return tokenRequestContent;
        }

        public class TokenResponse
        {
            public string access_token { get; set; }
            public string expires_in { get; set; }
            public string refresh_expires_in { get; set; }
            public string refresh_token { get; set; }
            public string token_type { get; set; }
            public string id_token { get; set; }
            public string session_state { get; set; }
            public string scope { get; set; }
        }
    }
}
