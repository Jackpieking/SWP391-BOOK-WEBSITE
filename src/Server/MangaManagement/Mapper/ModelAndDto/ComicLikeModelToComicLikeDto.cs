using AutoMapper;
using DTO.Incoming;
using Entity;
using Microsoft.Extensions.Options;

namespace Mapper.ModelAndDto
{
    public class ComicLikeModelToComicLikeDto : Profile
    {
        public ComicLikeModelToComicLikeDto()
        {
            CreateMap<ComicLikeModel, ComicLikeDto>().ForMember(destinationMember: destination => destination.Username,
                option =>
                {
                    option.MapFrom(mapExpression: source => source.UserModel.Username);
                })
                .ForMember(destinationMember: destination => destination.ComicName,
                option =>
                {
                    option.MapFrom(mapExpression: source => source.UserModel.Username);
                })
                .ReverseMap();
        }

    }
}