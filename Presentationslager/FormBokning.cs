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

        }

        private void BtnLaddaOmFormular_Click(object sender, EventArgs e)
        {
            listBoxBockerBokning.Items.Clear();
            listBoxTillangligaBocker.Items.Clear();
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

        private void btnGenomforBokning_Click(object sender, EventArgs e)
        {
            //Skapa nytt bokningsnummer genom att räkna totala antalet bokningar och lägga till ett B framför. Funkar eftersom index börjar på 0.
            string nyttBokningsNummer = "B" + BM.GetTotalAntalBokningar().ToList().Count().ToString();

            List<string> listedStrings = new List<string>();
            List<Bok> listedBoks = new List<Bok>();
            //Eftersom det bara finns en expedit i det nuvarande systemet är Nuvarande expedit satt titll denna.
            Expedit NuvarandeExpedit = BM.GetExpediter()[0];
            //Flyttar över innehållet i BokadeBöcker till listedBoks.
            foreach (string str in listBoxBockerBokning.Items)
            {
                listedStrings.Add(str);
                foreach(Bok B in BM.GetBokList())
                {
                    if (B.Titel == str)
                    {
                        listedBoks.Add(B);
                    }
                }
            }

            //Hämtar medlemmar och väljer ut den som har samma medlemsnummer som anges i inmatningsfältet.
            Medlem NuvarandeMedlem = null;
            foreach (Medlem M in BM.GetMedlemmar())
            {
                if (M.MedlemsNummer == textBoxMedlemsNummer.Text)
                {
                    NuvarandeMedlem = M;
                }
            }
            //Skapar den nya bokningen.
            BM.AddBokning(nyttBokningsNummer, dateTimePickerBokning.Value, listedBoks,NuvarandeExpedit,NuvarandeMedlem);
            //Visar bokningsnummret för expediten så Medlemmen kan få ta del av detta. 
            MessageBox.Show("Medlemsnummer: "+NuvarandeMedlem.MedlemsNummer+"\nNamn: "+NuvarandeMedlem.ForNamn+" "+NuvarandeMedlem.EfterNamn+"\nBokningsnummer: "+nyttBokningsNummer.ToString());
            //FormMain.ActiveForm
            //Close();
        }

        private void BtnHamtaTillgangligaBocker_Click(object sender, EventArgs e)
        {
            foreach (Bok B in BM.GetTillGangligaBocker(dateTimePickerBokning.Value))
            {
                listBoxTillangligaBocker.Items.Add(B.Titel);
            }
        }

        
    }
}
