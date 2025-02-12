using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
	[Table("Condidates")]
	public class Condidate
	{
		private string _name;
		private string _email;
		private int _age;
		private int _stage;
		private double _languageMark;
		private double _frameworkMark;
		private double _algoritmsMark;

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }	

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
		public double LanguageMark { get => _languageMark ; set 
			{
				if (value >= 0 && value <= 5) _languageMark = value;
			} 
		}
		public double AlgoritmsMark { get => _algoritmsMark; set 
			{
				if (value >= 0 && value <= 5) _algoritmsMark = value;
			} 
		}
		public double FrameworkMark { get => _frameworkMark; set 
			{
				if (value >= 0 && value <= 5) _frameworkMark = value;
			} 
		}

		public Identity Pol { get; set; }
		public ITSphere Sphere { get; set; }
		public EducationLevel Education { get; set; }
		public DateTime VisitDate { get; set; }
		public bool HasCourses { get; set; }
		public bool IsOffer { get; set; } = false;

		public Condidate() { }

	}
}
