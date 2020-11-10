using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace backend.Database
{
    public class CardapioDatabase
    {
        Models.cardapiodbContext db = new Models.cardapiodbContext();


        public Models.TbCardapio Salvar(Models.TbCardapio cardapio)
        {
            db.Add(cardapio);
            db.SaveChanges();

            return cardapio;
        }


        public List<Models.TbCardapio> Listar() 
        {
            List<Models.TbCardapio> cardapio = db.TbCardapio.ToList();
            return cardapio;
        }
    }
}