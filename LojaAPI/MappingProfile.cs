using AutoMapper;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._03_Entidades;

namespace LojaAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProdutoDto, Produto>().ReverseMap();
        }
    }
}
