using App1.Servico.Modelo;
using Newtonsoft.Json;
using System.Net;

namespace App1.Servico
{
    public class ViaCepServico
    {
        private static string EnderecoURL { get; set; } = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            var novoEndereco = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            var conteudo = wc.DownloadString(novoEndereco);

            
            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);

            if (endereco.Cep is null) return null;

            return endereco;
        }
    }
}
