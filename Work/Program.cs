static int IntParse(string s)
{
    char[] chars = s.ToCharArray();
    int result = 0;

    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] >= 48 && chars[i] <= 57)
        {
            //Console.WriteLine((int)chars[i]);
            result *= 10;
            result += chars[i] - 48;
        }
        else
        {
            throw new Exception($"{chars[i]} isn`t a number");
        }
    }
    
    return result;
}

static string SentenceReverse(string str)
{
    return str;
}

static string[] StringSplit(string sentence, char symbol)
{
    return sentence.Split(symbol);
}

Console.WriteLine(IntParse("150"));