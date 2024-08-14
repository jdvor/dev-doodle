namespace Doodle.Tests;

public class SequenceSearchTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Find(int caseNo, int[] nums, int expected)
    {
        var actual = SequenceSearch.Find(nums);
        Assert.True(expected == actual, $"caseNo: {caseNo}");
    }

    public static TheoryData<int, int[], int> Data()
    {
        var data = new TheoryData<int, int[], int>();
        foreach (var (caseNo, nums, result) in SequenceSearch.Data)
        {
            data.Add(caseNo, nums, result);
        }

        return data;
    }
}
