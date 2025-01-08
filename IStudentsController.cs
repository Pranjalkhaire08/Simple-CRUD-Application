using Microsoft.AspNetCore.Mvc;
using StudentPortal.Web.Models;

namespace StudentPortal.Web.Controllers
{
    public interface IStudentsController
    {
        IActionResult Add();
        Task<IActionResult> Add(AddStudentViewModel viewModel);
        Task<IActionResult> List();
    }
}