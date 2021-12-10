//using System;

//namespace project01
//{
//    class IfStmtChallenge2
//    {
//        static int highscore = 300;
//        static string highscorePlayer = "Chris";

//        static void Main(string[] args)
//        {
//            HighestScore(220, "Maria");
//            HighestScore(320, "Chuck");
//            HighestScore(360, "Chris");

//            Console.Read();
//        }

//        public static void HighestScore(int score, string playerName)
//        {
//            if (score > highscore)
//            {
//                Console.WriteLine("New high score is " + score);
//                Console.WriteLine("New high score holder is " + playerName);
//            }
//            else
//            {
//                Console.WriteLine("The old high score of " + highscore + " could not be broken and is still held by " + highscorePlayer);
//            }
//        }
//    }
//}