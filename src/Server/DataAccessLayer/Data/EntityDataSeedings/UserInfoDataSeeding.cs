using MangaManagementAPI.Data.Entites;
using MangaManagementAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class UserInfoDataSeeding : IEntityTypeConfiguration<UserInfo>
{
	/// <summary>
	/// Set some seeding data for UserInfo Table
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<UserInfo> builder)
	{
		/**
		 * Data for UserInfo table
		 */
		#region UserInfoSeedingData
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
				AccountBalance = 1000,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
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
				AccountBalance = 1500,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
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
				AccountBalance = 2000,
				Avatar = Path.Combine("C:", "Users", "USER", "Downloads", "pic1.jpg")
			}
		};
		#endregion

		builder.HasData(data: users);
	}
}
