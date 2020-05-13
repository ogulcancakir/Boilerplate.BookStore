using AutoMapper;
using Ogulcan.BookStore.Authors;

namespace Ogulcan.BookStore.Authors
{
    public class AuthorMapProfile : Profile
    {
        public AuthorMapProfile()
        {
            CreateMap<AuthorDto, Author>();
        }
    }
}
