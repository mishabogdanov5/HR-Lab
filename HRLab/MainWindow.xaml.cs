using System.Globalization;
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

namespace LoadDataApp
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

		}

		private void AddCondidate(Condidate condidate) 
		{
			CondidatesList.Items.Add(new ListItem(condidate));
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			(new AddNewCondidateWindow(AddCondidate)).ShowDialog();
		}
		
	}
}