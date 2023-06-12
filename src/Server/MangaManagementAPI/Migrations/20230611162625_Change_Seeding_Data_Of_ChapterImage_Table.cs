using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Change_Seeding_Data_Of_ChapterImage_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("4294f30a-0f88-4d8c-9571-a8e21e43d3e3"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("8ea3ffc6-d8b9-4267-b7f9-bc1fb5594fdd"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("bf3b0085-c46d-4a3c-9121-02fd9d8a999e"));

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("0c17d220-7f8e-4b58-b15d-a3f9d37a70dd"),
                column: "ImageURL",
                value: "43.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("0e66730c-50f5-4f72-b8cd-2f720ddf6d7e"),
                column: "ImageURL",
                value: "25.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("19954bda-0156-48f9-aee6-c8c258dafa58"),
                column: "ImageURL",
                value: "29.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1c9b47b7-27a5-46c4-a8d0-e7163f1c3e7f"),
                column: "ImageURL",
                value: "21.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1d73b99e-f451-4b55-9b20-ea4d572bc3a0"),
                column: "ImageURL",
                value: "16.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("22a1a283-80c0-4dc2-a9da-0a71a13b5dc0"),
                column: "ImageURL",
                value: "40.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("25a2ab91-5674-44aa-bbac-2ea3bceb71d4"),
                column: "ImageURL",
                value: "8.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("2abfb23c-34fa-4a48-b442-a1b28201ff32"),
                column: "ImageURL",
                value: "22.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("2cd639ce-c96f-4589-8014-0e6e7f9ff69f"),
                column: "ImageURL",
                value: "20.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("31ae274b-4dfc-4deb-af28-46de52cb6feb"),
                column: "ImageURL",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("34c310fd-4fdc-4048-9b11-7b0a29d3b440"),
                column: "ImageURL",
                value: "45.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("3aaaa9a7-4465-494a-a7bd-08157d913586"),
                column: "ImageURL",
                value: "5.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("3d6be27d-6bcc-4e23-9fde-f785d000a72e"),
                column: "ImageURL",
                value: "41.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("45c4dfd6-910c-49a4-bb1c-f499377c8c61"),
                column: "ImageURL",
                value: "23.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("47059dc1-e213-4dc9-a1f3-1e263f7f29f2"),
                column: "ImageURL",
                value: "44.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("48a81e89-dbad-4fb5-b992-66b0a575d781"),
                column: "ImageURL",
                value: "2.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("4aca6f3a-2ccf-49de-af02-0b1776e793ee"),
                column: "ImageURL",
                value: "17.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("4e86fa98-7b46-44e7-92bc-dcc997c3574a"),
                column: "ImageURL",
                value: "39.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("5b2c0a01-6bc0-4b9c-b66f-72c45c8bdcb7"),
                column: "ImageURL",
                value: "42.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("64e10a07-b7f7-4335-9ef9-a3c7a5b67d7c"),
                column: "ImageURL",
                value: "24.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("6788fa1f-f257-4582-842e-ad505f1c8e92"),
                column: "ImageURL",
                value: "36.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("6819a0d1-31a5-4e13-aaab-57fa19edc770"),
                column: "ImageURL",
                value: "46.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("71147712-b450-4e4b-8df1-ed5d50160bf9"),
                column: "ImageURL",
                value: "26.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("72b0ea4d-8f47-4e40-8fbb-9a5d5e1c87d3"),
                column: "ImageURL",
                value: "49.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("785fb0ef-b383-4f44-98b5-bd6a555f0626"),
                column: "ImageURL",
                value: "9.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("7bd54d5b-d802-4d60-91a8-82a9079b1876"),
                column: "ImageURL",
                value: "48.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("7fb2316f-4341-401d-b28a-40146f8a7a0b"),
                column: "ImageURL",
                value: "6.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("853addd5-5496-490f-86bd-cc12ba04e2bd"),
                column: "ImageURL",
                value: "27.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("87e12554-c4a1-4bb7-906f-71c16042aaf3"),
                column: "ImageURL",
                value: "33.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("97c8d20b-0f88-47a6-91cb-e76d0b357ad3"),
                column: "ImageURL",
                value: "28.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("97ce8e61-ac01-4e85-9a12-67d94f5b7102"),
                column: "ImageURL",
                value: "15.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("9a4c2922-3a3b-4cc1-ba2e-d62317c8c0e0"),
                column: "ImageURL",
                value: "1.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("9f58f9f7-40c0-46bc-8052-7cb0ffca9a2c"),
                column: "ImageURL",
                value: "47.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("a11be2b5-3c5c-4adc-8642-d2dfda33813d"),
                column: "ImageURL",
                value: "38.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("a79456c1-8024-4128-9a31-db46f7eeef08"),
                column: "ImageURL",
                value: "19.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ad981387-1e98-4036-8934-868c5e0880a9"),
                column: "ImageURL",
                value: "0.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ae3756ad-6b22-4645-90c6-a01b60b04d59"),
                column: "ImageURL",
                value: "30.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("b8f10d3d-74fb-448e-87a6-c2a46514e0e8"),
                column: "ImageURL",
                value: "34.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("bc5a3dbb-6b9e-4c4c-a013-f66ad22077dc"),
                column: "ImageURL",
                value: "31.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("bf280315-0e15-4074-978e-c0014a946383"),
                column: "ImageURL",
                value: "14.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("c2fa7cbe-138b-42e5-ad7b-c0afd43f43fd"),
                column: "ImageURL",
                value: "10.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("cb117933-9ccc-4ad6-afcf-65da344ba69a"),
                column: "ImageURL",
                value: "11.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("cb4b4f62-523f-4044-9d58-1ae3f12d430c"),
                column: "ImageURL",
                value: "4.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d119637e-bf32-4b23-81ff-a09c1d910b81"),
                column: "ImageURL",
                value: "12.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d3c2b7fa-2f9f-4883-862d-a9556d24a35d"),
                column: "ImageURL",
                value: "50.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d9c7b2a1-67e0-4daa-8ad0-b8560938e847"),
                column: "ImageURL",
                value: "7.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("e992e5d9-67a8-4164-9273-ae229e648556"),
                column: "ImageURL",
                value: "13.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("eec8c785-84cf-4b8e-bcf2-128a4d9876da"),
                column: "ImageURL",
                value: "32.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f1a77aa3-ffc5-4e9f-adcd-757545657941"),
                column: "ImageURL",
                value: "35.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f78ffa61-a567-479a-aa79-011dfa2fdc4e"),
                column: "ImageURL",
                value: "18.jpg");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f85d2bd9-6d9c-4a92-85b1-11c3ad17c133"),
                column: "ImageURL",
                value: "37.jpg");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("0c17d220-7f8e-4b58-b15d-a3f9d37a70dd"),
                column: "ImageURL",
                value: "43.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("0e66730c-50f5-4f72-b8cd-2f720ddf6d7e"),
                column: "ImageURL",
                value: "25.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("19954bda-0156-48f9-aee6-c8c258dafa58"),
                column: "ImageURL",
                value: "29.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1c9b47b7-27a5-46c4-a8d0-e7163f1c3e7f"),
                column: "ImageURL",
                value: "21.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1d73b99e-f451-4b55-9b20-ea4d572bc3a0"),
                column: "ImageURL",
                value: "16.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("22a1a283-80c0-4dc2-a9da-0a71a13b5dc0"),
                column: "ImageURL",
                value: "40.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("25a2ab91-5674-44aa-bbac-2ea3bceb71d4"),
                column: "ImageURL",
                value: "8.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("2abfb23c-34fa-4a48-b442-a1b28201ff32"),
                column: "ImageURL",
                value: "22.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("2cd639ce-c96f-4589-8014-0e6e7f9ff69f"),
                column: "ImageURL",
                value: "20.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("31ae274b-4dfc-4deb-af28-46de52cb6feb"),
                column: "ImageURL",
                value: "3.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("34c310fd-4fdc-4048-9b11-7b0a29d3b440"),
                column: "ImageURL",
                value: "45.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("3aaaa9a7-4465-494a-a7bd-08157d913586"),
                column: "ImageURL",
                value: "5.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("3d6be27d-6bcc-4e23-9fde-f785d000a72e"),
                column: "ImageURL",
                value: "41.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("45c4dfd6-910c-49a4-bb1c-f499377c8c61"),
                column: "ImageURL",
                value: "23.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("47059dc1-e213-4dc9-a1f3-1e263f7f29f2"),
                column: "ImageURL",
                value: "44.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("48a81e89-dbad-4fb5-b992-66b0a575d781"),
                column: "ImageURL",
                value: "2.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("4aca6f3a-2ccf-49de-af02-0b1776e793ee"),
                column: "ImageURL",
                value: "17.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("4e86fa98-7b46-44e7-92bc-dcc997c3574a"),
                column: "ImageURL",
                value: "39.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("5b2c0a01-6bc0-4b9c-b66f-72c45c8bdcb7"),
                column: "ImageURL",
                value: "42.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("64e10a07-b7f7-4335-9ef9-a3c7a5b67d7c"),
                column: "ImageURL",
                value: "24.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("6788fa1f-f257-4582-842e-ad505f1c8e92"),
                column: "ImageURL",
                value: "36.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("6819a0d1-31a5-4e13-aaab-57fa19edc770"),
                column: "ImageURL",
                value: "46.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("71147712-b450-4e4b-8df1-ed5d50160bf9"),
                column: "ImageURL",
                value: "26.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("72b0ea4d-8f47-4e40-8fbb-9a5d5e1c87d3"),
                column: "ImageURL",
                value: "49.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("785fb0ef-b383-4f44-98b5-bd6a555f0626"),
                column: "ImageURL",
                value: "9.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("7bd54d5b-d802-4d60-91a8-82a9079b1876"),
                column: "ImageURL",
                value: "48.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("7fb2316f-4341-401d-b28a-40146f8a7a0b"),
                column: "ImageURL",
                value: "6.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("853addd5-5496-490f-86bd-cc12ba04e2bd"),
                column: "ImageURL",
                value: "27.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("87e12554-c4a1-4bb7-906f-71c16042aaf3"),
                column: "ImageURL",
                value: "33.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("97c8d20b-0f88-47a6-91cb-e76d0b357ad3"),
                column: "ImageURL",
                value: "28.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("97ce8e61-ac01-4e85-9a12-67d94f5b7102"),
                column: "ImageURL",
                value: "15.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("9a4c2922-3a3b-4cc1-ba2e-d62317c8c0e0"),
                column: "ImageURL",
                value: "1.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("9f58f9f7-40c0-46bc-8052-7cb0ffca9a2c"),
                column: "ImageURL",
                value: "47.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("a11be2b5-3c5c-4adc-8642-d2dfda33813d"),
                column: "ImageURL",
                value: "38.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("a79456c1-8024-4128-9a31-db46f7eeef08"),
                column: "ImageURL",
                value: "19.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ad981387-1e98-4036-8934-868c5e0880a9"),
                column: "ImageURL",
                value: "0.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ae3756ad-6b22-4645-90c6-a01b60b04d59"),
                column: "ImageURL",
                value: "30.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("b8f10d3d-74fb-448e-87a6-c2a46514e0e8"),
                column: "ImageURL",
                value: "34.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("bc5a3dbb-6b9e-4c4c-a013-f66ad22077dc"),
                column: "ImageURL",
                value: "31.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("bf280315-0e15-4074-978e-c0014a946383"),
                column: "ImageURL",
                value: "14.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("c2fa7cbe-138b-42e5-ad7b-c0afd43f43fd"),
                column: "ImageURL",
                value: "10.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("cb117933-9ccc-4ad6-afcf-65da344ba69a"),
                column: "ImageURL",
                value: "11.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("cb4b4f62-523f-4044-9d58-1ae3f12d430c"),
                column: "ImageURL",
                value: "4.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d119637e-bf32-4b23-81ff-a09c1d910b81"),
                column: "ImageURL",
                value: "12.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d3c2b7fa-2f9f-4883-862d-a9556d24a35d"),
                column: "ImageURL",
                value: "50.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d9c7b2a1-67e0-4daa-8ad0-b8560938e847"),
                column: "ImageURL",
                value: "7.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("e992e5d9-67a8-4164-9273-ae229e648556"),
                column: "ImageURL",
                value: "13.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("eec8c785-84cf-4b8e-bcf2-128a4d9876da"),
                column: "ImageURL",
                value: "32.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f1a77aa3-ffc5-4e9f-adcd-757545657941"),
                column: "ImageURL",
                value: "35.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f78ffa61-a567-479a-aa79-011dfa2fdc4e"),
                column: "ImageURL",
                value: "18.png");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f85d2bd9-6d9c-4a92-85b1-11c3ad17c133"),
                column: "ImageURL",
                value: "37.png");

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("4294f30a-0f88-4d8c-9571-a8e21e43d3e3"), 50000.0, 50, new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6032), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("8ea3ffc6-d8b9-4267-b7f9-bc1fb5594fdd"), 100000.0, 100, new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6023), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("bf3b0085-c46d-4a3c-9121-02fd9d8a999e"), 200000.0, 200, new DateTime(2023, 6, 11, 12, 30, 13, 520, DateTimeKind.Utc).AddTicks(6034), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
                });
        }
    }
}
