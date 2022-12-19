try
{
    int targetNumber = new Random().Next(10);
    List<int> previousGuesses = new List<int>();

    while (true)
    {
        int number;
        bool previouslyGuessed;
        do
        {
            Console.Write("Välj en siffra mellan 0 and 9 (inklusive): ");
            number = Convert.ToInt32(Console.ReadLine());
            previouslyGuessed = previousGuesses.Contains(number);
            if (previouslyGuessed) Console.WriteLine("Den siffran har redan valts förut.");
        } while (previouslyGuessed);

        if (number == targetNumber) throw new Exception();

        previousGuesses.Add(number);
    }
}
catch (Exception)
{
    Console.WriteLine("Du valde samma siffra som datorn! Game Over!");
}

// 1: Answer this question: Did you make a custom exception type or use an existing one, and why did you choose what you did?
//
//    I just used `Exception` because it was easier. For a program this size, it didn't seem justified to build a whole
//    new exception class. (See also my answer to the next question.)
//
// 2: Answer this question: This program could also be written without exceptions, but the requirements demanded an exception
// for learning purposes. If you didn't have that requirement, would you have used an exception, and why or why not?
//
//    In this case, I wouldn't have used an exception. The code that detected the "problem" knows what to do about it.
//    So rather than throwing an exception, I would normally have just done something like use `Console.WriteLine`
//    to display the "You lose!" message, and then `break;` out of the loop and end the program.
