using Models;
using Services.Contracts;
using System.Collections.Generic;

namespace Services.Implementations;

public class ComicService : IComicService
{
    private IEnumerable<ComicModel> _comics;

    public IEnumerable<ComicModel> Comics
    {
        get { return _comics; }
        set { _comics = value; }
    }
}
