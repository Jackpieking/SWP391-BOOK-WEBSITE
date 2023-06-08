using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MangaManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class Delete_default_constraint_and_modify_requirement_of_foreign_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("59127b83-4fef-4d7d-98d0-3d34992c9692"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("dbdf76a1-dc3b-42e4-8053-db7088a0204e"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("f6cd96c7-ddd2-4cb3-9915-fb5472ffec81"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "user_access",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "user_access",
                type: "VARCHAR(13)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(13)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "user_access",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "user_access",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "user_access",
                type: "VARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "user_access",
                type: "VARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "BirthDay",
                table: "user_access",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "CURRENT_DATE");

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "user_access",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "AccountBalance",
                table: "user_access",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserIdentifier",
                table: "transaction_history",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "EarnedCoin",
                table: "transaction_history",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "transaction_history",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "transaction_history",
                type: "numeric(6,0)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(6,0)",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewTime",
                table: "review_comic",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<short>(
                name: "RatingStar",
                table: "review_comic",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValue: (short)0);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "review_comic",
                type: "VARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewTime",
                table: "review_chapter",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<short>(
                name: "RatingStar",
                table: "review_chapter",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValue: (short)0);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "review_chapter",
                type: "VARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastReadingTime",
                table: "reading_history",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SavingTime",
                table: "comic_saving",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PublishDate",
                table: "comic",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "CURRENT_DATE");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "comic",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "LatestChapter",
                table: "comic",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "comic",
                type: "VARCHAR(1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1000)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "comic",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "PublisherIdentifier",
                table: "comic",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "chapter_image",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<short>(
                name: "ImageNumber",
                table: "chapter_image",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValue: (short)0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ChapterIdentifier",
                table: "chapter_image",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "UnlockPrice",
                table: "chapter",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ComicIdentifier",
                table: "chapter",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<double>(
                name: "ChapterNumber",
                table: "chapter",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "category",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "category",
                type: "VARCHAR(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(500)",
                oldDefaultValue: "");

            migrationBuilder.CreateTable(
                name: "buying_history",
                columns: table => new
                {
                    UserIdentifer = table.Column<Guid>(type: "uuid", nullable: false),
                    ChapterIdentifer = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buying_history", x => new { x.UserIdentifer, x.ChapterIdentifer });
                    table.ForeignKey(
                        name: "FK_buying_history_chapter_UserIdentifer",
                        column: x => x.UserIdentifer,
                        principalTable: "chapter",
                        principalColumn: "ChapterIdentifier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_buying_history_user_access_UserIdentifer",
                        column: x => x.UserIdentifer,
                        principalTable: "user_access",
                        principalColumn: "UserIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "publisher",
                columns: table => new
                {
                    PublisherIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publisher", x => x.PublisherIdentifier);
                    table.ForeignKey(
                        name: "FK_publisher_user_access_UserIdentifier",
                        column: x => x.UserIdentifier,
                        principalTable: "user_access",
                        principalColumn: "UserIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                column: "PublisherIdentifier",
                value: new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"),
                column: "PublisherIdentifier",
                value: new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                column: "PublisherIdentifier",
                value: new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                column: "PublisherIdentifier",
                value: new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                column: "PublisherIdentifier",
                value: new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.InsertData(
                table: "publisher",
                columns: new[] { "PublisherIdentifier", "Description", "UserIdentifier" },
                values: new object[] { new Guid("51b02aef-2b58-4433-adea-e73c37b9f224"), "admin kiêm người đăng", new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") });

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "Amount", "Date", "EarnedCoin", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("119ee467-f244-4031-b9d8-e2dc5294dd5f"), 100000.0, new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5168), 100, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("3cb1e78d-5767-4eb3-bf7c-79cd72aec337"), 50000.0, new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5178), 50, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("bcecce52-6822-4499-bca5-8842634867de"), 200000.0, new DateTime(2023, 6, 8, 8, 15, 59, 190, DateTimeKind.Utc).AddTicks(5180), 200, new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
                });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                column: "Gender",
                value: 0);

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                column: "Gender",
                value: 0);

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("c6d20823-3d00-48a0-8074-36587bee2693"),
                column: "Gender",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comic_PublisherIdentifier",
                table: "comic",
                column: "PublisherIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_publisher_UserIdentifier",
                table: "publisher",
                column: "UserIdentifier",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_comic_publisher_PublisherIdentifier",
                table: "comic",
                column: "PublisherIdentifier",
                principalTable: "publisher",
                principalColumn: "PublisherIdentifier",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comic_publisher_PublisherIdentifier",
                table: "comic");

            migrationBuilder.DropTable(
                name: "buying_history");

            migrationBuilder.DropTable(
                name: "publisher");

            migrationBuilder.DropIndex(
                name: "IX_comic_PublisherIdentifier",
                table: "comic");

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("119ee467-f244-4031-b9d8-e2dc5294dd5f"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("3cb1e78d-5767-4eb3-bf7c-79cd72aec337"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("bcecce52-6822-4499-bca5-8842634867de"));

            migrationBuilder.DropColumn(
                name: "PublisherIdentifier",
                table: "comic");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "user_access",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "user_access",
                type: "VARCHAR(13)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(13)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "user_access",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "user_access",
                type: "integer",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "user_access",
                type: "VARCHAR(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "user_access",
                type: "VARCHAR(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "BirthDay",
                table: "user_access",
                type: "date",
                nullable: false,
                defaultValueSql: "CURRENT_DATE",
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "user_access",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<int>(
                name: "AccountBalance",
                table: "user_access",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserIdentifier",
                table: "transaction_history",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "EarnedCoin",
                table: "transaction_history",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "transaction_history",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "transaction_history",
                type: "numeric(6,0)",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "numeric(6,0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewTime",
                table: "review_comic",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<short>(
                name: "RatingStar",
                table: "review_comic",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "review_comic",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewTime",
                table: "review_chapter",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<short>(
                name: "RatingStar",
                table: "review_chapter",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "review_chapter",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastReadingTime",
                table: "reading_history",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SavingTime",
                table: "comic_saving",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PublishDate",
                table: "comic",
                type: "date",
                nullable: false,
                defaultValueSql: "CURRENT_DATE",
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "comic",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<double>(
                name: "LatestChapter",
                table: "comic",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "comic",
                type: "VARCHAR(1000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(1000)");

            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "comic",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "chapter_image",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<short>(
                name: "ImageNumber",
                table: "chapter_image",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<Guid>(
                name: "ChapterIdentifier",
                table: "chapter_image",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "UnlockPrice",
                table: "chapter",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "ComicIdentifier",
                table: "chapter",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<double>(
                name: "ChapterNumber",
                table: "chapter",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "category",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "category",
                type: "VARCHAR(500)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(500)");

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "Amount", "Date", "EarnedCoin", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("59127b83-4fef-4d7d-98d0-3d34992c9692"), 50000.0, new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6601), 50, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("dbdf76a1-dc3b-42e4-8053-db7088a0204e"), 100000.0, new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6595), 100, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("f6cd96c7-ddd2-4cb3-9915-fb5472ffec81"), 200000.0, new DateTime(2023, 6, 7, 14, 12, 51, 360, DateTimeKind.Utc).AddTicks(6604), 200, new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
                });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                column: "Gender",
                value: 2);

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                column: "Gender",
                value: 2);

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("c6d20823-3d00-48a0-8074-36587bee2693"),
                column: "Gender",
                value: 2);
        }
    }
}
