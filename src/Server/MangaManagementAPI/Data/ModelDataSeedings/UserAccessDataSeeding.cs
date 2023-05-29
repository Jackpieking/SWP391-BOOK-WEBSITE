﻿using MangaManagementAPI.Data.Models;
using MangaManagementAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangaManagementAPI.Data.ModelDataSeedings;

internal class UserAccessDataSeeding : IEntityTypeConfiguration<UserAccess>
{
	void IEntityTypeConfiguration<UserAccess>.Configure(EntityTypeBuilder<UserAccess> builder)
	{
		UserAccess userAccess = new()
		{
			ID = 1,
			FullName = "Le Dinh Dang Khoa",
			Gender = Gender.MALE,
			BirthDay = new(year: 2003, month: 12, day: 03),
			Email = "ledinhdangkhoa10a9@gmail.com",
			AccountBalance = 10_000_000,
			UserIdentifier = Guid.Parse(input: "585a96f6-3d1b-4fa3-83f1-e2da38ecd92b")
		};

		builder.HasData(data: userAccess);
	}
}
