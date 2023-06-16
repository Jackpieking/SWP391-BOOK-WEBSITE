using AutoMapper;
using Model;
using System;
using System.IO;

namespace Mapper.ModelAndDto;

public class UpdateCrawlDataToDatabaseAction_In_DtoToEntityProfile : Profile
{
	/// <summary>
	///
	/// </summary>
	public UpdateCrawlDataToDatabaseAction_In_DtoToEntityProfile()
	{
		#region Member mapping
		CreateMap<CrawlComicModel, ComicModel>()
			//comic identifier
			.ForMember(
				destinationMember: destination => destination.ComicIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})

			//publisher identifier
			.ForMember(
				destinationMember: destination => destination.PublisherIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));
				});

		CreateMap<CrawlChapterModel, ChapterModel>()
			//chapter identifier
			.ForMember(
				destinationMember: destination => destination.ChapterIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})

			//chapter image models
			.ForMember(
				destinationMember: destination => destination.ChapterImageModels,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => source.CrawlChapterImageModels);
				});

		CreateMap<CrawlChapterImageModel, ChapterImageModel>()
			//image identifier
			.ForMember(
				destinationMember: destination => destination.ImageIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})

			//image url
			.ForMember(
				destinationMember: destination => destination.ImageURL,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => $"{source.ImageNumber}{Path.GetExtension(new Uri(source.ImageUrl).GetLeftPart(UriPartial.Path))}");
				});

		CreateMap<CrawlCategoryModel, CategoryModel>()
			//category identifier
			.ForMember(
				destinationMember: destination => destination.CategoryIdentifier,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => Guid.NewGuid());
				})

			//category description
			.ForMember(
				destinationMember: destination => destination.CategoryDescription,
				memberOptions: option =>
				{
					option.MapFrom(mapExpression: source => string.Empty);
				});
		#endregion
	}
}
