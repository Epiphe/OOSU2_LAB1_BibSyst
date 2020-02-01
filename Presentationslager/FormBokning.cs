using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslayer;

namespace Presentationslager
{
    
    public partial class FormBokning : Form
    {
        Businessmanager BM = new Businessmanager();
        public FormBokning()
        {
            InitializeComponent();
            foreach (Bok B in BM.GetBokList())
            {
                listBoxTillangligaBocker.Items.Add(B.Titel);
            }
        }

        private void BtnLaddaOmFormular_Click(object sender, EventArgs e)
        {
            listBoxBockerBokning.Items.Clear();
            listBoxTillangligaBocker.Items.Clear();
            foreach (Bok B in BM.GetBokList())
            {
                listBoxTillangligaBocker.Items.Add(B.Titel);
            }

        }

        private void bntLaggTillBok_Click(object sender, EventArgs e)
        {
            listBoxBockerBokning.Items.Add(listBoxTillangligaBocker.SelectedItem);
            listBoxTillangligaBocker.Items.Remove(listBoxTillangligaBocker.SelectedItem);
        }

        private void BtnTaBortBok_Click(object sender, EventArgs e)
        {
            listBoxTillangligaBocker.Items.Add(listBoxBockerBokning.SelectedItem);
            listBoxBockerBokning.Items.Remove(listBoxBockerBokning.SelectedItem);
        }
    }
}
