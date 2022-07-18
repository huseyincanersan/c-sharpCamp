using AdaApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdaApp.Services
{
    public class PoliycRestServer
    {
        HttpClient client;

        public PoliycRestServer()
        {
            client = new HttpClient();
        }

        //Police ekleme fonksiyonu
        public async Task<string> addPolicy(POLICY policy)
        {
            string result = "";

            var uri = new Uri(Constants.BasePolicyAdress);

            try
            {
                var json = JsonConvert.SerializeObject(policy);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(uri, content);
                HttpStatusCode code = response.StatusCode;

                if (code==HttpStatusCode.OK)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception)
            {

                return null;
            }



            return result;
        }

        //Policeleri listelemek
        public async Task<List<POLICY>> getPolicies()
        {
            List<POLICY> policies = new List<POLICY>();
            var uri = new Uri(Constants.BasePolicyAdress);

            try
            {
                var response = await client.GetAsync(uri);
                HttpStatusCode code = response.StatusCode;
                if (code==HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    policies = JsonConvert.DeserializeObject<List<POLICY>>(content);
                    //if (policies==null)
                    //{
                    //    return new List<POLICY>();
                    //}
                }
            }
            catch (Exception)
            {

                return policies;
            }

            return policies;
        }


        //Police Silme Fonksiyonu
        public async Task<string> deletePolicy(int id)
        {
            string result = "";

            var uri = new Uri(Constants.BasePolicyAdress+"/"+id.ToString());
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);
                HttpStatusCode code = response.StatusCode;

                if (code==HttpStatusCode.OK)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception)
            {

                return null;
            }

            return result;

        }

    }
}
