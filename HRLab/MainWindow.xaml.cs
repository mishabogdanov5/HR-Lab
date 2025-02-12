using System.Globalization;
using System.Printing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HrLab;
using Microsoft.Win32;

namespace LoadDataApp
{
	public partial class MainWindow : Window
	{
		private readonly ApplicationContext _context;
		private readonly ICondidatesRepository _repository;
		public MainWindow()
		{
			InitializeComponent();

			_context = new ApplicationContext();
			_repository = new EFCondidatesRepository(_context);
			SetListView(_repository.ActiveCondidates);
		}

		private void SetListView(IEnumerable<Condidate> condidates) 
		{
			if (CondidatesList != null && CondidatesList.Items != null) CondidatesList.Items.Clear();
			if (condidates != null) 
			{
				foreach (Condidate condidate in condidates) CondidatesList.Items.Add(new ListItem(condidate));
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			_context.Dispose();
			base.OnClosed(e);
		}

		private void AddCondidate(Condidate condidate) 
		{
			CondidatesList.Items.Add(new ListItem(condidate));
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			(new AddNewCondidateWindow(AddCondidate, _repository)).ShowDialog();
		}

		private void SortingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (((ComboBoxItem)SortingComboBox.SelectedItem).Name) 
			{
				case "DateDescending":
					SetListView(_repository.GetActiveCondidatesSortedByVisitDateDescending());
					break;
				case "Date":
					SetListView(_repository?.GetActiveCondidatesSortedByVisitDate());
					break;
				case "Mark":
					SetListView(_repository.GetActiveCondidatesSortedByMark());
					break;
				case "MarkDescending":
					SetListView(_repository.GetActiveCondidatesSortedByMarkDescending());
					break;
				default:
					break;
			}
		}
	}
}