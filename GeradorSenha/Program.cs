using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Gerador de Senhas!");
        Console.Write("Comprimento da Senha: ");
        int length = int.Parse(Console.ReadLine());

        string password = GeneratePassword(length);

        Console.WriteLine("Senha Gerada: " + password);

        Console.ReadLine();
    }

    static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }

        return new string(password);
    }
}