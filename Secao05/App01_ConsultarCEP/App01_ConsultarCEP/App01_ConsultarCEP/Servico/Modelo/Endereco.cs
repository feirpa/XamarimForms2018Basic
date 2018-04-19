using System;
using System.Collections.Generic;
using System.Text;

namespace App01_ConsultarCEP.Servico.Modelo
{
	public class Endereco
	{
		public string cep { get; set; }
		public string logradouro { get; set; }
		public string complemento { get; set; }
		public string bairro { get; set; }
		public string localidade { get; set; }
		public string uf { get; set; }
		public string unidade { get; set; }
		public string ibge { get; set; }
		public string gia { get; set; }

		public override string ToString()
		{
			if (cep == null)
			{
				return "Cep invalido.";
			}

			return $@"CEP: {cep}
                      Logradouro: {logradouro}
                      Complemento: {complemento}
                      Bairro: {bairro}
                      Localidade: {localidade}
                      Uf: {uf}
                      Unidade: {unidade}
                      Ibge: {ibge}
                      Gia: {gia}";
		}
	}
}
