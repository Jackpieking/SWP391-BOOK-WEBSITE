using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ChapterImageEntityAndChapterImageModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ChapterImageEntity => ChapterImageModel
    /// </summary>
    public ChapterImageEntityAndChapterImageModelProfile()
    {
        CreateMap<ChapterImageEntity, ChapterImageModel>()
        #region Member mapping
            //ChapterEntity
            .ForMember(
                destinationMember: destination => destination.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                })
        #endregion
        .ReverseMap();
    }
}
