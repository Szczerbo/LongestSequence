List<int> inputList = new List<int> { 100, 4, 200, 1, 3, 201, 202, 203, 204, 2, 5 };
LongestSequence(inputList);

static List<int> LongestSequence(List<int> input)
{
    input.Sort();
    Console.WriteLine(string.Join(",", input));

    List<int> basicList = new List<int>();
    List<int> pretenderList = new List<int>();

    for (int i = 1; i < input.Count; i++)
    {
        if (input[i] - input[i - 1] == 1)
        {
            pretenderList.Add(input[i]);
            pretenderList.Add(input[i - 1]);

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

    var finalList = basicList.Distinct().OrderBy(x => x).ToList();
    return finalList;
}