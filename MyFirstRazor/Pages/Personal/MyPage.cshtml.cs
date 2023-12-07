using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Services;
using Models;

namespace MyFirstRazor.Pages
{
	public class vwmMyPage : PageModel
    {
        ICoolLists _service = null;

        public string Greetings { get; set; } = "Hello everyone";
        public List<csLatinSentence> Latin { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Martins page";
            Latin = _service.LatinSentences.Take(5).ToList();
        }

        public vwmMyPage(ICoolLists service)
        {
            _service = service;
        }
    }
}

