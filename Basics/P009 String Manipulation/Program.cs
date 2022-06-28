
stringManipulationTeorija();


void stringManipulationTeorija()
{
    Console.WriteLine("Hello string manipulation");
    Console.WriteLine();

    Console.WriteLine("*********String constructor**********");

    char[] letters = { 'H', 'e', 'l', 'l', 'o' };
    string greetings = new string(letters); // string constructor, sudeda viena string is masyvo
    Console.WriteLine(greetings);

    Console.WriteLine(letters[2]);
    Console.WriteLine(greetings[2]);

    //-------------------------------------------------------

    Console.WriteLine("*********String concatination**********");
}