//main program code

using CMP1903M_A01_2223;

public class MathsTutor
{
    static void Main(string[] args)
    {
        //test.runAllTests();
        string gamestate;
        gamestate = "menu";
        //menu
        Console.WriteLine("Welcome to Maths Tutor Application!");
        bool flag = false;
        do
        {
            Console.WriteLine("Menu: \n Instructions \n start game (3 cards) \n start game (5 cards) \n quit");
            gamestate = Console.ReadLine();
            flag = menu(gamestate);
        } while (!flag); //keeps asking until correct input is entered, error handling

    }
    public static bool menu(string gamestate)
    {
        //intial menu to view instructions, play game or quit

        if (gamestate == "instructions" || gamestate == "Instructions")
        {
            //instructions on how to play the game
            Console.WriteLine("This is the instructions on how this game works");
            Console.WriteLine("You will be randomly dealt 3 cards from a deck that has been shuffled in the Fisher-Yates style");
            Console.WriteLine("The cards will be displayed in 'number-suit' formation. For example, 4-1 represents the 4 of hearts");
            Console.WriteLine("The face cards - Jack, Queen and King, are represented with the numbers 11, 12 and 13 respectively.");
            Console.WriteLine("The suits will also signal an operation, and are represented as: \n 1: Hearts - + \n 2: Diamonds - -\n 3: Clubs - x \n 4: Spades - /");
            Console.WriteLine("You will be dealt 3 cards, for example: \n 4-1 \n 10-2 \n 4-4 \n You will be tasked with calculating what the answer is");
            Console.WriteLine("From the example: \n 4-1 represents the number 4 \n 5-4 represents the suit 4 which is / \n 4-4 represents the number 4");
            Console.WriteLine("therefore the sum you need to calculate is 4 / 4. This is 1.");
            Console.WriteLine("press any key to return to the menu");
            Console.ReadKey();
            return false;
        }
        else if (gamestate == "start 3" || gamestate == "start game 3" || gamestate == "Start 3" || gamestate == "start 3 cards"|| gamestate == "3 cards")
        {
            //call of function to play game with 3 cards
            game3();
            return true;
        }
        else if (gamestate == "start 5" || gamestate == "start game 5" || gamestate == "Start 5" || gamestate == "start 5 cards" || gamestate == "5 cards")
        {
            //call of function to play game with 5 cards
            game5();
            return true;
        }
        else if (gamestate == "quit" || gamestate == "Quit")
        {
            Console.WriteLine("Goodbye, hope you enjoyed the game!");
            Environment.Exit(0);
            return true;
        }
        else if (gamestate == "menu")
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Menu: \n Instructions \n start game (3 cards) \n start game (5 cards) \n quit");
                gamestate = Console.ReadLine();
                flag = menu(gamestate);
            } while (!flag); //keeps asking until correct input is entered, error handling
            return true;
        }
        else
        {
            //ask to try again, wrong input
            Console.WriteLine("Invalid input, please try again.");
            return false;
        }
    }
    public static bool game3()
    {
        Pack mypack= new Pack();
        mypack.shuffleCardPack(1);
        Console.WriteLine("Dealing 3 cards...");
        List<Card> dealtCards = mypack.dealCard(3);
        foreach (Card card in dealtCards)
        {
            Console.WriteLine($"Dealt card: {card.Value}-{card.Suit}");
        }
        Console.WriteLine("{0} {1} {2} = ", dealtCards[0].Value, dealtCards[1].Suit, dealtCards[2].Value);
        int firstNum = dealtCards[0].Value;
        int operation = dealtCards[1].Suit;
        int secondNum = dealtCards[2].Value;
        int input;
        double divInput;
        string reshuffle;
        bool flag = false;
        do
        {
            //asking user whether to reshuffle. do/while is error handling
            Console.WriteLine("Do you want to reshuffle the cards? (y/n):");
            reshuffle = Console.ReadLine();
            if (reshuffle.ToLower() == "y")
            {
                //reshuffling cards
                mypack.shuffleCardPack(1);
                Console.WriteLine("Playing again with reshuffled cards:");
                return game3(); //calling game with new cards

            }
            else if (reshuffle.ToLower() == "n")
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n': ");
                Console.ReadLine();
                flag = false;
            }
        } while (!flag);
        Console.WriteLine("Enter the correct answer: ");
        if (operation == 1)
        {
            //second number suit indicates addition
            input = int.Parse(Console.ReadLine());
            int answer = firstNum + secondNum;
            if (input == answer)
            {
                Console.WriteLine("Correct! Well done!");
                Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "play again")
                {
                    return game3();
                }
                else
                {
                    menu("menu");
                
                }
            }
            else
            {
                Console.WriteLine("Unlucky, that is incorrect");
                Console.WriteLine("Correct answer: " + answer);
                Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "play again")
                {
                    return game3();
                }
                else
                {
                    menu("menu");
                }
            }
        }
        else if (operation == 2)
        {
            //second number suit indicates subtraction
            input = int.Parse(Console.ReadLine());
            int answer = firstNum - secondNum;
            if (input == answer)
            {
                Console.WriteLine("Correct! Well done!");
                Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "play again")
                {
                    return game3();
                }
                else
                {
                    menu("menu");
                }
                
            }
            else
            {
                Console.WriteLine("Unlucky, that is incorrect");
                Console.WriteLine("Correct answer: " + answer);
                Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "play again")
                {
                    return game3();
                }
                else
                {
                    menu("menu");
                }
            }
        }
        else if (operation == 3)
        {
            //second number suit indicates multiplication
            input = int.Parse(Console.ReadLine());
            int answer = firstNum * secondNum;
            if (input == answer)
            {
                Console.WriteLine("Correct! Well done!");
                Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "play again")
                {
                    return game3();
                }
                else
                {
                    menu("menu");
                }
            }
            else
            {
                Console.WriteLine("Unlucky, that is incorrect");
                Console.WriteLine("Correct answer: " + answer);
                Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "play again")
                {
                    return game3();
                }
                else
                {
                    menu("menu");
                }
            }
            
        }
        else
        {
            //second number suit indicates division
            if (secondNum == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                divInput = double.Parse(Console.ReadLine());
                double answer = (double)firstNum / (double)secondNum;
                answer = Math.Round(answer, 2);
                if (divInput == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game3();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game3();
                    }
                    else
                    {
                        menu("menu");
                    }
                }  
            }
        }  
        return false;   
    }
    public static bool game5()
    {
        Pack mypack = new Pack();
        mypack.shuffleCardPack(1);
        Console.WriteLine("Dealing 5 cards...");
        List<Card> dealtCards = mypack.dealCard(5);
        foreach (Card card in dealtCards)
        {
            Console.WriteLine($"Dealt card: {card.Value}-{card.Suit}");
        }
        Console.WriteLine("{0} {1} {2} {3} {4} = ", dealtCards[0].Value, dealtCards[1].Suit, dealtCards[2].Value, dealtCards[3].Suit, dealtCards[4].Value);
        int firstNum = dealtCards[0].Value;
        int operation1 = dealtCards[1].Suit;
        int secondNum = dealtCards[2].Value;
        int operation2 = dealtCards[3].Suit;
        int thirdNum = dealtCards[4].Value;
        int input;
        double divInput;
        string reshuffle;
        bool flag = false;
        do
        {
            //asking user whether to reshuffle. do/while is error handling
            Console.WriteLine("Do you want to reshuffle the cards? (y/n):");
            reshuffle = Console.ReadLine();
            if (reshuffle.ToLower() == "y")
            {
                //reshuffling cards
                mypack.shuffleCardPack(1);
                Console.WriteLine("Playing again with reshuffled cards:");
                return game5(); //calling game with new cards

            }
            else if (reshuffle.ToLower() == "n")
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n': ");
                Console.ReadLine();
                flag = false;
            }
        } while (!flag);
        Console.WriteLine("Enter the correct answer: ");
        if (operation1 == 1)
        {
            //second number suit indicates addition
            if (operation2 == 1)
            {
                //second operation indicates addition
                input = int.Parse(Console.ReadLine());
                int answer = firstNum + secondNum + thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game3();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
                
            }
            else if (operation2 == 2)
            {
                //second operation indicates subtraction
                input = int.Parse(Console.ReadLine());
                int answer = firstNum + secondNum - thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
            }
            else if (operation2 == 3)
            {
                //second operation indicates multiplication, uses BIDMAS to calculate correct answer
                input = int.Parse(Console.ReadLine());
                int answer = firstNum + (secondNum * thirdNum);
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
            }
            else
            {
                //second number suit indicates division
                if (secondNum == 0 || thirdNum == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    divInput = double.Parse(Console.ReadLine());
                    double answer = firstNum + ((double)secondNum / (double)thirdNum);
                    answer = Math.Round(answer, 2);
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }
        }
        else if (operation1 == 2)
        {
            //second number suit indicates subtraction
            if (operation2 == 1)
            {
                //second operation indicates addition
                input = int.Parse(Console.ReadLine());
                int answer = firstNum - secondNum + thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }

            }
            else if (operation2 == 2)
            {
                //second operation indicates subtraction
                input = int.Parse(Console.ReadLine());
                int answer = firstNum - secondNum - thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
            }
            else if (operation2 == 3)
            {
                //second operation indicates multiplication, uses BIDMAS to calculate correct answer
                input = int.Parse(Console.ReadLine());
                int answer = firstNum - (secondNum * thirdNum);
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
            }
            else
            {
                //second number suit indicates division
                if (secondNum == 0 || thirdNum == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    divInput = double.Parse(Console.ReadLine());
                    double answer = firstNum - ((double)secondNum / (double)thirdNum);
                    answer = Math.Round(answer, 2);
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }
        }
        else if (operation1 == 3)
        {
            //second number suit indicates multiplication
            if (operation2 == 1)
            {
                //second operation indicates addition
                input = int.Parse(Console.ReadLine());
                int answer = firstNum * secondNum + thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }

            }
            else if (operation2 == 2)
            {
                //second operation indicates subtraction
                input = int.Parse(Console.ReadLine());
                int answer = firstNum * secondNum - thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
            }
            else if (operation2 == 3)
            {
                //second operation indicates multiplication, uses BIDMAS to calculate correct answer
                input = int.Parse(Console.ReadLine());
                int answer = firstNum * secondNum * thirdNum;
                if (input == answer)
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }

                }
                else
                {
                    Console.WriteLine("Unlucky, that is incorrect");
                    Console.WriteLine("Correct answer: " + answer);
                    Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "play again")
                    {
                        return game5();
                    }
                    else
                    {
                        menu("menu");
                    }
                }
            }
            else
            {
                //second number suit indicates division
                if (secondNum == 0 || thirdNum == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    divInput = double.Parse(Console.ReadLine());
                    double answer = (double)firstNum * ((double)secondNum / (double)thirdNum);
                    answer = Math.Round(answer, 2);
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }

        }
        else
        {
            //second number suit indicates division
            if (operation2 == 1)
            {
                //second operation indicates addition
                divInput = double.Parse(Console.ReadLine());
                double answer = ((double)firstNum / (double)secondNum) + thirdNum;
                answer = Math.Round(answer, 2);
                if (firstNum == 0 || secondNum == 0)
                {
                    Console.WriteLine("cannot divide by zero");
                }
                else
                {
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }
            else if (operation2 == 2)
            {
                //second operation indicates subtraction 
                divInput= double.Parse(Console.ReadLine());
                double answer = ((double)firstNum / (double)secondNum) - thirdNum;
                answer = Math.Round(answer, 2);
                if (firstNum == 0 || secondNum == 0)
                {
                    Console.WriteLine("cannot divide by 0");
                }
                else
                {
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }
            else if (operation2 == 3)
            {
                //second operation indicates multiplication
                divInput = double.Parse(Console.ReadLine());
                double answer = ((double)firstNum / (double)secondNum) * thirdNum;
                answer = Math.Round(answer, 2);
                if (firstNum == 0 || secondNum == 0)
                {
                    Console.WriteLine("cannot divide by 0");
                }
                else
                {
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }
            else
            {
                //operation 2 indicates division
                divInput = double.Parse(Console.ReadLine());
                double answer = (double)firstNum / (double)secondNum / (double)thirdNum;
                answer = Math.Round(answer, 2);
                if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
                {
                    Console.WriteLine("cannot divide by 0");
                }
                else
                {
                    if (divInput == answer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, that is incorrect");
                        Console.WriteLine("Correct answer: " + answer);
                        Console.WriteLine("Type 'menu' to return to the menu or type 'play again' to play another game");
                        string playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "play again")
                        {
                            return game5();
                        }
                        else
                        {
                            menu("menu");
                        }
                    }
                }
            }
        }
        return false;
    }
}