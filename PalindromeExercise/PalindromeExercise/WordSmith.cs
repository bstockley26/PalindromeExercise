using System;
using System.Collections.Generic;
using System.Linq;
namespace PalindromeExercise
{
	public class WordSmith
	{
		

        public bool IsAPalindrome(string word)
		{
			var reversed = "";

			for (int i=word.Length-1;i>=0; i--)
			{
				reversed += word[i];
			}

			if (word.ToLower() == reversed.ToLower())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

