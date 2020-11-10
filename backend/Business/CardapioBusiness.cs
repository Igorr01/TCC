using System;
using System.Collections.Generic;
using System.Linq;


namespace backend.Business
{
    public class CardapioBusiness
    {
        Database.TbCardapioDatabase db = new Database.CardapioDatabase();


         public Models.TbCardapio Salvar(Models.TbCardapio cardapio)
        {
            if (cardapio.VlPreco == stringEmpty)
                throw new Exception("Este campo é obrigatório");
            if (cardapio.NmLanche == stringEmpty)
                throw new Exception("Este campo é obrigatório");
            if (cardapio.NmBebida == stringEmpty)
                throw new Exception("Este campo é obrigatório");
            if (cardapio.NmAcompanhamento == stringEmpty)
                throw new Exception("Este campo é obrigatório");

            return db.Salvar(cardapio);
        }


        public List<Models.TbCardapio> Listar() 
        {
            return db.Listar();
        }
    }
}