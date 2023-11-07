namespace TestingPassord
{
	public class UnitTest1
	{
		
	}
	internal class RegisterViewModel
	{
		internal bool IsPasswordSecure(string password)
		{
			if (password.Length < 8)
			{
				return false;
			}

			if (!ContieneMayuscula(password))
			{
				return false;
			}

			if (!ContieneSimbolo(password))
			{
				return false;
			}

			return true;
		}

		private bool ContieneMayuscula(string password)
		{
			return password.Any(c => Char.IsLetter(c) && Char.IsUpper(c));
		}

		private bool ContieneSimbolo(string password)
		{
			return password.Any(c => Char.IsSymbol(c) || (Char.IsWhiteSpace(c) && !Char.IsLetterOrDigit(c)));
		}
	}
}