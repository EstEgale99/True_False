using System;
using System.Collections.Generic;
using System.Text;

namespace True_false
{
    class Comparison
    {
        private int correctAnswers = 0;

        public int CorrectAnswers
        {
            get { return correctAnswers; }
        }

        public bool CheckAnswer(OneQuestion question, bool userAnswer)
        {
            bool isCorrect = userAnswer == question.CorrectAnswer;

            if (isCorrect)
            {
                correctAnswers++;
            }

            return isCorrect;
        }

    }
}
