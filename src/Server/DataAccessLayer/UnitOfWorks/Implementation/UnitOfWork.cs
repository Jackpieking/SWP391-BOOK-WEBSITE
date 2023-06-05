using DataAccessLayer.Repositories.Contracts;
using DataAccessLayer.Repositories.Implementation;
using DataAccessLayer.UnitOfWorks.Contracts;
using MangaManagementAPI.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks.Implementation;

public class UnitOfWork : IUnitOfWork
{
	private readonly MangaContext _context;
	private ICategoryRepository _categoryRepository;
	private IChapterImageRepository _chapterImageRepository;
	private IChapterRepository _chapterRepository;
	private IComicCategoryRepository _comicCategoryRepository;
	private IComicRepository _comicRepository;
	private IComicSavingRepository _comicSavingRepository;
	private IReadingHistoryRepository _readingHistoryRepository;
	private IReviewChapterRepository _reviewChapterRepository;
	private IReviewComicRepository _reviewComicRepository;
	private ITransactionRepository _transactionRepository;
	private IUserInfoRepository _userInfoRepository;

	public UnitOfWork(MangaContext context) => _context = context;

	#region RepositoryArea
	public ICategoryRepository CategoryRepository
	{
		get
		{
			_categoryRepository ??= new CategoryRepository(dbSet: _context.Categories);

			return _categoryRepository;
		}
	}

	public IChapterImageRepository ChapterImageRepository
	{
		get
		{
			_chapterImageRepository ??= new ChapterImageRepository(dbSet: _context.ChapterImages);

			return _chapterImageRepository;
		}
	}

	public IChapterRepository ChapterRepository
	{
		get
		{
			_chapterRepository ??= new ChapterRepository(dbSet: _context.Chapters);

			return _chapterRepository;
		}
	}

	public IComicCategoryRepository ComicCategoryRepository
	{
		get
		{
			_comicCategoryRepository ??= new ComicCategoryRepository(dbSet: _context.ComicCategories);

			return _comicCategoryRepository;
		}
	}

	public IComicRepository ComicRepository
	{
		get
		{
			_comicRepository ??= new ComicRepository(dbSet: _context.Comics);

			return _comicRepository;
		}
	}

	public IComicSavingRepository ComicSavingRepository
	{
		get
		{
			_comicSavingRepository ??= new ComicSavingRepository(dbSet: _context.ComicSavings);

			return _comicSavingRepository;
		}
	}

	public IReadingHistoryRepository ReadingHistoryRepository
	{
		get
		{
			_readingHistoryRepository ??= new ReadingHistoryRepository(dbSet: _context.ReadingHistories);

			return _readingHistoryRepository;
		}
	}

	public IReviewChapterRepository ReviewChapterRepository
	{
		get
		{
			_reviewChapterRepository ??= new ReviewChapterRepository(dbSet: _context.ReviewChapters);

			return _reviewChapterRepository;
		}
	}

	public IReviewComicRepository ReviewComicRepository
	{
		get
		{
			_reviewComicRepository ??= new ReviewComicRepository(dbSet: _context.ReviewComics);

			return _reviewComicRepository;
		}
	}

	public ITransactionRepository TransactionRepository
	{
		get
		{
			_transactionRepository ??= new TransactionHistoryRepository(dbSet: _context.TransactionsHistories);

			return _transactionRepository;
		}
	}

	public IUserInfoRepository UserInfoRepository
	{
		get
		{
			_userInfoRepository ??= new UserInfoRepository(dbSet: _context.UserInfos);

			return _userInfoRepository;
		}
	}
	#endregion

	public async Task SaveAsync(CancellationToken cancellationToken)
		=> await _context.SaveChangesAsync(cancellationToken: cancellationToken);
}
