using AutoMapper;
using DTO.Outgoing;
using Model;

namespace Mapper.ModelAndDto;

public class ComicModelToGetComicDetailDtoProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicModel => GetComicDetail_Out_Dto
    /// </summary>
    public ComicModelToGetComicDetailDtoProfile()
    {
        CreateMap<ComicModel, GetComicDetailAction_Out_Dto>();
    }
}
