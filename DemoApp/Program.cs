Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть ім’я: ");
string name = (Console.ReadLine() ?? "").Trim();
while (name == "")
{
    Console.Write("Ім’я не може бути порожнім. Введіть ім’я: ");
    name = (Console.ReadLine() ?? "").Trim();
}
Console.WriteLine($"Вітаю {name}!");
