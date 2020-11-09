using System;

namespace backend.Models.Request 
{
    public class FastFoodRequest 
    {
        public class Login
        {
            public string DsEmail { get; set; }
            public string DsSenha { get; set; }
        }

        public class Cliente 
        {
            public string NmCliente { get; set; }
            public string DsCPF { get; set; }
        }

        public class Cardapio 
        {
            public string NmLanche { get; set; }
            public string NmBebida { get; set; }
            public string NmAcompanhamento { get; set; }
        }

        public class CardapioCombo 
        {
            public int IdCardapioCombo { get; set; }
            public string NmLanche { get; set; }
            public string NmBebida { get; set; }
            public string NmAcompanhamento { get; set; }
        }

    }
}