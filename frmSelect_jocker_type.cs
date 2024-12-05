using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morroco_cartes
{
    public partial class frmSelect_jocker_type : Form
    {
        string savetype = "";

public static frmSelect_jocker_type frjoker=new frmSelect_jocker_type();
        public frmSelect_jocker_type()
        {
            frjoker = this;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


       public string fr2_joker()
        {
            frjoker.ShowDialog();
        
            return savetype + "," + "6";

        }

  public void gitType(object sender, EventArgs e)
        {
            savetype=((PictureBox)sender).Tag.ToString();
            frjoker.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
