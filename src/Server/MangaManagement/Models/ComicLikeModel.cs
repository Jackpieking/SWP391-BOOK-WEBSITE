using Model;
using System;

namespace Entity;

public class ComicLikeModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public UserModel UserModel { get; set; }

    public ComicModel ComicModel { get; set; }
}
