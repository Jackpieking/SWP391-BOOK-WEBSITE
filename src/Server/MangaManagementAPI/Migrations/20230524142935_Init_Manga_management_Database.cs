using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;


namespace MangaManagementAPI.MaigaManagementAPI;

/// <inheritdoc />
public partial class Init_Manga_management_Database : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.CreateTable(
			name: "User-Access",
			columns: table => new
			{
				ID = table.Column<int>(type: "integer", nullable: false)
					.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
				FullName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
				Age = table.Column<byte>(type: "smallint", nullable: true),
				Gender = table.Column<int>(type: "integer", nullable: true),
				BirthDay = table.Column<DateOnly>(type: "date", nullable: true),
				Email = table.Column<string>(type: "VARCHAR(30)", nullable: false),
				AccountBalance = table.Column<int>(type: "integer", nullable: false),
				Avatar = table.Column<string>(type: "text", nullable: true),
				UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_User-Access", x => x.ID);
				table.UniqueConstraint("AK_User-Access_UserIdentifier", x => x.UserIdentifier);
			});

		migrationBuilder.CreateTable(
			name: "Login-Account",
			columns: table => new
			{
				ID = table.Column<int>(type: "integer", nullable: false)
					.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
				UserName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
				Password = table.Column<string>(type: "VARCHAR(50)", nullable: false),
				Role = table.Column<int>(type: "integer", nullable: false),
				UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Login-Account", x => x.ID);
				table.ForeignKey(
					name: "FK_Login-Account_User-Access_UserIdentifier",
					column: x => x.UserIdentifier,
					principalTable: "User-Access",
					principalColumn: "UserIdentifier",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.InsertData(
			table: "User-Access",
			columns: new[] { "ID", "AccountBalance", "Age", "Avatar", "BirthDay", "Email", "FullName", "Gender", "UserIdentifier" },
			values: new object[] { 1, 10000000, (byte)20, "", new DateOnly(2003, 12, 3), "ledinhdangkhoa10a9@gmail.com", "Le Dinh Dang Khoa", 0, new Guid("585a96f6-3d1b-4fa3-83f1-e2da38ecd92b") });

		migrationBuilder.InsertData(
			table: "Login-Account",
			columns: new[] { "ID", "Password", "Role", "UserIdentifier", "UserName" },
			values: new object[] { 1, "Jackpie2003", 2, new Guid("585a96f6-3d1b-4fa3-83f1-e2da38ecd92b"), "jackpieking" });

		migrationBuilder.CreateIndex(
			name: "IX_Login-Account_UserIdentifier",
			table: "Login-Account",
			column: "UserIdentifier",
			unique: true);

		migrationBuilder.CreateIndex(
			name: "IX_Login-Account_UserName",
			table: "Login-Account",
			column: "UserName",
			unique: true);

		migrationBuilder.CreateIndex(
			name: "IX_User-Access_UserIdentifier",
			table: "User-Access",
			column: "UserIdentifier",
			unique: true);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable(
			name: "Login-Account");

		migrationBuilder.DropTable(
			name: "User-Access");
	}
}
