string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fishes", "hamsters" };
string[] characters = { "Harry", "Ron" };
int[] numbers = { 1, 2, 3, 4, 5, 6 };

PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(characters);

PrintArrayElements2(numbers);

static void PrintArrayElements(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i+1}. {someArray[i]}");
    }
}
static void PrintArrayElements2(int[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {someArray[i]}");
    }
}