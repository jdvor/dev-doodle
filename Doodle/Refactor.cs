namespace Doodle;

/// <summary>
/// Refactor this class to use new client (NewDoodleClient) instead of the old one.
/// You may change whatever you wish in this class even Calculate method signature.
/// </summary>
public sealed class DoodleCalculator
{
    private readonly OldDoodleClient client = new();

    public int Calculate(int from, int to)
    {
        var sum = 0;
        for (var i = from; i <= to; i++)
        {
            sum += client.Fetch(i);
        }

        return sum;
    }
}

/// <summary>
/// do not touch
/// </summary>
public class OldDoodleClient
{
    public int Fetch(int i)
    {
        Thread.Sleep(70);
        return i * 2;
    }
}


/// <summary>
/// do not touch
/// </summary>
public sealed class NewDoodleClient : IDoodleClient
{
    public async Task<int> FetchAsync(int i, CancellationToken cancellationToken = default)
    {
        await Task.Delay(70, cancellationToken);
        return i * 2;
    }
}

/// <summary>
/// do not touch
/// </summary>
public interface IDoodleClient
{
    Task<int> FetchAsync(int i, CancellationToken cancellationToken = default);
}
