﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Delete_ComicLatestChapter_Column_And_Create_ComicStatus_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ComicLatestChapter",
                table: "comic");

            migrationBuilder.AddColumn<string>(
                name: "ComicStatus",
                table: "comic",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                column: "ComicStatus",
                value: "Đang Cập Nhật");

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"),
                column: "ComicStatus",
                value: "Đang Cập Nhật");

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                column: "ComicStatus",
                value: "Đang Cập Nhật");

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                column: "ComicStatus",
                value: "Đang Cập Nhật");

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                column: "ComicStatus",
                value: "Đang Cập Nhật");

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "ReviewTime",
                value: new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "TransactionAmount", "TransactionCoin", "TransactionDate", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("483c457e-f4bb-41c1-af0e-b836361cfabc"), 50000.0, 50, new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9005), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("780453f7-19a3-4d66-831f-b1de840d8ecd"), 100000.0, 100, new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(8999), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("cf0d0912-8e5a-4936-bae3-12bea0296607"), 200000.0, 200, new DateTime(2023, 6, 13, 4, 7, 2, 257, DateTimeKind.Utc).AddTicks(9019), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("483c457e-f4bb-41c1-af0e-b836361cfabc"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("780453f7-19a3-4d66-831f-b1de840d8ecd"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("cf0d0912-8e5a-4936-bae3-12bea0296607"));

            migrationBuilder.DropColumn(
                name: "ComicStatus",
                table: "comic");

            migrationBuilder.AddColumn<double>(
                name: "ComicLatestChapter",
                table: "comic",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                column: "ComicLatestChapter",
                value: 205.59999999999999);

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"),
                column: "ComicLatestChapter",
                value: 360.0);

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                column: "ComicLatestChapter",
                value: 232.0);

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                column: "ComicLatestChapter",
                value: 132.0);

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                column: "ComicLatestChapter",
                value: 302.0);

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
        }
    }
}