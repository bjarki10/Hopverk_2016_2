using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopverk
{
    public partial class Check_out : Form
    {
        string[] arr = new string[4];
        public Check_out()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void Catch(string[,] array2D, int rounds)
        {
            li_korfa.Clear();
            li_korfa.Columns.Add("Nafn", 200);
            li_korfa.Columns.Add("Voruflokkur", 120);
            li_korfa.Columns.Add("Verd", 60);
            li_korfa.Columns.Add("Alager", 60);

            for (int i = 0; i < rounds; i++)
            {
                ListViewItem itm;
                arr[0] = array2D[i,0];
                arr[1] = array2D[i,1];
                arr[2] = array2D[i,2];
                arr[3] = array2D[i,3];

                itm = new ListViewItem(arr);
                li_korfa.Items.Add(itm);
            }
            
            

            
        }
    }
}
