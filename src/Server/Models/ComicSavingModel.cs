using System;

namespace Model;

public class ComicSavingModel
{
    public Guid UserIdentifier { get; set; }

    public Guid ComicIdentifier { get; set; }

    public DateTime SavingTime { get; set; }

    public UserModel UserModel { get; set; }

    public ComicModel ComicModel { get; set; }
}