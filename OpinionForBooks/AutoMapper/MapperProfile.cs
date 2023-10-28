using AutoMapper;
using DB.Models;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.AutoMapper
{
    public class MapperProfile  : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookModel, Book>().ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.DateCreation))
            .ForMember(dest => dest.ResumeBook, opt => opt.MapFrom(src => src.summary))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status == 0 ? 1 : src.Status ))
            .ReverseMap();
            CreateMap<Book, BookDTO>()
           .ForMember(dest => dest.DateCreation, opt => opt.MapFrom(src => src.CreationDate))
            .ForMember(dest => dest.summary, opt => opt.MapFrom(src => src.ResumeBook))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
            .ForMember(dest => dest.AutorName, opt => opt.MapFrom(src => src.Autor.NickName));
            CreateMap<ReviewBook, ReviewBookDTO>()
           .ForMember(dest => dest.ReviewId, opt => opt.MapFrom(src => src.ReviewBookId))
           .ForMember(dest => dest.Qualification, opt => opt.MapFrom(src => src.Qualification.ToString()))
           .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
           .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.BookId))
           .ReverseMap();

            CreateMap<ReviewBookModel, ReviewBook>()
            .ForMember(dest => dest.Qualification, opt => opt.MapFrom(src => int.Parse(src.Qualification)))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status == 0 ? 1 : src.Status))
            .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.CreationDate))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
            .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.BookId))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ReverseMap();
            CreateMap<UserModel, User>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status == 0 ? 1 : src.Status))
           .ReverseMap();
            CreateMap<User, UserDTO>()
            .ReverseMap();

            CreateMap<Category, CategoryDTO>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId)).ReverseMap();
            CreateMap<Autor, AutorDTO>()
            .ForMember(dest => dest.AutorId, opt => opt.MapFrom(src => src.AutorId))
            .ForMember(dest => dest.AutorName, opt => opt.MapFrom(src => src.NickName));

    }
    }
}
