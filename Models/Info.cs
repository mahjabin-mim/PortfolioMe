using System;
namespace PortfolioMe.Models
{
	public class Info
	{
		public string name { set; get; }
        public string id { set; get; }
		public string email { set; get; }
		public string contact { set; get; }

        public Info(string name, string id, string email,string contact)
        {
			this.name = name;
			this.id = id;
			this.email = email;
			this.contact = contact;
        }
        public Info()
		{	
		}
	}
}

