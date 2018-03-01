using System;

namespace Aula03
{
    class Chatbot
    {
        static void Main(string[] args)
        {
            string question, answer;


            do
            {
                Console.Write("Coloque uma questão: ");
                question = Console.ReadLine();

                if (question == "EXIT")
                {
                    break;
                }
                else
                {
                    switch (question)
                    {
                        case "How are you?":
                            answer = "I'm fine, and you?";
                            break;

                        case "Hello, what's your name?":
                            answer = "Hi, my name is Rob.";
                            break;

                        case "Do you like bananas?":
                            answer = "NO!";
                            break;

                        case "Tell me a joke":
                            answer = "Knock, knock. " +
                                "Who’s there? Adore. " +
                                "Adore who? " +
                                "Adore is between us. Open up!";
                            break;

                        default:
                            answer = "I don't know how to answer that.";
                            break;
                    }
                    Console.WriteLine(answer);
                }
            }
                while (question != "EXIT") ;
            
        }
    }
}
