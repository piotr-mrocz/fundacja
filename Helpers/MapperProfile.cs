using AutoMapper;
using FundacjaZawszeRazem.DTOs;
using FundacjaZawszeRazem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<PetsListDTO, Pet>().ReverseMap();
            CreateMap<PetDetailsDTO, Pet>().ReverseMap();

            CreateMap<PetToAddDTO, Pet>().ReverseMap();
            CreateMap<PetToUpdateDTO, Pet>().ReverseMap();

            CreateMap<FoundHomeListDTO, FoundHome>().ReverseMap();
            CreateMap<FoundHomeDetailsDTO, FoundHome>().ReverseMap();

            CreateMap<FoundHomeToAddDTO, FoundHome>().ReverseMap();
            CreateMap<FoundHomeToUpdateDTO, FoundHome>().ReverseMap();

            CreateMap<RecentlyFoundListDTO, RecentlyFound>().ReverseMap();
            CreateMap<RecentlyFoundDetailsDTO, RecentlyFound>().ReverseMap();

            CreateMap<RecentlyFoundToAddDTO, RecentlyFound>().ReverseMap();
            CreateMap<RecentlyFoundToUpdateDTO, RecentlyFound>().ReverseMap();
        }


    }
}
