List<int> inputList = new List<int> { 100, 4, 200, 1, 3, 201, 202, 203, 204, 2, 5 };
LongestSequence(inputList);

static List<int> LongestSequence(List<int> input)
{
    List<int> basicList = new List<int>();
    List<int> pretenderList = new List<int>();

    for (int i = 1; i <= 2147483591; i++)
    {
        if(input.IndexOf(i) != -1)
        {
            pretenderList.Add(i);
            if(pretenderList.Count > basicList.Count)
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