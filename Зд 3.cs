using System;


interface IWorkable

{

    void Work();

}


interface IChargeable

{

    void Charge();

}


class Robot : IWorkable, IChargeable

{

    public string Name { get; private set; }
    private int energyLevel;

    
    public int EnergyLevel

    {

        get => energyLevel;
        private set

        {

            
            if (value < 0) energyLevel = 0;
            else if (value > 100) energyLevel = 100;
            else energyLevel = value;

        }

    }

    public Robot(string name, int initialEnergy)

    {

        Name = name;
        EnergyLevel = initialEnergy;

    }

    
    public void Work()

    {

        EnergyLevel -= 20;
        Console.WriteLine($"Робот {Name} поработал. Энергия: {EnergyLevel}%");

    }

    public void Charge()

    {

        EnergyLevel += 70;
        Console.WriteLine($"Робот {Name} заряжается. Энергия: {EnergyLevel}%");

    }
}

class Program

{

    static void Main()

    {

        // Робот с начальной энергией 70%
        Robot myRobot = new Robot("Терминатор 3000", 70);

        Console.WriteLine($"Начало смены для {myRobot.Name}");

        myRobot.Work();    // 70 - 20 = 50
        myRobot.Work();  // 50 - 20  = 30
        myRobot.Charge();  // 30 + 70 = 100 (не выше максимума)
        myRobot.Work();    // 100 - 20 = 80

        Console.WriteLine("Конец смены");

        Console.ReadLine();

    }

}
