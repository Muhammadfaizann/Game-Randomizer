using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Game_Randomizer.Client
{
    public class RestClient
    {
        private string login = "ayna";
        private string token = "12784-OhJLY5mb3BSOx0O";
        public RestClient()
        {
        }

        public static async Task<ApiResponse> Get()
        {
            using (var client = new HttpClient())
            {
                var request = await client.GetAsync("https://spoyer.ru/api/en/get.php?login=ayna&token=12784-OhJLY5mb3BSOx0O&task=livedata&sport=soccer");
                if (request.IsSuccessStatusCode)
                {
                    return new ApiResponse { Response = await request.Content.ReadAsStringAsync() };
                }
                else
                    return new ApiResponse { ErrorMessage = request.ReasonPhrase };
            }

        }
        }
    
    public class ApiResponse
    {
        public bool Successful => ErrorMessage == null;
        public string ErrorMessage { get; set; }
        public string Response { get; set; }
    }
}

