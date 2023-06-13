using Entity;
using Helper.DefinedEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class UserEntityDataSeeding : IEntityTypeConfiguration<UserEntity>
{
    /// <summary>
    /// Set some seeding data for UserInfo Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        /**
		 * Data for UserInfo table
		 */
        #region UserInfoSeedingData
        ICollection<UserEntity> users = new List<UserEntity>()
        {
            new()
            {
                UserIdentifier = new(g: "2231dfa9-c0f7-49c9-b0af-dac2cac61c72"),
                Username = "Jackpieking",
                Password = "Jackpie2003",
                UserFullName = "Lê Đình Đăng Khoa",
                UserGender = DefinedGender.MALE,
                UserBirthday = new(year: 2003, month: 12, day: 3),
                UserPhoneNumber = "0706042250",
                UserEmail = "ledinhdangkhoa10a9@gmail.com",
                UserAccountBalance = 30,
                UserAvatar = "User_Empty.png"
            },
            new()
            {
                UserIdentifier = new(g: "1ef67686-f4ad-48f2-b56c-c828ec53a8d5"),
                Username = "wibulord",
                Password = "NghiaLe123",
                UserFullName = "Lee Trung Nghĩa",
                UserGender = DefinedGender.MALE,
                UserBirthday = new(year: 2003, month: 4, day: 2),
                UserPhoneNumber = "0903591555",
                UserEmail = "nghialt123@gmail.com",
                UserAccountBalance = 100,
                UserAvatar = "User_Empty.png"
            },
            new()
            {

                UserIdentifier = new(g: "c6d20823-3d00-48a0-8074-36587bee2693"),
                Username = "lamvd",
                Password = "Lam123",
                UserFullName = "Võ Đại Lâm",
                UserGender = DefinedGender.MALE,
                UserBirthday = new(year: 2003, month: 8, day: 15),
                UserPhoneNumber = "02343883333",
                UserEmail = "lamvd@gmail.com",
                UserAccountBalance = 0,
                UserAvatar = "User_Empty.png"
            }
        };
        #endregion

        builder.HasData(data: users);
    }
}
