string enteredPassword = Console.ReadLine();
string correctPassword = "s3cr3t!P@ssw0rd";

if (enteredPassword == correctPassword)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong password!");
}