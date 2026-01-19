using System;

class ProgramConfig

{
    
    public const string Version = "v1.5.0";
    public const string DeveloperName = "Иван 2-ой курс";

    
    public static void ShowConfig()

    {

        Console.WriteLine("Информация о программе");
        Console.WriteLine($"Версия: {Version}");
        Console.WriteLine($"Разработчик: {DeveloperName}");

    }

}


class TestConfig

{

    static void Main()

    {

        ProgramConfig.ShowConfig();

        
        Console.WriteLine($"Текущая версия: {ProgramConfig.Version}");

        Console.ReadLine();

    }

}
