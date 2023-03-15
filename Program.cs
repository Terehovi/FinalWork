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
