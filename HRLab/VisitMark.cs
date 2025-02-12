using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataApp
{
	public class VisitMark
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public Condidate CurrentCondidate { get; set; }	
		public double LanguageMark { get; set; }
		public double AlgoritmsMark { get; set; }
		public double FrameworkMark { get; set; }

		public VisitMark(double languageMark, double algoritmsMark, double frameworkMark) 
		{
			if (IsMarkValid(languageMark)) LanguageMark = languageMark;
			if (IsMarkValid(algoritmsMark)) AlgoritmsMark = algoritmsMark;
			if (IsMarkValid(frameworkMark)) FrameworkMark = frameworkMark;
		}

		private bool IsMarkValid(double mark) 
		{
			return (mark >= 0) && (mark <= 5); 
		}
	}
}
