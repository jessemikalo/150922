Console.Write("Input your string, please: ");
string yourInput = Console.ReadLine();
int lenght = 0;

if (yourInput != null)
{
    foreach (var item in yourInput)
    {
        lenght++;
        //lenght = lenght + 1
    }
}
Console.WriteLine("manually calculated: {0}.", lenght);

//This was not allowed:
Console.WriteLine("The lenght of your story was {0} characters.",
yourInput.Length);



