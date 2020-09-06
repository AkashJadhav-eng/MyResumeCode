using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeProject2.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
        public string CAREEROBJECTIVE { get; set; }
        public MainResume EDUCATION { get; set; }
        public string Certification { get; set; }
        public string Programming_Language { get; set; }
        public string DataBase { get; set; }
        public string Framework_Used { get; set; }
        public string Operating_System { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string PermanentAddress { get; set; }
        public string LanguagesKnown { get; set; }
        public string Hobbies { get; set; }
        public string DECLARATION { get; set; }

    }
}