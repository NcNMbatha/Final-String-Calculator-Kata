namespace StringKataSix.Interfaces
{
    public interface IDelimeter
    {
        List<string> GetDelimeterList(string numbersWithDelimeters);

        List<string> ExtractDelimetersInBrackets(string numbersWithDelimeters);
    }
}
