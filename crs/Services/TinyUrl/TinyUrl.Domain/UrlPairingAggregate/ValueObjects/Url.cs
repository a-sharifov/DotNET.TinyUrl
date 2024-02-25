namespace TinyUrl.Domain.UrlPairingAggregate.ValueObjects;

public sealed class Url
{
    public string Value { get; private set; }
    private const string UrlPattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";

    private Url(string value) => Value = value;

    public static Url Create(string value)
    {
        if (!IsUrl(value))
        {
            //TODO Add exception
        }

        var url = new Url(value);
        return url;
    }

    public static bool IsUrl(string value) => 
        UrlRegexes.UrlRegex().IsMatch(value);
}