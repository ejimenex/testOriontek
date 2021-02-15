using AutoMapper;
using MDEntities.Model;
using MDRepository.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDApi
{
    public class Mapping
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Product, ProductDto>().ReverseMap();
                //
          
            });
            IMapper mapper = config.CreateMapper();
            return mapper;
        }
    }
}