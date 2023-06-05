using MangaManagementAPI.Data.Entites;
using MangaManagementAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.EntityConfigurations;

public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
{   /// <summary>
	/// Configure UserInfo table fiels and relationships
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<UserInfo> builder)
	{

		const string TableName = "user_access";
		const string VARCHAR_30 = "VARCHAR(30)";
		const string VARCHAR_50 = "VARCHAR(50)";
		const string VARCHAR_13 = "VARCHAR(13)";
		const string GEN_RANDOM_UUID = "gen_random_uuid()";
		const string CURRENT_DATE = "CURRENT_DATE";

		builder.ToTable(name: TableName);

		//primary key: UserIdentifier
		builder.HasKey(keyExpression: userInfo => userInfo.UserIdentifier);

		builder
			.Property(propertyExpression: userInfo => userInfo.UserIdentifier)
			.HasDefaultValueSql(sql: GEN_RANDOM_UUID);

		//field: UserName
		builder
			.Property(propertyExpression: userInfo => userInfo.UserName)
			.HasColumnType(typeName: VARCHAR_50)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: Password
		builder
			.Property(propertyExpression: userInfo => userInfo.Password)
			.HasColumnType(typeName: VARCHAR_50)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: FullName
		builder
			.Property(propertyExpression: userInfo => userInfo.FullName)
			.HasColumnType(typeName: VARCHAR_30)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: Gender
		builder
			.Property(propertyExpression: userAccess => userAccess.Gender)
			.HasDefaultValue(value: DefinedGender.OTHERS)
			.IsRequired();

		//field: BirthDay
		builder
			.Property(propertyExpression: userAccess => userAccess.BirthDay)
			.HasDefaultValueSql(sql: CURRENT_DATE)
			.IsRequired();

		//field: PhoneNumber
		builder
			.Property (propertyExpression: userInfo => userInfo.PhoneNumber)
			.HasColumnType(typeName: VARCHAR_13)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: Email
		builder
			.Property(propertyExpression: userInfo => userInfo.Email)
			.HasColumnType(typeName: VARCHAR_30)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();

		//field: Account Balance
		builder
			.Property(propertyExpression: userInfo => userInfo.AccountBalance)
			.HasDefaultValue(value: default(int))
			.IsRequired();

		//field: Avatar
		builder
			.Property(propertyExpression: userInfo => userInfo.Avatar)
			.HasColumnType(typeName: VARCHAR_50)
			.HasDefaultValue(value: string.Empty)
			.IsRequired();


		/**
		 *
		 * Relationship
		 *
		 */
		// One to many: UserInfo => TransactionHistory
		builder
			.HasMany(navigationExpression: userInfo => userInfo.TransactionHistories)
			.WithOne(navigationExpression: transactionHistory => transactionHistory.UserInfo)
			.HasForeignKey(foreignKeyExpression: transactionHistory => transactionHistory.UserIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: UserInfo => ReadingHistory
		builder
			.HasMany(navigationExpression: userInfo => userInfo.ReadingHistories)
			.WithOne(navigationExpression: readingHistory => readingHistory.UserInfo)
			.HasForeignKey(foreignKeyExpression: readingHistory => readingHistory.UserIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: UserInfo => ComicSaving
		builder
			.HasMany(navigationExpression: userInfo => userInfo.ComicSavings)
			.WithOne(navigationExpression: comicSaving => comicSaving.UserInfo)
			.HasForeignKey(foreignKeyExpression: comicSaving => comicSaving.UserIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: UserInfo => ReviewComic
		builder
			.HasMany(navigationExpression: userInfo => userInfo.ReviewComics)
			.WithOne(navigationExpression: reviewComic => reviewComic.UserInfo)
			.HasForeignKey(foreignKeyExpression: reviewComic => reviewComic.UserIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);

		// One to many: UserInfo => ReviewChapter
		builder
			.HasMany(navigationExpression: userInfo => userInfo.ReviewChapters)
			.WithOne(navigationExpression: reviewChapter => reviewChapter.UserInfo)
			.HasForeignKey(foreignKeyExpression: reviewChapter => reviewChapter.UserIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired(required: false);
	}
}
