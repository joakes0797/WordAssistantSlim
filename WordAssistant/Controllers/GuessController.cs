using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WordAssistant.Models;

namespace WordAssistant.Controllers
{
    public class GuessController : Controller
    {
        private readonly IGuessService service;

        public GuessController(IGuessService service)
        {
            this.service = service;
        }
        public IActionResult GuessCheck(GuessViewModel answer)
        {
            var results = service.GetResults(answer.B01, answer.B02, answer.B03, answer.B04, answer.B05, answer.B06, answer.B07, answer.B08, answer.B09, answer.B10, answer.B11, answer.B12, answer.B13, answer.B14, answer.B15, answer.B16, answer.B17, answer.B18, answer.B19, answer.B20);
            var count = results.Count();
            var viewModel = new ResultViewModel();

            if (count == 1)
            {
                viewModel.TableHeadMessage = "Best result";
            }
            else if (count == 0)
            {
                viewModel.TableHeadMessage = "No results found.";
            }
            else
            {
                viewModel.TableHeadMessage = $"{count} Potential Answers";
            }

            viewModel.Words = results;
            return View("../Home/Results", viewModel);
        }
    }
}
