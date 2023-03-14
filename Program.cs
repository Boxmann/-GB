void SecondArrayWithIF( string [] array1, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
string [] array1 = new string [] {"7618", "7624", "3016", "6581", "1456", "4419", "6266", "584", "8147", "7891", "636", "3468", "1482", "4401", "4010", "4193", "5800", "6814", "8589", "6060", "3297", "5405", "3755", "7214", "8044", "4745", "5749", "3150", "4250", "7810", "4551", "207", "8712", "4555", "242", "6483", "1311", "1805", "5179", "4431", "369", "6345", "2888", "5822", "8256", "8052", "6819", "2309", "3283", "1330"};
string [] array2 = new string [array1.Length];
SecondArrayWithIF(array1, array2);
PrintArray(array2);
