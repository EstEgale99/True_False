using System;
using System.Collections.Generic;
using System.Text;

namespace True_false
{
    class AnswerEnter
    {
            public bool GetAnswer(OneQuestion question)
            {
                Console.WriteLine();
                Console.WriteLine(question.QuestionText);
                Console.WriteLine();
                Console.WriteLine("1 - Верю");
                Console.WriteLine("2 - Не верю");

                while (true)
                {
                    Console.Write("Ваш ответ: ");

                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        return true;
                    }

                    if (input == "2")
                    {
                        return false;
                    }

                    Console.WriteLine("Ошибка. Введите 1 или 2.");
                }
            }
    }
}
