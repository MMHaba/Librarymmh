using AutoMapper;
using Librarymmh.Dtos;
using Librarymmh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Librarymmh.App_Start
{
    public class MappingProfile : Profile
    {

        //constructor
        public MappingProfile()
        {
            //I wanna be able to map customer to customerDto
            Mapper.CreateMap<Customer, CustomerDto>();
            //I wanna be able to map customerDto to customer
            Mapper.CreateMap<CustomerDto, Customer>();
            //I wanna be able to map book to bookdto
            Mapper.CreateMap<Book, BookDto>();
            //be able to map bookdto to book
            Mapper.CreateMap<BookDto, Book>();
            //I wanna be able to map genre to GenreDto
            Mapper.CreateMap<Genre, GenreDto>();
            //I wanna be able to map GenreDto to Genre
            Mapper.CreateMap<GenreDto, Genre>();
        }
    }
}