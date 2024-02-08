using System;

class Program
{
    static void Main(string[] args)
    {
        int lives = 10, noseLength = 0, mischiefMeter = 0, goodDeedsMeter = 0, decision = 0, round = 0;
        Random r = new Random();
        bool win = false;
        bool quit = false;
        bool gameActive = true;

        Console.WriteLine("Welcome to the adventures of Pinocchia!");
        Console.WriteLine("Your challenge is to help Pinocchia become a real girl by making good choices!");

        while (gameActive)
        {
            decision = UserDecision();
            if (decision == 1)
            {
                RandomScenario(r.Next(4), ref lives, ref noseLength, ref mischiefMeter, ref goodDeedsMeter);
            }
            else
            {
                quit = true;
                gameActive = false;
                Console.WriteLine("You have chosen to quit the game.");
            }

            CheckResults(ref round, ref lives, ref noseLength, ref mischiefMeter, ref goodDeedsMeter, ref win, ref quit, ref gameActive);
        }

        if (win)
            DisplayWithBorder("Congratulations! You helped Pinocchia become a real girl!");
        else if (lives <= 0)
            Console.WriteLine("You lost too many lives and did not help Pinocchia become a real girl. You lose.");
        else if (mischiefMeter >= 10)
            Console.WriteLine("Oh darn! You got Pinocchia into too much mischief! She'll never become a real girl now. You lose.");
        else if (noseLength >= 10)
            Console.WriteLine("Oh no! Pinocchia's nose has grown out of control! She'll never become a real girl now. You lose.");
    }

    private static int UserDecision()
    {
        Console.WriteLine("Press 1 to play or 2 to quit ");
        int decision = int.Parse(Console.ReadLine());

        while (decision != 1 && decision != 2)
        {
            Console.WriteLine("You entered an invalid number, please enter a 1 to play or a 2 to quit");
            decision = int.Parse(Console.ReadLine());
        }
        return decision;
    }

    private static void RandomScenario(int num, ref int lives, ref int noseLength, ref int mischiefMeter, ref int goodDeedsMeter)
    {
        Random random = new Random();
        int randomScenario = random.Next(0, 4);

        switch (num)
        {
            case 0:
                LyingScenario(random.Next(10), ref lives, ref noseLength, ref mischiefMeter);
                break;
            case 1:
                TruthTellingScenario(random.Next(10), ref lives, ref noseLength, ref goodDeedsMeter);
                break;
            case 2:
                MischiefScenario(random.Next(10), ref lives, ref mischiefMeter);
                break;
            case 3:
                GoodDeedsScenario(random.Next(10), ref lives, ref goodDeedsMeter);
                break;
            default:
                Console.WriteLine("Unexpected error");
                break;
        }
    }



    private static void LyingScenario(int num, ref int lives, ref int noseLength, ref int mischiefMeter)
    {
        Random random = new Random();
        int lyingScenario = random.Next(1, 11);

        switch (num)
        {
            case 1:
                Console.WriteLine("Pinocchia claimed she completed a difficult task when she actually failed to do so.");
                break;
            case 2:
                Console.WriteLine("Pinocchia denied eating the last piece of cake, even though she did.");
                break;
            case 3:
                Console.WriteLine("Pinocchia said she finished her homework, but she didn't even start it.");
                break;
            case 4:
                Console.WriteLine("Pinocchia blamed technical issues for missing a deadline, although it was her fault for procrastinating.");
                break;
            case 5:
                Console.WriteLine("Pinocchia pretended to like a friend she met at school, but she actually disliked her and talked about her behind her back.");
                break;
            case 6:
                Console.WriteLine("Pinocchia promised her mother she would clean her room, but knew it wasn't going to happen.");
                break;
            case 7:
                Console.WriteLine("Pinocchia exaggerated her contributions to a class project to impress her teacher.");
                break;
            case 8:
                Console.WriteLine("Pinocchia insisted she was studying at a friend's house when she was out partying.");
                break;
            case 9:
                Console.WriteLine("When Pinocchia's dog pooped in her neighbor's yard, she lied and said a different neighbor's dog was responsible.");
                break;
            case 10:
                Console.WriteLine("Pinocchia lied about her age so she could get in at a local night club when she was supposed to be in bed sleeping.");
                break;
            default:
                Console.WriteLine("Unexpected error");
                break;
        }

        Console.WriteLine("You lose 1 life, your Mischief meter has increased by 1, and your nose just grew another inch!");
        lives--;
        noseLength++;
        mischiefMeter++;
    }

    private static void MischiefScenario(int num, ref int lives, ref int mischiefMeter)
    {
        Random random = new Random();
        int lyingScenario = random.Next(1, 11);

        switch (num)
        {
            case 1:
                Console.WriteLine("Pinocchia swaps labels on food items in the pantry for a prank.");
                break;
            case 2:
                Console.WriteLine("Pinocchia hides her friend's phone as a joke.");
                break;
            case 3:
                Console.WriteLine("Pinocchia sets up a fake ghost scare in her school to spook others.");
                break;
            case 4:
                Console.WriteLine("Pinocchia changes the language settings on a classmate's computer as a prank.");
                break;
            case 5:
                Console.WriteLine("Pinocchia plans a surprise water balloon attack on another friend's birthday.");
                break;
            case 6:
                Console.WriteLine("Pinocchia fills her friend's room with rats while they're away.");
                break;
            case 7:
                Console.WriteLine("Pinocchia puts fake bugs in someone's bed for a laugh.");
                break;
            case 8:
                Console.WriteLine("Pinocchia sets up a booby trap in her house to startle visitors.");
                break;
            case 9:
                Console.WriteLine("Pinocchia pretends to be someone else during online gaming sessions and doesn't behave herself online.");
                break;
            case 10:
                Console.WriteLine("Pinocchia put toothpaste in her teacher's Oreos.");
                break;
            default:
                Console.WriteLine("Unexpected error");
                break;
        }

        Console.WriteLine("You lose 1 life and your Mischief meter has increased by 1!");
        lives--;
        mischiefMeter++;
    }

