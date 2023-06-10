using Microsoft.EntityFrameworkCore.Migrations;
using System;


namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Modify_Review_Comic_Data_Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") });

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

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.InsertData(
                table: "review_comic",
                columns: new[] { "ComicIdentifier", "UserIdentifier", "ComicComment", "ComicRatingStar", "ReviewTime" },
                values: new object[,]
                {
                    { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "Cười vãi", (short)5, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(620) },
                    { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "Tui muốn gud end", (short)1, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(621) },
                    { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "Tổng quan về cốt truyện ở mức ổn", (short)3, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(613) },
                    { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "Cốt truyện khó hiểu", (short)2, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(618) },
                    { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), "Đánh nhau ít nhưng tổng quan vẫn OK", (short)4, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(624) }
                });

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("035c28fd-6758-41b1-8920-5b87baf8a9fb"), 100000.0, 100, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(541), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("ccfd670d-32e9-45b8-8365-fb34a1b9621c"), 50000.0, 50, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(546), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("dd657c45-23c4-4438-90d7-ba4b9213cb60"), 200000.0, 200, new DateTime(2023, 6, 10, 6, 41, 9, 310, DateTimeKind.Utc).AddTicks(548), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") });

            migrationBuilder.DeleteData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") });

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("035c28fd-6758-41b1-8920-5b87baf8a9fb"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("ccfd670d-32e9-45b8-8365-fb34a1b9621c"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("dd657c45-23c4-4438-90d7-ba4b9213cb60"));

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

            migrationBuilder.InsertData(
                table: "review_comic",
                columns: new[] { "ComicIdentifier", "UserIdentifier", "ComicComment", "ComicRatingStar", "ReviewTime" },
                values: new object[,]
                {
                    { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "Cười vãi", (short)5, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1339) },
                    { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "Tui muốn gud end", (short)1, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1341) },
                    { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "Tổng quan về cốt truyện ở mức ổn", (short)3, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1331) },
                    { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "Cốt truyện khó hiểu", (short)2, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1338) },
                    { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), "Đánh nhau ít nhưng tổng quan vẫn OK", (short)4, new DateTime(2023, 6, 9, 8, 2, 55, 895, DateTimeKind.Utc).AddTicks(1343) }
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
        }
    }
}
