﻿using AutoMapper;
using Entity;
using Model;

namespace Mapper.ModelToEntity;

public class ReviewComicEntityAndReviewComicModelProfile : Profile
{
    /// <summary>
    /// Map configuration from ReviewComicEntity => ReviewComicModel
    /// </summary>
    public ReviewComicEntityAndReviewComicModelProfile()
    {
        CreateMap<ReviewComicEntity, ReviewComicModel>()
        #region Member mapping
            //ComicModel
            .ForMember(
                destinationMember: destination => destination.ComicModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.ComicEntity);
                })
            //UserModel
            .ForMember(
                destinationMember: destination => destination.UserModel,
                memberOptions: option =>
                {
                    option.MapFrom(mapExpression: source => source.UserEntity);
                })
        #endregion
        .ReverseMap();
    }
}