using Newtonsoft.Json;
using RestFulProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestFulProject.Services
{
    public class UserRestService
    {
        HttpClient client;

        public UserRestService()
        {
            client = new HttpClient();
        }

        //LOGIN fonksiyonu
        public async Task<USER> getUserByUserNameAndPassword(string username,string password) 
        {
            USER user = null;

            
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(username);
            queryString.Add("username",username);
            queryString.Add("password",password);

            var uri = new Uri(Constants.BaseUserAdress+"?"+queryString.ToString());

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync(); //gelen json nesnesini direkt olarak stringe ceviriyor
                    user = JsonConvert.DeserializeObject<USER>(content); // gelens stringi bir adet user nesnesine donusturuyor
                }
            }
            catch (Exception )
            {

                return null;
            }

            return user;
        }

        public async Task<string> addUser(USER u)
        {
            string result = "";

            var uri = new Uri(Constants.BaseUserAdress);
            try
            {
                var json = JsonConvert.SerializeObject(u);
                var content = new StringContent(json,Encoding.UTF8,"application/json");
                HttpResponseMessage response = await client.PostAsync(uri, content);

                HttpStatusCode code = response.StatusCode;

                if (code == HttpStatusCode.OK)
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
