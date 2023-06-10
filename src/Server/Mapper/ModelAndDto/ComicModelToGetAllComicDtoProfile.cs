using AutoMapper;
using DTO;
using Model;

namespace Mapper.ModelAndDto;

public class ComicModelToGetAllComicDtoProfile : Profile
{
    public ComicModelToGetAllComicDtoProfile()
    {
        /// <summary>
        /// Map configuration from ComicModel => GetAllComicAction_Out_Dto
        /// </summary>
        CreateMap<ComicModel, GetAllComicAction_Out_Dto>()
        #region Member mapping
            //ComicName
            .ForMember(
                destinationMember: destination => destination.ComicName,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicName);
                })
            //ComicPublishDate
            .ForMember(
                destinationMember: destination => destination.ComicPublishDate,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicPublishDate);
                })
            //ComicLastestChapter
            .ForMember(
                destinationMember: destination => destination.ComicLatestChapter,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicLatestChapter);
                })
            //ComicAvatar
            .ForMember(
                destinationMember: destination => destination.ComicAvatar,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicAvatar);
                });
        #endregion
    }
}
