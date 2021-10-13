using System;

while (true)
{
    int JordanHp = 100;
    int ZhuPhanHp = 150;
    string answer1 = "";
    while (answer1 != "b" && answer1 != "zhu phan" && answer1 != "a" && answer1 != "jordan")
    {
        Console.WriteLine("Fighting game");
        Console.WriteLine("Choose your fighter:");
        Console.WriteLine();
        Console.WriteLine("A)Jordan)");
        Console.WriteLine("Intelligence:0");
        Console.WriteLine("Strength:0");
        Console.WriteLine("Speed:0");
        Console.WriteLine("Defense:0");
        Console.WriteLine();
        Console.WriteLine("B)Zhu Phan");
        Console.WriteLine("Intelligence:Max");
        Console.WriteLine("Strength:Max");
        Console.WriteLine("Speed:Max");
        Console.WriteLine("Defense:Max");
        Console.WriteLine();
        Console.Write("Choice:");
        answer1 = Console.ReadLine().ToLower();
        Console.Clear();
    }
    if (answer1 == "b" || answer1 == "zhu phan")
    {
        Console.WriteLine("Your Fighter:Zhu Phan");
        Console.WriteLine();
    }
    else if (answer1 == "a" || answer1 == "jordan")
    {
        Console.WriteLine("Your Fighter:Jordan");
        Console.WriteLine();
    }

     while (JordanHp > 0 && ZhuPhanHp > 0)
     {
         Random genarator = new Random();
         if (JordanHp >=0)
         {
         int damage = genarator.Next(25, 50);
         ZhuPhanHp -= damage;
         if (ZhuPhanHp <= 0)
         {
             ZhuPhanHp = 0;
         }
         Console.WriteLine("Jordan punches Zhu Phan and deals " + damage + " damage");
         Console.WriteLine("Zhu phan HP:" + ZhuPhanHp);
         Console.WriteLine();
         }
         if (ZhuPhanHp >= 0)
         {
         int damage = genarator.Next(25, 50);
         JordanHp -= damage;
         if (JordanHp <= 0)
         {
             JordanHp = 0;
         }
         Console.WriteLine("Zhu Phan punches Jordan and deals " + damage + " damage");
         Console.WriteLine("Jordans Hp:" + JordanHp);
         Console.WriteLine();
         }
         if (JordanHp == 0)
         {
             Console.WriteLine("Zhu Phan is victorious");
             Console.WriteLine("Press 'Enter' to restart");
         }
         if (ZhuPhanHp == 0)
         {
             Console.WriteLine("Jordan is victorious");
             Console.WriteLine("Press 'Enter' to restart");
         }

     }
     Console.ReadLine();
     Console.Clear();
}