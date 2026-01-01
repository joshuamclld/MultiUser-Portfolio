// My Personal Portfolio's Main Controller
// This controller is responsible for showing my main homepage.

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using MultiUser_Portfolio.Data;
using MultiUser_Portfolio.Models;

namespace MultiUser_Portfolio.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _logger = logger;
        _context = context;
        _userManager = userManager;
    }

    // This is the main action for my portfolio.
    // It gathers all my information from the database and puts it into a single view model.
    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);

        var viewModel = new PortfolioViewModel
        {
            Profile = await _context.Profiles.FirstOrDefaultAsync(p => p.UserId == userId),
            About = await _context.Abouts.FirstOrDefaultAsync(a => a.UserId == userId),
            Experiences = await _context.Experiences.Where(e => e.UserId == userId).OrderByDescending(e => e.StartDate).ToListAsync(),
            Projects = await _context.Projects.Where(p => p.UserId == userId).ToListAsync(),
            Contact = await _context.Contacts.FirstOrDefaultAsync(c => c.UserId == userId),
            Skills = await _context.Skills.Where(s => s.UserId == userId).ToListAsync(),
            SocialLinks = await _context.SocialLinks.Where(s => s.UserId == userId).ToListAsync(),
            Educations = await _context.Educations.Where(e => e.UserId == userId).OrderByDescending(e => e.StartDate).ToListAsync(),
            Services = await _context.Services.Where(s => s.UserId == userId).ToListAsync()
        };
        return View(viewModel);
    }

    // This is the standard privacy page.
    public IActionResult Privacy()
    {
        return View();
    }

    // This is the standard error page.
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
