using System;
using System.Collections.Generic;


public class LoginAlreadyExistsException : Exception

{

    public LoginAlreadyExistsException(string message) : base(message) { }

}


public class WeakPasswordException : Exception

{

    public WeakPasswordException(string message) : base(message) { }

}


public class UserService

{
    
    private List<string> existingUsers = new List<string> { "user1", "admin_pro" };

    public void Register(string login, string password)

    {

        Console.WriteLine($"Регистрация: {login}, {password}");

        
        if (password.Length < 6)

        {

            throw new WeakPasswordException("Ошибка: Слабый пароль! Минимум 6 символов");

        }

        
        if (existingUsers.Contains(login))

        {

            throw new LoginAlreadyExistsException($"Ошибка: Логин {login} уже занят!");

        }

        
        existingUsers.Add(login);
        Console.WriteLine("Регистрация завершена успешно!");

    }

}

class Program

{

    static void Main()

    {

        UserService service = new UserService();

        
        try

        {

            service.Register("admin", "123");

        }

        catch (WeakPasswordException ex)

        {

            Console.WriteLine(ex.Message);

        }

        
        try

        {

            service.Register("user1", "qwerty666");

        }

        catch (LoginAlreadyExistsException ex)

        {

            Console.WriteLine(ex.Message);

            Console.ReadLine();

        }

    }

}