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
    public partial class Admin : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        List<string> linur = new List<string>();

        string[] arr = new string[4];

        public Admin()
        {
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            li_lager.Clear();
            li_lager.Columns.Add("Nafn", 200);
            li_lager.Columns.Add("Voruflokkur", 120);
            li_lager.Columns.Add("Verd", 60);
            li_lager.Columns.Add("ALager", 60);

            ListViewItem itm;

            linur = gagnagrunnur.LesautSQLToflu();

            try
            {

                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string Nafn = linaUrLista[0];
                    string Voruflokkur = linaUrLista[1];
                    string Verd = linaUrLista[2];
                    string ALager = linaUrLista[3];

                    arr[0] = Nafn;
                    arr[1] = Voruflokkur;
                    arr[2] = Verd;
                    arr[3] = ALager;


                    itm = new ListViewItem(arr);
                    li_lager.Items.Add(itm);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
