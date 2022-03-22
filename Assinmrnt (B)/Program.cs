// stackoverflow used for the palendome 


string sentence, fl;

fl = "";

Console.Write("Please enter your sentence : ");
sentence = Console.ReadLine();

Console.WriteLine(sentence.Length);

if (sentence.Length < 20)
{
    Console.WriteLine("testing less then 20");

    var fw = sentence;
    fw = sentence.Substring(0, fw.IndexOf(' '));
    Console.WriteLine(fw);
}
else if (sentence.Length >= 20)
{
    Console.WriteLine("testing for string between 20 & 40");

    foreach (var part in sentence.Split(' '))
    {
        fl = part.Substring(0,1);
        Console.WriteLine(fl);
    }
}
else if (sentence.Length > 60)
{
    Console.WriteLine("testing this string is grater then 60");


}