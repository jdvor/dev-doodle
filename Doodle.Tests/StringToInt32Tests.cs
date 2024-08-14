namespace Doodle.Tests;

public class StringToInt32Tests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Convert(string s, int expected)
    {
        var actual = StringToInt32.Convert(s);
        Assert.Equal(expected, actual);
    }

    public static TheoryData<string, int> Data()
    {
        var data = new TheoryData<string, int>();
        foreach (var (s, result) in StringToInt32.Data)
        {
            data.Add(s, result);
        }

        return data;
    }
}
