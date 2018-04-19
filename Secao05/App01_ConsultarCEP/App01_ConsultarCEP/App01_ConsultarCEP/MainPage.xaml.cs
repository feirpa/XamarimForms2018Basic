using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;

namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			Botao.Clicked += BuscarCep;
		}

		private void BuscarCep(object sender, EventArgs args)
		{
			string cep = txtCep.Text?.Trim();

			lblResultado.Text = "";

			if (isValidCEP(cep))
			{
				try
				{
					Endereco end = ViaCEPServico.BuscarEnderecoViaCep(cep);

					lblResultado.Text = end.ToString();
				}
				catch (Exception ex)
				{
					DisplayAlert("ERRO CRITICO", ex.Message, "OK");
				}
			}

		}

		private bool isValidCEP(string cep)
		{
			if (string.IsNullOrEmpty(cep))
				return false;

			if (cep.Length != 8)
			{
				DisplayAlert("ERRO", "Cep deve conter 8 caracteres.", "OK");
				return false;
			}

			int aux = 0;
			if (!int.TryParse(cep, out aux))
			{
				DisplayAlert("ERRO", "Cep deve possuir apenas numeros.", "OK");
				return false;
			}

			return true;
		}
	}
}
