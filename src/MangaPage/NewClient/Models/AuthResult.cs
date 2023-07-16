using System.Collections.Generic;

namespace NewClient.Models;

public class AuthResult
{
    public string Token { get; set; }

    public bool Result { get; set; }

    public IList<string> Errors { get; set; }
}
