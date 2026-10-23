using CalculatesInterest.Interfaces;

namespace CalculatesInterest.Services
{
	public class ShowMeTheCodeService : IShowMeTheCodeService
	{
		#region Constructor
		public ShowMeTheCodeService()
		{

		}

		#endregion

		#region Public Methods
		public string GetUrlSourceCode()
		{
			string sourceCode = "https://github.com/ggrubler/CalculatesInterest";

			return sourceCode;
		}

		#endregion

	}
}
