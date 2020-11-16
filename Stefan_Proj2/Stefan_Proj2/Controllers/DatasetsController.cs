using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stefan_Proj2.Data;
using Stefan_Proj2.Models;

namespace Stefan_Proj2.Controllers
{
    public class DatasetsController : Controller
    {
        private readonly TestProject2Context _context;

        public DatasetsController(TestProject2Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index_User()
        {
            return View(await _context.Dataset.ToListAsync());
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Dataset.ToListAsync());
        }

        // GET: Datasets
        public async Task<IActionResult> Index_Default(string Id)
        {
            var User = await _context.AspNetUsers.FindAsync(Id);
            if (Id == "e7c703e5-9657-449c-8c49-d563d6dabfc5")
            {
                return RedirectToAction(nameof(Index));
            }
            else
                if(Id != "e7c703e5-9657-449c-8c49-d563d6dabfc5" && Id != null)
            {
                return RedirectToAction(nameof(Index_User));
            }
            return NotFound();
            /*       var User = await _context.AspNetUsers.FindAsync(Id);
                   if (User == null)
                   {
                       return NotFound();
                   }
                   else
                   if(Id != "e7c703e5-9657-449c-8c49-d563d6dabfc5")
                   {
                       return RedirectToAction(nameof(Index_User));
                   }
               return View(await _context.Dataset.ToListAsync());*/
        }

        // GET: Datasets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataset = await _context.Dataset
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (dataset == null)
            {
                return NotFound();
            }

            return View(dataset);
        }

        // GET: Datasets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Datasets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Dataset dataset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataset);
        }

        // GET: Datasets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataset = await _context.Dataset.FindAsync(id);
            if (dataset == null)
            {
                return NotFound();
            }
            return View(dataset);
        }

        // POST: Datasets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Dataset dataset)
        {
            if (id != dataset.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatasetExists(dataset.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dataset);
        }

        // GET: Datasets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataset = await _context.Dataset
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (dataset == null)
            {
                return NotFound();
            }

            return View(dataset);
        }

        // POST: Datasets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dataset = await _context.Dataset.FindAsync(id);
            _context.Dataset.Remove(dataset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatasetExists(string id)
        {
            return _context.Dataset.Any(e => e.EmployeeNumber == id);
        }
    }
}
