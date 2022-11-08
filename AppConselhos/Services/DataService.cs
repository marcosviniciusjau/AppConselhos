using System;
using System.Collections.Generic;
using System.Text;


using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselhos.Model;
using Xamarin.Forms;

namespace AppConselhos.Services
{
    public class DataServices
    {
        public static async Task<Conselho> GetConselho()
        {

            string queryString = "https://api.adviceslip.com/advice" ;

            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            try
            {

                Conselho conselho_descricao = new Conselho();


                return conselho_descricao;
            }
            catch (Exception ex)
            {
             
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

        internal static Task<Conselho> GetConselho(Action<object, EventArgs> btnConselho_Clicked)
        {
            throw new NotImplementedException();
        }
    }
    }
