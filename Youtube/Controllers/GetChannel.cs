using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Youtube.Controllers
{
    public class GetChannel
    {
        public async Task<Models.Channel.ChannelDTO> GetChannels(string part, string forUsername)
        {
            Url baseUrl = new();
            string url = baseUrl.GetBaseYoutubeUrl();

            IYoutube youtube = RestClient.For<IYoutube>(url);

            try
            {
                Response<object> response = await youtube.GetChannelsAsync(part, forUsername, YoutubeSecret.GetApiKey());

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    Models.Channel.ChannelDTO channelDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Channel.ChannelDTO>(response.StringContent);

                    return channelDTO;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception)
            {
                return null;
            }

        }


    }
}
