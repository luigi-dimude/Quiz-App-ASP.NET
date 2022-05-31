using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Assignment_04.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserScores",
                columns: table => new
                {
                    UserScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizId = table.Column<int>(type: "int", nullable: true),
                    QuizTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlayerScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScores", x => x.UserScoreId);
                    table.ForeignKey(
                        name: "FK_UserScores_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                columns: table => new
                {
                    QuestionOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptions", x => x.QuestionOptionId);
                    table.ForeignKey(
                        name: "FK_QuestionOptions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizId", "Description", "Name" },
                values: new object[] { 1, "Fun quiz on chess!", "Chess Quiz" });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizId", "Description", "Name" },
                values: new object[] { 2, "How much do you really know about the most popular sport in the world?", "Soccer Quiz" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Content", "QuizId" },
                values: new object[,]
                {
                    { 1, "64", "What is the total number of squares on a chess board?", 1 },
                    { 38, "gold", "The world cup trophy is made of?", 2 },
                    { 21, "arsenal", "Soccer made its television debut in 1937, featuring what team in england", 2 },
                    { 22, "norway", "What team has never lost to Brzil in international competition", 2 },
                    { 23, "c. ronaldo", "the only known football player in professional history to score a goal in every single minute of a match?", 2 },
                    { 24, "neymar", "The most expensive transfer in soccer history was by which players", 2 },
                    { 25, "number 10", "What number is unofficially considered the kit number for the best player on a squad", 2 },
                    { 26, "pele", "What player has won the most world cups", 2 },
                    { 40, "real madrid", "What team has won the most champions league?", 2 },
                    { 27, "3", "Hat-trick is when a player scores how many goals?", 2 },
                    { 29, "2 times", "How many times has france won the world cup", 2 },
                    { 30, "england", "What country created the first professional league", 2 },
                    { 31, "messi", "Which player has the most ballon d'or", 2 },
                    { 32, "escobar", "What player scored an own goal for Columbia in the 1994 World Cup?", 2 },
                    { 33, "the referee", "The person who controls the match and enforces the laws of the game is?", 2 },
                    { 34, "11", "There are how many players on a soccer team", 2 },
                    { 35, "pitch", "A soccer field is also called a?", 2 },
                    { 28, "8", "How many countries have won the world cup", 2 },
                    { 39, "mexico", "The only country to host the world cup twice?", 2 },
                    { 20, "the king", "What is the most important piece in chess", 1 },
                    { 19, "the queen", "What is the strongest piece in chess", 1 },
                    { 2, "modern", "Which of the following is not a format of a chess game", 1 },
                    { 3, "grand master", "What is the highest title for professional chess players?", 1 },
                    { 4, "castles", "What is the other name for the rooks?", 1 },
                    { 5, "game theory", "Strategies in chess are used by economists as a basis for which theory?", 1 },
                    { 6, "russia", "Which country has the most grandmasters?", 1 },
                    { 7, "magnus carlsen", "Who is the current world chess champion?", 1 },
                    { 8, "risks one or more pawns or a minor piece to gain an advantage in position", "What is a gambit in chess?", 1 },
                    { 9, "deep blue", "What is the name of the computer which defeated the former world champion Garry Kasparov?", 1 },
                    { 10, "19th", "What century did the modern rules for chess standardised?", 1 },
                    { 11, "pawns", "Which piece can only move in a forward direction?", 1 },
                    { 12, "2500", "To be awarded the Grandmaster title, a player must have at least how many points in the ELO rating?", 1 },
                    { 13, "5949 moves", "The longest chess game theoretically possible is?", 1 },
                    { 14, "the king is dead", "The word checkmate is derived from the Arabic word shah mat, which means", 1 },
                    { 15, "1090", "The modern chess board as we see it today appeared first in Europe in the year", 1 },
                    { 16, "rookies", "Players in their first year are called", 1 },
                    { 17, "game of kings", "Chess is also called the?", 1 },
                    { 18, "L shape", "Knights move in what shape?", 1 },
                    { 36, "pakistan", "It is estimated that 55 percent of all footballs are created in what country", 2 },
                    { 37, "4 years", "The world cup takes place every?", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserScores",
                columns: new[] { "UserScoreId", "FirstName", "LastName", "PlayerName", "PlayerScore", "QuizId", "QuizTime" },
                values: new object[,]
                {
                    { 2, "John", "Smith", "John", 40.0, 1, new DateTime(2020, 12, 19, 5, 10, 20, 0, DateTimeKind.Unspecified) },
                    { 1, "Joshua", "Giggs", "ChessWiz94", 90.0, 1, new DateTime(2021, 12, 4, 0, 10, 4, 377, DateTimeKind.Local).AddTicks(5320) }
                });

            migrationBuilder.InsertData(
                table: "UserScores",
                columns: new[] { "UserScoreId", "FirstName", "LastName", "PlayerName", "PlayerScore", "QuizId", "QuizTime" },
                values: new object[] { 3, "James", "Sion", "Qwerty", 50.0, 1, new DateTime(2019, 11, 21, 5, 10, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserScores",
                columns: new[] { "UserScoreId", "FirstName", "LastName", "PlayerName", "PlayerScore", "QuizId", "QuizTime" },
                values: new object[] { 4, "Phil", "Scott", "Firmino9", 100.0, 2, new DateTime(2021, 10, 22, 5, 10, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "QuestionOptionId", "Content", "QuestionId" },
                values: new object[,]
                {
                    { 1, "62", 1 },
                    { 103, "c. ronaldo", 26 },
                    { 104, "george best", 26 },
                    { 105, "3", 27 },
                    { 106, "2", 27 },
                    { 107, "4", 27 },
                    { 108, "5", 27 },
                    { 109, "4", 28 },
                    { 102, "pele", 26 },
                    { 110, "8", 28 },
                    { 112, "32", 28 },
                    { 113, "once", 29 },
                    { 114, "2 times", 29 },
                    { 115, "none of the above", 29 },
                    { 116, "3 times", 29 },
                    { 117, "england", 30 },
                    { 118, "spain", 30 },
                    { 111, "16", 28 },
                    { 119, "italy", 30 },
                    { 101, "maradona", 26 },
                    { 99, "number 2", 25 },
                    { 83, "man united", 21 },
                    { 84, "chelsea", 21 },
                    { 85, "spain", 22 },
                    { 86, "norway", 22 },
                    { 87, "france", 22 },
                    { 88, "italy", 22 },
                    { 89, "george best", 23 },
                    { 100, "number 10", 25 },
                    { 90, "maradona", 23 },
                    { 92, "c. ronaldo", 23 },
                    { 93, "pogba", 24 },
                    { 94, "neymar", 24 },
                    { 95, "mbappe", 24 },
                    { 96, "messi", 24 },
                    { 97, "number 6", 25 },
                    { 98, "number 11", 25 },
                    { 91, "messi", 23 },
                    { 82, "liverpool", 21 },
                    { 120, "brazil", 30 },
                    { 122, "c. ronaldo", 31 },
                    { 143, "india", 36 }
                });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "QuestionOptionId", "Content", "QuestionId" },
                values: new object[,]
                {
                    { 144, "brazil", 36 },
                    { 145, "3 years", 37 },
                    { 146, "5 years", 37 },
                    { 147, "2 years", 37 },
                    { 148, "4 years", 37 },
                    { 149, "gold", 38 },
                    { 142, "pakistan", 36 },
                    { 150, "silver", 38 },
                    { 152, "bronze", 38 },
                    { 153, "france", 39 },
                    { 154, "mexico", 39 },
                    { 155, "brazil", 39 },
                    { 156, "spain", 39 },
                    { 157, "real madrid", 40 },
                    { 158, "barcelona", 40 },
                    { 151, "plastic", 38 },
                    { 121, "messi", 31 },
                    { 141, "china", 36 },
                    { 139, "court", 35 },
                    { 123, "pele", 31 },
                    { 124, "maradona", 31 },
                    { 125, "escobar", 32 },
                    { 126, "adam", 32 },
                    { 127, "shawn", 32 },
                    { 128, "maradona", 32 },
                    { 129, "the enforcer", 33 },
                    { 140, "none of the above", 35 },
                    { 130, "the decision maker", 33 },
                    { 132, "the referee", 33 },
                    { 133, "10", 34 },
                    { 134, "5", 34 },
                    { 135, "11", 34 },
                    { 136, "12", 34 },
                    { 137, "pitch", 35 },
                    { 138, "plains", 35 },
                    { 131, "the master", 33 },
                    { 81, "arsenal", 21 },
                    { 80, "there is no single most important piece", 20 },
                    { 79, "none of the above", 20 },
                    { 22, "russia", 6 },
                    { 23, "norway", 6 },
                    { 24, "india", 6 }
                });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "QuestionOptionId", "Content", "QuestionId" },
                values: new object[,]
                {
                    { 25, "magnus carlsen", 7 },
                    { 26, "wesley so", 7 },
                    { 27, "garry kasparov", 7 },
                    { 28, "fabiano caruana", 7 },
                    { 21, "usa", 6 },
                    { 29, "risks one or more pawns or a minor piece to gain an advantage in position", 8 },
                    { 31, "none of the above", 8 },
                    { 32, "sacrificing a pawn", 8 },
                    { 33, "deep red", 9 },
                    { 34, "deep fake", 9 },
                    { 35, "deep AI", 9 },
                    { 36, "deep blue", 9 },
                    { 37, "16th", 10 },
                    { 30, "sacrficing a bishop", 8 },
                    { 38, "19th", 10 },
                    { 20, "game theory", 5 },
                    { 18, "classical economics", 5 },
                    { 2, "64", 1 },
                    { 3, "54", 1 },
                    { 4, "52", 1 },
                    { 5, "rapid", 2 },
                    { 6, "classical", 2 },
                    { 7, "blitz", 2 },
                    { 8, "modern", 2 },
                    { 19, "macro economics", 5 },
                    { 9, "international master", 3 },
                    { 11, "grand master", 3 },
                    { 12, "chess expert", 3 },
                    { 13, "knights", 4 },
                    { 14, "crowns", 4 },
                    { 15, "castles", 4 },
                    { 16, "bishops", 4 },
                    { 17, "economist theory", 5 },
                    { 10, "chess master", 3 },
                    { 39, "20th", 10 },
                    { 40, "13th", 10 },
                    { 41, "minions", 11 },
                    { 63, "noobs", 16 },
                    { 64, "newbies", 16 },
                    { 65, "game of kings", 17 },
                    { 66, "game of the people", 17 },
                    { 67, "game of the youth", 17 }
                });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "QuestionOptionId", "Content", "QuestionId" },
                values: new object[,]
                {
                    { 68, "game of the holy", 17 },
                    { 69, "S shape", 18 },
                    { 62, "amateurs", 16 },
                    { 70, "Z shape", 18 },
                    { 72, "L shape", 18 },
                    { 73, "the king", 19 },
                    { 74, "the queen", 19 },
                    { 75, "the pawn", 19 },
                    { 76, "the knight", 19 },
                    { 77, "the king", 20 },
                    { 78, "the queen", 20 },
                    { 71, "none of the above", 18 },
                    { 61, "rookies", 16 },
                    { 60, "1090", 15 },
                    { 59, "900", 15 },
                    { 42, "bishop", 11 },
                    { 43, "rooks", 11 },
                    { 44, "pawns", 11 },
                    { 45, "2500", 12 },
                    { 46, "2000", 12 },
                    { 47, "2800", 12 },
                    { 48, "2300", 12 },
                    { 49, "5949 moves", 13 },
                    { 50, "5749 moves", 13 },
                    { 51, "1820 moves", 13 },
                    { 52, "6000 moves", 13 },
                    { 53, "i got your king", 14 },
                    { 54, "it is over", 14 },
                    { 55, "game over", 14 },
                    { 56, "the king is dead", 14 },
                    { 57, "2000", 15 },
                    { 58, "1000", 15 },
                    { 159, "AC milan", 40 },
                    { 160, "bayern munich", 40 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScores_QuizId",
                table: "UserScores",
                column: "QuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionOptions");

            migrationBuilder.DropTable(
                name: "UserScores");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
