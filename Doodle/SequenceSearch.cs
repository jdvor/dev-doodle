namespace Doodle;

public static class SequenceSearch
{
    /// <summary>
    /// Given an unsorted array of integers nums;
    /// what is the longest consecutive sequence that you can create from input numbers (nums).
    /// </summary>
    public static int Find(int[] nums)
    {
        throw new NotImplementedException();
    }

    public static readonly (int caseNo, int[] nums, int result)[] Data =
    [
        (1, [], 0),
        (2, [0], 1),
        (3, [100, 4, 200, 1, 3, 2], 4),
        (4, [0, 3, 7, 2, 5, 8, 4, 6, 0, 1], 9),
        (5, [9, 1, 4, 7, 3, -1, 0, 5 ,8, -1, 6], 7),
        (6, [1, 2, 0, 1], 3)
    ];
}
