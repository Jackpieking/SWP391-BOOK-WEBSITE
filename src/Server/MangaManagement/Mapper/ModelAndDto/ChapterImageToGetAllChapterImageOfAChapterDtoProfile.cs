using AutoMapper;
using DTO.Outgoing;
using Model;

namespace Mapper.ModelAndDto;

public class ChapterImageToGetAllChapterImageOfAChapterDtoProfile : Profile
{
    /// <summary>
    ///
    /// </summary>
    public ChapterImageToGetAllChapterImageOfAChapterDtoProfile()
    {
        CreateMap<ChapterModel, GetAllChapterImageOfAChapterAction_Out_Dto>()
            //ComicName
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.ComicName,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicModel.ComicName);
                })
            //ChapterReviews
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.ChapterReviews,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewChapterModels);
                });


        CreateMap<ChapterImageModel, GetAllChapterImageOfAChapterAction_Out_Dto.ChapterImageDto>();

        CreateMap<ReviewChapterModel, GetAllChapterImageOfAChapterAction_Out_Dto.ReviewChapterDto>()
        #region Member mapping
            //Username
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.Username,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserModel.Username);
                })
            //UserAvatar
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.UserAvatar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserModel.UserAvatar);
                })
            //ChapterComment
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.ChapterComment,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterComment);
                })
            //ChapterRatingStart
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.ChapterRatingStar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterRatingStar);
                })
            //ReviewTime
            .ForMember(
                destinationMember: reviewComicModel => reviewComicModel.ReviewTime,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ReviewTime);
                });
        #endregion
    }
}
