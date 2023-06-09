using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ChapterImageEntityToChapterImageModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ChapterImageEntity => ChapterImageModel
    /// </summary>
    public ChapterImageEntityToChapterImageModelProfile()
    {
        CreateMap<ChapterImageEntity, ChapterImageModel>()
        #region Member mapping
            //ChapterEntity
            .ForMember(
                destinationMember: chapterImageEntity => chapterImageEntity.ChapterModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ChapterEntity);
                })
        #endregion
        .ReverseMap();
    }
}
