using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangaManagementAPI;

internal class UserAccessConfiguration : IEntityTypeConfiguration<UserInfo>
{    public void Configure(EntityTypeBuilder<UserInfo> builder)
    {

		const string TableName ="User-Access";
		const string VARCHAR_30 = "VARCHAR(30)";
		const string VARCHAR_50 = "VARCHAR(50)";
        builder.ToTable(name: TableName);

        builder.HasKey(keyExpression: userAccess => userAccess.ID);

        builder
            .Property(propertyExpression: userAccess => userAccess.FullName)
            .HasColumnType(VARCHAR_30)
            .IsRequired(required: false);

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
            .Property(propertyExpression: userAccess => userAccess.Gender)
            .IsRequired();

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
			.Property(propertyExpression: userAccess => userAccess.Email)
			.HasColumnType(typeName: VARCHAR_30)
			.IsRequired();

        builder
            .Property(propertyExpression: userAccess => userAccess.Avatar)
            .HasColumnType(typeName: "VARCHAR")
            .HasMaxLength(maxLength: 50)
            .HasDefaultValue("") //set defaul value like facebook avatar
            .IsRequired();

        builder
            .Property(propertyExpression: userAccess => userAccess.UserIdentifier)
            .IsRequired();

        builder
            .HasIndex(indexExpression: userAccess => userAccess.UserIdentifier)
            .IsUnique();

        // builder
        //     .HasOne(navigationExpression: userAccess => userAccess.LoginAccount)
        //     .WithOne(navigationExpression: loginAccount => loginAccount.UserAccess)
        //     .HasPrincipalKey<UserInfo>(keyExpression: userAccess => userAccess.UserIdentifier)
        //     .HasForeignKey<LoginAccount>(foreignKeyExpression: loginAccount => loginAccount.UserIdentifier)
        //     .OnDelete(deleteBehavior: DeleteBehavior.Cascade)
        //     .IsRequired();

		// builder
		// 	.HasIndex(indexExpression: userAccess => userAccess.UserIdentifier)
		// 	.IsUnique();
	}

}
