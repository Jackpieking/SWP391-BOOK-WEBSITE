using AutoMapper;
using DTO.Outgoing;
using Model;
using System.Collections.Generic;

namespace Mapper.ModelAndDto;

public class ComicModelToGetComicDetailDtoProfile : Profile
{
    public ComicModelToGetComicDetailDtoProfile()
    {
        CreateMap<ComicModel, GetComicDetailAction_Out_Dto>()
        #region Member mapping
            //ReviewComicDtos
            .ForMember(
                destinationMember: comicModel => comicModel.ComicReviews,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source
                        => new List<GetComicDetailAction_Out_Dto.ReviewComicDto>());
                })
            //CategoryNames
            .ForMember(
                destinationMember: comicModel => comicModel.CategoryNames,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => new List<string>());
                })
            //ChapterDtos
            .ForMember(
                destinationMember: comicModel => comicModel.ComicChapters,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterModels);
                });
        #endregion

        CreateMap<ReviewComicModel, GetComicDetailAction_Out_Dto.ReviewComicDto>()
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
                });
        #endregion

        CreateMap<ChapterModel, GetComicDetailAction_Out_Dto.ChapterDto>();
    }
}
