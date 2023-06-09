﻿using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ComicSavingEntityToComicSavingModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ComicSavingEntity => ComicSavingModel
    /// </summary>
    public ComicSavingEntityToComicSavingModelProfile()
    {
        CreateMap<ComicSavingEntity, ComicSavingModel>()
        #region Member mapping
            //UserModel
            .ForMember(
                destinationMember: comicSavingEntity => comicSavingEntity.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
            //ComicModel
            .ForMember(
                destinationMember: comicSavingEntity => comicSavingEntity.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })
        #endregion
        .ReverseMap();
    }
}
