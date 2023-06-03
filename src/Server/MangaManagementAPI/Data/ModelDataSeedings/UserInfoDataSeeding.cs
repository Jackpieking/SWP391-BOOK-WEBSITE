using MangaManagementAPI.Data.Models;
using MangaManagementAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class UserInfoDataSeeding : IEntityTypeConfiguration<UserInfo>
{
	public void Configure(EntityTypeBuilder<UserInfo> builder)
	{
		ICollection<UserInfo> users = new List<UserInfo>()
		{
			new()
			{
				UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
				UserName = "John Doe",
				Password = "12345678",
				FullName = "John Doe",
				Gender = DefinedGender.MALE,
				BirthDay = DateOnly.FromDateTime(dateTime: DateTime.UtcNow),
				PhoneNumber = "1234567890",
				Email = "johndoe@example.com",
				AccountBalance = 1000
			},
			new()
			{
				UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
				UserName = "Jane Smith",
				Password = "12345678",
				FullName = "Jane Smith",
				Gender = DefinedGender.FEMALE,
				BirthDay = DateOnly.FromDateTime(dateTime: DateTime.UtcNow),
				PhoneNumber = "5550123456",
				Email = "janesmith@example.com",
				AccountBalance = 1500
			},
			new()
			{

				UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
				UserName = "Alice Thompson",
				Password = "12345678",
				FullName = "Alice Thompson",
				Gender = DefinedGender.OTHERS,
				BirthDay = DateOnly.FromDateTime(dateTime: DateTime.UtcNow),
				PhoneNumber = "7778889999",
				Email = "alicethompson@example.com",
				AccountBalance = 2000
			}
		};

		builder.HasData(data: users);
	}
}
