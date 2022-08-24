
#region Task 1
//Example 1
for (int i = 0; i <= 100; i++) Console.WriteLine($"{i}  {i * -1}");

//Example 2
for (int i = 0; i <= 100; i++) Console.WriteLine($"{i}  {-i}");
#endregion


#region Task2
Console.WriteLine("Enter word");
string? response = Console.ReadLine();
for (int i = response.Length - 1; 0 <= i; i--) Console.Write(response[i]);
#endregion


#region Task 3
for (int i = 10; i <= 20; i++)
    Console.WriteLine(i % 2 == 0 ? i + " Equal 2 *" + i / 2 : i % 3 == 0 ? i + " Equal 3 *" + i / 3 : i + " Is a prime number");
#endregion


#region Task 4
int[] numbers = new int[1];
bool process = true;

while (process)
{
    Console.WriteLine("Enter number");
    numbers.SetValue(int.Parse(Console.ReadLine()), 0);
goQuession:
    Console.WriteLine("Do you want to enter a new number? Y");
    switch (Console.ReadLine().ToUpper())
    {
        case "Y":
            Array.Resize(ref numbers, numbers.Length + 1);
            Console.WriteLine("Enter number");
            numbers.SetValue(int.Parse(Console.ReadLine()), numbers.Length - 1);
            goto goQuession;
        default:
            process = false;
            break;
    }
}

int[] teksayilar = Array.FindAll(numbers, x => x % 2 != 0);
int max = teksayilar.Length > 0 ? teksayilar[0] : 0;
int min = teksayilar.Length > 0 ? teksayilar[0] : 0;
for (int i = 0; i < teksayilar.Length; i++)
{
    if (max < teksayilar[i])
        max = teksayilar[i];

    if (min > teksayilar[i])
        min = teksayilar[i];
}
Console.WriteLine(teksayilar.Length < 1 ? "odd number not found" : max - min);
#endregion