using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MangaManagementAPI.Migrations
{
	/// <inheritdoc />
	public partial class Init_Manga_management_Database : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "category",
				columns: table => new
				{
					CategoryIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
					Name = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: ""),
					Description = table.Column<string>(type: "VARCHAR(500)", nullable: false, defaultValue: "")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_category", x => x.CategoryIdentifier);
				});

			migrationBuilder.CreateTable(
				name: "comic",
				columns: table => new
				{
					ComicIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
					Name = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: ""),
					Description = table.Column<string>(type: "VARCHAR(200)", nullable: false, defaultValue: ""),
					Avatar = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: ""),
					PublishDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
					LatestChapter = table.Column<double>(type: "double precision", nullable: false, defaultValue: 0.0)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_comic", x => x.ComicIdentifier);
				});

			migrationBuilder.CreateTable(
				name: "user_access",
				columns: table => new
				{
					UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
					UserName = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: ""),
					Password = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: ""),
					FullName = table.Column<string>(type: "VARCHAR(30)", nullable: false, defaultValue: ""),
					Gender = table.Column<int>(type: "integer", nullable: false, defaultValue: 2),
					BirthDay = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
					PhoneNumber = table.Column<string>(type: "VARCHAR(13)", nullable: false, defaultValue: ""),
					Email = table.Column<string>(type: "VARCHAR(30)", nullable: false, defaultValue: ""),
					AccountBalance = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
					Avatar = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: "")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_user_access", x => x.UserIdentifier);
				});

			migrationBuilder.CreateTable(
				name: "chapter",
				columns: table => new
				{
					ChapterIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
					ChapterNumber = table.Column<double>(type: "double precision", nullable: false, defaultValue: 0.0),
					UnlockPrice = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
					ComicIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("00000000-0000-0000-0000-000000000000"))
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_chapter", x => x.ChapterIdentifier);
					table.ForeignKey(
						name: "FK_chapter_comic_ComicIdentifier",
						column: x => x.ComicIdentifier,
						principalTable: "comic",
						principalColumn: "ComicIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "comic_category",
				columns: table => new
				{
					CategoryIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					ComicIdentifier = table.Column<Guid>(type: "uuid", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_comic_category", x => new { x.CategoryIdentifier, x.ComicIdentifier });
					table.ForeignKey(
						name: "FK_comic_category_category_CategoryIdentifier",
						column: x => x.CategoryIdentifier,
						principalTable: "category",
						principalColumn: "CategoryIdentifier",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_comic_category_comic_ComicIdentifier",
						column: x => x.ComicIdentifier,
						principalTable: "comic",
						principalColumn: "ComicIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "comic_saving",
				columns: table => new
				{
					UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					ComicIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					SavingTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_comic_saving", x => new { x.ComicIdentifier, x.UserIdentifier });
					table.ForeignKey(
						name: "FK_comic_saving_comic_ComicIdentifier",
						column: x => x.ComicIdentifier,
						principalTable: "comic",
						principalColumn: "ComicIdentifier",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_comic_saving_user_access_UserIdentifier",
						column: x => x.UserIdentifier,
						principalTable: "user_access",
						principalColumn: "UserIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "review_comic",
				columns: table => new
				{
					UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					ComicIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					RatingStar = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
					Comment = table.Column<string>(type: "VARCHAR(200)", nullable: false, defaultValue: ""),
					ReviewTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_review_comic", x => new { x.UserIdentifier, x.ComicIdentifier });
					table.ForeignKey(
						name: "FK_review_comic_comic_ComicIdentifier",
						column: x => x.ComicIdentifier,
						principalTable: "comic",
						principalColumn: "ComicIdentifier",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_review_comic_user_access_UserIdentifier",
						column: x => x.UserIdentifier,
						principalTable: "user_access",
						principalColumn: "UserIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "transaction_history",
				columns: table => new
				{
					TransactionIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
					Amount = table.Column<double>(type: "numeric(6,0)", nullable: false, defaultValue: 0.0),
					EarnedCoin = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
					Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
					UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("00000000-0000-0000-0000-000000000000"))
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_transaction_history", x => x.TransactionIdentifier);
					table.ForeignKey(
						name: "FK_transaction_history_user_access_UserIdentifier",
						column: x => x.UserIdentifier,
						principalTable: "user_access",
						principalColumn: "UserIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "chapter_image",
				columns: table => new
				{
					ImageIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
					ImageNumber = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
					ImageURL = table.Column<string>(type: "VARCHAR(50)", nullable: false, defaultValue: ""),
					ChapterIdentifier = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("00000000-0000-0000-0000-000000000000"))
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_chapter_image", x => x.ImageIdentifier);
					table.ForeignKey(
						name: "FK_chapter_image_chapter_ChapterIdentifier",
						column: x => x.ChapterIdentifier,
						principalTable: "chapter",
						principalColumn: "ChapterIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "reading_history",
				columns: table => new
				{
					UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					ChapterIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					LastReadingTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_reading_history", x => new { x.UserIdentifier, x.ChapterIdentifier });
					table.ForeignKey(
						name: "FK_reading_history_chapter_ChapterIdentifier",
						column: x => x.ChapterIdentifier,
						principalTable: "chapter",
						principalColumn: "ChapterIdentifier",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_reading_history_user_access_UserIdentifier",
						column: x => x.UserIdentifier,
						principalTable: "user_access",
						principalColumn: "UserIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "review_chapter",
				columns: table => new
				{
					UserIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					ChapterIdentifier = table.Column<Guid>(type: "uuid", nullable: false),
					RatingStar = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
					Comment = table.Column<string>(type: "VARCHAR(200)", nullable: false, defaultValue: ""),
					ReviewTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_review_chapter", x => new { x.UserIdentifier, x.ChapterIdentifier });
					table.ForeignKey(
						name: "FK_review_chapter_chapter_ChapterIdentifier",
						column: x => x.ChapterIdentifier,
						principalTable: "chapter",
						principalColumn: "ChapterIdentifier",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_review_chapter_user_access_UserIdentifier",
						column: x => x.UserIdentifier,
						principalTable: "user_access",
						principalColumn: "UserIdentifier",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "category",
				columns: new[] { "CategoryIdentifier", "Description", "Name" },
				values: new object[,]
				{
					{ new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"), "A story where martial arts and martial arts-related topics are covered. This includes stories about martial artists, martial arts tournaments, martial arts academies, and other topics related to martial arts. For example, some common subcategories are martial arts styles, self-defense, and martial arts history. Some anime and manga with this category include 'Kenichi: The Mightiest Disciple' and 'The Karate Kid.'", "MartialArts" },
					{ new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), "A story where horror and horror-related topics are covered. This includes stories about monsters, ghosts, demons, zombies, vampires, and other", "Horror" },
					{ new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), "A story where a lot of cooking and cooking-related topics are covered. This includes cooking shows, celebrity chefs, restaurants, recipe books, cooking techniques, and other topics related to cooking. For example, some common subcategories are cooking techniques, vegan cooking, baking, and food chemistry.", "Cooking" },
					{ new Guid("72522ef6-6633-4519-872b-36bc0675e328"), "A story where science fiction and sci-fi-related topics are covered. This includes stories about futuristic worlds, space travel, aliens, cyborgs, robots, and other topics related to imaginary or futuristic worlds. For example, some common subcategories are sci-fi adventures, science fiction romance, and space operas. Some manga and anime with this category include 'Ghost in the Shell' and 'Cowboy Bebop.'", "Sci-fi" },
					{ new Guid("ad2149ef-ac21-4759-88d8-e586e850e299"), "A story where student life and school-related topics are covered. This includes stories about students, teachers, school activities, school dramas, and other topics related to the school setting. For example, some common subcategories are school life, school romances, school sports, and school clubs. Some manga and anime with this category include 'K-On!' and 'GTO.'", "SchoolLife" },
					{ new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"), "A story where the art is in full color.", "FullColor" },
					{ new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"), "A story where fighting and battling-related topics are covered. This includes stories about heroes, villains, monsters, ninjas, soldiers, aliens, robots, and other topics related to battles and wars. For example, some common subcategories are action adventures, science fiction, and super-hero stories. Some manga and anime with this category include 'Dragon Ball Z' and 'One Piece.'", "Action" }
				});

			migrationBuilder.InsertData(
				table: "comic",
				columns: new[] { "ComicIdentifier", "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
				values: new object[,]
				{
					{ new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), "C:\\Users\\USER\\Downloads\\pic1.jpg", "This comic follows the adventures of a group of superheroes in a universe of superpowers and evil villains.", 40.0, "atadakishta", new DateOnly(2014, 1, 1) },
					{ new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), "C:\\Users\\USER\\Downloads\\pic1.jpg", "This comic follows the adventures of a group of historical heroes in a universe of real-world events and historical figures.", 19.0, "eikan no tatakai", new DateOnly(2017, 4, 1) },
					{ new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), "C:\\Users\\USER\\Downloads\\pic1.jpg", "This comic follows the adventures of a group of sci-fi heroes in a universe of advanced technology and alien civilizations.", 13.0, "eiyu no chi", new DateOnly(2016, 3, 1) },
					{ new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), "C:\\Users\\USER\\Downloads\\pic1.jpg", "This comic follows the adventures of a group of fantasy heroes in a universe of magic and mysticism.", 8.0, "bouken-sha no tabi", new DateOnly(2015, 2, 1) },
					{ new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), "C:\\Users\\USER\\Downloads\\pic1.jpg", "This comic follows the adventures of a group of romantic heroes in a universe of love and relationships.", 33.0, "shichiryu no himitsu", new DateOnly(2018, 4, 22) }
				});

			migrationBuilder.InsertData(
				table: "user_access",
				columns: new[] { "UserIdentifier", "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
				values: new object[,]
				{
					{ new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), 1500, "C:\\Users\\USER\\Downloads\\pic1.jpg", new DateOnly(2023, 6, 4), "janesmith@example.com", "Jane Smith", 1, "12345678", "5550123456", "Jane Smith" },
					{ new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), 1000, "C:\\Users\\USER\\Downloads\\pic1.jpg", new DateOnly(2023, 6, 4), "johndoe@example.com", "John Doe", 0, "12345678", "1234567890", "John Doe" },
					{ new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), 2000, "C:\\Users\\USER\\Downloads\\pic1.jpg", new DateOnly(2023, 6, 4), "alicethompson@example.com", "Alice Thompson", 2, "12345678", "7778889999", "Alice Thompson" }
				});

			migrationBuilder.InsertData(
				table: "chapter",
				columns: new[] { "ChapterIdentifier", "ChapterNumber", "ComicIdentifier" },
				values: new object[,]
				{
					{ new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), 1.0, new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") },
					{ new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), 1.0, new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f") }
				});

			migrationBuilder.InsertData(
				table: "chapter",
				columns: new[] { "ChapterIdentifier", "ChapterNumber", "ComicIdentifier", "UnlockPrice" },
				values: new object[,]
				{
					{ new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), 1.0, new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), 75 },
					{ new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), 1.0, new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), 150 },
					{ new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), 2.0, new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), 25 }
				});

			migrationBuilder.InsertData(
				table: "comic_category",
				columns: new[] { "CategoryIdentifier", "ComicIdentifier" },
				values: new object[,]
				{
					{ new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") },
					{ new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") }
				});

			migrationBuilder.InsertData(
				table: "comic_saving",
				columns: new[] { "ComicIdentifier", "UserIdentifier", "SavingTime" },
				values: new object[,]
				{
					{ new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8276) },
					{ new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8272) },
					{ new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8273) },
					{ new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8277) },
					{ new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8269) }
				});

			migrationBuilder.InsertData(
				table: "review_comic",
				columns: new[] { "ComicIdentifier", "UserIdentifier", "Comment", "RatingStar", "ReviewTime" },
				values: new object[,]
				{
					{ new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "I laughed so hard I cried!", (short)5, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8012) },
					{ new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "I hated the ending.", (short)1, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8015) },
					{ new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "The artwork is amazing!", (short)3, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8003) },
					{ new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "The story line is hard to follow.", (short)2, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8010) },
					{ new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), "I wanted more action scenes.", (short)4, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8017) }
				});

			migrationBuilder.InsertData(
				table: "transaction_history",
				columns: new[] { "TransactionIdentifier", "Amount", "Date", "EarnedCoin", "UserIdentifier" },
				values: new object[,]
				{
					{ new Guid("38da794c-febd-41bd-aec6-43dc631c77bd"), 50000.0, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(7898), 50, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
					{ new Guid("7fc98212-eb59-4f66-9476-0055b9390132"), 100000.0, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(7838), 100, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
					{ new Guid("dcee2662-889a-44b6-91c5-be4a48313c9a"), 200000.0, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(7902), 200, new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
				});

			migrationBuilder.InsertData(
				table: "chapter_image",
				columns: new[] { "ImageIdentifier", "ChapterIdentifier", "ImageNumber", "ImageURL" },
				values: new object[,]
				{
					{ new Guid("1753ec49-2e45-4eec-ad77-44c514f19d35"), new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
					{ new Guid("27cddd0a-a8b2-4173-b951-0bedac4ce505"), new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
					{ new Guid("ad981387-1e98-4036-8934-868c5e0880a9"), new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
					{ new Guid("d531039b-1797-4b16-9302-349a6b13b331"), new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" },
					{ new Guid("ef7ff0f1-ae92-4887-b7fe-b93a43f36399"), new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), (short)1, "C:\\Users\\USER\\Downloads\\pic1.jpg" }
				});

			migrationBuilder.InsertData(
				table: "reading_history",
				columns: new[] { "ChapterIdentifier", "UserIdentifier", "LastReadingTime" },
				values: new object[,]
				{
					{ new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8201) },
					{ new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8198) },
					{ new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8195) },
					{ new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8203) },
					{ new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8200) }
				});

			migrationBuilder.InsertData(
				table: "review_chapter",
				columns: new[] { "ChapterIdentifier", "UserIdentifier", "Comment", "RatingStar", "ReviewTime" },
				values: new object[,]
				{
					{ new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"), "It's ok, but not great.", (short)3, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8107) },
					{ new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "It's the best thing I've read in years!", (short)5, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8102) },
					{ new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"), "I didn't like it at all.", (short)2, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8110) },
					{ new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), "It's pretty good!", (short)4, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8114) },
					{ new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693"), "It's the worst.", (short)1, new DateTime(2023, 6, 4, 5, 23, 22, 571, DateTimeKind.Utc).AddTicks(8112) }
				});

			migrationBuilder.CreateIndex(
				name: "IX_chapter_ComicIdentifier",
				table: "chapter",
				column: "ComicIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_chapter_image_ChapterIdentifier",
				table: "chapter_image",
				column: "ChapterIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_comic_category_ComicIdentifier",
				table: "comic_category",
				column: "ComicIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_comic_saving_UserIdentifier",
				table: "comic_saving",
				column: "UserIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_reading_history_ChapterIdentifier",
				table: "reading_history",
				column: "ChapterIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_review_chapter_ChapterIdentifier",
				table: "review_chapter",
				column: "ChapterIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_review_comic_ComicIdentifier",
				table: "review_comic",
				column: "ComicIdentifier");

			migrationBuilder.CreateIndex(
				name: "IX_transaction_history_UserIdentifier",
				table: "transaction_history",
				column: "UserIdentifier");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "chapter_image");

			migrationBuilder.DropTable(
				name: "comic_category");

			migrationBuilder.DropTable(
				name: "comic_saving");

			migrationBuilder.DropTable(
				name: "reading_history");

			migrationBuilder.DropTable(
				name: "review_chapter");

			migrationBuilder.DropTable(
				name: "review_comic");

			migrationBuilder.DropTable(
				name: "transaction_history");

			migrationBuilder.DropTable(
				name: "category");

			migrationBuilder.DropTable(
				name: "chapter");

			migrationBuilder.DropTable(
				name: "user_access");

			migrationBuilder.DropTable(
				name: "comic");
		}
	}
}
