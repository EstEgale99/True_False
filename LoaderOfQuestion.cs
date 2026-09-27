using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace True_false
{
    class LoaderOfQuestion
    {
        private List<OneQuestion> questions;
        private Random random = new Random();

        public void LoadQuestions(string filePath)
        {
            // Чтение JSON-файла и десериализация в список вопросов
            string json = File.ReadAllText(filePath);
            questions = JsonSerializer.Deserialize<List<OneQuestion>>(json);
        }

        public OneQuestion GetRandomQuestion()
        {
            if (questions == null || questions.Count == 0)
            {
                throw new InvalidOperationException("Questions have not been loaded or the list is empty.");
            }
            int index = random.Next(questions.Count);
            return questions[index];
        }

    }
}
