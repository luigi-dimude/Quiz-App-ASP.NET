using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    public static class QuestionPool
    {

        // Static method that generates a subset of questions from list in a random order
        public static List<Question> GetSetQuestions(List<Question> questions, int numQuestions)
        {
            // Subset questions cannot be more than actual questions
            if (numQuestions > questions.Count)
            {
                throw new ArgumentException("The set of questions must be less than total available questions");
            }
            // Number of subset questions cannot be a negative number or less than 1
            if (numQuestions < 1)
            {
                throw new ArgumentException("There must be at least one question");
            }

            // Subset of questions to be returned
            List<Question> userQuestions = new List<Question>();
            
            // To generate a subset questions in a ramdom order
            Random rand = new Random();

            /*
             *  Updated this part from assignment 03 to make code more efficient.
             *  The list removes questions that have already been added to the generated subset list
             */
            do
            {
                // Get random number based questions count
                int number = rand.Next(questions.Count);

                // Insert unique random question to subset of questions 
                if (!userQuestions.Contains(questions[number]))
                {
                    // Adds question from list randomly to subset list to be returned
                    userQuestions.Add(questions[number]);

                    // Removes added question from list
                    questions.Remove(questions[number]);
                }

            }
            while (userQuestions.Count != numQuestions); // Continues to loop until generated question list is filled

            // Returns generated question list
            return userQuestions;
        }
    }
}
