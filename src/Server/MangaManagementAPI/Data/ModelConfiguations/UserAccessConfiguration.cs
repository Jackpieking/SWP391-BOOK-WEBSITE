using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfiguations;

internal class UserAccessConfiguration : IEntityTypeConfiguration<UserAccess>
{
	public void Configure(EntityTypeBuilder<UserAccess> builder)
	{
		const string TableName ="User-Access";
		const string VARCHAR_30 = "VARCHAR(30)";

		builder.ToTable(name: TableName);

		builder.HasKey(keyExpression: userAccess => userAccess.ID);

		builder
			.Property(propertyExpression: userAccess => userAccess.ID)
			.ValueGeneratedOnAdd()
			.IsRequired();

		builder
			.Property(propertyExpression: userAccess => userAccess.FullName)
			.HasColumnType(VARCHAR_30)
			.IsRequired(required: false);

		builder
			.Property(propertyExpression: userAccess => userAccess.Age)
			.IsRequired(required: false);

		builder
			.Property(propertyExpression: userAccess => userAccess.Gender)
			.IsRequired(required: false);

		builder
			.Property(propertyExpression: userAccess => userAccess.BirthDay)
			.IsRequired(required: false);

		builder
			.Property(propertyExpression: userAccess => userAccess.Email)
			.HasColumnType(VARCHAR_30)
			.IsRequired();

		builder
			.Property(propertyExpression: userAccess => userAccess.AccountBalance)
			.IsRequired();

		builder
			.Property(propertyExpression: userAccess => userAccess.Avatar)
			.IsRequired(required: false);

		builder
			.Property(propertyExpression: userAccess => userAccess.UserIdentifier)
			.IsRequired();

		builder
			.HasIndex(indexExpression: userAccess => userAccess.UserIdentifier)
			.IsUnique();

		builder
			.HasOne(navigationExpression: userAccess => userAccess.LoginAccount)
			.WithOne(navigationExpression: loginAccount => loginAccount.UserAccess)
			.HasPrincipalKey<UserAccess>(keyExpression: userAccess => userAccess.UserIdentifier)
			.HasForeignKey<LoginAccount>(foreignKeyExpression: loginAccount => loginAccount.UserIdentifier)
			.OnDelete(deleteBehavior: DeleteBehavior.Cascade)
			.IsRequired();
	}
}
