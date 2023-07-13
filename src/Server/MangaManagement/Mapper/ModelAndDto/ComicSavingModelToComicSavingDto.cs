using AutoMapper;

namespace Mapper.ModelAndDto
{
    public class ComicSavingModelToComicSavingDto : Profile
    {
        //public ComicSavingModelToComicSavingDto()
        //{
        //    CreateMap<ComicSavingModel, ComicSavingDto>()
        //        .ForMember(destinationMember: destination => destination.ComicName,
        //        options =>
        //        {
        //            options.MapFrom(mapExpression: source => source.ComicModel.ComicName);
        //        });
        //}
    }
}