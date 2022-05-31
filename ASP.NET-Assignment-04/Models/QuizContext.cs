using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Assignment_04.Models
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options)
           : base(options)
        { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<UserScore> UserScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserScore>().HasData(
               new 
               {
                   UserScoreId = 1,
                   PlayerName = "ChessWiz94",
                   FirstName = "Joshua",
                   LastName = "Giggs",
                   QuizId = 1,
                   QuizTime = DateTime.Now,
                   PlayerScore = 90.00
               },
               new
               {
                   UserScoreId = 2,
                   PlayerName = "John",
                   FirstName = "John",
                   LastName = "Smith",
                   QuizId = 1,
                   QuizTime = new DateTime(2020, 12, 19, 5, 10, 20),
                   PlayerScore = 40.00
               },
               new
               {
                   UserScoreId = 3,
                   PlayerName = "Qwerty",
                   FirstName = "James",
                   LastName = "Sion",
                   QuizId = 1,
                   QuizTime = new DateTime(2019, 11, 21, 5, 10, 20),
                   PlayerScore = 50.00
               },
               new
               {
                   UserScoreId = 4,
                   PlayerName = "Firmino9",
                   FirstName = "Phil",
                   LastName = "Scott",
                   QuizId = 2,
                   QuizTime = new DateTime(2021, 10, 22, 5, 10, 20),
                   PlayerScore = 100.00
               }
           );

            modelBuilder.Entity<Quiz>().HasData(
               new Quiz
               {
                   QuizId = 1,
                   Name = "Chess Quiz",
                   Description = "Fun quiz on chess!"
               },
               new Quiz
               {
                   QuizId = 2,
                   Name = "Soccer Quiz",
                   Description = "How much do you really know about the most popular sport in the world?"
               }
           );
            modelBuilder.Entity<Question>().HasData(
                new
                {
                    QuestionId = 1,
                    Content = "What is the total number of squares on a chess board?",
                    Answer = "64",
                    QuizId = 1
                },
               new
               {
                   QuestionId = 2,
                   Content = "Which of the following is not a format of a chess game",
                   Answer = "modern",
                   QuizId = 1
               },
                new
                {
                    QuestionId = 3,
                    Content = "What is the highest title for professional chess players?",
                    Answer = "grand master",
                    QuizId = 1
                },
                 new
                 {
                     QuestionId = 4,
                     Content = "What is the other name for the rooks?",
                     Answer = "castles",
                     QuizId = 1
                 },
                 new
                 {
                     QuestionId = 5,
                     Content = "Strategies in chess are used by economists as a basis for which theory?",
                     Answer = "game theory",
                     QuizId = 1
                 },
                 new
                 {
                     QuestionId = 6,
                     Content = "Which country has the most grandmasters?",
                     Answer = "russia",
                     QuizId = 1
                 },
                 new
                 {
                     QuestionId = 7,
                     Content = "Who is the current world chess champion?",
                     Answer = "magnus carlsen",
                     QuizId = 1
                 },
                 new
                 {
                     QuestionId = 8,
                     Content = "What is a gambit in chess?",
                     Answer = "risks one or more pawns or a minor piece to gain an advantage in position",
                     QuizId = 1
                 },
                  new
                  {
                      QuestionId = 9,
                      Content = "What is the name of the computer which defeated the former world champion Garry Kasparov?",
                      Answer = "deep blue",
                      QuizId = 1
                  },
                   new
                   {
                       QuestionId = 10,
                       Content = "What century did the modern rules for chess standardised?",
                       Answer = "19th",
                       QuizId = 1
                   },
                   new
                   {
                       QuestionId = 11,
                       Content = "Which piece can only move in a forward direction?",
                       Answer = "pawns",
                       QuizId = 1
                   },
                    new
                    {
                        QuestionId = 12,
                        Content = "To be awarded the Grandmaster title, a player must have at least how many points in the ELO rating?",
                        Answer = "2500",
                        QuizId = 1
                    },
                     new
                     {
                         QuestionId = 13,
                         Content = "The longest chess game theoretically possible is?",
                         Answer = "5949 moves",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 14,
                         Content = "The word checkmate is derived from the Arabic word shah mat, which means",
                         Answer = "the king is dead",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 15,
                         Content = "The modern chess board as we see it today appeared first in Europe in the year",
                         Answer = "1090",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 16,
                         Content = "Players in their first year are called",
                         Answer = "rookies",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 17,
                         Content = "Chess is also called the?",
                         Answer = "game of kings",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 18,
                         Content = "Knights move in what shape?",
                         Answer = "L shape",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 19,
                         Content = "What is the strongest piece in chess",
                         Answer = "the queen",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 20,
                         Content = "What is the most important piece in chess",
                         Answer = "the king",
                         QuizId = 1
                     },
                     new
                     {
                         QuestionId = 21,
                         Content = "Soccer made its television debut in 1937, featuring what team in england",
                         Answer = "arsenal",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 22,
                         Content = "What team has never lost to Brzil in international competition",
                         Answer = "norway",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 23,
                         Content = "the only known football player in professional history to score a goal in every single minute of a match?",
                         Answer = "c. ronaldo",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 24,
                         Content = "The most expensive transfer in soccer history was by which players",
                         Answer = "neymar",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 25,
                         Content = "What number is unofficially considered the kit number for the best player on a squad",
                         Answer = "number 10",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 26,
                         Content = "What player has won the most world cups",
                         Answer = "pele",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 27,
                         Content = "Hat-trick is when a player scores how many goals?",
                         Answer = "3",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 28,
                         Content = "How many countries have won the world cup",
                         Answer = "8",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 29,
                         Content = "How many times has france won the world cup",
                         Answer = "2 times",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 30,
                         Content = "What country created the first professional league",
                         Answer = "england",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 31,
                         Content = "Which player has the most ballon d'or",
                         Answer = "messi",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 32,
                         Content = "What player scored an own goal for Columbia in the 1994 World Cup?",
                         Answer = "escobar",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 33,
                         Content = "The person who controls the match and enforces the laws of the game is?",
                         Answer = "the referee",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 34,
                         Content = "There are how many players on a soccer team",
                         Answer = "11",
                         QuizId = 2
                     },
                     new
                     {
                         QuestionId = 35,
                         Content = "A soccer field is also called a?",
                         Answer = "pitch",
                         QuizId = 2
                     },
                      new
                      {
                          QuestionId = 36,
                          Content = "It is estimated that 55 percent of all footballs are created in what country",
                          Answer = "pakistan",
                          QuizId = 2
                      },
                       new
                       {
                           QuestionId = 37,
                           Content = "The world cup takes place every?",
                           Answer = "4 years",
                           QuizId = 2
                       },
                       new
                       {
                           QuestionId = 38,
                           Content = "The world cup trophy is made of?",
                           Answer = "gold",
                           QuizId = 2
                       },
                       new
                       {
                           QuestionId = 39,
                           Content = "The only country to host the world cup twice?",
                           Answer = "mexico",
                           QuizId = 2
                       },
                        new
                        {
                            QuestionId = 40,
                            Content = "What team has won the most champions league?",
                            Options = new List<string> { "real madrid", "barcelona", "AC milan", "bayern munich" },
                            Answer = "real madrid",
                            QuizId = 2
                        }
            );
            modelBuilder.Entity<QuestionOption>().HasData(
               new
               {
                   QuestionOptionId = 1,
                   Content = "62",
                   QuestionId = 1
               },
               new
               {
                   QuestionOptionId = 2,
                   Content = "64",
                   QuestionId = 1
               },
               new
               {
                   QuestionOptionId = 3,
                   Content = "54",
                   QuestionId = 1
               },
               new
               {
                   QuestionOptionId = 4,
                   Content = "52",
                   QuestionId = 1
               },
               new
               {
                   QuestionOptionId = 5,
                   Content = "rapid",
                   QuestionId = 2
               },
                new
                {
                    QuestionOptionId = 6,
                    Content = "classical",
                    QuestionId = 2
                },
                new
                {
                    QuestionOptionId = 7,
                    Content = "blitz",
                    QuestionId = 2
                },
                new
                {
                    QuestionOptionId = 8,
                    Content = "modern",
                    QuestionId = 2
                },
                new
                {
                    QuestionOptionId = 9,
                    Content = "international master",
                    QuestionId = 3
                },
                new
                {
                    QuestionOptionId = 10,
                    Content = "chess master",
                    QuestionId = 3
                },
                new
                {
                    QuestionOptionId = 11,
                    Content = "grand master",
                    QuestionId = 3
                },
                new
                {
                    QuestionOptionId = 12,
                    Content = "chess expert",
                    QuestionId = 3
                },
                new
                {
                    QuestionOptionId = 13,
                    Content = "knights",
                    QuestionId = 4
                },
                new
                {
                    QuestionOptionId = 14,
                    Content = "crowns",
                    QuestionId = 4
                },
                new
                {
                    QuestionOptionId = 15,
                    Content = "castles",
                    QuestionId = 4
                },
                new
                {
                    QuestionOptionId = 16,
                    Content = "bishops",
                    QuestionId = 4
                },
                new
                {
                    QuestionOptionId = 17,
                    Content = "economist theory",
                    QuestionId = 5
                },
                new
                {
                    QuestionOptionId = 18,
                    Content = "classical economics",
                    QuestionId = 5
                },
                new
                {
                    QuestionOptionId = 19,
                    Content = "macro economics",
                    QuestionId = 5
                },
                new
                {
                    QuestionOptionId = 20,
                    Content = "game theory",
                    QuestionId = 5
                },
                new
                {
                    QuestionOptionId = 21,
                    Content = "usa",
                    QuestionId = 6
                },
                new
                {
                    QuestionOptionId = 22,
                    Content = "russia",
                    QuestionId = 6
                },
                new
                {
                    QuestionOptionId = 23,
                    Content = "norway",
                    QuestionId = 6
                },
                new
                {
                    QuestionOptionId = 24,
                    Content = "india",
                    QuestionId = 6
                },
                new
                {
                    QuestionOptionId = 25,
                    Content = "magnus carlsen",
                    QuestionId = 7
                },
                new
                {
                    QuestionOptionId = 26,
                    Content = "wesley so",
                    QuestionId = 7
                },
                new
                {
                    QuestionOptionId = 27,
                    Content = "garry kasparov",
                    QuestionId = 7
                },
                new
                {
                    QuestionOptionId = 28,
                    Content = "fabiano caruana",
                    QuestionId = 7
                },
                new
                {
                    QuestionOptionId = 29,
                    Content = "risks one or more pawns or a minor piece to gain an advantage in position",
                    QuestionId = 8
                },
                new
                {
                    QuestionOptionId = 30,
                    Content = "sacrficing a bishop",
                    QuestionId = 8
                },
                new
                {
                    QuestionOptionId = 31,
                    Content = "none of the above",
                    QuestionId = 8
                },
                new
                {
                    QuestionOptionId = 32,
                    Content = "sacrificing a pawn",
                    QuestionId = 8
                },
                new
                {
                    QuestionOptionId = 33,
                    Content = "deep red",
                    QuestionId = 9
                },
                new
                {
                    QuestionOptionId = 34,
                    Content = "deep fake",
                    QuestionId = 9
                },
                new
                {
                    QuestionOptionId = 35,
                    Content = "deep AI",
                    QuestionId = 9
                },
                new
                {
                    QuestionOptionId = 36,
                    Content = "deep blue",
                    QuestionId = 9
                },
                new
                {
                    QuestionOptionId = 37,
                    Content = "16th",
                    QuestionId = 10
                },
                new
                {
                    QuestionOptionId = 38,
                    Content = "19th",
                    QuestionId = 10
                },
                new
                {
                    QuestionOptionId = 39,
                    Content = "20th",
                    QuestionId = 10
                },
                new
                {
                    QuestionOptionId = 40,
                    Content = "13th",
                    QuestionId = 10
                },
                new
                {
                    QuestionOptionId = 41,
                    Content = "minions",
                    QuestionId = 11
                },
                new
                {
                    QuestionOptionId = 42,
                    Content = "bishop",
                    QuestionId = 11
                },
                new
                {
                    QuestionOptionId = 43,
                    Content = "rooks",
                    QuestionId = 11
                },
                new
                {
                    QuestionOptionId = 44,
                    Content = "pawns",
                    QuestionId = 11
                },
                new
                {
                    QuestionOptionId = 45,
                    Content = "2500",
                    QuestionId = 12
                },
                new
                {
                    QuestionOptionId = 46,
                    Content = "2000",
                    QuestionId = 12
                },
                new
                {
                    QuestionOptionId = 47,
                    Content = "2800",
                    QuestionId = 12
                },
                new
                {
                    QuestionOptionId = 48,
                    Content = "2300",
                    QuestionId = 12
                },
                new
                {
                    QuestionOptionId = 49,
                    Content = "5949 moves",
                    QuestionId = 13
                },
                new
                {
                    QuestionOptionId = 50,
                    Content = "5749 moves",
                    QuestionId = 13
                },
                new
                {
                    QuestionOptionId = 51,
                    Content = "1820 moves",
                    QuestionId = 13
                },
                new
                {
                    QuestionOptionId = 52,
                    Content = "6000 moves",
                    QuestionId = 13
                },
                new
                {
                    QuestionOptionId = 53,
                    Content = "i got your king",
                    QuestionId = 14
                },
                new
                {
                    QuestionOptionId = 54,
                    Content = "it is over",
                    QuestionId = 14
                },
                new
                {
                    QuestionOptionId = 55,
                    Content = "game over",
                    QuestionId = 14
                },
                new
                {
                    QuestionOptionId = 56,
                    Content = "the king is dead",
                    QuestionId = 14
                },
                new
                {
                    QuestionOptionId = 57,
                    Content = "2000",
                    QuestionId = 15
                },
                new
                {
                    QuestionOptionId = 58,
                    Content = "1000",
                    QuestionId = 15
                },
                new
                {
                    QuestionOptionId = 59,
                    Content = "900",
                    QuestionId = 15
                },
                new
                {
                    QuestionOptionId = 60,
                    Content = "1090",
                    QuestionId = 15
                },
                new
                {
                    QuestionOptionId = 61,
                    Content = "rookies",
                    QuestionId = 16
                },
                new
                {
                    QuestionOptionId = 62,
                    Content = "amateurs",
                    QuestionId = 16
                },
                new
                {
                    QuestionOptionId = 63,
                    Content = "noobs",
                    QuestionId = 16
                },
                new
                {
                    QuestionOptionId = 64,
                    Content = "newbies",
                    QuestionId = 16
                },
                new
                {
                    QuestionOptionId = 65,
                    Content = "game of kings",
                    QuestionId = 17
                },
                new
                {
                    QuestionOptionId = 66,
                    Content = "game of the people",
                    QuestionId = 17
                },
                new
                {
                    QuestionOptionId = 67,
                    Content = "game of the youth",
                    QuestionId = 17
                },
                new
                {
                    QuestionOptionId = 68,
                    Content = "game of the holy",
                    QuestionId = 17
                },
                new
                {
                    QuestionOptionId = 69,
                    Content = "S shape",
                    QuestionId = 18
                },
                new
                {
                    QuestionOptionId = 70,
                    Content = "Z shape",
                    QuestionId = 18
                },
                new
                {
                    QuestionOptionId = 71,
                    Content = "none of the above",
                    QuestionId = 18
                },
                new
                {
                    QuestionOptionId = 72,
                    Content = "L shape",
                    QuestionId = 18
                },
                new
                {
                    QuestionOptionId = 73,
                    Content = "the king",
                    QuestionId = 19
                },
                new
                {
                    QuestionOptionId = 74,
                    Content = "the queen",
                    QuestionId = 19
                },
                new
                {
                    QuestionOptionId = 75,
                    Content = "the pawn",
                    QuestionId = 19
                },
                new
                {
                    QuestionOptionId = 76,
                    Content = "the knight",
                    QuestionId = 19
                },
                new
                {
                    QuestionOptionId = 77,
                    Content = "the king",
                    QuestionId = 20
                },
                new
                {
                    QuestionOptionId = 78,
                    Content = "the queen",
                    QuestionId = 20
                },
                new
                {
                    QuestionOptionId = 79,
                    Content = "none of the above",
                    QuestionId = 20
                },
                new
                {
                    QuestionOptionId = 80,
                    Content = "there is no single most important piece",
                    QuestionId = 20
                },
                new
                {
                    QuestionOptionId = 81,
                    Content = "arsenal",
                    QuestionId = 21
                },
                new
                {
                    QuestionOptionId = 82,
                    Content = "liverpool",
                    QuestionId = 21
                },
                new
                {
                    QuestionOptionId = 83,
                    Content = "man united",
                    QuestionId = 21
                },
                new
                {
                    QuestionOptionId = 84,
                    Content = "chelsea",
                    QuestionId = 21
                },
                new
                {
                    QuestionOptionId = 85,
                    Content = "spain",
                    QuestionId = 22
                },
                new
                {
                    QuestionOptionId = 86,
                    Content = "norway",
                    QuestionId = 22
                },
                new
                {
                    QuestionOptionId = 87,
                    Content = "france",
                    QuestionId = 22
                },
                new
                {
                    QuestionOptionId = 88,
                    Content = "italy",
                    QuestionId = 22
                },
                new
                {
                    QuestionOptionId = 89,
                    Content = "george best",
                    QuestionId = 23
                },
                new
                {
                    QuestionOptionId = 90,
                    Content = "maradona",
                    QuestionId = 23
                },
                new
                {
                    QuestionOptionId = 91,
                    Content = "messi",
                    QuestionId = 23
                },
                new
                {
                    QuestionOptionId = 92,
                    Content = "c. ronaldo",
                    QuestionId = 23
                },
                new
                {
                    QuestionOptionId = 93,
                    Content = "pogba",
                    QuestionId = 24
                },
                new
                {
                    QuestionOptionId = 94,
                    Content = "neymar",
                    QuestionId = 24
                },
                new
                {
                    QuestionOptionId = 95,
                    Content = "mbappe",
                    QuestionId = 24
                },
                new
                {
                    QuestionOptionId = 96,
                    Content = "messi",
                    QuestionId = 24
                },
                new
                {
                    QuestionOptionId = 97,
                    Content = "number 6",
                    QuestionId = 25
                },
                new
                {
                    QuestionOptionId = 98,
                    Content = "number 11",
                    QuestionId = 25
                },
                new
                {
                    QuestionOptionId = 99,
                    Content = "number 2",
                    QuestionId = 25
                },
                new
                {
                    QuestionOptionId = 100,
                    Content = "number 10",
                    QuestionId = 25
                },
                new
                {
                    QuestionOptionId = 101,
                    Content = "maradona",
                    QuestionId = 26
                },
                new
                {
                    QuestionOptionId = 102,
                    Content = "pele",
                    QuestionId = 26
                },
                new
                {
                    QuestionOptionId = 103,
                    Content = "c. ronaldo",
                    QuestionId = 26
                },
                new
                {
                    QuestionOptionId = 104,
                    Content = "george best",
                    QuestionId = 26
                },
                new
                {
                    QuestionOptionId = 105,
                    Content = "3",
                    QuestionId = 27
                },
                new
                {
                    QuestionOptionId = 106,
                    Content = "2",
                    QuestionId = 27
                },
                new
                {
                    QuestionOptionId = 107,
                    Content = "4",
                    QuestionId = 27
                },
                new
                {
                    QuestionOptionId = 108,
                    Content = "5",
                    QuestionId = 27
                },
                new
                {
                    QuestionOptionId = 109,
                    Content = "4",
                    QuestionId = 28
                },
                new
                {
                    QuestionOptionId = 110,
                    Content = "8",
                    QuestionId = 28
                },
                new
                {
                    QuestionOptionId = 111,
                    Content = "16",
                    QuestionId = 28
                },
                new
                {
                    QuestionOptionId = 112,
                    Content = "32",
                    QuestionId = 28
                },
                new
                {
                    QuestionOptionId = 113,
                    Content = "once",
                    QuestionId = 29
                },
                new
                {
                    QuestionOptionId = 114,
                    Content = "2 times",
                    QuestionId = 29
                },
                new
                {
                    QuestionOptionId = 115,
                    Content = "none of the above",
                    QuestionId = 29
                },
                new
                {
                    QuestionOptionId = 116,
                    Content = "3 times",
                    QuestionId = 29
                },
                new
                {
                    QuestionOptionId = 117,
                    Content = "england",
                    QuestionId = 30
                },
                new
                {
                    QuestionOptionId = 118,
                    Content = "spain",
                    QuestionId = 30
                },
                new
                {
                    QuestionOptionId = 119,
                    Content = "italy",
                    QuestionId = 30
                },
                new
                {
                    QuestionOptionId = 120,
                    Content = "brazil",
                    QuestionId = 30
                },
                new
                {
                    QuestionOptionId = 121,
                    Content = "messi",
                    QuestionId = 31
                },
                new
                {
                    QuestionOptionId = 122,
                    Content = "c. ronaldo",
                    QuestionId = 31
                },
                new
                {
                    QuestionOptionId = 123,
                    Content = "pele",
                    QuestionId = 31
                },
                new
                {
                    QuestionOptionId = 124,
                    Content = "maradona",
                    QuestionId = 31
                },
                new
                {
                    QuestionOptionId = 125,
                    Content = "escobar",
                    QuestionId = 32
                },
                new
                {
                    QuestionOptionId = 126,
                    Content = "adam",
                    QuestionId = 32
                },
                new
                {
                    QuestionOptionId = 127,
                    Content = "shawn",
                    QuestionId = 32
                },
                new
                {
                    QuestionOptionId = 128,
                    Content = "maradona",
                    QuestionId = 32
                },
                new
                {
                    QuestionOptionId = 129,
                    Content = "the enforcer",
                    QuestionId = 33
                },
                new
                {
                    QuestionOptionId = 130,
                    Content = "the decision maker",
                    QuestionId = 33
                },
                new
                {
                    QuestionOptionId = 131,
                    Content = "the master",
                    QuestionId = 33
                },
                new
                {
                    QuestionOptionId = 132,
                    Content = "the referee",
                    QuestionId = 33
                },
                new
                {
                    QuestionOptionId = 133,
                    Content = "10",
                    QuestionId = 34
                },
                new
                {
                    QuestionOptionId = 134,
                    Content = "5",
                    QuestionId = 34
                },
                new
                {
                    QuestionOptionId = 135,
                    Content = "11",
                    QuestionId = 34
                },
                new
                {
                    QuestionOptionId = 136,
                    Content = "12",
                    QuestionId = 34
                },
                new
                {
                    QuestionOptionId = 137,
                    Content = "pitch",
                    QuestionId = 35
                },
                new
                {
                    QuestionOptionId = 138,
                    Content = "plains",
                    QuestionId = 35
                },
                new
                {
                    QuestionOptionId = 139,
                    Content = "court",
                    QuestionId = 35
                },
                new
                {
                    QuestionOptionId = 140,
                    Content = "none of the above",
                    QuestionId = 35
                },
                new
                {
                    QuestionOptionId = 141,
                    Content = "china",
                    QuestionId = 36
                },
                new
                {
                    QuestionOptionId = 142,
                    Content = "pakistan",
                    QuestionId = 36
                },
                new
                {
                    QuestionOptionId = 143,
                    Content = "india",
                    QuestionId = 36
                },
                new
                {
                    QuestionOptionId = 144,
                    Content = "brazil",
                    QuestionId = 36
                },
                new
                {
                    QuestionOptionId = 145,
                    Content = "3 years",
                    QuestionId = 37
                },
                new
                {
                    QuestionOptionId = 146,
                    Content = "5 years",
                    QuestionId = 37
                },
                new
                {
                    QuestionOptionId = 147,
                    Content = "2 years",
                    QuestionId = 37
                },
                new
                {
                    QuestionOptionId = 148,
                    Content = "4 years",
                    QuestionId = 37
                },
                new
                {
                    QuestionOptionId = 149,
                    Content = "gold",
                    QuestionId = 38
                },
                new
                {
                    QuestionOptionId = 150,
                    Content = "silver",
                    QuestionId = 38
                },
                new
                {
                    QuestionOptionId = 151,
                    Content = "plastic",
                    QuestionId = 38
                },
                new
                {
                    QuestionOptionId = 152,
                    Content = "bronze",
                    QuestionId = 38
                },
                new
                {
                    QuestionOptionId = 153,
                    Content = "france",
                    QuestionId = 39
                },
                new
                {
                    QuestionOptionId = 154,
                    Content = "mexico",
                    QuestionId = 39
                },
                new
                {
                    QuestionOptionId = 155,
                    Content = "brazil",
                    QuestionId = 39
                },
                new
                {
                    QuestionOptionId = 156,
                    Content = "spain",
                    QuestionId = 39
                },
                new
                {
                    QuestionOptionId = 157,
                    Content = "real madrid",
                    QuestionId = 40
                },
                new
                {
                    QuestionOptionId = 158,
                    Content = "barcelona",
                    QuestionId = 40
                },
                new
                {
                    QuestionOptionId = 159,
                    Content = "AC milan",
                    QuestionId = 40
                },
                new
                {
                    QuestionOptionId = 160,
                    Content = "bayern munich",
                    QuestionId = 40
                }
           );

        }

    }
}
