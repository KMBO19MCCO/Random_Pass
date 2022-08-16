using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CreateRandomPassword());
        Console.WriteLine(CreateRandomPassword(10));
        Console.WriteLine(CreateRandomPassword(30));

        Console.WriteLine(CreateRandomPasswordWithRandomLength());

        Console.ReadKey();
    }


    // Стандартный размер пароля = 15  
    private static string CreateRandomPassword(int length = 15)
    {
        // Создаём строку допустимых символов
        string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
        Random random = new Random();


        char[] chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            chars[i] = validChars[random.Next(0, validChars.Length)];
        }
        return new string(chars);
    }

    private static string CreateRandomPasswordWithRandomLength()
    {

        string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
        Random random = new Random();

        // минимальный размер 8. Максимальный - количество допустимых символов
        int size = random.Next(8, validChars.Length);


        char[] chars = new char[size];
        for (int i = 0; i < size; i++)
        {
            chars[i] = validChars[random.Next(0, validChars.Length)];
        }
        return new string(chars);
    }
}