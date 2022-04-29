using System;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Windows.Forms;
using System.Net.Mail;

namespace SwissTransportGUI
{

    public partial class Form1 : Form
    {

        ITransport verbindung = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void VerbindungSuchenButtonTab1_Click(object sender, EventArgs e)
        {
            try
            {

                var VerbindungsListe = verbindung.GetConnections(AbfahrtsortComboBoxTab1.Text, DestinationComboBoxTab1.Text,
                    AbfahrtsDatumDateTimePickerTab1.Value.ToShortDateString(), AbfahrtsZeitDateTimePickerTab1.Value.ToShortTimeString());

                foreach (Connection VerbindungsItem in VerbindungsListe.ConnectionList)
                {
                    VerbindungsanzeigeDataGridViewTab1.Rows.Add(VerbindungsItem.From.Station.Name, VerbindungsItem.To.Station.Name,
                        VerbindungsItem.From.Departure, string.Format("{0:HH:mm}", VerbindungsItem.Duration), VerbindungsItem.From.Platform);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AbfahrtenButtonTab2_Click(object sender, EventArgs e)
        {
            try
            {

                var Abfahrtsliste = verbindung.GetStationBoard(AbfahrtsortComboBoxTab2.Text, AbfahrtsortComboBoxTab2.Text);

                foreach (StationBoard AbfahrtstafelItem in Abfahrtsliste.Entries)
                {
                    AbfahrtenanzeigeDataGridViewTab2.Rows.Add(Abfahrtsliste.Station.Name, AbfahrtstafelItem.To,
                        AbfahrtstafelItem.Stop.Departure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StationsSucheStartenButtonTab3_Click(object sender, EventArgs e)
        {
            SearchPositionAsync();
        }

        private void AbfahrtsortComboBoxTab1_KeyUp(object sender, KeyEventArgs e)
        {
            AutoFill(sender, e);
        }

        private void DestinationComboBoxTab1_KeyUp(object sender, KeyEventArgs e)
        {
            AutoFill(sender, e);
        }

        private void AbfahrtsortComboBoxTab2_KeyUp(object sender, KeyEventArgs e)
        {
            AutoFill(sender, e);
        }

        void AutoFill(object sender, KeyEventArgs Taste)
        {
            try
            {
                ComboBox SelectedBox = (ComboBox)sender;

                if (char.IsLetterOrDigit((char)Taste.KeyCode))
                {
                    var StationList = verbindung.GetStations(SelectedBox.Text);

                    SelectedBox.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                    SelectedBox.Items.Clear();

                    if (StationList.StationList.Count == 0)
                    {
                        SelectedBox.Items.Add("Keine Übereinstimmungen");
                    }
                    else
                    {
                        foreach (Station StationItem in StationList.StationList)
                        {
                            if (StationItem.Name != null)
                                SelectedBox.Items.Add(StationItem.Name);
                        }
                    }

                    SelectedBox.SelectionStart = SelectedBox.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void VerbindungsanzeigeDataGridViewTab1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VerbindungsanzeigeDataGridViewTab1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = VerbindungsanzeigeDataGridViewTab1.Rows[e.RowIndex];

                string Abfahrtsort = row.Cells[0].Value.ToString();
                string Destination = row.Cells[1].Value.ToString();
                string Abfahrtszeit = row.Cells[2].Value.ToString();
                string Dauer = row.Cells[3].Value.ToString();
                string Gleis;
                if (row.Cells[4].Value != null)
                {
                    Gleis = "auf Gleis " + row.Cells[4].Value.ToString();
                }
                else
                {
                    Gleis = ". Leider konnte ich kein Gleis finden";
                }

                Email email = new Email(Abfahrtsort, Destination, Abfahrtszeit, Dauer, Gleis);
                email.SendMail();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbfahrtsZeitDateTimePickerTab1.Format = DateTimePickerFormat.Time;
            AbfahrtsDatumDateTimePickerTab1.Format = DateTimePickerFormat.Custom;
            AbfahrtsDatumDateTimePickerTab1.CustomFormat = "dd.MM.yyyy";
        }

        async Task SearchPositionAsync()
        {
            try
            {
                //Ortung
                Ortung duWirstGeortet = new Ortung();
                string ort = await duWirstGeortet.GetGeoInfo();

                NameDerStationTextBoxTab3.Text = ort;


                //Abfahrtenliste
                var Abfahrtsliste = verbindung.GetStationBoard(NameDerStationTextBoxTab3.Text, NameDerStationTextBoxTab3.Text);

                foreach (StationBoard AbfahrtstafelItem in Abfahrtsliste.Entries)
                {
                    AbfahrtenanzeigeDataGridViewTab3.Rows.Add(Abfahrtsliste.Station.Name, AbfahrtstafelItem.To,
                        AbfahrtstafelItem.Stop.Departure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TakeMeHomeButtonTab1_Click(object sender, EventArgs e)
        {
            SearchPositionTakeMeHomeAsync();
        }

        async Task SearchPositionTakeMeHomeAsync()
        {
            try
            {
                //Ortung
                Ortung duWirstGeortet = new Ortung();
                string ort = await duWirstGeortet.GetGeoInfo();

                AbfahrtsortComboBoxTab1.Text = ort;
                DestinationComboBoxTab1.Text = "Buttisholz";

                var VerbindungsListe = verbindung.GetConnections(AbfahrtsortComboBoxTab1.Text, DestinationComboBoxTab1.Text,
                    AbfahrtsDatumDateTimePickerTab1.Value.ToShortDateString(), AbfahrtsZeitDateTimePickerTab1.Value.ToShortTimeString());

                foreach (Connection VerbindungsItem in VerbindungsListe.ConnectionList)
                {
                    VerbindungsanzeigeDataGridViewTab1.Rows.Add(VerbindungsItem.From.Station.Name, VerbindungsItem.To.Station.Name,
                        VerbindungsItem.From.Departure, string.Format("{0:HH:mm}", VerbindungsItem.Duration), VerbindungsItem.From.Platform);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}