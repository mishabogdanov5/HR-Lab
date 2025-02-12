using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using LoadDataApp;

namespace HrLab
{
	public interface ICondidatesRepository
	{
		public IEnumerable<Condidate> Condidates { get;  }
		public IEnumerable<Condidate> OfferCondidates { get; }
		public IEnumerable<Condidate> ActiveCondidates { get; }
		public void Add(Condidate condidate);
		public bool Remove(Condidate condidate);
		public bool RemoveById(int id);
		public bool RemoveFromActiveById(int id);
		public Condidate? GetCondidateById(int id);
		public Condidate? GetActiveCondidateById(int id);
		public IEnumerable<Condidate> GetActiveCondidatesSortedByMarkDescending();
		public IEnumerable<Condidate> GetActiveCondidatesSortedByMark();
		public IEnumerable<Condidate> GetActiveCondidatesSortedByVisitDateDescending();
		public IEnumerable<Condidate> GetActiveCondidatesSortedByVisitDate();
	}
}
