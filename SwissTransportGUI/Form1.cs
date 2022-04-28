using SwissTransport.Core;
using SwissTransport.Models;
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
            var VerbindungsListe = verbindung.GetConnections(AbfahrtsortComboBoxTab1.Text, DestinationComboBoxTab1.Text);

            foreach (Connection VerbindungsItem in VerbindungsListe.ConnectionList)
            {
                VerbindungsanzeigeDataGridViewTab1.Rows.Add(VerbindungsItem.From, VerbindungsItem.To, VerbindungsItem.From.Departure,
                   VerbindungsItem.Duration, VerbindungsItem.From.Platform);
            }
        }

        private void AbfahrtenButtonTab2_Click(object sender, EventArgs e)
        {
            var Abfahrtsliste = verbindung.GetStationBoard(AbfahrtsortComboBoxTab2.Text, AbfahrtsortComboBoxTab2.Text);

            foreach (StationBoard AbfahrtstafelItem in Abfahrtsliste.Entries)
            {
                AbfahrtenanzeigeDataGridViewTab2.Rows.Add(Abfahrtsliste.Station.Name, AbfahrtstafelItem.To,
                    AbfahrtstafelItem.Stop.Departure);
            }
        }

        private void StationsSucheStartenButtonTab3_Click(object sender, EventArgs e)
        {

            

            var Abfahrtsliste = verbindung.GetStationBoard(NameDerStationTextBoxTab3.Text, NameDerStationTextBoxTab3.Text);

            foreach (StationBoard AbfahrtstafelItem in Abfahrtsliste.Entries)
            {
                AbfahrtenanzeigeDataGridViewTab3.Rows.Add(Abfahrtsliste.Station.Name, AbfahrtstafelItem.To,
                    AbfahrtstafelItem.Stop.Departure);
            }
        }

        private void AbfahrtsortComboBoxTab1_KeyUp(object sender, KeyEventArgs e)
        {

            if(char.IsLetterOrDigit((char)e.KeyCode))
            {
                var Stationsliste = verbindung.GetStations(AbfahrtsortComboBoxTab1.Text);

                AbfahrtsortComboBoxTab1.DroppedDown = true;
                foreach (Station StationItem in Stationsliste.StationList)
                {
                    if (StationItem.Name == null)
                    {
                        AbfahrtsortComboBoxTab1.Items.Clear();
                        AbfahrtsortComboBoxTab1.Items.Add("Keine Vorschläge gefunden");
                    }
                    else
                    {
                        AbfahrtsortComboBoxTab1.Items.Clear();
                        AbfahrtsortComboBoxTab1.Items.Add(StationItem.Name);
                    }
                }
            }
        }
    }
}