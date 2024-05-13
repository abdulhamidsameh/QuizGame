namespace QuizGame
{
	internal class Program
	{
		private static bool IsAnswerCorrect(string UserAnswer, string CorrectAnswer)
			=> UserAnswer.ToLower() == CorrectAnswer.ToLower();

		static void Main(string[] args)
		{
			int Marks = 0;
			string[] Questions =
			{
				"1- What Is The Capital Of Italy?",
				"1- What Is The Red Planet?",
				"1- What Is The Largest Aniaml?",
			};
			string[] Answers =
			{
				"Roma",
				"Mars",
				"Whale"
			};
			Console.WriteLine("Welcome Into Our Quiz Game");
			Console.WriteLine("***************************");
			for (int i = 0; i < Questions.Length; i++)
			{
				Console.Write($"{Questions[i]}: ");
				string UserAnswer = Console.ReadLine()!;
				if (string.IsNullOrEmpty(UserAnswer))
				{
					Console.WriteLine("The Answer Must Not A Empty Or Null");
				}
				else
				{
					if (IsAnswerCorrect(Answers[i], UserAnswer))
					{
						Console.WriteLine("Congratulation The Answer is Correct");
						Marks++;
					}
					else
					{
						Console.WriteLine($"Sorry For You The Answer Is Wrong. The Correct Answer Is {Answers[i]}");
					}
				}
			}
			Console.WriteLine("The Quiz Is Ended");
			Console.WriteLine($"Your Mark Is {Marks} From {Questions.Length}");
		}
	}
}
