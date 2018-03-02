/*Shane MacDonald
 *3U_U1CareersShane
 * displays information on the computer science program at the University of Guelph
 * March 2, 2018
 */

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3U_U1CareersShane
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e) 
        {
            
            lblContent.Content = 
                "University of Guelph: Computer Science \n" +
                "GCT \n" +
                "28 000 students attend the University\n" +
                "Moderatly competeative\n" +
                "Guelph is a city located in Central Ontario and has a population of 130 000. The campus is" +
                "Costs:\n" +   
                "   Full-time Tuition	$6,571\n" +
                "   Residence Room	$6,082\n" +
                "   Textbooks	$1,320\n"
                ;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lblContent.Content =
                "First Year Courses:\n" +
                "   Introduction to Programming\n" +
                "   Calculus I\n" +
                "   3 electives\n"
                ;

            
            
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblContent.Content =
          "Prerequisites:\n" +
          "   4U English\n" +
          "   4U Caluclas and Vectors\n" +
          "   4 Additional 4U Courses\n" +
          "Recomended Courses:\n" +
          "   4U Computing\n" +
          "   4U Data Management\n" +
          "Minimum Average: 75%\n" 
          ;

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lblContent.Content =
                "Potential Careers:\n" +
                "   Game Programmer\n" +
                "   - programes and developes games\n" +
                "   Software Developer\n" +
                "   - research, design, programming, and testing of computer software\n" +
                "   User Experience Designer\n" +
                "   - designs the interface which the user interacts with"
                ;
        }
      
        
    }
}
