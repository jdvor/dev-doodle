namespace Doodle;

public static class StringToInt32
{
    /// <summary>
    /// 1) Ignore any leading whitespace.
    ///
    /// 2) Determine the sign by checking if the next character is '-' or '+'.
    /// Assume positivity if neither is present.
    ///
    /// 3) Read the integer by skipping leading zeros until a non-digit character is encountered
    /// or the end of the string is reached. If no digits were read, then the result is 0.
    ///
    /// 4) If the integer is out of the 32-bit signed integer range [-2^31, 2^31 - 1], then round the integer
    /// to remain in the range. Specifically, integers less than -2^31 should be rounded to -2^31,
    /// and integers greater than 2^31 - 1 should be rounded to 2^31 - 1.
    /// </summary>
    public static int Convert(string s)
    {
        throw new NotImplementedException();
    }

    public static readonly (string s, int result)[] Data =
    [
        ("42", 42),
        ("-42", -42),
        ("4193 with words", 4193),
        ("  43", 43),
        (" -43", -43),
        ("0032", 32),
        ("00320", 320),
        ("-00320", -320),
        ("     +004500", 4500),
        ("no numbers", 0),
        (" b1234", 0),
        (" 00533 ", 533),
        (" -00533 ", -533),
        ("2147483647", int.MaxValue),
        ("-2147483648", int.MinValue),
        ("100000000000000", int.MaxValue),
        ("-100000000000000", int.MinValue),
        ("   +0 123", 0),
    ];
}
