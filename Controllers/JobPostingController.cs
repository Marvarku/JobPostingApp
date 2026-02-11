using Microsoft.AspNetCore.Mvc;
using JobPostingApp.Models;

namespace JobPostingApp.Controllers;

public class JobPostingController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        var model = new JobPostingFormViewModel
        {
            ContractType = "Permanent",
            WorkScope = "Fulltime",
            GermanLevel = "B2"
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Create(JobPostingFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        // Backend persistence will be added later.
        ViewBag.Message = "Form submitted (not yet saved). / Formular gesendet (noch nicht gespeichert).";
        return View(model);
    }
}

