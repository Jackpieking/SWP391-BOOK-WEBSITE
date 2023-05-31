using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfiguations;

internal class UserAccessConfiguration : IEntityTypeConfiguration<UserInfo>
{
	public void Configure(EntityTypeBuilder<UserInfo> builder)
	{
		const string TableName ="User-Access";
		const string VARCHAR_30 = "VARCHAR(30)";
		const string VARCHAR_50 = "VARCHAR(50)";

		builder.ToTable(name: TableName);

		builder.HasKey(keyExpression: userAccess => userAccess.ID);

		builder
			.Property(propertyExpression: userAccess => userAccess.ID)
			.UseIdentityByDefaultColumn();

		builder
			.Property(propertyExpression: loginAccount => loginAccount.UserName)
			.HasColumnType(typeName: VARCHAR_50)
			.IsRequired();

		builder
			.Property(propertyExpression: loginAccount => loginAccount.Password)
			.HasColumnType(typeName: VARCHAR_50)
			.IsRequired();

		builder
			.Property(propertyExpression: loginAccount => loginAccount.Role)
			.IsRequired();

		builder
			.Property(propertyExpression: userAccess => userAccess.FullName)
			.HasColumnType(typeName: VARCHAR_30)
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
			.HasColumnType(typeName: VARCHAR_30)
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
	}
}
