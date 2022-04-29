using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }
        public async Task<string> GetGeoInfo()
        {

            var ipAddress = await GetIPAddress();

            var response = await httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=2500765c85ce118349358cff03ce09d8");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var model = new JSONLesen();
                model = JsonConvert.DeserializeObject<JSONLesen>(json);
                return model.City;
            }
            return null;
        }
    }
}
