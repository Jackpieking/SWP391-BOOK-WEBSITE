using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ReviewChapterDataSeeding : IEntityTypeConfiguration<ReviewChapter>
{
	public void Configure(EntityTypeBuilder<ReviewChapter> builder)
	{

	}
}
