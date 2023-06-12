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
        CreateMap<ChapterImageModel, GetAllChapterImageOfAChapterAction_Out_Dto>();
    }
}
