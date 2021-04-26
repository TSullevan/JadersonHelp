using System.Collections.Generic;
using System.Linq;
using JadersonHelp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JadersonHelp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RastreioController : ControllerBase
    {
        private readonly ILogger<RastreioController> _logger;
        private readonly RastreioDbContext _rastreioDbContext;

        public RastreioController(ILogger<RastreioController> logger, RastreioDbContext rastreioDbContext)
        {
            _logger = logger;
            _rastreioDbContext = rastreioDbContext;
        }

        [HttpGet("{index}")]
        public Preco Get(int index)
        {

            // Preco precoLegal = new Preco()
            // {
            //     PrecoFixo = 30,
            //     PrecoKm = 31,
            //     PrecoPeso = 32,
            //     PrecoVolume = 33
            // };

            // _rastreioDbContext.Precos.Add(precoLegal);

            // _rastreioDbContext.SaveChanges();

            Preco precoEncontrado = _rastreioDbContext.Precos.FirstOrDefault(x => x.IdPreco == index);

            return precoEncontrado;
        }
    }
}
