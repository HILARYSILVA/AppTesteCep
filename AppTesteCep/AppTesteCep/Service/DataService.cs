using AppTesteCep.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppTesteCep.Service
{
    public class DataService
    {

        public static async Task<Endereco> GetEnderecoByCep(string cep)
        {
            Endereco end;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/endereco/by-cep?cep=");

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    end = JsonConvert.DeserializeObject<Endereco>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return end;
        }






        public static async Task<List<Bairro>> GetBairrosByIdCidade(int id_Cidade)
        {
            List<Bairro> arr_bairro = new List<Bairro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/bairro/by-cidade?id_cidade=");

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content?.ReadAsStringAsync().Result;

                    arr_bairro = JsonConvert.DeserializeObject<List<Bairro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return arr_bairro;
        }
        public static async Task<List<Logradouro>> GetLogradouroByBairroAndCidade(int id_Cidade, string id_Bairro)
        {
            List<Logradouro> arr_logradouro = new List<Logradouro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/Logradouro/by-bairro?id_cidade=&bairro=");

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content?.ReadAsStringAsync().Result;

                    arr_logradouro = JsonConvert.DeserializeObject<List<Logradouro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return arr_logradouro;
        }
        public static async Task<List<Logradouro>> GetCepByLogradouro(int cep)
        {
            List<Logradouro> arr_logradourocep = new List<Logradouro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/Logradouro/by-bairro?id_cidade=&bairro=");

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content?.ReadAsStringAsync().Result;

                    arr_logradourocep = JsonConvert.DeserializeObject<List<Logradouro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }
            return arr_logradourocep;
        }

    } 
}
