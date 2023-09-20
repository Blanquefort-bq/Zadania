using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
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
using static System.Net.WebRequestMethods;

namespace WpfApp2
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
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileStream File = new FileStream($"{Name.Text}.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(File);
            sw.WriteLine(tekst.Text);



            string fileName = "myfile.ext";
            
            string fullPath;
            fullPath = System.IO.Path.GetFullPath(fileName);
            sw.WriteLine("{1}", fileName, fullPath);




            /*< TreeView Name = "myTreeViewEvent" >
              < TreeViewItem Header = "Employee1" IsSelected = "True" >
                < TreeViewItem Header = "Jesper Aaberg" />
                < TreeViewItem Header = "Employee Number" >
                  < TreeViewItem Header = "12345" />
                </ TreeViewItem >
                < TreeViewItem Header = "Work Days" >
                  < TreeViewItem Header = "Monday" />
                  < TreeViewItem Header = "Tuesday" />
                  < TreeViewItem Header = "Thursday" />
                </ TreeViewItem >
              </ TreeViewItem >*/






            sw.Close();
            File.Close();
            
        }
        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {           
        }
        private void tekst_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
