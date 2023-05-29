using MangaManagementAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI.Data.ModelConfiguations;

internal class LoginAccountConfiguration : IEntityTypeConfiguration<LoginAccount>
{
	public void Configure(EntityTypeBuilder<LoginAccount> builder)
	{
		const string TableName = "Login-Account";
		const string VARCHAR_50 = "VARCHAR(50)";

		builder.ToTable(name: TableName);

		builder.HasKey(keyExpression: loginAccount => loginAccount.ID);

		builder
			.Property(propertyExpression: loginAccount => loginAccount.ID)
			.UseIdentityAlwaysColumn()
			.IsRequired();

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
			.Property(propertyExpression: loginAccount => loginAccount.UserIdentifier)
			.IsRequired();

		builder
			.HasIndex(loginAccount => loginAccount.UserName)
			.IsUnique();

		builder
			.HasIndex(loginAccount => loginAccount.UserIdentifier)
			.IsUnique();
	}
}
