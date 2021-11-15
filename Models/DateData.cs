namespace CVBuilder.Models;
public static class DateData
{
    public static Span<int> Years() => Enumerable.Range(1900, 2023 - 1900).Reverse().ToArray();
    public static Span<Months> Month() => (Span<Months>)Enum.GetValues(typeof(Months))!;
}