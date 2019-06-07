using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace APA_MLAculminating
{
    /// <summary>
    /// Interaction logic for APA.xaml
    /// </summary>
    public partial class APA : Window
    {
        public APA()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, RoutedEventArgs e)
        {
            TextBlock buildTheApaCitation = new TextBlock();

            buildTheApaCitation.Inlines.Add(new Run(LastName.Text + ", " + FirstName.Text + " " + MidName.Text + " "));

            buildTheApaCitation.Inlines.Add(new Italic(new Run(WebsiteName.Text)));

            buildTheApaCitation.Inlines.Add(new Run(", " + "\n\n\t" +
                " (" + Year.Text + ") " + ArticleName.Text + ", " + Day.Text + "/" + Month.Text + APAlink.Text + ", "));

            lblOutput.Content = buildTheApaCitation;
        }

        private void Month_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }//This and APA.xaml coded by Aidan
}