    private static void TruthTellingScenario(int num, ref int lives, ref int noseLength, ref int goodDeedsMeter)
    {
        Random random = new Random();
        int lyingScenario = random.Next(1, 11);

        switch (num)
        {
            case 1:
                Console.WriteLine("Pinocchia admits to making a mistake that cost the team the game.");
                break;
            case 2:
                Console.WriteLine("Pinocchia confesses to breaking a valuable item accidentally.");
                break;
            case 3:
                Console.WriteLine("Pinocchia tells her teacher the truth about why she didn't complete her assignment.");
                break;
            case 4:
                Console.WriteLine("Pinocchia owns up to a mistake that someone else was about to get blamed for.");
                break;
            case 5:
                Console.WriteLine("Pinocchia tells another friend the truth when asked if she liked their new haircut, but gave them a compliment on their outfit instead.");
                break;
            case 6:
                Console.WriteLine("Pinocchia acknowledges her mischievous tendencies and promises to work on improving.");
                break;
            case 7:
                Console.WriteLine("Pinocchia credits others for their success on a project.");
                break;
            case 8:
                Console.WriteLine("Pinocchia tells her mom where she was and what she was doing, even though she knows she'll get in trouble.");
                break;
            case 9:
                Console.WriteLine("Pinocchia informs a neighbor about the limitations of a product before they purchase it.");
                break;
            case 10:
                Console.WriteLine("Pinocchia tells the truth about her friendship with the bullied kid in school, even though others are teasing her for it.");
                break;
            default:
                Console.WriteLine("Unexpected error");
                break;
        }

        Console.WriteLine("You gain 1 life, your Good Deeds meter has increased by 1, and your nose just shrank by 1 inch!");
        lives++;
        noseLength--;
        goodDeedsMeter++;
    }

    private static void GoodDeedsScenario(int num, ref int lives, ref int goodDeedsMeter)
    {
        Random random = new Random();
        int lyingScenario = random.Next(1, 11);

        switch (num)
        {
            case 1:
                Console.WriteLine("Pinocchia helps an elderly person carry their groceries to their car.");
                break;
            case 2:
                Console.WriteLine("Pinocchia volunteers at a local soup kitchen to serve meals to the homeless.");
                break;
            case 3:
                Console.WriteLine("Pinocchia helps a classmate understand a difficult concept before an exam.");
                break;
            case 4:
                Console.WriteLine("Pinocchia stays late to help a friend finish a project before it's due.");
                break;
            case 5:
                Console.WriteLine("Pinocchia surprises another friend with a thoughtful gift on a rough day.");
                break;
            case 6:
                Console.WriteLine("Pinocchia convinces her politician to sponsor legislation to improve environmental protection measures.");
                break;
            case 7:
                Console.WriteLine("Pinocchia organizes a charity event to raise funds for a worthy cause.");
                break;
            case 8:
                Console.WriteLine("Pinocchia helps clean up a local park as part of a community service initiative.");
                break;
            case 9:
                Console.WriteLine("Pinocchia goes out of her way to assist a stranger with finding the perfect produce at the farmer's market.");
                break;
            case 10:
                Console.WriteLine("Pinocchia adopts a rescue pet from a shelter and gives it a good home.");
                break;
            default:
                Console.WriteLine("Unexpected error");
                break;
        }

        Console.WriteLine("You gain 1 life and your Good Deeds meter has increased by 1!");
        lives++;
        goodDeedsMeter++;
    }

    private static void CheckResults(ref int round, ref int lives, ref int noseLength, ref int mischiefMeter, ref int goodDeedsMeter, ref bool win, ref bool quit, ref bool gameActive)
    {
        round++;

        Console.WriteLine($">>>>> Round {round} <<<<<");
        Console.WriteLine($">>>>> Lives: {lives} Nose Length: {noseLength} Mischief Meter: {mischiefMeter} Good Deeds Meter: {goodDeedsMeter} <<<<<");

        if (round >= 25)
        {
            win = true;
            gameActive = false;
            DisplayWithBorder("Congratulations! You helped Pinocchia become a real girl! You win!");
        }
        else if (lives <= 0 || noseLength >= 10 || mischiefMeter >= 10)
        {
            quit = true;
            gameActive = false;
            Console.WriteLine("Game Over!");
        }
    }

    private static void DisplayWithBorder(string words)
    {
        const int EXTRA_STARS = 4;
        const string SYMBOL = "*";
        int size = words.Length + EXTRA_STARS;
        int x;
        for (x = 0; x < size; ++x)
            Console.Write(SYMBOL);
        Console.WriteLine();
        Console.WriteLine(SYMBOL + " " + words + " " + SYMBOL);
        for (x = 0; x < size; ++x)
            Console.Write(SYMBOL);
        Console.WriteLine("\n\n");
    }
}


