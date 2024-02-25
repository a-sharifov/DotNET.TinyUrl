namespace TinyUrl.Domain.UrlPairingAggregate;

public sealed class UrlPairing
{
    public Url FullUrl { get; private set; }
    public Url ShortUrl { get; private set; }
    public CreatedAt CreatedAt { get; private set; }

    private UrlPairing(Url fullUrl, Url shortUrl, CreatedAt createdAt) =>
        (FullUrl, ShortUrl, CreatedAt) = (fullUrl, shortUrl, createdAt);

    public static UrlPairing Create(Url fullUrl, Url shortUrl, CreatedAt createdAt)
    {
        var urlPairing = 
            new UrlPairing(fullUrl, shortUrl, createdAt);

        return urlPairing;
    }
}
