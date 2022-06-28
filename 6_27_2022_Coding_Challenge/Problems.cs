//Question 1
string stringLights = Console.ReadLine();
int lights = Int32.Parse(stringLights);

for(int x = 0; x < lights; x++)
{
    int y = Int32.Parse(Console.ReadLine());
    Console.WriteLine((y + 1) * (y + 2) / 2 - 1);
}
//Question 2
string stringcount = Console.ReadLine();
int count = Int32.Parse(stringcount);
string[] firstNames = new string[count];
string[] secondNames = new string[count];
for(int i = 0; i < count; i++)
{
    string bothNames = Console.ReadLine();
    string[] words = bothNames.Split(' ');
    string name1 = words[0];
    string name2 = words[1];
    firstNames[i] = name1;
    secondNames[i] = name2;
}

string[] answers = new string[count];
for (int i = 0; i < count; i++)
{
    string name1 = firstNames[i];
    string name2 = secondNames[i];
    string mainString = "";
    string checkString = "";
    if (name1.Length < name2.Length)
    {
        mainString = name1;
        checkString = name2;
    }
    else
    {
        mainString = name2;
        checkString = name1;
    }
    foreach (char c in mainString)
    {
        if (mainString.Count(a => (a == c)) > checkString.Count(a => (a == c)))
        {
            answers[i] = "NO";
        }
    }
    if (answers[i] != "NO")
        answers[i] = "YES";
}
foreach (string answer in answers)
{
    Console.WriteLine(answer);
}
