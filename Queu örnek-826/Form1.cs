using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queu_örnek_826
{
    public partial class Form1 : Form
    {
        Stack<string>musteri=new Stack<string>();   
 
        public Form1()
           
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Push("kübra");
            musteri.Push("efe");
            musteri.Push("eymen");
            musteri.Push("hayrunnisa");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Push(txtAd.Text);
        }
        private void musteriCagir(Label lbl)
        {
            try
            {
                // hatalı olabilecek(lar)burada olur.
                lbl.Text = musteri.Pop();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 

            }
            
        }
        private void btnCagir1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblCagir1);
        }

        private void btnCagir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblCagir2);
        }

        private void btnCagir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblCagir3);
        }
    }
}
