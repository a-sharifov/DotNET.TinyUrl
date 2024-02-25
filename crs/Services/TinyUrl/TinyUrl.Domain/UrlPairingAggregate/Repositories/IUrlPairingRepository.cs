namespace TinyUrl.Domain.UrlPairingAggregate.Repositories;

public interface IUrlPairingRepository
{
    public void AddUrlPairing(UrlPairing urlPairing);
    public Url? GetShortUrlFromFullUrl(Url shorlUrl);
}
