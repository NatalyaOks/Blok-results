string[] array = {"!", "1234", "qwert", "285", "7a", "-2","итоги"};
int lenArray = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lenArray++;
    }
}

string[] array1 = new string[lenArray];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array1[j] = array[i];
        j++;
    }
}

for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + " ");
}
