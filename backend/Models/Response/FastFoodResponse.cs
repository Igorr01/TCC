using System;

namespace backend.Models.Response
{

    public class FastFoodResponse {
        public class Login {
            public int IdLogin  { get; set; }
            public string DsEmail { get; set; }
            public string DsSenha { get; set; }
            public string DsPerfil { get; set; }
        }

        public class Cliente {
            public int IdCliente { get; set; }
            public int IdLogin { get; set; }
            public string NmCliente { get; set; }
            public DateTime DtNascimento { get; set; }
            public string DsEndereco { get; set; }
            public string DsCPF { get; set; }
            public string NrCelular { get; set; }
            public string NrTelefone { get; set; }
        }


        public class Cardapio {
            public int IdCardapio { get; set; }
            public string NmLanche { get; set; }
            public string NmBebida { get; set; }
            public string NmAcompanhamento { get; set; }
        }


        public class CardapioCombo {
            public int IdCardapioCombo { get; set; }
            public string NmLanche { get; set; }
            public string NmBebida { get; set; }
            public string NmAcompanhamento { get; set; }
        }

    }
}