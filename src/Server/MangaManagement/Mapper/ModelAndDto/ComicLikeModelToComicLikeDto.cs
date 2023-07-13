using AutoMapper;

namespace Mapper.ModelAndDto
{
    public class ComicLikeModelToComicLikeDto : Profile
    {
        //public ComicLikeModelToComicLikeDto()
        //{
        //    CreateMap<ComicLikeModel, ComicLikeDto>()
        //        .ForMember(destinationMember: destination => destination.ComicAvatar,
        //        options =>
        //        {
        //            options.MapFrom(mapExpression: source => source.ComicModel.ComicAvatar);
        //        })
        //        .ForMember(destinationMember: destination => destination.ComicName,
        //        options =>
        //        {
        //            options.MapFrom(mapExpression: source => source.ComicModel.ComicName);
        //        });
        //}
    }
}