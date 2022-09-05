string [] array = {"1234","qwert","285","7a","-2"};

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write (array[i] + "\t");
    }
}