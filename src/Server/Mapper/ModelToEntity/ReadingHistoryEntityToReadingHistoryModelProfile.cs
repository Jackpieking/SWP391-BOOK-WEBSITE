using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReadingHistoryEntityToReadingHistoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReadingHistoryEntity => ReadingHistoryModel
    /// </summary>
    public ReadingHistoryEntityToReadingHistoryModelProfile()
    {
        CreateMap<ReadingHistoryEntity, ReadingHistoryModel>()
        #region Member mapping
            //UserIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserIdentifier);
                })
            //ChapterIdentifier
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterIdentifier,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterIdentifier);
                })
            //LastReadingTime
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.LastReadingTime,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.LastReadingTime);
                })
            //UserModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ChapterModel
            .ForMember(
                destinationMember: userInfoEntity => userInfoEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                });
        #endregion
    }
}
