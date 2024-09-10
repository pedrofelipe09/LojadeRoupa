using AutoMapper;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._01_Service;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ProdutoController:ControllerBase
    {
        private readonly ProdutoRepository _repository;
       // private readonly IMapper _mapper;

        public ProdutoController( string connection)
        {
            _repository = new ProdutoRepository(connection);
        }


        [HttpPost("Adicionar-dapper")]
        public void AdicionarProduto(Produto produto)

        {
            //Produto produto1 = _mapper.Map<Produto>(produto);
            _repository.AdicionarProduto(produto);
        }
        //[HttpGet("Listar-Produtos")]
        //public List<Produto> ListarProdutos()
        //{
        //    return _repository.ListarProdutos();
        //}



    }
}
