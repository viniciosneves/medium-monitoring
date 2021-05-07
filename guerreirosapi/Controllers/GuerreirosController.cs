using guerreirosapi.InMemory;
using guerreirosapi.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guerreirosapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuerreirosController : ControllerBase
    {

        private readonly ILogger<GuerreirosController> _logger;
        private readonly InMemoryContext _context;


        public GuerreirosController(ILogger<GuerreirosController> logger, InMemoryContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public List<Guerreiro> Get()
        {
            return _context.Guerreiros.ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public Guerreiro Get(int id)
        {
            return _context.Guerreiros
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        [HttpPost]
        public Guerreiro Post([FromBody] Guerreiro guerreiro)
        {

            _context.Guerreiros.Add(guerreiro);
            _context.SaveChanges();
            return guerreiro;
        }

        [HttpPut]
        public Guerreiro Put([FromBody] Guerreiro guerreiro)
        {
            Guerreiro model = Obter(guerreiro.Id);
            model.Nome = guerreiro.Nome;
            _context.SaveChanges();
            return model;
        }

        private Guerreiro Obter(int id)
        {
            return _context.Guerreiros
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        [HttpDelete]
        [Route("{id}")]
        public Guerreiro Delete(int id)
        {

            Guerreiro model = Obter(id);
            _context.Guerreiros.Remove(model);
            _context.SaveChanges();
            return model;
        }

    }
}
