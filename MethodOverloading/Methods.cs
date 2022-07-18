using System;
namespace MethodOverloading
{
	public class Methods
	{
		public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}

		public static decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}

		//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
		//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
		public static string Add(int num1, int num2, bool isTrue)
		{
			int sum = num1 + num2;
			string result = "";
			if (isTrue == true)
			{
				if (sum == 1)
				{
					result = "1 dollar";
				}
				else
				{
					result = $"{sum} dollars";
				}
			}
			else
			{
				result = "";
			}
			return result;
		}
	}
}

