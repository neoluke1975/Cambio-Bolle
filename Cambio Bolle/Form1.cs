using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Cambio_Bolle
{
    public partial class Form1 : Form
    {
        FbConnection connessione = new FbConnection("User=SYSDBA;Password=masterkey;Database=c:/program files (x86)/winfarm/archivi/arc2000.phs;DataSource=localhost;");
        public Form1()
        {
            InitializeComponent();
            //DateTime today = DateTime.Now;
            //TimeSpan tempo = new TimeSpan(-4, 0, 0, 0);
            //;
            //string data= (today.Add(tempo)).ToString("MM/dd/yyyy");
            //textBox1.Text = data;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tbxCodGrossDaSost1.Text = Cambio_Bolle.Properties.Settings.Default.codgrosSost1;
            tbxCodGrossDaSost2.Text = Cambio_Bolle.Properties.Settings.Default.codgrosSost2;
            tbxCodGrossDaSost3.Text = Cambio_Bolle.Properties.Settings.Default.codgrosSost3;
            tbxCodGrossDaSost4.Text = Cambio_Bolle.Properties.Settings.Default.codgrosSost4;
            tbxCodGrossDaSost5.Text = Cambio_Bolle.Properties.Settings.Default.codgrosSost5;
            tbxCodGrossDaSost6.Text = Cambio_Bolle.Properties.Settings.Default.codgrosSost6;
            tbxCodGrosscheSost1.Text = Cambio_Bolle.Properties.Settings.Default.codgrosNuovo1;
            tbxCodGrosscheSost2.Text = Cambio_Bolle.Properties.Settings.Default.codgrosNuovo2;
            tbxCodGrosscheSost3.Text = Cambio_Bolle.Properties.Settings.Default.codgrosNuovo3;
            tbxCodGrosscheSost4.Text = Cambio_Bolle.Properties.Settings.Default.codgrosNuovo4;
            tbxCodGrosscheSost5.Text = Cambio_Bolle.Properties.Settings.Default.codgrosNuovo5;
            tbxCodGrosscheSost6.Text = Cambio_Bolle.Properties.Settings.Default.codgrosNuovo6;
            cBxGross1.Checked = Cambio_Bolle.Properties.Settings.Default.check1;
            cBxgross2.Checked = Cambio_Bolle.Properties.Settings.Default.check2;
            cBxgross3.Checked = Cambio_Bolle.Properties.Settings.Default.check3;
            cBxgross4.Checked = Cambio_Bolle.Properties.Settings.Default.check4;
            cBxgross5.Checked = Cambio_Bolle.Properties.Settings.Default.check5;
            cBxgross6.Checked = Cambio_Bolle.Properties.Settings.Default.check6;
            cBxTimerAut.Checked = Cambio_Bolle.Properties.Settings.Default.check7;
            if (cBxTimerAut.Checked == true)
            {
                timer1.Enabled = true;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            update();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cambio_Bolle.Properties.Settings.Default.codgrosSost1 = tbxCodGrossDaSost1.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosSost2 = tbxCodGrossDaSost2.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosSost3 = tbxCodGrossDaSost3.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosSost4 = tbxCodGrossDaSost4.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosSost5 = tbxCodGrossDaSost5.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosSost6 = tbxCodGrossDaSost6.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosNuovo1 = tbxCodGrosscheSost1.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosNuovo2 = tbxCodGrosscheSost2.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosNuovo3 = tbxCodGrosscheSost3.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosNuovo4 = tbxCodGrosscheSost4.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosNuovo5 = tbxCodGrosscheSost5.Text;
            Cambio_Bolle.Properties.Settings.Default.codgrosNuovo6 = tbxCodGrosscheSost6.Text;

            Cambio_Bolle.Properties.Settings.Default.check1 = cBxGross1.Checked;
            Cambio_Bolle.Properties.Settings.Default.check2 = cBxgross2.Checked;
            Cambio_Bolle.Properties.Settings.Default.check3 = cBxgross3.Checked;
            Cambio_Bolle.Properties.Settings.Default.check4 = cBxgross4.Checked;
            Cambio_Bolle.Properties.Settings.Default.check5 = cBxgross5.Checked;
            Cambio_Bolle.Properties.Settings.Default.check6 = cBxgross6.Checked;
            Cambio_Bolle.Properties.Settings.Default.check7 = cBxTimerAut.Checked;
            Cambio_Bolle.Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            MessageBox.Show("UPDATE ESEGUITO CORRETTAMENTE");

        }
        public void update()
        {

            connessione.Open();
            if (cBxGross1.Checked == true)
            {
                FbCommand update1 = new FbCommand("update ord_testa set codice='" + tbxCodGrosscheSost1.Text + "' where (tipo='SD' or tipo='SG') and codice='" + tbxCodGrossDaSost1.Text + "'", connessione);
                update1.ExecuteNonQuery();
            }
            if (cBxgross2.Checked == true)
            {
                FbCommand update2 = new FbCommand("update ord_testa set codice='" + tbxCodGrosscheSost2.Text + "' where (tipo='SD' or tipo='SG') and codice='" + tbxCodGrossDaSost2.Text + "'", connessione);
                update2.ExecuteNonQuery();
            }
            if (cBxgross3.Checked == true)
            {
                FbCommand update3 = new FbCommand("update ord_testa set codice='" + tbxCodGrosscheSost3.Text + "' where (tipo='SD' or tipo='SG') and codice='" + tbxCodGrossDaSost3.Text + "'", connessione);
                update3.ExecuteNonQuery();
            }
            if (cBxgross4.Checked == true)
            {
                FbCommand update4 = new FbCommand("update ord_testa set codice='" + tbxCodGrosscheSost4.Text + "' where (tipo='SD' or tipo='SG') and codice='" + tbxCodGrossDaSost4.Text + "'", connessione);
                update4.ExecuteNonQuery();
            }
            if (cBxgross5.Checked == true)
            {
                FbCommand update5 = new FbCommand("update ord_testa set codice='" + tbxCodGrosscheSost5.Text + "' where (tipo='SD' or tipo='SG') and codice='" + tbxCodGrossDaSost5.Text + "'", connessione);
                update5.ExecuteNonQuery();
            }
            if (cBxgross6.Checked == true)
            {
                FbCommand update6 = new FbCommand("update ord_testa set codice='" + tbxCodGrosscheSost6.Text + "' where (tipo='SD' or tipo='SG') and codice='" + tbxCodGrossDaSost6.Text + "'", connessione);
                update6.ExecuteNonQuery();
            }
            connessione.Close();

        }
    }
}
