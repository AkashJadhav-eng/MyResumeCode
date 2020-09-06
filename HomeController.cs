using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject2.Models;

namespace ResumeProject2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Resume290820Entities1 db = new Resume290820Entities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Resume()
        {
            List<Detail> det = db.Details.ToList();
            List<SSC> ssc = db.SSCs.ToList();
            List<HSC> hsc = db.HSCs.ToList();
            List<Graduation> gr = db.Graduations.ToList();
            List<TechnicalSkill> te = db.TechnicalSkills.ToList();
            List<Project> pr = db.Projects.ToList();
            List<PersonalDetail> per = db.PersonalDetails.ToList();

            var multipletable = from A in det
                                join B in ssc on A.Id equals B.Id into table1
                                from B in table1.DefaultIfEmpty()
                                join C in hsc on B.Id equals C.Id into table2
                                from C in table2.DefaultIfEmpty()
                                join D in gr on C.Id equals D.Id into table3
                                from D in table3.DefaultIfEmpty()
                                join E in te on D.Id equals E.Id into table4
                                from E in table4.DefaultIfEmpty()
                                join F in pr on E.Id equals F.Id into table5
                                from F in table5.DefaultIfEmpty()
                                join G in per on F.Id equals G.Id into table6
                                from G in table6.DefaultIfEmpty()
                                select new Multipleclass
                                {
                                    detail = A,
                                    ssc = B,
                                    hsc = C,
                                    graduation = D,
                                    technicalskill = E,
                                    project = F,
                                    personaldetail = G
                                };



            return View(multipletable);
            //return View(ssc);
        }

        // DETAILS
        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Details(Detail de)
        {
            Detail Det = new Detail();
            Det.Name = de.Name;
            Det.EmailId = de.EmailId;
            Det.ContactNumber = de.ContactNumber;
            Det.CAREEROBJECTIVE = de.CAREEROBJECTIVE;
            db.Details.Add(Det);
            db.SaveChanges();

            return RedirectToAction("SSC");
        }

        //SSC DETAILS
        [HttpGet]
        public ActionResult SSC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SSC(SSC sc)
        {
            SSC ssc = new SSC();
            ssc.Qualification = sc.Qualification;
            ssc.University = sc.University;
            ssc.Percentage = sc.Percentage;
            ssc.YearOfPassing = sc.YearOfPassing;
            db.SSCs.Add(ssc);
            db.SaveChanges();
            return RedirectToAction("HSC");
        }

        //HSC DETAILS
        [HttpGet]
        public ActionResult HSC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HSC(HSC HS)
        {
            HSC hsc = new HSC();
            hsc.Qualification = HS.Qualification;
            hsc.University = HS.University;
            hsc.Percentage = HS.Percentage;
            hsc.YearOfPassing = HS.YearOfPassing;
            db.HSCs.Add(hsc);
            db.SaveChanges();

            return RedirectToAction("Graduation");
        }

        //Graduation DETAILS

        [HttpGet]
        public ActionResult Graduation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Graduation(Graduation grd)
        {
            Graduation Gr = new Graduation();

            Gr.Qualification = grd.Qualification;
            Gr.University = grd.University;
            Gr.Percentage = grd.Percentage;
            Gr.YearOfPassing = grd.YearOfPassing;
            db.Graduations.Add(Gr);
            db.SaveChanges();
            return RedirectToAction("TechnicalSkills");
        }


        //TechnicalSkills DETAILS
        [HttpGet]
        public ActionResult TechnicalSkills()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TechnicalSkills(TechnicalSkill tec)
        {
            TechnicalSkill tech = new TechnicalSkill();
            tech.Certification = tec.Certification;
            tech.DataBaseUsed = tec.DataBaseUsed;
            tech.FrameworkUsed = tec.FrameworkUsed;
            tech.ProgrammingLanguage = tec.ProgrammingLanguage;
            tech.OperatingSystem = tec.OperatingSystem;
            db.TechnicalSkills.Add(tech);
            db.SaveChanges();
            return RedirectToAction("Project");
        }

        //Project DETAILS
        [HttpGet]
        public ActionResult Project()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Project(Project pr)
        {
            Project pro = new Project();
            pro.ProjectName = pr.ProjectName;
            pro.Description = pr.Description;
            db.Projects.Add(pro);
            db.SaveChanges();
            return RedirectToAction("PersonalDetails");
        }

        //PersonalDetails DETAILS
        [HttpGet]
        public ActionResult PersonalDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonalDetails(PersonalDetail pd)
        {
            PersonalDetail ped = new PersonalDetail();
            ped.FullName = pd.FullName;
            ped.DOB = pd.DOB;
            ped.PermanentAddress = pd.PermanentAddress;
            ped.LanguagesKnown = pd.LanguagesKnown;
            ped.Hobbies = pd.Hobbies;
            ped.DECLARATION = pd.DECLARATION;

            db.PersonalDetails.Add(ped);
            db.SaveChanges();


            return RedirectToAction("Resume");
        }



    }
}