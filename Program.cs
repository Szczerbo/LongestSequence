using System.Text;

List<int> inputList = new List<int> { 100, 4, 200, 1, 3, 201, 202, 203, 204, 2, 5, 2147483647, 2147483642, 2147483643, 2147483644, 2147483645, 2147483646, 2147483641 };
var finalResult = LongestSequence(inputList);
StringBuilder finalResultString = new StringBuilder();

finalResultString.Append('[').Append(String.Join(",", finalResult)).Append(']');

Console.WriteLine($"Najdłuższy ciąg ma długość {finalResult.Count} i jest to {finalResultString}");

Console.Read();

static List<int> LongestSequence(List<int> input)
{
    List<int> basicList = new List<int>();
    List<int> pretenderList = new List<int>();

    for (uint i = 0; i <= Int32.MaxValue; i++)
    {
        if (input.IndexOf((int)i) != -1)
        {
            pretenderList.Add((int)i);

            if (pretenderList.Count > basicList.Count)
            {
                basicList = new List<int>(pretenderList);
            }
        }
        else
        {
            pretenderList.Clear();
        }
    }
    return basicList;
}