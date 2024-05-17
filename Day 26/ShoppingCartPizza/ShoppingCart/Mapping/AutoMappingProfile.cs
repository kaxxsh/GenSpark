using AutoMapper;
using ShoppingCart.Model;
using ShoppingCart.Model.Dto;

namespace ShoppingCart.Mapping
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<orders,OrderDto>().ReverseMap();
            CreateMap<pizzas, PizzaDto>().ReverseMap();
            CreateMap<createOrderDto, orders>().ReverseMap();
            CreateMap<createPizzaDto, pizzas>().ReverseMap();
            CreateMap<updateOrderDto, orders>();
            CreateMap<updatePizzaDto, pizzas>();

        }
    }
}
