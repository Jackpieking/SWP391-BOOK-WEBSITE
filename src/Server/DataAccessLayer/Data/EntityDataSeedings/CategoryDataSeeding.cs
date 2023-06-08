using MangaManagementAPI.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.EntityDataSeedings;

public class CategoryDataSeeding : IEntityTypeConfiguration<Category>
{
    /// <summary>
    /// Set some seeding data for Category Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        /**
		 * Data for Category table
		 */
        #region CategorySeedingData
        ICollection<Category> categories = new List<Category>()
        {
            new()
            {
                CategoryIdentifier = new(g: "414e65b4-1949-48ce-a764-26fb66e95550"),
                Name = "Mystery",
                Description = "Thể loại theo sau một tội ác (như giết người hoặc mất tích) từ thời điểm nó được thực hiện cho đến thời điểm nó được giải quyết"
            },
            new()
            {
                CategoryIdentifier = new(g: "1b9d5460-4c32-4703-b4bd-c52e5fb6e943"),
                Name = "Romance",
                Description = "Thường đề cập đến một loại tiểu thuyết thuộc thể loại viễn tưởng tập trung chủ yếu vào mối quan hệ và tình yêu lãng mạn giữa hai người, và thường có một kết thúc lạc quan và thỏa mãn về mặt cảm xúc"
            },
            new()
            {
                CategoryIdentifier = new(g: "ad2149ef-ac21-4759-88d8-e586e850e299"),
                Name = "Historical",
                Description = "Lấy bối cảnh là một giai đoạn lịch sử và cố gắng truyền đạt tinh thần, cách cư xử và điều kiện xã hội của một thời đại đã qua với các chi tiết hiện thực và sự trung thực (trong một số trường hợp chỉ là sự trung thực bề ngoài) với sự thật lịch sử"
            },
            new()
            {
                CategoryIdentifier = new(g: "edc6e266-7b95-4723-a420-8e51a78d99bc"),
                Name = "Drama",
                Description = "Phương thức cụ thể của tiểu thuyết được thể hiện trong biểu diễn: một vở kịch, opera, kịch câm, múa ba lê, v.v., được trình diễn trong rạp hát, hoặc trên đài phát thanh hoặc truyền hình"
            },
            new()
            {
                CategoryIdentifier = new(g: "72522ef6-6633-4519-872b-36bc0675e328"),
                Name = "Fantasy",
                Description = "Một thể loại của tiểu thuyết suy đoán liên quan đến các yếu tố ma thuật, thường lấy bối cảnh trong một vũ trụ hư cấu và đôi khi lấy cảm hứng từ thần thoại và văn hóa dân gian"
            },
            new()
            {
                CategoryIdentifier = new(g: "ddebafec-b0a5-49c6-ac6c-261079080dce"),
                Name = "Adventure",
                Description = "Thể loại bao gồm những cuốn sách mà nhân vật chính thực hiện một cuộc hành trình sử thi, về mặt cá nhân hoặc địa lý"
            },
            new()
            {
                CategoryIdentifier = new(g: "322dbf35-54aa-416e-b121-42fc20b9d94b"),
                Name = "Shounen",
                Description = "Một thể loại biên tập truyện tranh Nhật Bản nhắm đến đối tượng là các cậu bé vị thành niên"
            },
        };
        #endregion

        builder.HasData(data: categories);
    }
}
