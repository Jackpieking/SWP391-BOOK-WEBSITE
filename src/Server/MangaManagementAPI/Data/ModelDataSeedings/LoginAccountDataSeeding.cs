using MangaManagementAPI.Data.Models;
using MangaManagementAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.ModelDataSeedings;

internal class LoginAccountDataSeeding : IEntityTypeConfiguration<LoginAccount>
{
	void IEntityTypeConfiguration<LoginAccount>.Configure(EntityTypeBuilder<LoginAccount> builder)
	{
		LoginAccount loginAccount = new()
		{
			UserName = "jackpieking",
			Password = "Jackpie2003",
			Role = Role.READER,
			UserIdentifier = Guid.Parse(input: "585a96f6-3d1b-4fa3-83f1-e2da38ecd92b")
		};

		builder.HasData(data: loginAccount);
	}
}
