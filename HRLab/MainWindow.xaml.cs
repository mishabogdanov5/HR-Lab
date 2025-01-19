using System.Runtime.ConstrainedExecution;
using System.Text;
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
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			CondidatesList.SelectionChanged += (object sender, SelectionChangedEventArgs e) => 
				{
					if (e.Source != null) MessageBox.Show($"Selected: {((Label)CondidatesList.SelectedItem).Content}");
				};
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			CondidatesList.Items.Add(CreateFromString("jfkrjrjfr"));
		}

		private Label CreateFromString(string source) 
		{
			Label label = new Label();

			label.FontSize = 15;
			label.Margin = new Thickness(0, 0, 0, 10);
			label.Content = source;

			return label;
		}
	}
}