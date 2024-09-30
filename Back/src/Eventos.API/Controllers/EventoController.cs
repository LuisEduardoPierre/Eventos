using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eventos.API.Models;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){

                    EventoId = 1,
                    Tema = "Agular 13 e .NET 6",
                    Local = "BH",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "Foto.png"
                      },
                new Evento(){

                    EventoId = 2,
                    Tema = "Agular e suas novidades",
                    Local = "SP",
                    Lote = "2° Lote",
                    QtdPessoas = 400,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "Banner.png"
                      },

        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _evento;
    }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(EventoController => EventoController.EventoId == id);
    }

        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete com id = {id}";
        }
    }
}
