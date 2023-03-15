string[] GenrateResultArray(string[] start)
{
    int size = 0;
    for (int i = 0; i < start.Length; i++)
    {
        if (start[i].Length <= 3)
        {
            size++;
        }
    }
    string[] result = new string[size];
    return result;
}
void AddTheNecessaryElements(string[] start, string[] res)
{
    int n = 0;
    int j = 0;
    while (n < res.Length)
    {
        while (j < start.Length)
        {
            if (start[j].Length <= 3)
            {
                res[n] = start[j];
                n++;
            }
            j++;
        }
    }
}