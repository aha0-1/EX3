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

namespace EX3
{
    public class Student
    {
        string studentName;
        double studentWeight;
        double studentGrade;
        double averageWeight;
        

        public Student()
        { }

        public Student(string sname,double sweight, double sgrade, double savgweight)
        {
            this.studentName = sname;
            this.studentWeight = sweight;
            this.studentGrade = sgrade;
            this.averageWeight = savgweight;

        }
        public override string ToString()//To Show in list
        {
            string message = string.Format("{0}", this.studentName);
            return message;
        }
       
      
    } 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentsList;//does not exist
        public MainWindow()
        {
            studentsList = new List<Student>();
            InitializeComponent();
            this.StudentRosterLB.ItemsSource = studentsList;//bind to LB
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string sname = this.NameTB.Text;
            double sweight = Convert.ToInt32(this.WeightTB.Text);
            double sgrade= Convert.ToInt32(this.GradeTB.Text);
            double savgweight = Convert.ToInt32(this.AvgWeightTB.Text);
            Student student = new Student(sname,sweight,sgrade,savgweight);
            this.studentsList.Add(student);//add to lb
            this.StudentRosterLB.Items.Refresh();//calls to lb
            

            double sumweight = 0;
            double averageweight = 0;
            for (int i=0; i<sweight;i++)
            {
                sumweight += sweight;
                averageweight = sumweight / i;
            }

            double sumgrade = 0;
            double averagegrade = 0;
            for(int i=0; i < sgrade; i++)
            {
                sumgrade += sgrade;
                averagegrade = sumgrade / i;
            }
           


        }
        

        
    }
}
