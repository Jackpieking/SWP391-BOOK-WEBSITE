using MangaManagementAPI.Data.Entites;
using MangaManagementAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MangaManagementAPI.Data.ModelDataSeedings;

public class UserInfoDataSeeding : IEntityTypeConfiguration<UserInfo>
{
    /// <summary>
    /// Set some seeding data for UserInfo Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<UserInfo> builder)
    {
        /**
		 * Data for UserInfo table
		 */
        #region UserInfoSeedingData
        ICollection<UserInfo> users = new List<UserInfo>()
        {
            new()
            {
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                UserName = "Jackpieking",
                Password = "Jackpie2003",
                FullName = "Lê Đình Đăng Khoa",
                Gender = DefinedGender.MALE,
                BirthDay = new(year: 2003, month: 12, day: 3),
                PhoneNumber = "0706042250",
                Email = "ledinhdangkhoa10a9@gmail.com",
                AccountBalance = 30,
                Avatar = "User_Empty.png"
            },
            new()
            {
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                UserName = "wibulord",
                Password = "NghiaLe123",
                FullName = "Lee Trung Nghĩa",
                Gender = DefinedGender.MALE,
                BirthDay = new(year: 2003, month: 4, day: 2),
                PhoneNumber = "0903591555",
                Email = "nghialt123@gmail.com",
                AccountBalance = 100,
                Avatar = "User_Empty.png"
            },
            new()
            {

                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                UserName = "lamvd",
                Password = "Lam123",
                FullName = "Võ Đại Lâm",
                Gender = DefinedGender.MALE,
                BirthDay = new(year: 2003, month: 8, day: 15),
                PhoneNumber = "02343883333",
                Email = "lamvd@gmail.com",
                AccountBalance = 0,
                Avatar = "User_Empty.png"
            }
        };
        #endregion

        builder.HasData(data: users);
    }
}
