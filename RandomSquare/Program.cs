// See https://aka.ms/new-console-template for more information

//1. Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
//2. With the resulting List, populate a new List that contains each number squared. For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
//3. Then remove any number that is odd from the list of squared numbers.

//Create List

List<int> randomNums = new List<int>();

//populate List

for (int i = 0; i < 20; i++)
{
    Random random = new Random();
    int num = random.Next(1, 50);

    randomNums.Add(num);
}

//square
var randomNumsSquared = randomNums.Select(num => num * num);

//remove odd numbers
var randomNumsSquaredWithoutOddNums = randomNumsSquared.Where(num => num % 2 == 0);

//seeing if list of 20 random numbers between 1-50 populate
//foreach (int num in randomNums)
//{
//    Console.WriteLine($"{num}");
//}

//Console.WriteLine("___________________");

////seeing if each number in the above list gets squared
//foreach (int num in randomNumsSquared)
//{
//    Console.WriteLine($"{num}");
//}

//Console.WriteLine("___________________");

////seeing if the odd numbers get removed
//foreach (int num in randomNumsSquaredWithoutOddNums)
//{
//    Console.WriteLine($"{num}");
//}

Console.WriteLine($"Original random numbers: {string.Join(", ", randomNums)}");
Console.WriteLine($"Those numbers squared: {string.Join(", ", randomNumsSquared)}");
Console.WriteLine($"Only even numbers: {string.Join(", ", randomNumsSquaredWithoutOddNums)}");