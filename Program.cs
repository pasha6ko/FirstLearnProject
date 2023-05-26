/*Console.Write("Введите имя: ");
string username = Console.ReadLine();
Console.WriteLine($"Привет,\n{username}");
Console.WriteLine(
    $"-1 + 4 * 6 ={-1f + 4f * 6f}\n" +
    $"( 35 + 5 ) % 7 = {(35f + 5f) % 7f}\n" +
    $"14 + -4 * 6 / 11 = {14f + -4f * 6f / 11f}\n" +
    $"2 + 15 / 6 * 1 - 7 % 2 = {2f + 15f / 6f * 1f - 7f % 2f}\n");
Console.Write("Введите первое число: ");
double a = float.Parse(Console.ReadLine());// Оно тоже работает ._.
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите четвёртое число: ");
double d = Convert.ToDouble(Console.ReadLine());
double answer = (a + b + c + d)/4;
Console.WriteLine(answer);*/
Console.Write("Введите количество одногрупников: ");
int groupmates = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Страниц: ");
int pageCount = Convert.ToInt32(Console.ReadLine());
if (pageCount <= 0 || groupmates<=0)
{
    Console.WriteLine(0);
    return;
}
Console.WriteLine(groupmates * pageCount);


