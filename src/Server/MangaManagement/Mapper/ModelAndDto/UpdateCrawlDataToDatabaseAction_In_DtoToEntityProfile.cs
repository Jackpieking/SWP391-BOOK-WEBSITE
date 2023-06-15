using AutoMapper;
using DTO.Incoming;
using Model;
using System;

namespace Mapper.ModelAndDto;

public class UpdateCrawlDataToDatabaseAction_In_DtoToEntityProfile : Profile
{
	/// <summary>
	///
	/// </summary>
	public UpdateCrawlDataToDatabaseAction_In_DtoToEntityProfile()
	{
		#region Member mapping
		CreateMap<UpdateCrawlDataToDatabaseAction_In_Dto.ComicDtoType, ComicModel>()
			.ForMember(
				destinationMember: destination => destination.PublisherIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));
				});

		CreateMap<UpdateCrawlDataToDatabaseAction_In_Dto.CategoryDtoType, CategoryModel>();

		CreateMap<UpdateCrawlDataToDatabaseAction_In_Dto.ChapterDtoType, ChapterModel>()
			.ForMember(
				destinationMember: destination => destination.ChapterImageModels,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => source.ChapterImageDtos);
				});

		CreateMap<UpdateCrawlDataToDatabaseAction_In_Dto.ChapterDtoType.ChapterImageDtoType, ChapterImageModel>();
		#endregion
	}
}
