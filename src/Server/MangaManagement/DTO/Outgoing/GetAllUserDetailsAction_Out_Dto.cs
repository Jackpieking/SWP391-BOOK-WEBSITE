using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helper.DefinedEnums;

namespace DTO.Outgoing
{
    public class GetAllUserDetailsAction_Out_Dto
    {
        public Guid UserIdentifier { get; set; }

        public string Username { get; set; }

        public string UserFullName { get; set; }

        public DefinedGender UserGender { get; set; }

        public DateOnly UserBirthday { get; set; }

        public string UserPhoneNumber { get; set; }

        public string UserEmail { get; set; }

        public int UserAccountBalance { get; set; }

        public string UserAvatar { get; set; }

        public ICollection<TransactionsHistoryDto> TransactionHistoryOutDto { get; set; } = new List<TransactionsHistoryDto>();

        public ICollection<ComicSavingDto> ComicSavingOutDto { get; set; } = new List<ComicSavingDto>();

        public ICollection<ReadingHistoryDto> ReadingHistoriesOutDto { get; set; } = new List<ReadingHistoryDto>();

        public ICollection<ReviewComicDtoForUser> ReviewComicOutDto { get; set; } = new List<ReviewComicDtoForUser>();

        public ICollection<ReviewChapterDtoForUser> ReviewChapterOutDto { get; set; } = new List<ReviewChapterDtoForUser>();

        public ICollection<BuyingHistoryDto> BuyingHistorieOutDto { get; set; } = new List<BuyingHistoryDto>();

        public ICollection<ComicLikeDto> ComicLikeOutDto { get; set; } = new List<ComicLikeDto>();

        // ----------------------------------

        public class ComicLikeDto
        {
            public string ComicAvatar { get; set; }
            public string ComicName { get; set; }
        }

        public class BuyingHistoryDto
        {
            public DateTime BuyingDate { get; set; }
            public string ComicName { get; set; }
            public string ChapterNumber { get; set; }
            public int ChapterUnlockPrice { get; set; }
        }

        public class ReadingHistoryDto
        {
            public DateTime LastReadingTime { get; set; }
            public string ChapterNumber { get; set; }
            public string ComicName { get; set; }
        }

        public class ComicSavingDto
        {
            public DateTime SavingTime { get; set; }
            public string ComicName { get; set; }
        }

        public class TransactionsHistoryDto
        {
            public double TransactionAmount { get; set; }
            public DateTime TransactionDate { get; set; }
            public int TransactionCoin { get; set; }
        }

        public class ReviewChapterDtoForUser
        {
            public string ComicName { get; set; }
            public string ChapterNumber { get; set; }
            public short ChapterRatingStar { get; set; }
            public string ChapterComment { get; set; }
            public DateTime ReviewTime { get; set; }
        }

        public class ReviewComicDtoForUser
        {
            public short ComicRatingStar { get; set; }
            public string ComicComment { get; set; }
            public DateTime ReviewTime { get; set; }
            public string ComicName { get; set; }

        }
    }
}