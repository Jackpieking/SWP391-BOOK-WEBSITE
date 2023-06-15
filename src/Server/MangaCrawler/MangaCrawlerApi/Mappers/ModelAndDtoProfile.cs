using AutoMapper;
using MangaCrawlerApi.Data.Models;
using MangaCrawlerApi.DTOs.Outgoing;
using System;
using System.IO;

namespace MangaCrawlerApi.Mappers;

public class ModelAndDtoProfile : Profile
{
	/// <summary>
	///
	/// </summary>
	public ModelAndDtoProfile()
	{
		#region Member mapping
		CreateMap<Comic, UpdateCrawlDataToDatabaseAction_Out_Dto.ComicDtoType>()
			.ForMember(
				destinationMember: destination => destination.ComicIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})
			.ForMember(
				destinationMember: destination => destination.ComicChapterDtos,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => source.ComicChapters);
				})
			.ForMember(
				destinationMember: destination => destination.ComicCategoryDtos,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => source.ComicCategories);
				});

		CreateMap<Chapter, UpdateCrawlDataToDatabaseAction_Out_Dto.ChapterDtoType>()
			.ForMember(
				destinationMember: destination => destination.ChapterIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})
			.ForMember(
				destinationMember: destination => destination.ChapterImageDtos,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => source.ChapterImages);
				});

		CreateMap<ChapterImage, UpdateCrawlDataToDatabaseAction_Out_Dto.ChapterDtoType.ChapterImageDtoType>()
			.ForMember(
				destinationMember: destination => destination.ImageIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})
			.ForMember(
				destinationMember: destination => destination.ImageURL,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => $"{source.ImageNumber}{Path.GetExtension(new Uri(source.ImageUrl).GetLeftPart(UriPartial.Path))}");
				});

		CreateMap<Category, UpdateCrawlDataToDatabaseAction_Out_Dto.CategoryDtoType>()
			.ForMember(
				destinationMember: destination => destination.CategoryIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})
			.ForMember(
				destinationMember: destination => destination.CategoryDescription,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => string.Empty);
				});
		#endregion
	}
}
