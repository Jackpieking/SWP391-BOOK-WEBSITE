using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ChapterDataSeeding : IEntityTypeConfiguration<Chapter>
{
	public void Configure(EntityTypeBuilder<Chapter> builder)
	{
		ICollection<Chapter> chapters = new List<Chapter>()
		{

		};

		builder.HasData(data: chapters);
	}
}
