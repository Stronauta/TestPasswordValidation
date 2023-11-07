namespace TestingPassord
{
	public class UnitTest1
	{
		[Fact]
		public void IsPasswordSecure_returns_false_if_password_has_less_than_8_characters()
		{
			//Arrange
			var registerViewModel = new RegisterViewModel();

			//Act
			bool result = registerViewModel.IsPasswordSecure("1234567");

			//Assert
			Assert.False(result);
		}

		[Fact]
		public void IsPasswordSecure_returns_false_if_password_does_not_contains_uppercase_character()
		{
			//Arrange
			var registerViewModel = new RegisterViewModel();

			//Act
			bool result = registerViewModel.IsPasswordSecure("12345678a");

			//Assert
			Assert.False(result);
		}

		[Fact]
		public void IsPasswordSecure_returns_false_if_password_does_not_contains_symbol()
		{
			//Arrange
			var registerViewModel = new RegisterViewModel();

			//Act
			bool result = registerViewModel.IsPasswordSecure("12345678");

			//Assert
			Assert.False(result);
		}
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