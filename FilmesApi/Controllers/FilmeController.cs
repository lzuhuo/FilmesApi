using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using FilmesApi.Profiles;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        

        [HttpPost]
        public IActionResult InsereFilme(CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);

            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RetornaFilme), new { codigo = filme.CD_FILME }, filme);
        }

        [HttpGet]
        public IActionResult RetornaFilmes()
        {
            return Ok(_context.Filmes);
        }

        [HttpGet("{codigo}")]
        public IActionResult RetornaFilme(int codigo)
        {
            Filme filme = _context.Filmes.FirstOrDefault(e => e.CD_FILME == codigo);
            if(filme != null)
            {
                ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
                return Ok(filmeDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{codigo}")]
        public IActionResult AtualizaFilme(int codigo, [FromBody] UpdateFilmeDto filmedto)
        {
            Filme filme = _context.Filmes.FirstOrDefault(e => e.CD_FILME == codigo);
            if(filme == null)
            {
                return NotFound();
            }
            filme = _mapper.Map<Filme>(filmedto);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{codigo}")]
        public IActionResult DeletaFilme(int codigo)
        {
            Filme filme = _context.Filmes.FirstOrDefault(e => e.CD_FILME == codigo);
            if (filme == null)
            {
                return NotFound();
            }
            _context.Remove(filme);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
