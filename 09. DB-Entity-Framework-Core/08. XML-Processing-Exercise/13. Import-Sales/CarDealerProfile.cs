using AutoMapper;
using CarDealer.DTO.Input;
using CarDealer.Models;
using System;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            this.CreateMap<CustomerInputModel, Customer>()
                .ForMember(x => x.BirthDate, y => y.MapFrom(s => DateTime.Parse(s.BirthDate)));
        }
    }
}
