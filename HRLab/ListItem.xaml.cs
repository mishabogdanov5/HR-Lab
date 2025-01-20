using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoadDataApp
{
	public partial class ListItem : UserControl
	{
		private Condidate _condidate;
		public ListItem(Condidate condidate)
		{
			InitializeComponent();
			_condidate = condidate;

			InitiallizeInfo(condidate);
		}

		private void InitiallizeInfo(Condidate condidate) 
		{
			NameLabel.Content += condidate.Name;
			AgeLabel.Content += condidate.Age.ToString();
			EmailLabel.Content += condidate.Email;
		}

		private void ExtraInfoButton_Click(object sender, RoutedEventArgs e)
		{

        }
    }
}
