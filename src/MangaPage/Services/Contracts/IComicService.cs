using Models;
using System.Collections.Generic;

namespace Services.Contracts;

public interface IComicService
{
    IEnumerable<ComicModel> Comics { get; set; }
}
