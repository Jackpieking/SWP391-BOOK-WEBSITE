using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccessLayer.Data.ModelDataSeedings;

public class ChapterImageEntityDataSeeding : IEntityTypeConfiguration<ChapterImageEntity>
{
    /// <summary>
    /// Set some seeding data for Chapter Image Table
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ChapterImageEntity> builder)
    {
        /**
		 * Data for ChapterImage table
		 */
        #region ChapterImageSeedingData
        ICollection<ChapterImageEntity> chapterImages = new List<ChapterImageEntity>()
        {
			#region dc31637b-416c-458d-9942-74fa1470ca20
            new()
            {
                ImageIdentifier = new(g: "ad981387-1e98-4036-8934-868c5e0880a9"),
                ImageNumber = 0,
                ImageURL = "0.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "9a4c2922-3a3b-4cc1-ba2e-d62317c8c0e0"),
                ImageNumber = 1,
                ImageURL = "1.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "48a81e89-dbad-4fb5-b992-66b0a575d781"),
                ImageNumber = 2,
                ImageURL = "2.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "31ae274b-4dfc-4deb-af28-46de52cb6feb"),
                ImageNumber = 3,
                ImageURL = "3.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "cb4b4f62-523f-4044-9d58-1ae3f12d430c"),
                ImageNumber = 4,
                ImageURL = "4.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "3aaaa9a7-4465-494a-a7bd-08157d913586"),
                ImageNumber = 5,
                ImageURL = "5.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "7fb2316f-4341-401d-b28a-40146f8a7a0b"),
                ImageNumber = 6,
                ImageURL = "6.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "d9c7b2a1-67e0-4daa-8ad0-b8560938e847"),
                ImageNumber = 7,
                ImageURL = "7.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "25a2ab91-5674-44aa-bbac-2ea3bceb71d4"),
                ImageNumber = 8,
                ImageURL = "8.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "785fb0ef-b383-4f44-98b5-bd6a555f0626"),
                ImageNumber = 9,
                ImageURL = "9.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "c2fa7cbe-138b-42e5-ad7b-c0afd43f43fd"),
                ImageNumber = 10,
                ImageURL = "10.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "cb117933-9ccc-4ad6-afcf-65da344ba69a"),
                ImageNumber = 11,
                ImageURL = "11.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "d119637e-bf32-4b23-81ff-a09c1d910b81"),
                ImageNumber = 12,
                ImageURL = "12.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "e992e5d9-67a8-4164-9273-ae229e648556"),
                ImageNumber = 13,
                ImageURL = "13.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "bf280315-0e15-4074-978e-c0014a946383"),
                ImageNumber = 14,
                ImageURL = "14.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "97ce8e61-ac01-4e85-9a12-67d94f5b7102"),
                ImageNumber = 15,
                ImageURL = "15.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "1d73b99e-f451-4b55-9b20-ea4d572bc3a0"),
                ImageNumber = 16,
                ImageURL = "16.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "4aca6f3a-2ccf-49de-af02-0b1776e793ee"),
                ImageNumber = 17,
                ImageURL = "17.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "f78ffa61-a567-479a-aa79-011dfa2fdc4e"),
                ImageNumber = 18,
                ImageURL = "18.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "a79456c1-8024-4128-9a31-db46f7eeef08"),
                ImageNumber = 19,
                ImageURL = "19.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "2cd639ce-c96f-4589-8014-0e6e7f9ff69f"),
                ImageNumber = 20,
                ImageURL = "20.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "1c9b47b7-27a5-46c4-a8d0-e7163f1c3e7f"),
                ImageNumber = 21,
                ImageURL = "21.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "2abfb23c-34fa-4a48-b442-a1b28201ff32"),
                ImageNumber = 22,
                ImageURL = "22.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "45c4dfd6-910c-49a4-bb1c-f499377c8c61"),
                ImageNumber = 23,
                ImageURL = "23.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "64e10a07-b7f7-4335-9ef9-a3c7a5b67d7c"),
                ImageNumber = 24,
                ImageURL = "24.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "0e66730c-50f5-4f72-b8cd-2f720ddf6d7e"),
                ImageNumber = 25,
                ImageURL = "25.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "71147712-b450-4e4b-8df1-ed5d50160bf9"),
                ImageNumber = 26,
                ImageURL = "26.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "853addd5-5496-490f-86bd-cc12ba04e2bd"),
                ImageNumber = 27,
                ImageURL = "27.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "97c8d20b-0f88-47a6-91cb-e76d0b357ad3"),
                ImageNumber = 28,
                ImageURL = "28.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "19954bda-0156-48f9-aee6-c8c258dafa58"),
                ImageNumber = 29,
                ImageURL = "29.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "ae3756ad-6b22-4645-90c6-a01b60b04d59"),
                ImageNumber = 30,
                ImageURL = "30.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "bc5a3dbb-6b9e-4c4c-a013-f66ad22077dc"),
                ImageNumber = 31,
                ImageURL = "31.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "eec8c785-84cf-4b8e-bcf2-128a4d9876da"),
                ImageNumber = 32,
                ImageURL = "32.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "87e12554-c4a1-4bb7-906f-71c16042aaf3"),
                ImageNumber = 33,
                ImageURL = "33.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "b8f10d3d-74fb-448e-87a6-c2a46514e0e8"),
                ImageNumber = 34,
                ImageURL = "34.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "f1a77aa3-ffc5-4e9f-adcd-757545657941"),
                ImageNumber = 35,
                ImageURL = "35.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "6788fa1f-f257-4582-842e-ad505f1c8e92"),
                ImageNumber = 36,
                ImageURL = "36.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "f85d2bd9-6d9c-4a92-85b1-11c3ad17c133"),
                ImageNumber = 37,
                ImageURL = "37.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "a11be2b5-3c5c-4adc-8642-d2dfda33813d"),
                ImageNumber = 38,
                ImageURL = "38.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "4e86fa98-7b46-44e7-92bc-dcc997c3574a"),
                ImageNumber = 39,
                ImageURL = "39.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "22a1a283-80c0-4dc2-a9da-0a71a13b5dc0"),
                ImageNumber = 40,
                ImageURL = "40.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "3d6be27d-6bcc-4e23-9fde-f785d000a72e"),
                ImageNumber = 41,
                ImageURL = "41.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "5b2c0a01-6bc0-4b9c-b66f-72c45c8bdcb7"),
                ImageNumber = 42,
                ImageURL = "42.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "0c17d220-7f8e-4b58-b15d-a3f9d37a70dd"),
                ImageNumber = 43,
                ImageURL = "43.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "47059dc1-e213-4dc9-a1f3-1e263f7f29f2"),
                ImageNumber = 44,
                ImageURL = "44.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "34c310fd-4fdc-4048-9b11-7b0a29d3b440"),
                ImageNumber = 45,
                ImageURL = "45.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "6819a0d1-31a5-4e13-aaab-57fa19edc770"),
                ImageNumber = 46,
                ImageURL = "46.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "9f58f9f7-40c0-46bc-8052-7cb0ffca9a2c"),
                ImageNumber = 47,
                ImageURL = "47.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "7bd54d5b-d802-4d60-91a8-82a9079b1876"),
                ImageNumber = 48,
                ImageURL = "48.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "72b0ea4d-8f47-4e40-8fbb-9a5d5e1c87d3"),
                ImageNumber = 49,
                ImageURL = "49.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            },
            new()
            {
                ImageIdentifier = new(g: "d3c2b7fa-2f9f-4883-862d-a9556d24a35d"),
                ImageNumber = 50,
                ImageURL = "50.jpg",
                ChapterIdentifier = new(g: "dc31637b-416c-458d-9942-74fa1470ca20")
            }
		    #endregion
        };
        #endregion

        builder.HasData(data: chapterImages);
    }
}
