using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using WieIsDeMol.domain;

namespace WieIsDeMol
{
    class GameController
    {
        private Investigator investigator;
        private string[] questions;
        private int turnCounter;

        public void Start()
        {
            var data = DummyData.GetDummyData();
            this.investigator = new Investigator(data);
            this.investigator.RandomOffender();

            this.questions = new string[7];
            this.questions[0] = "I know who did it, it was {name}! (repeatable)";
            this.questions[1] = "Is your gender {Gender}? (Male, Female, Unknown)";
            this.questions[2] = "Do you have glasses? (True or False)";
            this.questions[3] = "Is your balance higher then {value}?";
            this.questions[4] = "Is your haircollor {haircollor}?";
            this.questions[5] = "Do you ilke to practice {hobby} in your free time?";
            this.questions[6] = "Are you older then {age}?";


            Suspect offender = null;
            turnCounter = 0;
            while(offender == null)
            {
                this.PrintResults();
                this.PrintOptions();
                String input = Console.ReadLine();
                this.ProcessInput(input);
                turnCounter++;

                if(investigator.Suspects.Count == 1)
                {
                    offender = investigator.Suspects.First();
                }

                Console.WriteLine("=========== NEXT ROUND =============");
            }

            Console.WriteLine("You found the offender in {1} turns, it was {0}", offender.Name, turnCounter);
            Console.WriteLine("Would you like to play again? Press Y to play again, or any other key to close this app");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.KeyChar == 'y')
                Start();

            Environment.Exit(0);

        }

        private void ProcessInput(String input)
        {
            try
            {
                //split into 2 params
                string[] values = input.Split(" ");
                int questionIndex = int.Parse(values[0]);
                string param = values.Length > 1 ? values[1] : null;

                bool? isCorrect = this.processQuestion(questionIndex, param);

                if(isCorrect == null)
                {
                    Console.WriteLine("No valid question selected");
                    return; //we are done here
                }

                Console.ForegroundColor = isCorrect.Value ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine("That is {0}", isCorrect.Value ? "correct" : "incorrect");
                Console.ForegroundColor = ConsoleColor.White;

                if(questionIndex != 0)
                    questions[questionIndex] = null; //remove the question as an option
            }
            catch(Exception e)
            {
                Console.WriteLine("Cannot process input, try again");
            }
        }

        private bool? processQuestion(int questionIndex, string param = null)
        {
            switch (questionIndex)
            {
                case 0: return this.investigator.Accuse(param); break;
                case 1: return this.investigator.FilterByGender(param.toGender()); break;
                case 2: return this.investigator.FilterByGlasses(); break;
                case 3: return this.investigator.FilterByBalance(double.Parse(param));
                case 4: return this.investigator.FilterByHairCollor(param);
                case 5: return this.investigator.FilterByHobby(param);
                case 6: return this.investigator.FilterByAge(int.Parse(param));
                default: return null;
            }
        }

        public void PrintOptions()
        {
            Console.WriteLine("What would you like to ask? These are your options:");
            for (int i = 0; i < questions.Length; i++)
            {
                if(questions[i] != null)
                    Console.WriteLine("{0}: {1}", i, questions[i]);
            }
            Console.WriteLine("What will be your next question?");
        }

        public void PrintResults()
        {
            Console.WriteLine("You are now on turn {0} and there are {1} suspects left: ", this.turnCounter, this.investigator.Suspects.Count);

            //zelf een counter bij houden of toch maar de klassieke for loop?
            int counter = 1;
            this.investigator.Suspects.ForEach(s => {
                Console.Write("=== Suspect Nr. {0}: ", counter);
                Console.WriteLine(s.ToString());
                counter++;
            });
            Console.WriteLine("====================================");
        }
    }
}
