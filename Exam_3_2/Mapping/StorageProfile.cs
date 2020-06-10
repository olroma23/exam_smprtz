using AutoMapper;
using Exam_3_2.Entity;
using Exam_3_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_3_2.Mapping
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            CreateMap<Shop, ShopModel>().ReverseMap();
        }
    }
}
