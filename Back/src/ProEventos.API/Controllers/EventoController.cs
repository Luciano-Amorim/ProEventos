﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
           new Evento(){
                EventoId = 1,
                Local = "Salvador",
                Tema = "Estou de saco cheio",
                Lote = "1º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL="foto.jpeg"}, 
                
                new Evento(){
                EventoId = 2,
                Local = "Salvador",
                Tema = "Cansei",
                Lote = "1º Lote",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemURL="Nada.jpeg"}
                
           }; 
        
        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get() 
        {
           return _evento;
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id) 
        {
           return _evento.Where(evento => evento.EventoId == id );
            
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de POST";
        }

        [HttpPut ("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id= {id}";
        }

        [HttpDelete ("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id= {id}";
        }
    }
}
