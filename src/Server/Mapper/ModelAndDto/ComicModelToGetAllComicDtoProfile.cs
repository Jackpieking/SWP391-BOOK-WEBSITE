using AutoMapper;
using DTO;
using Model;

namespace Mapper.ModelAndDto;

public class ComicModelToGetAllComicDtoProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicModel => GetAllComicAction_Out_Dto
    /// </summary>
    public ComicModelToGetAllComicDtoProfile()
    {
        CreateMap<ComicModel, GetAllComicAction_Out_Dto>();
    }
}
