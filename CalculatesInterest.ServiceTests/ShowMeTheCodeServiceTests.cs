using CalculatesInterest.Interfaces;
using CalculatesInterest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatesInterest.ServiceTests
{
	public class ShowMeTheCodeServiceTests
	{
		[Fact]
		private void CheckIfUrlIsCorrect()
		{
			IShowMeTheCodeService service = new ShowMeTheCodeService();

			string expectedSourceCode = "https://github.com/ggrubler/CalculatesInterest";

			string actualSourceCode = service.GetUrlSourceCode();

			Assert.Equal(expectedSourceCode, actualSourceCode);
		}
	}
}
