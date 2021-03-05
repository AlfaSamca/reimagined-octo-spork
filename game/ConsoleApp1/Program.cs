using System;
class Igra
{
    static void Main()
    {
        Console.WriteLine("Hello. My name is Nikita Lysevich. Would you like to play the role of a real bandit? And there may be a real pirate? And have huge treasures? ");
        Console.WriteLine("Do you want to try this role?");
        string a;
        do
        {
            Console.WriteLine("If you are with us, then answer: 'YES' ");
            Console.WriteLine("And if you are a coward, then answer no: 'NO' ");
            a = Console.ReadLine();
            if (a == "YES")
            {
                Console.WriteLine("I saw your potential as a bandit. You're in our gang now!!!");
            }
            if (a == "NO")
            {
                Console.WriteLine("COWARD!!!Can you still think about it?");
            }
            if ((a != "YES") && (a != "NO"))
            {
                Console.WriteLine("Hey. Don't piss me off!!!Can you still think about it?");
            }
        } while (a != "YES");
        Console.WriteLine("We'll sneak aboard with you secretly at night. Aren't you afraid of the dark?");
        string b;
        do
        {
            Console.WriteLine("If it is, then answer it: 'YES' ");
            Console.WriteLine("And if you're not afraid, then answer me: 'NO' ");
            b = Console.ReadLine();
            if (b == "YES")
            {
                Console.WriteLine("We will be able to overcome this fear!");
            }
            if (b == "NO")
            {
                Console.WriteLine("Excellent. That's why I chose you!");
            }
            if ((b != "YES") && (b != "NO"))
            {
                Console.WriteLine("You're deluding me again!!!");
            }
        } while ((b != "YES") && (b != "NO"));
        Console.WriteLine("While everyone is sleeping, we need to get into the cabin, where all the treasures lie!");
        Console.WriteLine("Are you afraid?");
        string c;
        do
        {
            Console.WriteLine("If it is, then answer it: 'YES. BUT I'M IN' ");
            Console.WriteLine("And if you're not afraid, then answer me: 'NO' ");
            c = Console.ReadLine();
            if (c == "YES")
            {
                Console.WriteLine("Wow. A real bandit!!!");
            }
            if (c == "NO")
            {
                Console.WriteLine("Fearless. I love them!");
            }
            if ((c != "YES") && (c != "NO"))
            {
                Console.WriteLine("You're saying the wrong thing. Let's get down to business!");
            }
        } while ((c != "YES") && (c != "NO"));
        Console.WriteLine("Go softly, softly, very softly...");
        Console.WriteLine("Shhh. Opening the door!");
        Console.WriteLine("LOOK!!!!!");
        Console.WriteLine("And where are our treasures?");
        Console.WriteLine("Look. Look. There's a chest there!!!");
        Console.WriteLine("You were recommended to me as a good lock picker. Is it true?");
        string f;
        do
        {
            Console.WriteLine("Tell the truth. Just don't lie. Answer: 'YES', if it is true");
            Console.WriteLine("And if you were deceived, answer: 'NO' ");
            f = Console.ReadLine();
            if (f == "YES")
            {
                Console.WriteLine("Why didn't I see you as a real gangster right away?!");
            }
            if (f == "NO")
            {
                Console.WriteLine("The lock is the simplest. You can do it anyway!");
            }
            if ((f != "YES") && (f != "NO"))
            {
                Console.WriteLine("Without further ado. Let's you answer as I asked");
            }
        } while ((f != "YES") && (f != "NO"));
        Console.WriteLine("Here is a strange and talking castle");
        Console.WriteLine("The pirates made a number");
        Console.WriteLine("We need to figure it out before dawn");
        Console.WriteLine("While the pirates are sleeping, you have time to open it and pick up the treasure");
        Console.WriteLine("You have a question: 'What is the strangeness of this castle?' ");
        Console.WriteLine("The pirates, too, can forget the secret number");
        Console.WriteLine("The talking lock tells you whether the hidden number is greater or less");
        Console.WriteLine("Chest code from 10 to 99!");
        Console.WriteLine("Come on. I believe in you, My good friend");
        Random rnd = new Random();
        Random rndm = new Random();
        int A = rndm.Next(10, 99);
        while (true)
        {
            int B = Convert.ToInt32(Console.ReadLine());
            if (B == A)
            {
                Console.WriteLine("You now have access to the content");
                Console.WriteLine("Good. Take the treasure and leave");
                break;
            }
            else
            {
                Console.WriteLine("You're in the wrong direction at all!!!");
                if (A > B)
                {
                    Console.WriteLine("Your code is bigger");
                }
                else
                {
                    Console.WriteLine("Your code is smaller");
                }
            }

        }
    }
}
