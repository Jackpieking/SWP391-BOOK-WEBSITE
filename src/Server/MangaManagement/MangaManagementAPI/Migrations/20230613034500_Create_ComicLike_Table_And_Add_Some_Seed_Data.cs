using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Create_ComicLike_Table_And_Add_Some_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buying_history_chapter_UserIdentifer",
                table: "buying_history");

            migrationBuilder.DropForeignKey(
                name: "FK_buying_history_user_UserIdentifer",
                table: "buying_history");

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("1d96460f-c42d-4b4d-a8f0-b8dfc5499d78"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("33d85aab-2f59-4d92-a1e7-7b346c67facc"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("dac3cef5-d6a2-417e-875e-c790f62c1d63"));

            migrationBuilder.RenameColumn(
                name: "ComicPublishDate",
                table: "comic",
                newName: "ComicPublishedDate");

            migrationBuilder.RenameColumn(
                name: "ChapterIdentifer",
                table: "buying_history",
                newName: "ChapterIdentifier");

            migrationBuilder.RenameColumn(
                name: "UserIdentifer",
                table: "buying_history",
                newName: "UserIdentifier");

            migrationBuilder.CreateTable(
                name: "comic_like",
                columns: table => new
                {
                    UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
                    ComicIdentifier = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comic_like", x => new { x.UserIdentifier, x.ComicIdentifier });
                    table.ForeignKey(
                        name: "FK_comic_like_comic_ComicIdentifier",
                        column: x => x.ComicIdentifier,
                        principalTable: "comic",
                        principalColumn: "ComicIdentifier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comic_like_user_UserIdentifier",
                        column: x => x.UserIdentifier,
                        principalTable: "user",
                        principalColumn: "UserIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 13));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 13));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 13));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("dc31637b-416c-458d-9942-74fa1470ca20"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 13));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 13));

            migrationBuilder.InsertData(
                table: "comic_like",
                columns: new[] { "ComicIdentifier", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                    { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
                });

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("19d2629b-88ef-4d5d-8e40-727f7c44be8a"), 50000.0, 50, new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9213), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("8c488635-cacf-4531-afe1-ace71ed52768"), 200000.0, 200, new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9215), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                    { new Guid("c58c229b-8e76-4cc5-93b8-3ba23b314dd5"), 100000.0, 100, new DateTime(2023, 6, 13, 3, 45, 0, 620, DateTimeKind.Utc).AddTicks(9207), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_comic_like_ComicIdentifier",
                table: "comic_like",
                column: "ComicIdentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_buying_history_chapter_UserIdentifier",
                table: "buying_history",
                column: "UserIdentifier",
                principalTable: "chapter",
                principalColumn: "ChapterIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buying_history_user_UserIdentifier",
                table: "buying_history",
                column: "UserIdentifier",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buying_history_chapter_UserIdentifier",
                table: "buying_history");

            migrationBuilder.DropForeignKey(
                name: "FK_buying_history_user_UserIdentifier",
                table: "buying_history");

            migrationBuilder.DropTable(
                name: "comic_like");

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("19d2629b-88ef-4d5d-8e40-727f7c44be8a"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("8c488635-cacf-4531-afe1-ace71ed52768"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("c58c229b-8e76-4cc5-93b8-3ba23b314dd5"));

            migrationBuilder.RenameColumn(
                name: "ComicPublishedDate",
                table: "comic",
                newName: "ComicPublishDate");

            migrationBuilder.RenameColumn(
                name: "ChapterIdentifier",
                table: "buying_history",
                newName: "ChapterIdentifer");

            migrationBuilder.RenameColumn(
                name: "UserIdentifier",
                table: "buying_history",
                newName: "UserIdentifer");

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 11));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 11));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 11));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("dc31637b-416c-458d-9942-74fa1470ca20"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 11));

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"),
                column: "AddedDate",
                value: new DateOnly(2023, 6, 11));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("1d96460f-c42d-4b4d-a8f0-b8dfc5499d78"), 200000.0, 200, new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6742), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                    { new Guid("33d85aab-2f59-4d92-a1e7-7b346c67facc"), 100000.0, 100, new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6734), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("dac3cef5-d6a2-417e-875e-c790f62c1d63"), 50000.0, 50, new DateTime(2023, 6, 11, 16, 26, 25, 471, DateTimeKind.Utc).AddTicks(6740), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_buying_history_chapter_UserIdentifer",
                table: "buying_history",
                column: "UserIdentifer",
                principalTable: "chapter",
                principalColumn: "ChapterIdentifier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buying_history_user_UserIdentifer",
                table: "buying_history",
                column: "UserIdentifer",
                principalTable: "user",
                principalColumn: "UserIdentifier",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
