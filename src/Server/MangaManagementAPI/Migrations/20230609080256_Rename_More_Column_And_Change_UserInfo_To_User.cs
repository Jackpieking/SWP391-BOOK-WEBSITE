using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Rename_More_Column_And_Change_UserInfo_To_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buying_history_user_access_UserIdentifer",
                table: "buying_history");

            migrationBuilder.DropForeignKey(
                name: "FK_comic_saving_user_access_UserIdentifier",
                table: "comic_saving");

            migrationBuilder.DropForeignKey(
                name: "FK_publisher_user_access_UserIdentifier",
                table: "publisher");

            migrationBuilder.DropForeignKey(
                name: "FK_reading_history_user_access_UserIdentifier",
                table: "reading_history");

            migrationBuilder.DropForeignKey(
                name: "FK_review_chapter_user_access_UserIdentifier",
                table: "review_chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_review_comic_user_access_UserIdentifier",
                table: "review_comic");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_history_user_access_UserIdentifier",
                table: "transaction_history");

            migrationBuilder.DropTable(
                name: "user_access");

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("73cd2e1c-6865-4130-ae64-117da77abf04"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("8aaf07da-23a2-41ae-b76e-803ad16c6319"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("e8ab6315-71d3-40bd-9615-4c2ab17f5497"));

            migrationBuilder.RenameColumn(
                name: "Coin",
                table: "transaction_history",
                newName: "TransactionCoin");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "transaction_history",
                newName: "TransactionAmount");

            migrationBuilder.RenameColumn(
                name: "RatingStar",
                table: "review_comic",
                newName: "ComicRatingStar");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "review_comic",
                newName: "ComicComment");

            migrationBuilder.RenameColumn(
                name: "RatingStar",
                table: "review_chapter",
                newName: "ChapterRatingStar");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "review_chapter",
                newName: "ChapterComment");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "publisher",
                newName: "PublisherDescription");

            migrationBuilder.RenameColumn(
                name: "PublishDate",
                table: "comic",
                newName: "ComicPublishDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "comic",
                newName: "ComicName");

            migrationBuilder.RenameColumn(
                name: "LatestChapter",
                table: "comic",
                newName: "ComicLatestChapter");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "comic",
                newName: "ComicDescription");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "comic",
                newName: "ComicAvatar");

            migrationBuilder.RenameColumn(
                name: "UnlockPrice",
                table: "chapter",
                newName: "ChapterUnlockPrice");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "category",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "category",
                newName: "CategoryDescription");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Username = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    UserFullName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UserGender = table.Column<int>(type: "integer", nullable: false),
                    UserBirthday = table.Column<DateOnly>(type: "date", nullable: false),
                    UserPhoneNumber = table.Column<string>(type: "VARCHAR(13)", nullable: false),
                    UserEmail = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    UserAccountBalance = table.Column<int>(type: "integer", nullable: false),
                    UserAvatar = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.UserIdentifier);
                });

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "UserIdentifier", "Password", "UserAccountBalance", "UserAvatar", "UserBirthday", "UserEmail", "UserFullName", "UserGender", "UserPhoneNumber", "Username" },
                values: new object[,]
                {
                    { new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "NghiaLe123", 100, "User_Empty.png", new DateOnly(2003, 4, 2), "nghialt123@gmail.com", "Lee Trung Nghĩa", 0, "0903591555", "wibulord" },
                    { new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "Jackpie2003", 30, "User_Empty.png", new DateOnly(2003, 12, 3), "ledinhdangkhoa10a9@gmail.com", "Lê Đình Đăng Khoa", 0, "0706042250", "Jackpieking" },
                    { new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), "Lam123", 0, "User_Empty.png", new DateOnly(2003, 8, 15), "lamvd@gmail.com", "Võ Đại Lâm", 0, "02343883333", "lamvd" }
                });

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("53ac7590-281d-48f7-9fe5-4bb80b4c25b1"), 50000.0, 50, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(388), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("618d6c1c-e1a5-41cc-b41a-5b8e2914a8a3"), 200000.0, 200, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(390), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                    { new Guid("f0aa18ba-776d-45ce-a5a6-9e5577b0e38b"), 100000.0, 100, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(382), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_buying_history_user_UserIdentifer",
                table: "buying_history",
                column: "UserIdentifer",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comic_saving_user_UserIdentifier",
                table: "comic_saving",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_publisher_user_UserIdentifier",
                table: "publisher",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reading_history_user_UserIdentifier",
                table: "reading_history",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_review_chapter_user_UserIdentifier",
                table: "review_chapter",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_review_comic_user_UserIdentifier",
                table: "review_comic",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_history_user_UserIdentifier",
                table: "transaction_history",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buying_history_user_UserIdentifer",
                table: "buying_history");

            migrationBuilder.DropForeignKey(
                name: "FK_comic_saving_user_UserIdentifier",
                table: "comic_saving");

            migrationBuilder.DropForeignKey(
                name: "FK_publisher_user_UserIdentifier",
                table: "publisher");

            migrationBuilder.DropForeignKey(
                name: "FK_reading_history_user_UserIdentifier",
                table: "reading_history");

            migrationBuilder.DropForeignKey(
                name: "FK_review_chapter_user_UserIdentifier",
                table: "review_chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_review_comic_user_UserIdentifier",
                table: "review_comic");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_history_user_UserIdentifier",
                table: "transaction_history");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("53ac7590-281d-48f7-9fe5-4bb80b4c25b1"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("618d6c1c-e1a5-41cc-b41a-5b8e2914a8a3"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("f0aa18ba-776d-45ce-a5a6-9e5577b0e38b"));

            migrationBuilder.RenameColumn(
                name: "TransactionCoin",
                table: "transaction_history",
                newName: "Coin");

            migrationBuilder.RenameColumn(
                name: "TransactionAmount",
                table: "transaction_history",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "ComicRatingStar",
                table: "review_comic",
                newName: "RatingStar");

            migrationBuilder.RenameColumn(
                name: "ComicComment",
                table: "review_comic",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "ChapterRatingStar",
                table: "review_chapter",
                newName: "RatingStar");

            migrationBuilder.RenameColumn(
                name: "ChapterComment",
                table: "review_chapter",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "PublisherDescription",
                table: "publisher",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ComicPublishDate",
                table: "comic",
                newName: "PublishDate");

            migrationBuilder.RenameColumn(
                name: "ComicName",
                table: "comic",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ComicLatestChapter",
                table: "comic",
                newName: "LatestChapter");

            migrationBuilder.RenameColumn(
                name: "ComicDescription",
                table: "comic",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ComicAvatar",
                table: "comic",
                newName: "Avatar");

            migrationBuilder.RenameColumn(
                name: "ChapterUnlockPrice",
                table: "chapter",
                newName: "UnlockPrice");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "category",
                newName: "Description");

            migrationBuilder.CreateTable(
                name: "user_access",
                columns: table => new
                {
                    UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    AccountBalance = table.Column<int>(type: "integer", nullable: false),
                    Avatar = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    BirthDay = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(13)", nullable: false),
                    UserName = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_access", x => x.UserIdentifier);
                });

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.InsertData(
                table: "user_access",
                columns: new[] { "UserIdentifier", "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), 100, "User_Empty.png", new DateOnly(2003, 4, 2), "nghialt123@gmail.com", "Lee Trung Nghĩa", 0, "NghiaLe123", "0903591555", "wibulord" },
                    { new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), 30, "User_Empty.png", new DateOnly(2003, 12, 3), "ledinhdangkhoa10a9@gmail.com", "Lê Đình Đăng Khoa", 0, "Jackpie2003", "0706042250", "Jackpieking" },
                    { new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), 0, "User_Empty.png", new DateOnly(2003, 8, 15), "lamvd@gmail.com", "Võ Đại Lâm", 0, "Lam123", "02343883333", "lamvd" }
                });

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "Amount", "Coin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("73cd2e1c-6865-4130-ae64-117da77abf04"), 100000.0, 100, new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(1525), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("8aaf07da-23a2-41ae-b76e-803ad16c6319"), 200000.0, 200, new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(1533), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                    { new Guid("e8ab6315-71d3-40bd-9615-4c2ab17f5497"), 50000.0, 50, new DateTime(2023, 6, 9, 7, 38, 12, 312, DateTimeKind.Utc).AddTicks(1530), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_buying_history_user_access_UserIdentifer",
                table: "buying_history",
                column: "UserIdentifer",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comic_saving_user_access_UserIdentifier",
                table: "comic_saving",
                column: "UserIdentifier",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_publisher_user_access_UserIdentifier",
                table: "publisher",
                column: "UserIdentifier",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reading_history_user_access_UserIdentifier",
                table: "reading_history",
                column: "UserIdentifier",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_review_chapter_user_access_UserIdentifier",
                table: "review_chapter",
                column: "UserIdentifier",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_review_comic_user_access_UserIdentifier",
                table: "review_comic",
                column: "UserIdentifier",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_history_user_access_UserIdentifier",
                table: "transaction_history",
                column: "UserIdentifier",
                principalTable: "user_access",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
