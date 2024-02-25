namespace TinyUrl.Domain.UrlPairingAggregate.Regexes;

internal partial class UrlRegexes
{
    private const string UrlPattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";

    [GeneratedRegex(UrlPattern)]
    public static partial Regex UrlRegex();
}
