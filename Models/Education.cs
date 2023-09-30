using System;
namespace PortfolioMe.Models
{
    public class Education
    {
        public string degree { set; get; }
        public string institution { set; get; }
        public string year { set; get; }
        public string group { set; get; }
        public string result { set; get; }

        public Education(string degree, string institution, string year, string group, string result)
        {
            this.degree = degree;
            this.institution = institution;
            this.year = year;
            this.group = group;
            this.result = result;
        }

        public Education()
        {
        }
    }
}

