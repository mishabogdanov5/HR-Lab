using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadDataApp;
using Microsoft.EntityFrameworkCore;

namespace HrLab
{
	public class EFCondidatesRepository : ICondidatesRepository
	{
		private ApplicationContext _context;

		public EFCondidatesRepository(ApplicationContext context)
		{
			_context = context;
		}
		public IEnumerable<Condidate> Condidates => _context.Condidates;
		public IEnumerable<Condidate> ActiveCondidates => Condidates.Where(cond => !cond.IsOffer);

		public IEnumerable<Condidate> OfferCondidates => Condidates.Where(cond => cond.IsOffer);

		public void Add(Condidate condidate)
		{
			_context.Condidates.Add(condidate);
			_context.SaveChanges();
		}
		public bool Remove(Condidate condidate)
		{
			return Condidates.ToList().Remove(condidate);
		}

		public IEnumerable<Condidate> GetActiveCondidatesSortedByMarkDescending() 
		{
			return ActiveCondidates
				.OrderByDescending(cond => (cond.FrameworkMark + cond.LanguageMark + cond.AlgoritmsMark)/3);
		}

		public IEnumerable<Condidate> GetActiveCondidatesSortedByVisitDateDescending()
		{
			return ActiveCondidates
				.OrderByDescending(cond => cond.VisitDate);
		}

		public IEnumerable<Condidate> GetActiveCondidatesSortedByMark()
		{
			return ActiveCondidates
				.OrderBy(cond => (cond.FrameworkMark + cond.LanguageMark + cond.AlgoritmsMark) / 3);
		}

		public IEnumerable<Condidate> GetActiveCondidatesSortedByVisitDate()
		{
			return ActiveCondidates
				.OrderBy(cond => cond.VisitDate);
		}

		public Condidate? GetCondidateById(int id)
		{
			return Condidates.FirstOrDefault(cond => cond.Id == id);
		}

		public Condidate? GetActiveCondidateById(int id)
		{
			return ActiveCondidates.FirstOrDefault(cond => cond.Id == id);
		}

		public bool RemoveById(int id)
		{
			if (GetCondidateById(id) != null) return Remove(GetCondidateById(id)!);
			return false;
		}

		public bool RemoveFromActiveById(int id)
		{
			Condidate? condidate = ActiveCondidates.FirstOrDefault(cond => cond.Id == id);

			if (condidate != null) 
			{ 
				condidate.IsOffer = true; 
				return true; 
			}

			return false;
		}
	}
}
