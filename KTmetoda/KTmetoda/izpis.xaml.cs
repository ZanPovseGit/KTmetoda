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

namespace KTmetoda
{
    /// <summary>
    /// Interaction logic for izpis.xaml
    /// </summary>
    public partial class izpis : Window
    {
        public izpis(List<string> a)
        {
            InitializeComponent();
            //string[] arra = a.Select(i => i.ToString()).ToArray();
            //arra = izpisi.Text.Split('\n');
            foreach (string m in a)
            {
                izpisi.Text += m;
                izpisi.Text += System.Environment.NewLine;
            }
        }
    }
}
