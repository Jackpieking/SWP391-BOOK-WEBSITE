using AutoMapper;
using DTO.Incoming;
using Model;

namespace Mapper.ModelAndDto
{
    public class ReviewComicModelToReviewComicDto : Profile
    {
        public ReviewComicModelToReviewComicDto()
        {
            CreateMap<ReviewComicModel, ReviewComicDto>()
                .ForMember(destinationMember: destination => destination.ComicName,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.ComicModel.ComicName);
                })
                .ForMember(destinationMember: destination => destination.ComicStatus,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.ComicModel.ComicStatus);
                })
                .ForMember(destinationMember: destination => destination.Username,
                options =>
                {
                    options.MapFrom(mapExpression: source => source.UserModel.Username);
                })
                .ReverseMap();
        }
    }
}