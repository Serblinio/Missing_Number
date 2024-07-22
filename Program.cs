
long[] numsArr = [0, 1, 3, 4, 6, 7, 8];

Console.WriteLine("Исходный массив: [0, 1, 3, 4, 6, 7, 8]");
Solution.DisplayMissingNumbers(numsArr);

Console.WriteLine("Введите числа через пробел:");
var input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
    return;

try
{
    var nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(long.Parse)
        .ToArray();
    
    Solution.DisplayMissingNumbers(nums);
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введите только числа, разделенные пробелами.");
}
catch (OverflowException)
{
    Console.WriteLine("Ошибка: Введенное число слишком большое для типа long.");
}