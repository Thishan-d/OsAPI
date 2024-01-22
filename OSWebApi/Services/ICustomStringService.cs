namespace OSWebApi.Services
{
    public interface ICustomStringService
    {
        string ConvertConsonantsToUppercase(string inputString);
        string ConvertVowelsToLowercase(string inputString);
        string IgnoreNumbersInWord(string inputString);
        string ReverseString(string inputString);
    }
}