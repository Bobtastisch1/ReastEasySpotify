using RestEase;

namespace ReastEasySpotify.Youtube.Controllers
{
    internal class GetSearch
    {

        public async Task<Models.Search.SearchDTO> GetSearches(string part, string q,string type)
        {
            Url baseUrl = new();
            string url = baseUrl.GetBaseYoutubeUrl();

            IYoutube youtube = RestClient.For<IYoutube>(url);

            try
            {
                Response<object> response = await youtube.GetSearchAsync(part, q, YoutubeSecret.GetApiKey(),type);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    Models.Search.SearchDTO searchDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Search.SearchDTO>(response.StringContent);

                    return searchDTO;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
