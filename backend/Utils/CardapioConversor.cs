using System;

namespace backend.Utils
{
    public class CardapioConversor
    {
        public Models.TbCardapio ParaTabela(Models.Request.FastFoodRequest request)
        {
            Models.TbCardapio cardapio = new Models.TbCardapio();
            cardapio.VlPreco = request.Valor;
            cardapio.NmLanche = request.Nome;
            cardapio.NmBebida = request.Nome;
            cardapio.NmAcompanhamento = request.Nome;

            return cardapio;
        } 



         public Models.Response.FastFoodResponse ParaResponse(Models.TbCardapio cardapio)
        {
            Models.Response.FastFoodResponse resp = new Models.Response.FastFoodResponse();
            resp.Id = cardapio.IdCardapio;
            resp.Nome = cardapio.NmLanche;
            resp.Nome = cardapio.NmBebida;
            resp.Nome = cardapio.NmAcompanhamento;

            return resp;
        } 
    }
}