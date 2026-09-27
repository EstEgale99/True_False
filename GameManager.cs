using System;
using System.Collections.Generic;
using System.Text;

namespace True_false
{
    class GameManager
    {
        private LoaderOfQuestion loader;
        private AnswerEnter answerEnter;
        private Comparison comparison;

        private const int QuestionsPerGame = 10;

        public GameManager(
            LoaderOfQuestion loader,
            AnswerEnter answerEnter,
            Comparison comparison)
        {
            this.loader = loader;
            this.answerEnter = answerEnter;
            this.comparison = comparison;
        }

        public void Start()
        {
            // Загружаем все вопросы из JSON
            loader.LoadQuestions("Questions.json");

            Console.WriteLine("=== ВЕРЮ / НЕ ВЕРЮ ===");
            Console.WriteLine();

            // Игровой цикл
            for (int i = 0; i < QuestionsPerGame; i++)
            {
                Console.WriteLine($"Вопрос {i + 1} из {QuestionsPerGame}");

                // Получаем случайный вопрос
                OneQuestion currentQuestion =
                    loader.GetRandomQuestion();

                // Показываем вопрос и получаем ответ игрока
                bool userAnswer =
                    answerEnter.GetAnswer(currentQuestion);

                // Проверяем ответ
                bool isCorrect =
                    comparison.CheckAnswer(
                        currentQuestion,
                        userAnswer);

                // GameManager решает, что показать
                if (isCorrect)
                {
                    Console.WriteLine("Правильно!");
                }
                else
                {
                    Console.WriteLine("Неправильно!");

                    string correctAnswer =
                        currentQuestion.CorrectAnswer
                            ? "Верю"
                            : "Не верю";

                    Console.WriteLine(
                        $"Правильный ответ: {correctAnswer}");
                }

                Console.WriteLine(
                    $"Пояснение: {currentQuestion.Explanation}");

                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();
            }

            // Конец игры
            Console.WriteLine("=== ИГРА ОКОНЧЕНА ===");

            Console.WriteLine(
                $"Правильных ответов: " +
                $"{comparison.CorrectAnswers} из {QuestionsPerGame}");
        }
    }
}
