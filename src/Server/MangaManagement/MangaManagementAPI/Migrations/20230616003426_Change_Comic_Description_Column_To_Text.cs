using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
	/// <inheritdoc />
	public partial class Change_Comic_Description_Column_To_Text : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "transaction_history",
				keyColumn: "TransactionIdentifier",
				keyValue: new Guid("4f0da62e-48c1-4103-beb8-951f20bde2e8"));

			migrationBuilder.DeleteData(
				table: "transaction_history",
				keyColumn: "TransactionIdentifier",
				keyValue: new Guid("85d98d2b-ffe7-4f04-b530-003c5e46c070"));

			migrationBuilder.DeleteData(
				table: "transaction_history",
				keyColumn: "TransactionIdentifier",
				keyValue: new Guid("d8d36a45-c1a5-45a0-ae2e-fe011344964f"));

			migrationBuilder.AlterColumn<string>(
				name: "ComicDescription",
				table: "comic",
				type: "TEXT",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "VARCHAR(1000)");

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 16));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 16));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 16));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("dc31637b-416c-458d-9942-74fa1470ca20"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 16));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 16));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7210));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7205));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7208));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7212));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7202));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7137));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7134));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7128));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7139));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7136));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7053));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7051));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7058));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7061));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(7059));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6947));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6948));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6940));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6944));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6951));

			migrationBuilder.InsertData(
				table: "transaction_history",
				columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
				values: new object[,]
				{
					{ new Guid("6b9c020e-ffe4-4ad6-8a81-2513d77191c4"), 100000.0, 100, new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6857), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
					{ new Guid("72f3406b-c7ed-4415-8ca1-502de7d7d737"), 200000.0, 200, new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6866), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
					{ new Guid("bcbda934-1b9c-4684-a375-1b1d619ba3a0"), 50000.0, 50, new DateTime(2023, 6, 16, 0, 34, 26, 298, DateTimeKind.Utc).AddTicks(6864), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "transaction_history",
				keyColumn: "TransactionIdentifier",
				keyValue: new Guid("6b9c020e-ffe4-4ad6-8a81-2513d77191c4"));

			migrationBuilder.DeleteData(
				table: "transaction_history",
				keyColumn: "TransactionIdentifier",
				keyValue: new Guid("72f3406b-c7ed-4415-8ca1-502de7d7d737"));

			migrationBuilder.DeleteData(
				table: "transaction_history",
				keyColumn: "TransactionIdentifier",
				keyValue: new Guid("bcbda934-1b9c-4684-a375-1b1d619ba3a0"));

			migrationBuilder.AlterColumn<string>(
				name: "ComicDescription",
				table: "comic",
				type: "VARCHAR(1000)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "TEXT");

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 14));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 14));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 14));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("dc31637b-416c-458d-9942-74fa1470ca20"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 14));

			migrationBuilder.UpdateData(
				table: "chapter",
				keyColumn: "ChapterIdentifier",
				keyValue: new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"),
				column: "AddedDate",
				value: new DateOnly(2023, 6, 14));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3963));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3958));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3961));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3965));

			migrationBuilder.UpdateData(
				table: "comic_saving",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "SavingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3955));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3892));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3889));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3885));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3893));

			migrationBuilder.UpdateData(
				table: "reading_history",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "LastReadingTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3890));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3821));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3817));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3824));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3828));

			migrationBuilder.UpdateData(
				table: "review_chapter",
				keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3826));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3744));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3746));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3738));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3742));

			migrationBuilder.UpdateData(
				table: "review_comic",
				keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
				keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
				column: "ReviewTime",
				value: new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3749));

			migrationBuilder.InsertData(
				table: "transaction_history",
				columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
				values: new object[,]
				{
					{ new Guid("4f0da62e-48c1-4103-beb8-951f20bde2e8"), 200000.0, 200, new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3654), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
					{ new Guid("85d98d2b-ffe7-4f04-b530-003c5e46c070"), 100000.0, 100, new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3646), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
					{ new Guid("d8d36a45-c1a5-45a0-ae2e-fe011344964f"), 50000.0, 50, new DateTime(2023, 6, 14, 13, 33, 3, 746, DateTimeKind.Utc).AddTicks(3652), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") }
				});
		}
	}
}
