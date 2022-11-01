using System;
using System.Collections.Generic;
using System.Text;


using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselhos.Model;


namespace AppConselhos.Services
{
    public class DataServices
    {
        public static async Task<Conselho> GetConselho(string conselho)
        {

            string queryString = "https://api.adviceslip.com/advice" + conselho;

          

            if (conselho != null)
            {
                Conselho conselho_descricao = new Conselho();

                conselho_descricao.Descricao = (string)conselho;

                return conselho_descricao;
            }
            else
            {
                return null;
            }
        }
        public static async Task<dynamic> getDataFromService(string queryString)
            {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(queryString);
                dynamic data = null;
                if (response != null)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(json);
                }
                return data;
            }
        }
    }
