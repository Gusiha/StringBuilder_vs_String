using System.Text;

string greeting = "Hello World";
StringBuilder stringBuilder = new StringBuilder("Hello World");


DateTime start = DateTime.Now;
for (long i = 0; i < 100000; i++)
{
    greeting += "HelloAgain";
}
DateTime end = DateTime.Now;
Console.WriteLine($"String Concat : {end - start}");


start = DateTime.Now;
for (long i = 0; i < 100000; i++)
{
    stringBuilder.Append("HelloAgain");
}
string Copy = stringBuilder.ToString();
end = DateTime.Now;

Console.WriteLine($"StringBuilder Concat : {end - start}");