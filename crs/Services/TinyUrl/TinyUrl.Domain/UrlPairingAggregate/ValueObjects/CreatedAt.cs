namespace TinyUrl.Domain.UrlPairingAggregate.ValueObjects;

public sealed class CreatedAt
{
    public DateTime Value { get; private set; }

    private CreatedAt(DateTime value) => Value = value;

    public static CreatedAt Create(DateTime value)
    {
        if (value > DateTime.UtcNow)
        {
            // TODO: Add Exception
        }

        var createdAt = new CreatedAt(value);
        return createdAt;
    }
}
