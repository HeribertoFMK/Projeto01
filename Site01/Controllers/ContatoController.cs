using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ReceberContato([FromForm]Contato contato)
        {

            if (ModelState.IsValid)
            {
                string conteudo = string.Format("Nome:{0},E-mail:{1},Assunto:{2} ,Menssagem:{3}", contato.Nome, contato.Email, contato.Assunto, contato.Menssagem);

                return new ContentResult() { Content = conteudo };

            }
            else
            {
                return View("Index");
            }
            
        }

        //Obter Dados Manualmente
        /*public ActionResult ReceberContato()
        {
            //Post - Request.Form
            //Get - Request.Query ou Request.QueryString

            Contato contato = new Contato();

            contato.Nome = Request.Form["nome"]; 
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Mensagem = Request.Form["menssagem"];

            string conteudo = string.Format("Nome:{0},E-mail:{1},Assunto:{2} ,Menssagem:{3}",contato.Nome,contato.Email,contato.Assunto,contato.Mensagem);

            return new ContentResult(){Content = conteudo };
        }*/
    }
}
