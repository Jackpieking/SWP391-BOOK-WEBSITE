using DataAccessLayer.Repositories.Contracts;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Contracts;

public interface IUnitOfWork
{
	ICategoryRepository CategoryRepository { get; }
	IChapterImageRepository ChapterImageRepository { get; }
	IChapterRepository ChapterRepository { get; }
	IComicCategoryRepository ComicCategoryRepository { get; }
	IComicRepository ComicRepository { get; }
	IComicSavingRepository ComicSavingRepository { get; }
	IReadingHistoryRepository ReadingHistoryRepository { get; }
	IReviewChapterRepository ReviewChapterRepository { get; }
	IReviewComicRepository ReviewComicRepository { get; }
	ITransactionRepository TransactionRepository { get; }
	IUserRepository UserInfoRepository { get; }
	IPublisherRepository PublisherRepository { get; }
	IBuyingHistoryRepository BuyingHistoryRepository { get; }
	Task SaveAsync();
}
