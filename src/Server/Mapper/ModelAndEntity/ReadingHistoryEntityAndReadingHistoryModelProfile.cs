using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReadingHistoryEntityAndReadingHistoryModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReadingHistoryEntity => ReadingHistoryModel
    /// </summary>
    public ReadingHistoryEntityAndReadingHistoryModelProfile()
    {
        CreateMap<ReadingHistoryEntity, ReadingHistoryModel>()
        #region Member mapping
            //UserModel
            .ForMember(
                destinationMember: readingHistoryEntity => readingHistoryEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ChapterModel
            .ForMember(
                destinationMember: readingHistoryEntity => readingHistoryEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                })
        #endregion
        .ReverseMap();
    }
}
