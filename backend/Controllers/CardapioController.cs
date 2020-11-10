using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class CardapioController : ControllerBase
    {
        Business.CardapioBusiness business = new Business.CardapioBusiness();
        Utils.CardapioConversor conversor = new Utils.CardapioConversor();

        [HttpPost]
        public ActionResult<Models.Response.FastFoodResponse> Inserir(Models.Request.FastFoodRequest request)
        {
            try
            {
                Models.TbCardapio cardapio = conversor.ParaTabela(request);
                business.Salvar(cardapio);

                Models.Response.FastFoodResponse resp = conversor.ParaResponse(cardapio);
                return resp;
            }
            catch (System.Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }


        [HttpGet]
        public ActionResult<List<Models.Response.FastFoodResponse>> Listar()
        {
            try
            {
                List<Models.TbCardapio> cardapio = business.Listar();
                if (cardapio.Count == 0)
                        return NotFound();

                List<Models.Response.FastFoodResponse> resp = conversor.ParaResponse(cardapio);
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new Models.Response.ErroResponse(500, ex.Message)
                );
            }
        }
    }
}