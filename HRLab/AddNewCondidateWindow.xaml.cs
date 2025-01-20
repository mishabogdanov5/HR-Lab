using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LoadDataApp;

namespace HrLab
{
	public partial class AddNewCondidateWindow : Window
	{
		private OnCondidateAdded _handler;
		public AddNewCondidateWindow(OnCondidateAdded handler)
		{
			InitializeComponent();
			_handler = handler;
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			if (IsInfoValid())
			{
				Condidate current = new Condidate()
				{
					Name = NameTextBox.Text,
					Email = EmailTextBox.Text,
					Age = int.Parse(AgeTextBox.Text),
					Stage = int.Parse(ExperienceTextBox.Text),
					Pol = (bool)Man.IsChecked ? Identity.MAN : Identity.WOMEN,
					Sphere = (ITSphere) SectionComboBox.SelectedIndex,
					Education = (EducationLevel)EducationComboBox.SelectedIndex,
					VisitDate = (DateTime)VisitDatePicker.SelectedDate,
					Mark = new VisitMark(double.Parse(LanguageMarkTextBox.Text, _doubleFormat),
					double.Parse(AlgoritmsMarkTextBox.Text, _doubleFormat), double.Parse(FrameworkMarkTextBox.Text, _doubleFormat)),
					HasCourses = (bool)HasCourses.IsChecked
				};

				_handler.Invoke(current);
				Hide();
			}
		}

		private static readonly Regex _emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
		private static readonly NumberFormatInfo _doubleFormat = new NumberFormatInfo() { CurrencyDecimalSeparator = "." };

		private bool IsInfoValid()
		{
			if (string.IsNullOrEmpty(NameTextBox.Text))
			{
				MessageBox.Show("Name is empty!");
				return false;
			}

			if (string.IsNullOrEmpty(EmailTextBox.Text))
			{
				MessageBox.Show("Email is empty!");
				return false;
			}

			if (!_emailRegex.IsMatch(EmailTextBox.Text))
			{
				MessageBox.Show("Entry Email in correct formt!");
				return false;
			}

			if (string.IsNullOrEmpty(AgeTextBox.Text))
			{
				MessageBox.Show("Age is empty!");
				return false;
			}

			int t = 0;
			if (!int.TryParse(AgeTextBox.Text, out t))
			{
				MessageBox.Show("Entry age in correct format!");
				return false;
			}

			if (int.Parse(AgeTextBox.Text) < 16 || int.Parse(AgeTextBox.Text) > 70)
			{
				MessageBox.Show("Age should be in range from 16 to 70!");
				return false;
			}

			if (string.IsNullOrEmpty(ExperienceTextBox.Text))
			{
				MessageBox.Show("Experience is empty!");
				return false;
			}

			if (!int.TryParse(ExperienceTextBox.Text, out t))
			{
				MessageBox.Show("Entry experience in correct format!");
				return false;
			}

			if (int.Parse(ExperienceTextBox.Text) < 0 || int.Parse(ExperienceTextBox.Text) > 55)
			{
				MessageBox.Show("Experience should be in range from 0 to 55!");
				return false;
			}

			if (VisitDatePicker.SelectedDate == null)
			{
				MessageBox.Show("Pick visit date!");
				return false;
			}


			if (string.IsNullOrEmpty(LanguageMarkTextBox.Text))
			{
				MessageBox.Show("Language mark is empty!");
				return false;
			}

			double d = 0;
			if (!double.TryParse(LanguageMarkTextBox.Text, _doubleFormat, out d))
			{
				MessageBox.Show("Entry language mark in correct format!");
				return false;
			}

			if (double.Parse(LanguageMarkTextBox.Text, _doubleFormat) < 0 || double.Parse(LanguageMarkTextBox.Text, _doubleFormat) > 5)
			{
				MessageBox.Show("Language mark should be in range from 0 to 5!");
				return false;
			}

			if (string.IsNullOrEmpty(AlgoritmsMarkTextBox.Text))
			{
				MessageBox.Show("Algoritms mark is empty!");
				return false;
			}

			if (!double.TryParse(AlgoritmsMarkTextBox.Text, _doubleFormat, out d))
			{
				MessageBox.Show("Entry algoritms mark in correct format!");
				return false;
			}

			if (double.Parse(AlgoritmsMarkTextBox.Text, _doubleFormat) < 0 || double.Parse(AlgoritmsMarkTextBox.Text, _doubleFormat) > 5)
			{
				MessageBox.Show("Algoritms mark should be in range from 0 to 5!");
				return false;
			}

			if (string.IsNullOrEmpty(FrameworkMarkTextBox.Text))
			{
				MessageBox.Show("Framework mark is empty!");
				return false;
			}

			if (!double.TryParse(FrameworkMarkTextBox.Text, _doubleFormat, out d))
			{
				MessageBox.Show("Framework algoritms mark in correct format!");
				return false;
			}

			if (double.Parse(FrameworkMarkTextBox.Text, _doubleFormat) < 0 || double.Parse(FrameworkMarkTextBox.Text, _doubleFormat) > 5)
			{
				MessageBox.Show("Framework mark should be in range from 0 to 5!");
				return false;
			}

			return true;
		}
	}
}
