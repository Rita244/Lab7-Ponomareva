// ### Шаг 2. ref — Swap

// void Swap(ref int a, ref int b)
// {
//    int temp = a;
//    a = b;
//    b = temp;
// }
// int x1 = 10;
// int x2 = 20;

// Console.WriteLine($"До обмена: x1 = {x1}, x2 = {x2}");
// Swap(ref x1, ref x2);
// Console.WriteLine($"После обмена: x1 = {x1}, x2 = {x2}");


// ### Шаг 3. out — частное и остаток

// class Program
// {
//    static void Main()
//    {
//       double a = 10;
//       double b = 2;

//       if (TryDivide(a, b, out double result))
//       {
//          Console.WriteLine($"Успех! {a} / {b} = {result}");
//       }
//       else
//       {
//          Console.WriteLine("Деление не удалось.");
//       }
//    }

//    static bool TryDivide(double a, double b, out double result)
//    {
//       if (b == 0)
//       {
//          result = 0;
//          return false;
//       }
//       result = a / b;
//       return true;
//    }
// }


// ### Шаг 4. in


// using System;

// class Program
// {
//    static void Swap(ref int a, ref int b) 
//    {
//       int temp = a;
//       a = b;
//       b = temp;
//    }

//    static void Main()
//    {
//       int x = 3;
//       int y = 8;

//       Console.WriteLine("До:    x = " + x + ", y = " + y);

//       Swap(ref x, ref y);

//       Console.WriteLine("После: x = " + x + ", y = " + y);
//    }
// }


// ### Шаг 5. Необязательные параметры и именованные аргументы

// using System;

// class Program
// {
//    static void PrintCharacter(string name, int level,
//                               string charClass = "Гоку",
//                               bool showStats = false)
//    {
//       Console.WriteLine(name + ", уровень " + level + ", класс: " + charClass);

//       if (showStats)
//       {
//          Console.WriteLine("  (характеристики)");
//       }
//    }

//    static void Main()
//    {
//       PrintCharacter("Рита", 5);
//       PrintCharacter("Ярик", 7, showStats: true);
//       PrintCharacter(charClass: "Марвел", name: "Саша", level: 3);
//    }
// }


// ## Итоговая задача. Проектирование системы персонажа

// using System;

// struct CharacterStats
// {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }

// class Program
// {
// // ref: метод изменяет переменную health у вызывающего кода
//     static void RestoreHealth(ref int health, int amount)
//     {
//         health += amount;
//     }

// //считает и возвращает число 
//     static int CalculateDamage(int baseDamage, int bonusDamage)
//     {
//         return baseDamage + bonusDamage;
//     }

// // out: возвращает два значения 
//     static bool TryCastSkill(int mana, int skillCost, out int skillEffect)
//     {
//         if (mana < skillCost)
//         {
//             skillEffect = 0;
//             return false;
//         }

//         skillEffect = skillCost * 2;
//         return true;
//     }

// // in: передаётся только для чтения
//     static void DisplayStats(in CharacterStats stats)
//     {
//         Console.WriteLine("Здоровье: " + stats.Health);
//         Console.WriteLine("Урон:     " + stats.Damage);
//         Console.WriteLine("Броня:    " + stats.Armor);
//     }

//     static void PrintCharacterReport(string characterName, int level,
//                                      string charClass = "Гоку",
//                                      bool detailed = false)
//     {
//         Console.WriteLine(characterName + ", уровень " + level + ", класс: " + charClass);

//         if (detailed)
//             Console.WriteLine("  (характеристики)");
//     }

//     static void Main()
//     {
//         int health = 50;

//         RestoreHealth(ref health, 30);
//         Console.WriteLine("Здоровье после лечения: " + health);

//         int damage = CalculateDamage(20, 5);
//         Console.WriteLine("Итоговый урон: " + damage);

//         if (TryCastSkill(10, 4, out int effect))
//             Console.WriteLine("Умение сработало, эффект: " + effect);
//         else
//             Console.WriteLine("Не хватило маны");

//         CharacterStats stats;
//         stats.Health = health;
//         stats.Damage = damage;
//         stats.Armor = 12;
//         DisplayStats(in stats);

//         PrintCharacterReport("Рита", 5);
//         PrintCharacterReport("Ярик", 7, detailed: true);
//         PrintCharacterReport("Саша", 3, "Марвел");
//     }
// }
