﻿using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class ComicDataSeeding : IEntityTypeConfiguration<Comic>
{
    /// <summary>
    /// Set some seeding data for Comic Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Comic> builder)
    {
        /**
		 * Data for Comic table
		 */
        #region ComicSeedingData
        ICollection<Comic> comics = new List<Comic>()
        {
            new()
            {
                ComicIdentifier = new(g: "4dfe12e0-cb8a-4282-8e74-3b1e8053f787"),
                Name = "Thanh Gươm Diệt Quỷ",
                Description = "Kimetsu no Yaiba – Tanjirou là con cả của gia đình vừa mất cha. Một ngày nọ, Tanjirou đến thăm thị trấn khác để bán than, khi đêm về cậu ở nghỉ tại nhà người khác thay vì về nhà vì lời đồn thổi về ác quỷ luôn rình mò gần núi vào buổi tối. Khi cậu về nhà vào ngày hôm sau, bị kịch đang đợi chờ cậu…",
                PublishDate = new(year: 2016, month: 11, day: 2),
                LatestChapter = 205.6,
                Avatar = "Thanh_Gươm_Diệt_Quỷ.jpg"
            },
            new()
            {
                ComicIdentifier = new(g: "aadadaf7-fc21-4559-a53c-f97eb1ba583f"),
                Name = "Hội Pháp Sư Nhiệm Vụ Trăm Năm",
                Description = "Tuyện tiếp nối chap 545 của Fairy Tail, khi nhóm Natsu đi làm nhiệm vụ trăm năm.",
                PublishDate = new(year: 2018, month: 7, day: 25),
                LatestChapter = 132,
                Avatar = "Hội_Pháp_Sư_Nhiệm_Vụ_Trăm_Năm.jpg"
            },
            new()
            {
                ComicIdentifier = new(g: "8aa5080b-0212-4b9c-9b70-0afc2bc4b99f"),
                Name = "Onepunch Man",
                Description = "Onepunch-Man là một Manga thể loại siêu anh hùng với đặc trưng phồng tôm đấm phát chết luôn… Lol!!! Nhân vật chính trong Onepunch-man là Saitama, một con người mà nhìn đâu cũng thấy “tầm thường”, từ khuôn mặt vô hồn, cái đầu trọc lóc, cho tới thể hình long tong. Tuy nhiên, con người nhìn thì tầm thường này lại chuyên giải quyết những vấn đề hết sức bất thường. Anh thực chất chính là một siêu anh hùng luôn tìm kiếm cho mình một đối thủ mạnh. Vấn đề là, cứ mỗi lần bắt gặp một đối thủ tiềm năng, thì đối thủ nào cũng như đối thủ nào, chỉ ăn một đấm của anh là… chết luôn. Liệu rằng Onepunch-Man Saitaman có thể tìm được cho mình một kẻ ác dữ dằn đủ sức đấu với anh? Hãy theo bước Saitama trên con đường một đấm tìm đối cực kỳ hài hước của anh!!\r\n\r\n",
                PublishDate = new(year: 2018, month: 3, day: 26),
                LatestChapter = 232,
                Avatar = "Onepunch_Man.jpg"
            },
            new()
            {
                ComicIdentifier = new(g: "5d34237a-f44c-4f3f-8495-2b36047e034e"),
                Name = "Black Clover - Thế Giới Phép Thuật",
                Description = "Aster và Yuno là hai đứa trẻ bị bỏ rơi ở nhà thờ và cùng nhau lớn lên tại đó. Khi còn nhỏ, chúng đã hứa với nhau xem ai sẽ trở thành Ma pháp vương tiếp theo. Thế nhưng, khi cả hai lớn lên, mọi sô chuyện đã thay đổi. Yuno là thiên tài ma pháp với sức mạnh tuyệt đỉnh trong khi Aster lại không thể sử dụng ma pháp và cố gắng bù đắp bằng thể lực. Khi cả hai được nhận sách phép vào tuổi 15, Yuno đã được ban cuốn sách phép cỏ bốn bá (trong khi đa số là cỏ ba lá) mà Aster lại không có cuốn nào. Tuy nhiên, khi Yuno bị đe dọa, sự thật về sức mạnh của Aster đã được giải mã- cậu ta được ban cuốn sách phép cỏ năm lá, cuốn sách phá ma thuật màu đen. Bấy giờ, hai người bạn trẻ đang hướng ra thế giới, cùng chung mục tiêu.",
                PublishDate = new(year: 2015, month: 4, day: 18),
                LatestChapter = 360,
                Avatar = "Black_Clover_Thế_Giới_Phép_Thuật.jpg"
            },
            new()
            {
                ComicIdentifier = new(g: "b8d6abf3-b7e0-4a20-8647-f8f4f1ac04d3"),
                Name = "Thần Y Đích Nữ",
                Description = "Một nữ quân y đặc cấp trong bộ đội lục chiến, thánh thủ trung tây y, tinh thông võ thuật, tiễn thuật vì một tai nạn trên không mà xuyên không về lịch sử. Mang trên mình mối thù, nàng sẽ làm gì đây?",
                PublishDate = new(year: 2016, month: 5, day: 26),
                LatestChapter = 302,
                Avatar = "Thần_Y_Đích_Nữ.jpg"
            }
        };
        #endregion

        builder.HasData(data: comics);
    }
}
