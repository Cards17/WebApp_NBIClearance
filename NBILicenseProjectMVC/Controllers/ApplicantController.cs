using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NBILicenseProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace NBILicenseProjectMVC.Controllers
{
    public class ApplicantController : Controller
    {
        //private readonly CustomerDbContext _context;
        private readonly IConfiguration _config;
        //private readonly IWebHostEnvironment _webHostingEnviroment;
        private readonly string _apiUrl;
        public static HttpClient Client = null;

        public ApplicantController(IConfiguration config)
        {
            //_context = context;
            _config = config;
            _apiUrl = _config.GetValue<string>("WebApiUrl");
            if (Client == null)
            {
                Client = new HttpClient();
                Client.Timeout = TimeSpan.FromSeconds(_config.GetValue<int>("WebApiTimeOut"));
                Client.BaseAddress = new Uri(_apiUrl);

            }

        }

        // GET: Applicant
        public async Task<IActionResult> Index(string searchBy, string searchValue, string sortOrder)
        {
            
            IList<Applicant> listapplicants = null;
            try
            {
                var responseTask = Client.GetAsync("api/Applicant");
                responseTask.Wait();
                var result = responseTask.Result;


                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Applicant>>();
                    readTask.Wait();
                    listapplicants = readTask.Result;
                }

            }
            catch (Exception ex)
            {
                return View("BadRequest");
            }

            //Search functionalities

            try
            {
                if (listapplicants.Count == 0)
                {
                    TempData["InfoMessage"] = "Your database has no entry data.";
                }
                else
                {
                    if (string.IsNullOrEmpty(searchValue))
                    {
                        TempData["InfoMessage"] = "PLease provide search value";
                        return View(listapplicants);
                    }
                    else
                    {
                        if (searchBy.ToLower() == "firstname")
                        {
                            var searchAuthorName = listapplicants.Where(x => x.Firstname.ToLower().Contains(searchValue.ToLower()));
                            return View(searchAuthorName);
                        }
                        else if (searchBy.ToLower() == "lastname")
                        {
                            var searchTitle = listapplicants.Where(x => x.Lastname.ToLower().Contains(searchValue.ToLower()));
                            return View(searchTitle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return View("BadRequest");
            }
            
            //Sort

            try 
            {
                ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Lastname" : "";
                SortFilter sortFilter = new SortFilter();

                if (sortFilter.sortBy == "Lastname")
                {
                    var sortlastname = listapplicants.Where(x => x.Lastname.StartsWith(sortOrder));
                    sortlastname.OrderBy(x => x.Lastname);
                    return View(sortlastname.ToList());
                }
                
            }
         
            catch (Exception ex)
            {
                return View("BadRequest");
            }

           return View(listapplicants);
        }


        // GET: Applicant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("NotFound", id.Value);
            }

            var applicant = GetApplicant(id.Value);
            if (applicant == null)
            {
                return View("NotFound", id.Value);
            }

            return View(applicant);
        }

        // GET: Applicant/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applicant/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BranchName,Date,ValidId,ApplicantPicture,Lastname,Firstname,Middlename,Birthdate,Gender,CivilStatus,EducationalAttainment,LandlineNumber,MobileNumber,EmailAddress,Complexion,Peculiarities,Religion,Height,Weight,HusbandOrWifeName,FatherName,FatherBirthplace,MotherName,MotherBirthplace")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                var responseTask = Client.PostAsJsonAsync("api/Applicant", applicant);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(applicant);
        }

        // GET: Applicant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound", id.Value);
            }

            var applicant = GetApplicant(id.Value);
            if (applicant == null)
            {
                return View("NotFound", id.Value);
            }
            return View(applicant);
        }

        // POST: Applicant/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BranchName,Date,ValidId,ApplicantPicture,Lastname,Firstname,Middlename,Birthdate,Gender,CivilStatus,EducationalAttainment,LandlineNumber,MobileNumber,EmailAddress,Complexion,Peculiarities,Religion,Height,Weight,HusbandOrWifeName,FatherName,FatherBirthplace,MotherName,MotherBirthplace")] Applicant applicant)
        {
            if (id != applicant.Id)
            {
                //return NotFound();
                return View("NotFound", id);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(applicant);
                    //await _context.SaveChangesAsync();
                    //HTTP GET
                    var responseTask = Client.PutAsJsonAsync($"api/Applicant/{id}", applicant);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        Response.StatusCode = 404;
                        return View("NotFound", id);
                    }
                }
                catch (Exception ex)
                {
                    Response.StatusCode = 400;
                    return View("BadRequest");
                }  
            }
            return View(applicant);
        }

        // GET: Applicant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("NotFound", id.Value);
            }

            var applicant = GetApplicant(id.Value);
            if (applicant == null)
            {
                Response.StatusCode = 404;
                return View("NotFound", id.Value);
            }

            return View(applicant);
        }

        // POST: Applicant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try 
            {
                var responseTask = Client.DeleteAsync($"api/Applicant/{id}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
                return View("BadRequest");
            }
            return RedirectToAction(nameof(Delete), id);


        }

        //private bool ApplicantExists(int id)
        //{
        //    return _context.Applicant.Any(e => e.Id == id);
        //}

        private Applicant GetApplicant(int id)
        {
            Applicant applicant = null;
            var responseTask = Client.GetAsync($"api/Applicant/{id}");
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Applicant>();
                readTask.Wait();
                applicant = readTask.Result;
            }
            return applicant;
        }
    }
}
