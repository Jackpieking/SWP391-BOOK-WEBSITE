using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Data.EntityConfigurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{   /// <summary>
    /// Configure UserInfo table fiels and relationships
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {

        const string TableName = "user";
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

        //field: Username
        builder
            .Property(propertyExpression: userInfo => userInfo.Username)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: Password
        builder
            .Property(propertyExpression: userInfo => userInfo.Password)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();

        //field: UserFullName
        builder
            .Property(propertyExpression: userInfo => userInfo.UserFullName)
            .HasColumnType(typeName: VARCHAR_30)
            .IsRequired();

        //field: UserGender
        builder
            .Property(propertyExpression: userAccess => userAccess.UserGender)
            .IsRequired();

        //field: UserBirthday
        builder
            .Property(propertyExpression: userAccess => userAccess.UserBirthday)
            .IsRequired();

        //field: UserPhoneNumber
        builder
            .Property(propertyExpression: userInfo => userInfo.UserPhoneNumber)
            .HasColumnType(typeName: VARCHAR_13)
            .IsRequired();

        //field: UserEmail
        builder
            .Property(propertyExpression: userInfo => userInfo.UserEmail)
            .HasColumnType(typeName: VARCHAR_30)
            .IsRequired();

        //field: UserAccountBalance
        builder
            .Property(propertyExpression: userInfo => userInfo.UserAccountBalance)
            .IsRequired();

        //field: UserAvatar
        builder
            .Property(propertyExpression: userInfo => userInfo.UserAvatar)
            .HasColumnType(typeName: VARCHAR_50)
            .IsRequired();


        /**
		 *
		 * Relationship
		 *
		 */
        // One to many: User => TransactionHistory
        builder
            .HasMany(navigationExpression: user => user.TransactionHistoryEntities)
            .WithOne(navigationExpression: transactionHistory => transactionHistory.UserEntity)
            .HasForeignKey(foreignKeyExpression: transactionHistory => transactionHistory.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: User => ReadingHistory
        builder
            .HasMany(navigationExpression: user => user.ReadingHistorieEntities)
            .WithOne(navigationExpression: readingHistory => readingHistory.UserEntity)
            .HasForeignKey(foreignKeyExpression: readingHistory => readingHistory.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: User => ComicSaving
        builder
            .HasMany(navigationExpression: user => user.ComicSavingEntities)
            .WithOne(navigationExpression: comicSaving => comicSaving.UserEntity)
            .HasForeignKey(foreignKeyExpression: comicSaving => comicSaving.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: User => ReviewComic
        builder
            .HasMany(navigationExpression: user => user.ReviewComicEntities)
            .WithOne(navigationExpression: reviewComic => reviewComic.UserEntity)
            .HasForeignKey(foreignKeyExpression: reviewComic => reviewComic.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: User => ReviewChapter
        builder
            .HasMany(navigationExpression: user => user.ReviewChapterEntities)
            .WithOne(navigationExpression: reviewChapter => reviewChapter.UserEntity)
            .HasForeignKey(foreignKeyExpression: reviewChapter => reviewChapter.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to one: User => Publisher
        builder
            .HasOne(navigationExpression: user => user.PublisherEntity)
            .WithOne(navigationExpression: publisher => publisher.UserEntity)
            .HasForeignKey<PublisherEntity>(foreignKeyExpression: publisher => publisher.UserIdentifier)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

        // One to many: User => BuyingHistory
        builder
            .HasMany(navigationExpression: user => user.BuyingHistorieEntities)
            .WithOne(navigationExpression: buyingHistory => buyingHistory.UserEntity)
            .HasForeignKey(foreignKeyExpression: buyingHistory => buyingHistory.UserIdentifer)
            .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
    }
}
