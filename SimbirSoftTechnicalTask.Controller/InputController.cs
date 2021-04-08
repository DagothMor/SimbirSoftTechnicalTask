namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Checking console input for different variables.
	/// </summary>
	public static class InputController
	{
		public static bool CheckForNullEmptyOrWhiteSpace(string input)
		{
			if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
			{
				return true;
			}
			return false;
		}
	}

}
