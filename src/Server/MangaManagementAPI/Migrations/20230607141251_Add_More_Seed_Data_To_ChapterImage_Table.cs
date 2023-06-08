using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MangaManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class Add_More_Seed_Data_To_ChapterImage_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1753ec49-2e45-4eec-ad77-44c514f19d35"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("27cddd0a-a8b2-4173-b951-0bedac4ce505"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d531039b-1797-4b16-9302-349a6b13b331"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ef7ff0f1-ae92-4887-b7fe-b93a43f36399"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("42b6cb40-8369-4620-bf3b-d31c49a9284c"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("72b35d60-35f4-43ae-8eb2-5840e711329e"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("dd11cb5d-5665-4f02-b9c0-28fc303c12a1"));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                column: "Description",
                value: "Thường đề cập đến một loại tiểu thuyết thuộc thể loại viễn tưởng tập trung chủ yếu vào mối quan hệ và tình yêu lãng mạn giữa hai người, và thường có một kết thúc lạc quan và thỏa mãn về mặt cảm xúc");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ad981387-1e98-4036-8934-868c5e0880a9"),
                columns: new[] { "ImageNumber", "ImageURL" },
                values: new object[] { (short)0, "0.png" });

            migrationBuilder.InsertData(
                table: "chapter_image",
                columns: new[] { "ImageIdentifier", "ChapterIdentifier", "ImageNumber", "ImageURL" },
                values: new object[,]
                {
                    { new Guid("0c17d220-7f8e-4b58-b15d-a3f9d37a70dd"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)43, "43.png" },
                    { new Guid("0e66730c-50f5-4f72-b8cd-2f720ddf6d7e"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)25, "25.png" },
                    { new Guid("19954bda-0156-48f9-aee6-c8c258dafa58"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)29, "29.png" },
                    { new Guid("1c9b47b7-27a5-46c4-a8d0-e7163f1c3e7f"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)21, "21.png" },
                    { new Guid("1d73b99e-f451-4b55-9b20-ea4d572bc3a0"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)16, "16.png" },
                    { new Guid("22a1a283-80c0-4dc2-a9da-0a71a13b5dc0"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)40, "40.png" },
                    { new Guid("25a2ab91-5674-44aa-bbac-2ea3bceb71d4"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)8, "8.png" },
                    { new Guid("2abfb23c-34fa-4a48-b442-a1b28201ff32"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)22, "22.png" },
                    { new Guid("2cd639ce-c96f-4589-8014-0e6e7f9ff69f"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)20, "20.png" },
                    { new Guid("31ae274b-4dfc-4deb-af28-46de52cb6feb"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)3, "3.png" },
                    { new Guid("34c310fd-4fdc-4048-9b11-7b0a29d3b440"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)45, "45.png" },
                    { new Guid("3aaaa9a7-4465-494a-a7bd-08157d913586"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)5, "5.png" },
                    { new Guid("3d6be27d-6bcc-4e23-9fde-f785d000a72e"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)41, "41.png" },
                    { new Guid("45c4dfd6-910c-49a4-bb1c-f499377c8c61"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)23, "23.png" },
                    { new Guid("47059dc1-e213-4dc9-a1f3-1e263f7f29f2"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)44, "44.png" },
                    { new Guid("48a81e89-dbad-4fb5-b992-66b0a575d781"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)2, "2.png" },
                    { new Guid("4aca6f3a-2ccf-49de-af02-0b1776e793ee"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)17, "17.png" },
                    { new Guid("4e86fa98-7b46-44e7-92bc-dcc997c3574a"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)39, "39.png" },
                    { new Guid("5b2c0a01-6bc0-4b9c-b66f-72c45c8bdcb7"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)42, "42.png" },
                    { new Guid("64e10a07-b7f7-4335-9ef9-a3c7a5b67d7c"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)24, "24.png" },
                    { new Guid("6788fa1f-f257-4582-842e-ad505f1c8e92"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)36, "36.png" },
                    { new Guid("6819a0d1-31a5-4e13-aaab-57fa19edc770"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)46, "46.png" },
                    { new Guid("71147712-b450-4e4b-8df1-ed5d50160bf9"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)26, "26.png" },
                    { new Guid("72b0ea4d-8f47-4e40-8fbb-9a5d5e1c87d3"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)49, "49.png" },
                    { new Guid("785fb0ef-b383-4f44-98b5-bd6a555f0626"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)9, "9.png" },
                    { new Guid("7bd54d5b-d802-4d60-91a8-82a9079b1876"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)48, "48.png" },
                    { new Guid("7fb2316f-4341-401d-b28a-40146f8a7a0b"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)6, "6.png" },
                    { new Guid("853addd5-5496-490f-86bd-cc12ba04e2bd"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)27, "27.png" },
                    { new Guid("87e12554-c4a1-4bb7-906f-71c16042aaf3"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)33, "33.png" },
                    { new Guid("97c8d20b-0f88-47a6-91cb-e76d0b357ad3"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)28, "28.png" },
                    { new Guid("97ce8e61-ac01-4e85-9a12-67d94f5b7102"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)15, "15.png" },
                    { new Guid("9a4c2922-3a3b-4cc1-ba2e-d62317c8c0e0"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)1, "1.png" },
                    { new Guid("9f58f9f7-40c0-46bc-8052-7cb0ffca9a2c"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)47, "47.png" },
                    { new Guid("a11be2b5-3c5c-4adc-8642-d2dfda33813d"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)38, "38.png" },
                    { new Guid("a79456c1-8024-4128-9a31-db46f7eeef08"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)19, "19.png" },
                    { new Guid("ae3756ad-6b22-4645-90c6-a01b60b04d59"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)30, "30.png" },
                    { new Guid("b8f10d3d-74fb-448e-87a6-c2a46514e0e8"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)34, "34.png" },
                    { new Guid("bc5a3dbb-6b9e-4c4c-a013-f66ad22077dc"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)31, "31.png" },
                    { new Guid("bf280315-0e15-4074-978e-c0014a946383"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)14, "14.png" },
                    { new Guid("c2fa7cbe-138b-42e5-ad7b-c0afd43f43fd"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)10, "10.png" },
                    { new Guid("cb117933-9ccc-4ad6-afcf-65da344ba69a"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)11, "11.png" },
                    { new Guid("cb4b4f62-523f-4044-9d58-1ae3f12d430c"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)4, "4.png" },
                    { new Guid("d119637e-bf32-4b23-81ff-a09c1d910b81"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)12, "12.png" },
                    { new Guid("d3c2b7fa-2f9f-4883-862d-a9556d24a35d"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)50, "50.png" },
                    { new Guid("d9c7b2a1-67e0-4daa-8ad0-b8560938e847"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)7, "7.png" },
                    { new Guid("e992e5d9-67a8-4164-9273-ae229e648556"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)13, "13.png" },
                    { new Guid("eec8c785-84cf-4b8e-bcf2-128a4d9876da"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)32, "32.png" },
                    { new Guid("f1a77aa3-ffc5-4e9f-adcd-757545657941"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)35, "35.png" },
                    { new Guid("f78ffa61-a567-479a-aa79-011dfa2fdc4e"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)18, "18.png" },
                    { new Guid("f85d2bd9-6d9c-4a92-85b1-11c3ad17c133"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)37, "37.png" }
                });

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
                columns: new[] { "Avatar", "Gender" },
                values: new object[] { "User_Empty.png", 0 });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                columns: new[] { "Avatar", "Gender" },
                values: new object[] { "User_Empty.png", 0 });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("c6d20823-3d00-48a0-8074-36587bee2693"),
                columns: new[] { "Avatar", "Gender" },
                values: new object[] { "User_Empty.png", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("0c17d220-7f8e-4b58-b15d-a3f9d37a70dd"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("0e66730c-50f5-4f72-b8cd-2f720ddf6d7e"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("19954bda-0156-48f9-aee6-c8c258dafa58"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1c9b47b7-27a5-46c4-a8d0-e7163f1c3e7f"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("1d73b99e-f451-4b55-9b20-ea4d572bc3a0"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("22a1a283-80c0-4dc2-a9da-0a71a13b5dc0"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("25a2ab91-5674-44aa-bbac-2ea3bceb71d4"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("2abfb23c-34fa-4a48-b442-a1b28201ff32"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("2cd639ce-c96f-4589-8014-0e6e7f9ff69f"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("31ae274b-4dfc-4deb-af28-46de52cb6feb"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("34c310fd-4fdc-4048-9b11-7b0a29d3b440"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("3aaaa9a7-4465-494a-a7bd-08157d913586"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("3d6be27d-6bcc-4e23-9fde-f785d000a72e"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("45c4dfd6-910c-49a4-bb1c-f499377c8c61"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("47059dc1-e213-4dc9-a1f3-1e263f7f29f2"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("48a81e89-dbad-4fb5-b992-66b0a575d781"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("4aca6f3a-2ccf-49de-af02-0b1776e793ee"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("4e86fa98-7b46-44e7-92bc-dcc997c3574a"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("5b2c0a01-6bc0-4b9c-b66f-72c45c8bdcb7"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("64e10a07-b7f7-4335-9ef9-a3c7a5b67d7c"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("6788fa1f-f257-4582-842e-ad505f1c8e92"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("6819a0d1-31a5-4e13-aaab-57fa19edc770"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("71147712-b450-4e4b-8df1-ed5d50160bf9"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("72b0ea4d-8f47-4e40-8fbb-9a5d5e1c87d3"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("785fb0ef-b383-4f44-98b5-bd6a555f0626"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("7bd54d5b-d802-4d60-91a8-82a9079b1876"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("7fb2316f-4341-401d-b28a-40146f8a7a0b"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("853addd5-5496-490f-86bd-cc12ba04e2bd"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("87e12554-c4a1-4bb7-906f-71c16042aaf3"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("97c8d20b-0f88-47a6-91cb-e76d0b357ad3"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("97ce8e61-ac01-4e85-9a12-67d94f5b7102"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("9a4c2922-3a3b-4cc1-ba2e-d62317c8c0e0"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("9f58f9f7-40c0-46bc-8052-7cb0ffca9a2c"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("a11be2b5-3c5c-4adc-8642-d2dfda33813d"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("a79456c1-8024-4128-9a31-db46f7eeef08"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ae3756ad-6b22-4645-90c6-a01b60b04d59"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("b8f10d3d-74fb-448e-87a6-c2a46514e0e8"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("bc5a3dbb-6b9e-4c4c-a013-f66ad22077dc"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("bf280315-0e15-4074-978e-c0014a946383"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("c2fa7cbe-138b-42e5-ad7b-c0afd43f43fd"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("cb117933-9ccc-4ad6-afcf-65da344ba69a"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("cb4b4f62-523f-4044-9d58-1ae3f12d430c"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d119637e-bf32-4b23-81ff-a09c1d910b81"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d3c2b7fa-2f9f-4883-862d-a9556d24a35d"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("d9c7b2a1-67e0-4daa-8ad0-b8560938e847"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("e992e5d9-67a8-4164-9273-ae229e648556"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("eec8c785-84cf-4b8e-bcf2-128a4d9876da"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f1a77aa3-ffc5-4e9f-adcd-757545657941"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f78ffa61-a567-479a-aa79-011dfa2fdc4e"));

            migrationBuilder.DeleteData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("f85d2bd9-6d9c-4a92-85b1-11c3ad17c133"));

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

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                column: "Description",
                value: " Thường đề cập đến một loại tiểu thuyết thuộc thể loại viễn tưởng tập trung chủ yếu vào mối quan hệ và tình yêu lãng mạn giữa hai người, và thường có một kết thúc lạc quan và thỏa mãn về mặt cảm xúc");

            migrationBuilder.UpdateData(
                table: "chapter_image",
                keyColumn: "ImageIdentifier",
                keyValue: new Guid("ad981387-1e98-4036-8934-868c5e0880a9"),
                columns: new[] { "ImageNumber", "ImageURL" },
                values: new object[] { (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" });

            migrationBuilder.InsertData(
                table: "chapter_image",
                columns: new[] { "ImageIdentifier", "ChapterIdentifier", "ImageNumber", "ImageURL" },
                values: new object[,]
                {
                    { new Guid("1753ec49-2e45-4eec-ad77-44c514f19d35"), new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
                    { new Guid("27cddd0a-a8b2-4173-b951-0bedac4ce505"), new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
                    { new Guid("d531039b-1797-4b16-9302-349a6b13b331"), new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
                    { new Guid("ef7ff0f1-ae92-4887-b7fe-b93a43f36399"), new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "Amount", "Date", "EarnedCoin", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("42b6cb40-8369-4620-bf3b-d31c49a9284c"), 100000.0, new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6542), 100, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("72b35d60-35f4-43ae-8eb2-5840e711329e"), 200000.0, new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6550), 200, new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                    { new Guid("dd11cb5d-5665-4f02-b9c0-28fc303c12a1"), 50000.0, new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6547), 50, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
                });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                columns: new[] { "Avatar", "Gender" },
                values: new object[] { "", 2 });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                columns: new[] { "Avatar", "Gender" },
                values: new object[] { "", 2 });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("c6d20823-3d00-48a0-8074-36587bee2693"),
                columns: new[] { "Avatar", "Gender" },
                values: new object[] { "", 2 });
        }
    }
}
