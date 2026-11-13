Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть ім’я: ");
string? input = Console.ReadLine();
if (input == null) return;
string name = input.Trim();
while (name == "")
{
    Console.Write("Ім’я не може бути порожнім. Введіть ім’я: ");
    input = Console.ReadLine();
    if (input == null) return;
    name = input.Trim();
}
Console.Write("Введіть вік: ");
int age;
input = Console.ReadLine();
if (input == null) return;
while (!int.TryParse(input, out age) || age < 0 || age > 130)
{
    Console.Write("Введіть цілий вік від 0 до 130: ");
    input = Console.ReadLine();
    if (input == null) return;
}
Console.WriteLine($"Вітаю {name}!");
Console.WriteLine($"Ім’я: {name}. Вік: {age}.");
if (age >= 18)
    Console.WriteLine("Користувач повнолітній.");
else
    Console.WriteLine("Користувач неповнолітній.");
