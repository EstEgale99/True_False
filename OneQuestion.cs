using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace True_false
{
    class OneQuestion
    {
        [JsonPropertyName("Text")]
        public string QuestionText { get; set; }
        [JsonPropertyName("Answer")]
        public bool CorrectAnswer { get; set; }
        [JsonPropertyName("Explanation")]
        public string Explanation { get; set; }
    }
}
