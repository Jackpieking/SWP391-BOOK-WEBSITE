using DataAccessLayer.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class UserInfoEntityConfiguration : IEntityTypeConfiguration<UserInfoEntity>
{   /// <summary>
    /// Configure UserInfo table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<UserInfoEntity> builder)
    {

        const string TableName = "user_access";
        const string VARCHAR_30 = "VARCHAR(30)";
        const string VARCHAR_50 = "VARCHAR(50)";
        const string VARCHAR_13 = "VARCHAR(13)";
        const string GEN_RANDOM_UUID = "gen_random_uuid()";

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
            .IsRequired();

        //field: Password
        builder
            .Property(propertyExpression: userInfo => userInfo.Password)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: FullName
        builder
            .Property(propertyExpression: userInfo => userInfo.FullName)
            .HasColumnType(typeName: VARCHAR_30)
            .IsRequired();

        //field: Gender
        builder
            .Property(propertyExpression: userAccess => userAccess.Gender)
            .IsRequired();

        //field: BirthDay
        builder
            .Property(propertyExpression: userAccess => userAccess.BirthDay)
            .IsRequired();

        //field: PhoneNumber
        builder
            .Property(propertyExpression: userInfo => userInfo.PhoneNumber)
            .HasColumnType(typeName: VARCHAR_13)
            .IsRequired();

        //field: Email
        builder
            .Property(propertyExpression: userInfo => userInfo.Email)
            .HasColumnType(typeName: VARCHAR_30)
            .IsRequired();

        //field: Account Balance
        builder
            .Property(propertyExpression: userInfo => userInfo.AccountBalance)
            .IsRequired();

        //field: Avatar
        builder
            .Property(propertyExpression: userInfo => userInfo.Avatar)
            .HasColumnType(typeName: VARCHAR_50)
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
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: UserInfo => ReadingHistory
        builder
            .HasMany(navigationExpression: userInfo => userInfo.ReadingHistories)
            .WithOne(navigationExpression: readingHistory => readingHistory.UserInfo)
            .HasForeignKey(foreignKeyExpression: readingHistory => readingHistory.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: UserInfo => ComicSaving
        builder
            .HasMany(navigationExpression: userInfo => userInfo.ComicSavings)
            .WithOne(navigationExpression: comicSaving => comicSaving.UserInfo)
            .HasForeignKey(foreignKeyExpression: comicSaving => comicSaving.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: UserInfo => ReviewComic
        builder
            .HasMany(navigationExpression: userInfo => userInfo.ReviewComics)
            .WithOne(navigationExpression: reviewComic => reviewComic.UserInfo)
            .HasForeignKey(foreignKeyExpression: reviewComic => reviewComic.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: UserInfo => ReviewChapter
        builder
            .HasMany(navigationExpression: userInfo => userInfo.ReviewChapters)
            .WithOne(navigationExpression: reviewChapter => reviewChapter.UserInfo)
            .HasForeignKey(foreignKeyExpression: reviewChapter => reviewChapter.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to one: UserInfo => Publisher
        builder
            .HasOne(navigationExpression: userInfo => userInfo.Publisher)
            .WithOne(navigationExpression: publisher => publisher.UserInfo)
            .HasForeignKey<PublisherEntity>(foreignKeyExpression: publisher => publisher.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: UserInfo => BuyingHistory
        builder
            .HasMany(navigationExpression: userInfo => userInfo.BuyingHistories)
            .WithOne(navigationExpression: buyingHistory => buyingHistory.UserInfo)
            .HasForeignKey(foreignKeyExpression: buyingHistory => buyingHistory.UserIdentifer)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}
