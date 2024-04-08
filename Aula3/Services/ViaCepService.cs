using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Services
{
    public class ViaCepService
    {
        /// <summary>
        /// Método para consulta de dados de endereço baseado em CEP
        /// </summary>
        /// <param name="cep">Numero do cep desejado</param>
        /// <returns>Endereço baseado no cep informado</returns>
        public string GetData(string cep)
        {
            //instanciando o objeto HTTP CLIENT
            var httpClient = new HttpClient();

            //fazendo uma requisição na API do ViaCep para consultar endereço
            var response = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            //verificando se a resposta obteve sucesso
            if (response.IsSuccessStatusCode)
            {
                //retornando o conteúdo obtido na resposta
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                //retornando uma mensagem de erro
                return "\nErro ao obter o endereço, verifique o valor informado.";
            }
        }
    }
}
