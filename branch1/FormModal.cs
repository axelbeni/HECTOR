using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace Hector
{
    public partial class FormModal : Form
    {

        private string name;
        public FormModal()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void buttonSelect_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers csv (*.csv)|*.csv|Tous les fichiers (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            DialogResult dr = new DialogResult();
            dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                name = ofd.FileName;
                textBoxFileName.Text = Path.GetFileName(name);
            }
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonIntegEcrase_Click(object sender, EventArgs e)
        {
            Controler c = new Controler();
            backgroundWorker1.RunWorkerAsync();
            ManageData manage = new ManageData();
            manage.createClass(name);
            c.Connexion();
            c.viderTables();
            c.insertData(manage.getArticles(), manage.getMarques(), manage.getFamille(), manage.getSousFamille());
            MessageBox.Show("Succès Inégration des données");
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Your background task goes here
            for (int i = 0; i <= 100; i++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(i);
            }
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar.Value = e.ProgressPercentage;
        }
    }
}

