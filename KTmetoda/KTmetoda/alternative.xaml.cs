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
    /// Interaction logic for alternative.xaml
    /// </summary>
    public partial class alternative : Window
    {
        public List<string> param;
        public List<string> imeAlternativ;
        public List<List<int>> odlocitve;
        public alternative(List<string> parametri)
        {
            InitializeComponent();
            param = new List<string>(parametri);
            odlocitve = new List<List<int>>();
            imeAlternativ = new List<string>();
            foreach(string a in param)
            {
                Utezi.Content = Utezi.Content + a;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var c = new List<int>();
            imeAlternativ.Add(ImeAlternative.Text);
            var stev = preference.Text.Split(',');
            foreach(string a in stev)
            {
                c.Add(int.Parse(a));
            }
            odlocitve.Add(c);
            ImeAlternative.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<int> utezi = new List<int>();
            int rezult = 0;
            List<string> rez = new List<string>();
            foreach(string a in param)
            {
                var s = a.Split(',');
                utezi.Add(int.Parse(s[1]));
            }

            string max = "";
            int st = 0,mm=0,maxi=0;
            string ac = "";
            foreach(List<int> c in odlocitve)
            {
                rez.Add(imeAlternativ[st]);
                for (int i = 0 ;i<utezi.Count;i++)
                {
                    ac += c[i].ToString()+ ",";
                    mm = c[i]  * utezi[i];
                    rezult += mm;
                }
                ac += rezult.ToString();
                rez[st] += ac;
                if (maxi < rezult)
                {
                    max = imeAlternativ[st] + ":" + rezult.ToString();
                    maxi = rezult;
                }
                ac = "";
                rezult = 0;
                st++;
            }
            rez.Add(max);





            izpis aa = new izpis(rez);
            aa.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            List<int> utezi = new List<int>();
            int rezult = 0;
            List<int> rez = new List<int>();
            foreach (string a in param)
            {
                var s = a.Split(',');
                utezi.Add(int.Parse(s[1]));
            }

            int max=0;
            int st = 0, mm = 0, maxi = 0;
            
            foreach (List<int> c in odlocitve)
            {              
                for (int i = 0; i < utezi.Count; i++)
                {
                    
                    mm = c[i] * utezi[i];
                    rezult += mm;
                }
                rez.Add(rezult);
                if (maxi <= rezult)
                {
                    max = rezult;
                }
                rezult = 0;
                st++;
            }




            Form1 nn = new Form1(rez,utezi);
            nn.ShowDialog();
        }
    }
}
