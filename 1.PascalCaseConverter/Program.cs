using System.Text;
namespace Program;
public static class Program
{
    public static void Main()
    {
        Console.Write("Enter words separated by space to convert:");
        var input = Console.ReadLine();

        var variableName = ConvertToPascalCase(input);

        Console.WriteLine(variableName);

    }
    static string ConvertToPascalCase(string input)
    {
        var loweredInput = input.ToLower();
        var output = new StringBuilder(loweredInput.Length);

        for (var i = 0; i < loweredInput.Length; i++)
        {
            if (loweredInput[i] == ' ')
            {
                continue;
            }
            else if (i == 0 || loweredInput[i - 1] == ' ')
            {
                output.Append(Char.ToUpper(loweredInput[i]));
            }
            else
            {
                output.Append(loweredInput[i]);
            }
        }
        return output.ToString();
    }
}
