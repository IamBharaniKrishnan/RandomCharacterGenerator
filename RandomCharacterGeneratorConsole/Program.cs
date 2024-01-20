using RandomCharacterGeneratorLibrary;

public class Program
{
    static void Main(string[] args)
    {
        string password = "";

        foreach (var item in new Random().GenerateRandomCharacters(16))
        {
            password += item;
        }

        Console.WriteLine(password);
        Console.ReadLine();
    }
}