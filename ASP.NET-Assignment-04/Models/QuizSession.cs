using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ASP.NET_Assignment_04.Models
{
    public class QuizSession
    {
        private const string QuestionSet = "questions";
        private const string UserAnswers = "answers";
        private const string QuestionSetCount = "questionscount";
        private const string QuizPlayer = "quizplayer";
        private const string Quiztime = "quiztime";
        private const string QuizId = "quizid";
        private const string QuizResult = "quizresult";


        private ISession session { get; set; }
        public QuizSession(ISession session)
        {
            this.session = session;
        }

        public void SetQuizId(int quizId) => session.SetInt32(QuizId, quizId);
        public int GetQuizId() => session.GetInt32(QuizId) ?? 1;
        public void SetQuestions(List<Question> questions)
        {
            session.SetObject(QuestionSet, questions);
            session.SetInt32(QuestionSetCount, questions.Count);
        }
        public List<Question> GetQuestions() =>
            session.GetObject<List<Question>>(QuestionSet) ?? new List<Question>();
        public void SetAnswers(List<Answer> answers) =>
            session.SetObject(UserAnswers, answers);
        public List<Answer> GetAnswers() =>
            session.GetObject<List<Answer>>(UserAnswers) ?? new List<Answer>();
        public int GetQuestionsCount() => session.GetInt32(QuestionSetCount) ?? 0;
        public void SetQuizPlayer(User player) =>
            session.SetObject(QuizPlayer, player);
        
        public User GetQuizPlayer() =>
            session.GetObject<User>(QuizPlayer) ?? new User();

        public void SetQuizTime(DateTime datetime) =>
           session.SetObject(Quiztime, datetime);

        public DateTime GetQuizTime() =>
            session.GetObject<DateTime>(Quiztime);

        public void SetQuizResult(Double result) => 
            session.SetObject(QuizResult, result);
        public double GetQuizResult() =>
            session.GetObject<Double>(QuizResult);
    }
}
