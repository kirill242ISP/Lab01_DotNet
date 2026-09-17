// // See https://aka.ms/new-console-template for more information
// /*int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";
// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);*/

// var firstname = "кирилл";
// var lastname = "игошин";
// var group = "ИСП-242";
// var birthyear = 2008;
// var gpa = 4.6;
// var stipendia = true;

// var firstname2 = "наиль";
// var lastname2 = "имашев";
// var group2 = "ИСП-242";
// var birthyear2 = 2008;
// var gpa2 = 4.5;
// var stipendia2 = true;

// int currentyear = 2026;
// int age = currentyear - birthyear;


// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstname} {lastname}");
// Console.WriteLine($"гpуnna: {group}");
// Console.WriteLine($"Boзpacт: {age} лет"); Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {stipendia}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично! {firstname} любит {subject}.");
// int a = 15;
// int b = 4;
// Console.WriteLine($"Cyммa: {a + b}"); Console.WriteLine($"Paзность: {a - b}"); Console.WriteLine($"Произведение:{a * b}");
// Console.WriteLine($"чacтное (int): {a / b}"); Console.WriteLine($"Oстaток: {a % b}");
// double result = (double)a / b;
// Console.WriteLine($"Частное (double):{result}");
// Console.WriteLine("Калькулятор");
// Console.WriteLine("Введите первое число:");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма:{num1 + num2}");
// Console.WriteLine($"Разность:{num1 - num2}");
// Console.WriteLine($"Произведение:{num1 * num2}");
// if (num2 != 0)
//     Console.WriteLine($"Частное:{num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль невозможно");
// int metr1 = 1;
// System.Int32 metr2 = 1;
Console.WriteLine("Добро пожаловать в анкету!");
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine());
Console.Write("Введите ваш cредний балл: ");
double gpa = double.Parse(Console.ReadLine());
int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;
// string status;
// if (isExcellent == true) status = "Отличник";
// else status = "Хорошист";
string status = isExcellent ? "Отличник" : "Хорошист";
Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa} ");
Console.WriteLine($"Статус: {status} ");
Console.WriteLine($"Лет до 30: {30 - age}");
Console.WriteLine("Нажмите enter для выхода....");
Console.ReadLine();