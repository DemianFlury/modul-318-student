using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SwissTransportGUI
{
    internal class Ortung
    {

        private HttpClient httpClient { get;}

        public Ortung()
        {
            httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(10)
            };
        }

        private async Task<string> GetIPAddress()
        {
            var ipAddress = await httpClient.GetAsync($"http://ipinfo.io/ip");
            if (ipAddress.IsSuccessStatusCode)
            {
                var json = await ipAddress.Content.ReadAsStringAsync();
                return json.ToString();
            }
            return "";
        }
        public async Task<string> GetGeoInfo()
        {

            var ipAddress = await GetIPAddress();

            var response = await httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=2500765c85ce118349358cff03ce09d8");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }
    }
}
