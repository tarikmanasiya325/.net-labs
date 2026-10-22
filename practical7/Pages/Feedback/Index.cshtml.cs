using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FeedbackEntry = Practical7_MVC.Models.Feedback;

namespace practical7.Pages.Feedback;

public class IndexModel : PageModel
{
    private static readonly List<FeedbackEntry> FeedbackList = [];
    private static int _nextId = 1;

    [BindProperty]
    public FeedbackEntry Feedback { get; set; } = new();

    public IReadOnlyList<FeedbackEntry> SubmittedFeedback => FeedbackList;

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Feedback.Id = _nextId++;
        FeedbackList.Add(Feedback);
        return RedirectToPage();
    }
}
