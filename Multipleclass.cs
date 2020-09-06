using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeProject2.Models
{
    public class Multipleclass
    {
        public Detail detail { get; set; }
        public SSC ssc { get; set; }
        public HSC hsc { get; set; }
        public Graduation graduation { get; set; }
        public TechnicalSkill technicalskill { get; set; }
        public Project project { get; set; }
        public PersonalDetail personaldetail { get; set; }
    }
}