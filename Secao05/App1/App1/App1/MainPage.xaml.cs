using App1.Servico;
using App1.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Botao.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs eventArgs)
        {
            try
            {
                var cep = Cep.Text.Trim();
                if (IsValidCep(cep))
                {
                    Endereco end = ViaCepServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        Resultado.Text = string.Format("Endereço: {0},{1},{2}", end.Logradouro, end.Localidade, end.UF);
                    }
                    else
                    {
                        DisplayAlert("Erro", "Endereço não encontrado para CEP: " + cep, "OK");

                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro - Crítico!", ex.Message, "OK");
            }

        }

        private bool IsValidCep(string cep)
        {
            cep = cep.Replace("-", "");

            int novoCEP = 0;
            if (!int.TryParse(cep, out novoCEP))
            {
                DisplayAlert("Erro - CEP inválido!", "Cep deve ser composto apenas por números.", "OK");
                return false;
            }

            if (cep.Length != 8)
            {
                DisplayAlert("Erro - CEP inválido!", "Cep deve conter 8 carecteres.", "OK");
                return false;
            }


            return true;
        }
    }
}
