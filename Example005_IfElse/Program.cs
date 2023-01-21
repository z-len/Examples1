Console.WriteLine("Введите имя:");
string username = Console.ReadLine();
if (username. ToLower()== "маша") // ToLower() переводит все символы в нижний регистр
{

    Console.WriteLine("Ура! Это же Маша!");
}

else
{
    Console.Write("Привет, ");
    Console.Write(username);
}



