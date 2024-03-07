using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Project.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job job)
        { 
            jobManager.TInsert(job);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.TGetById(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            jobManager.TUpdate(job);
            return RedirectToAction("Index");
        }
    }
}
