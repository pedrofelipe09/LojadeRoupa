﻿namespace LojaAPI.Controllers.DTO.Produto
{
    public class CreateProdutoDto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int Validade { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
