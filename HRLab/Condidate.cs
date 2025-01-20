using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using HrLab;

namespace LoadDataApp
{
	public class Condidate
	{
		private string _name;
		private string _email;
		private int _age;
		private int _stage;

		public string Name { get => _name; set
			{
				if (string.IsNullOrEmpty(value) || value.Length > 60 || value.Length < 2) return;
				_name = value;
			}
		}
		public string Email { get => _email; set
			{
				Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
				if (regex.IsMatch(value)) _email = value;
			} 
		}
		public int Age { get => _age; set
			{
				if (value < 16 || value > 70) return;
				_age = value;
			}
		}
		public int Stage { get => _stage; set
			{
				if (value < 0 || value > 55) return;
				_stage = value;
			}
		}

		public Identity Pol { get; set; }
		public ITSphere Sphere { get; set; }
		public EducationLevel Education { get; set; }
		public DateTime VisitDate { get; set; }
		public VisitMark Mark { get; set; }
		public bool HasCourses { get; set; }

		public Condidate() { }

	}
}
