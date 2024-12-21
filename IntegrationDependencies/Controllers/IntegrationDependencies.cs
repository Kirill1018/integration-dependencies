using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntegrationDependencies.Controllers
{
	public class IntegrationDependencies : Controller
	{
		private readonly ILogger<IntegrationDependencies> _logger;

		public IntegrationDependencies(ILogger<IntegrationDependencies> logger)
		{
			_logger = logger;
		}

		public IActionResult Dependencies()
		{
			Chessboard chessboard = new Chessboard();
			var blackCell = chessboard.BlackCell;
			var whiteCell = chessboard.WhiteCell;
			blackCell.Draw();
			whiteCell.Draw();
			string? whiteCol = whiteCell.Color, blackCol = blackCell.Color;
			ViewData["whiteFlow"] = whiteCol;
			ViewData["blackFlow"] = blackCol;
			return View();
		}
	}
}