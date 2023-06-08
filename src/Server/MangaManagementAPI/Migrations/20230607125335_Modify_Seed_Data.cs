using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MangaManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class Modify_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") });

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("21e655da-32ac-4e5a-9de4-6f5c68a606ba"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("7b622c3b-dc7f-40f9-b683-daa42ede8ec7"));

            migrationBuilder.DeleteData(
                table: "transaction_history",
                keyColumn: "TransactionIdentifier",
                keyValue: new Guid("9a4c2212-6243-4676-95f2-83f2d2dbcee5"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "comic",
                type: "VARCHAR(1000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldDefaultValue: "");

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Thường đề cập đến một loại tiểu thuyết thuộc thể loại viễn tưởng tập trung chủ yếu vào mối quan hệ và tình yêu lãng mạn giữa hai người, và thường có một kết thúc lạc quan và thỏa mãn về mặt cảm xúc", "Romance" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Một thể loại biên tập truyện tranh Nhật Bản nhắm đến đối tượng là các cậu bé vị thành niên", "Shounen" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("414e65b4-1949-48ce-a764-26fb66e95550"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Thể loại theo sau một tội ác (như giết người hoặc mất tích) từ thời điểm nó được thực hiện cho đến thời điểm nó được giải quyết", "Mystery" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("72522ef6-6633-4519-872b-36bc0675e328"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Một thể loại của tiểu thuyết suy đoán liên quan đến các yếu tố ma thuật, thường lấy bối cảnh trong một vũ trụ hư cấu và đôi khi lấy cảm hứng từ thần thoại và văn hóa dân gian", "Fantasy" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("ad2149ef-ac21-4759-88d8-e586e850e299"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Lấy bối cảnh là một giai đoạn lịch sử và cố gắng truyền đạt tinh thần, cách cư xử và điều kiện xã hội của một thời đại đã qua với các chi tiết hiện thực và sự trung thực (trong một số trường hợp chỉ là sự trung thực bề ngoài) với sự thật lịch sử", "Historical" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Thể loại bao gồm những cuốn sách mà nhân vật chính thực hiện một cuộc hành trình sử thi, về mặt cá nhân hoặc địa lý", "Adventure" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Phương thức cụ thể của tiểu thuyết được thể hiện trong biểu diễn: một vở kịch, opera, kịch câm, múa ba lê, v.v., được trình diễn trong rạp hát, hoặc trên đài phát thanh hoặc truyền hình", "Drama" });

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
                column: "UnlockPrice",
                value: 0);

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("dc31637b-416c-458d-9942-74fa1470ca20"),
                column: "UnlockPrice",
                value: 0);

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"),
                columns: new[] { "ChapterNumber", "ComicIdentifier", "UnlockPrice" },
                values: new object[] { 1.0, new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), 0 });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "Thanh_Gươm_Diệt_Quỷ.jpg", "Kimetsu no Yaiba – Tanjirou là con cả của gia đình vừa mất cha. Một ngày nọ, Tanjirou đến thăm thị trấn khác để bán than, khi đêm về cậu ở nghỉ tại nhà người khác thay vì về nhà vì lời đồn thổi về ác quỷ luôn rình mò gần núi vào buổi tối. Khi cậu về nhà vào ngày hôm sau, bị kịch đang đợi chờ cậu…", 205.59999999999999, "Thanh Gươm Diệt Quỷ", new DateOnly(2016, 11, 2) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "Black_Clover_Thế_Giới_Phép_Thuật.jpg", "Aster và Yuno là hai đứa trẻ bị bỏ rơi ở nhà thờ và cùng nhau lớn lên tại đó. Khi còn nhỏ, chúng đã hứa với nhau xem ai sẽ trở thành Ma pháp vương tiếp theo. Thế nhưng, khi cả hai lớn lên, mọi sô chuyện đã thay đổi. Yuno là thiên tài ma pháp với sức mạnh tuyệt đỉnh trong khi Aster lại không thể sử dụng ma pháp và cố gắng bù đắp bằng thể lực. Khi cả hai được nhận sách phép vào tuổi 15, Yuno đã được ban cuốn sách phép cỏ bốn bá (trong khi đa số là cỏ ba lá) mà Aster lại không có cuốn nào. Tuy nhiên, khi Yuno bị đe dọa, sự thật về sức mạnh của Aster đã được giải mã- cậu ta được ban cuốn sách phép cỏ năm lá, cuốn sách phá ma thuật màu đen. Bấy giờ, hai người bạn trẻ đang hướng ra thế giới, cùng chung mục tiêu.", 360.0, "Black Clover - Thế Giới Phép Thuật", new DateOnly(2015, 4, 18) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "Onepunch_Man.jpg", "Onepunch-Man là một Manga thể loại siêu anh hùng với đặc trưng phồng tôm đấm phát chết luôn… Lol!!! Nhân vật chính trong Onepunch-man là Saitama, một con người mà nhìn đâu cũng thấy “tầm thường”, từ khuôn mặt vô hồn, cái đầu trọc lóc, cho tới thể hình long tong. Tuy nhiên, con người nhìn thì tầm thường này lại chuyên giải quyết những vấn đề hết sức bất thường. Anh thực chất chính là một siêu anh hùng luôn tìm kiếm cho mình một đối thủ mạnh. Vấn đề là, cứ mỗi lần bắt gặp một đối thủ tiềm năng, thì đối thủ nào cũng như đối thủ nào, chỉ ăn một đấm của anh là… chết luôn. Liệu rằng Onepunch-Man Saitaman có thể tìm được cho mình một kẻ ác dữ dằn đủ sức đấu với anh? Hãy theo bước Saitama trên con đường một đấm tìm đối cực kỳ hài hước của anh!!\r\n\r\n", 232.0, "Onepunch Man", new DateOnly(2018, 3, 26) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "Hội_Pháp_Sư_Nhiệm_Vụ_Trăm_Năm.jpg", "Tuyện tiếp nối chap 545 của Fairy Tail, khi nhóm Natsu đi làm nhiệm vụ trăm năm.", 132.0, "Hội Pháp Sư Nhiệm Vụ Trăm Năm", new DateOnly(2018, 7, 25) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "Thần_Y_Đích_Nữ.jpg", "Một nữ quân y đặc cấp trong bộ đội lục chiến, thánh thủ trung tây y, tinh thông võ thuật, tiễn thuật vì một tai nạn trên không mà xuyên không về lịch sử. Mang trên mình mối thù, nàng sẽ làm gì đây?", 302.0, "Thần Y Đích Nữ", new DateOnly(2016, 5, 26) });

            migrationBuilder.InsertData(
                table: "comic_category",
                columns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                values: new object[,]
                {
                    { new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"), new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3") },
                    { new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") },
                    { new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") },
                    { new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f") },
                    { new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") },
                    { new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3") },
                    { new Guid("72522ef6-6633-4519-872b-36bc0675e328"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") },
                    { new Guid("72522ef6-6633-4519-872b-36bc0675e328"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") },
                    { new Guid("72522ef6-6633-4519-872b-36bc0675e328"), new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f") },
                    { new Guid("ad2149ef-ac21-4759-88d8-e586e850e299"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") },
                    { new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"), new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f") },
                    { new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"), new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f") },
                    { new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") },
                    { new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") }
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
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Art đẹp, nhưng cốt truyện không hay", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Nó hay vãi", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Art tạm tạm", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Được phết", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Meh không ổn tí nào", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Cười vãi", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Tui muốn gud end", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Tổng quan về cốt truyện ở mức ổn", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Cốt truyện khó hiểu", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "Đánh nhau ít nhưng tổng quan vẫn OK", new DateTime(2023, 6, 7, 12, 53, 35, 196, DateTimeKind.Utc).AddTicks(6629) });

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
                columns: new[] { "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 100, "", new DateOnly(2003, 4, 2), "nghialt123@gmail.com", "Lee Trung Nghĩa", 0, "NghiaLe123", "0903591555", "wibulord" });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                columns: new[] { "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 30, "", new DateOnly(2003, 12, 3), "ledinhdangkhoa10a9@gmail.com", "Lê Đình Đăng Khoa", 0, "Jackpie2003", "0706042250", "Jackpieking" });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("c6d20823-3d00-48a0-8074-36587bee2693"),
                columns: new[] { "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 0, "", new DateOnly(2003, 8, 15), "lamvd@gmail.com", "Võ Đại Lâm", 0, "Lam123", "02343883333", "lamvd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"), new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"), new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("72522ef6-6633-4519-872b-36bc0675e328"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("72522ef6-6633-4519-872b-36bc0675e328"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("72522ef6-6633-4519-872b-36bc0675e328"), new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("ad2149ef-ac21-4759-88d8-e586e850e299"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"), new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"), new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") });

            migrationBuilder.DeleteData(
                table: "comic_category",
                keyColumns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                keyValues: new object[] { new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"), new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e") });

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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "comic",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(1000)",
                oldDefaultValue: "");

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where martial arts and martial arts-related topics are covered. This includes stories about martial artists, martial arts tournaments, martial arts academies, and other topics related to martial arts. For example, some common subcategories are martial arts styles, self-defense, and martial arts history. Some anime and manga with this category include 'Kenichi: The Mightiest Disciple' and 'The Karate Kid.'", "MartialArts" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("322dbf35-54aa-416e-b121-42fc20b9d94b"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where horror and horror-related topics are covered. This includes stories about monsters, ghosts, demons, zombies, vampires, and other", "Horror" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("414e65b4-1949-48ce-a764-26fb66e95550"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where a lot of cooking and cooking-related topics are covered. This includes cooking shows, celebrity chefs, restaurants, recipe books, cooking techniques, and other topics related to cooking. For example, some common subcategories are cooking techniques, vegan cooking, baking, and food chemistry.", "Cooking" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("72522ef6-6633-4519-872b-36bc0675e328"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where science fiction and sci-fi-related topics are covered. This includes stories about futuristic worlds, space travel, aliens, cyborgs, robots, and other topics related to imaginary or futuristic worlds. For example, some common subcategories are sci-fi adventures, science fiction romance, and space operas. Some manga and anime with this category include 'Ghost in the Shell' and 'Cowboy Bebop.'", "Sci-fi" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("ad2149ef-ac21-4759-88d8-e586e850e299"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where student life and school-related topics are covered. This includes stories about students, teachers, school activities, school dramas, and other topics related to the school setting. For example, some common subcategories are school life, school romances, school sports, and school clubs. Some manga and anime with this category include 'K-On!' and 'GTO.'", "SchoolLife" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("ddebafec-b0a5-49c6-ac6c-261079080dce"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where the art is in full color.", "FullColor" });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "CategoryIdentifier",
                keyValue: new Guid("edc6e266-7b95-4723-a420-8e51a78d99bc"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "A story where fighting and battling-related topics are covered. This includes stories about heroes, villains, monsters, ninjas, soldiers, aliens, robots, and other topics related to battles and wars. For example, some common subcategories are action adventures, science fiction, and super-hero stories. Some manga and anime with this category include 'Dragon Ball Z' and 'One Piece.'", "Action" });

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"),
                column: "UnlockPrice",
                value: 75);

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("dc31637b-416c-458d-9942-74fa1470ca20"),
                column: "UnlockPrice",
                value: 150);

            migrationBuilder.UpdateData(
                table: "chapter",
                keyColumn: "ChapterIdentifier",
                keyValue: new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"),
                columns: new[] { "ChapterNumber", "ComicIdentifier", "UnlockPrice" },
                values: new object[] { 2.0, new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), 25 });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "image\\pic1.jpg", "This comic follows the adventures of a group of superheroes in a universe of superpowers and evil villains.", 40.0, "atadakishta", new DateOnly(2014, 1, 1) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "image\\pic1.jpg", "This comic follows the adventures of a group of historical heroes in a universe of real-world events and historical figures.", 19.0, "eikan no tatakai", new DateOnly(2017, 4, 1) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "image\\pic1.jpg", "This comic follows the adventures of a group of sci-fi heroes in a universe of advanced technology and alien civilizations.", 13.0, "eiyu no chi", new DateOnly(2016, 3, 1) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "image\\pic1.jpg", "This comic follows the adventures of a group of fantasy heroes in a universe of magic and mysticism.", 8.0, "bouken-sha no tabi", new DateOnly(2015, 2, 1) });

            migrationBuilder.UpdateData(
                table: "comic",
                keyColumn: "ComicIdentifier",
                keyValue: new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                columns: new[] { "Avatar", "Description", "LatestChapter", "Name", "PublishDate" },
                values: new object[] { "image\\pic1.jpg", "This comic follows the adventures of a group of romantic heroes in a universe of love and relationships.", 33.0, "shichiryu no himitsu", new DateOnly(2018, 4, 22) });

            migrationBuilder.InsertData(
                table: "comic_category",
                columns: new[] { "CategoryIdentifier", "ComicIdentifier" },
                values: new object[] { new Guid("414e65b4-1949-48ce-a764-26fb66e95550"), new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787") });

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("4dfe12e0-cb8a-4282-8e74-3b1e8053f787"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("aadadaf7-fc21-4559-a53c-f97eb1ba583f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "comic_saving",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                column: "SavingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "reading_history",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ef26e85e-4bd5-414f-9a2b-40bc43534523"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                column: "LastReadingTime",
                value: new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "It's ok, but not great.", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("3f5a415f-caa3-426b-8926-a11a55dc49b0"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "It's the best thing I've read in years!", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("dc31637b-416c-458d-9942-74fa1470ca20"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "I didn't like it at all.", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("94f15b6a-a89b-4546-82a4-98098bab83ff"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "It's pretty good!", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "review_chapter",
                keyColumns: new[] { "ChapterIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("ab9d0e26-4c6e-40a8-97e3-1d5d012b4d80"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "It's the worst.", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "I laughed so hard I cried!", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "I hated the ending.", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("5d34237a-f44c-4f3f-8495-2b36047e034e"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "The artwork is amazing!", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "The story line is hard to follow.", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "review_comic",
                keyColumns: new[] { "ComicIdentifier", "UserIdentifier" },
                keyValues: new object[] { new Guid("8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"), new Guid("c6d20823-3d00-48a0-8074-36587bee2693") },
                columns: new[] { "Comment", "ReviewTime" },
                values: new object[] { "I wanted more action scenes.", new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.InsertData(
                table: "transaction_history",
                columns: new[] { "TransactionIdentifier", "Amount", "Date", "EarnedCoin", "UserIdentifier" },
                values: new object[,]
                {
                    { new Guid("21e655da-32ac-4e5a-9de4-6f5c68a606ba"), 50000.0, new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5681), 50, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("7b622c3b-dc7f-40f9-b683-daa42ede8ec7"), 100000.0, new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5677), 100, new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72") },
                    { new Guid("9a4c2212-6243-4676-95f2-83f2d2dbcee5"), 200000.0, new DateTime(2023, 6, 6, 18, 31, 22, 489, DateTimeKind.Utc).AddTicks(5683), 200, new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5") }
                });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                columns: new[] { "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 1500, "C:\\Users\\USER\\Downloads\\pic1.jpg", new DateOnly(2023, 6, 6), "janesmith@example.com", "Jane Smith", 1, "12345678", "5550123456", "Jane Smith" });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                columns: new[] { "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 1000, "C:\\Users\\USER\\Downloads\\pic1.jpg", new DateOnly(2023, 6, 6), "johndoe@example.com", "John Doe", 2, "12345678", "1234567890", "John Doe" });

            migrationBuilder.UpdateData(
                table: "user_access",
                keyColumn: "UserIdentifier",
                keyValue: new Guid("c6d20823-3d00-48a0-8074-36587bee2693"),
                columns: new[] { "AccountBalance", "Avatar", "BirthDay", "Email", "FullName", "Gender", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 2000, "C:\\Users\\USER\\Downloads\\pic1.jpg", new DateOnly(2023, 6, 6), "alicethompson@example.com", "Alice Thompson", 2, "12345678", "7778889999", "Alice Thompson" });
        }
    }
}
