using SwissTransport.Core;
using SwissTransport.Models;
using System.Windows.Forms;
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

                var VerbindungsListe = verbindung.GetConnections(AbfahrtsortComboBoxTab1.Text, DestinationComboBoxTab1.Text);

                foreach (Connection VerbindungsItem in VerbindungsListe.ConnectionList)
                {
                    VerbindungsanzeigeDataGridViewTab1.Rows.Add(VerbindungsItem.From, VerbindungsItem.To, VerbindungsItem.From.Departure,
                       VerbindungsItem.Duration, VerbindungsItem.From.Platform);
                }
            } catch (Exception ex)
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
            try
            {

            

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
                ComboBox cb = (ComboBox)sender;

                if (char.IsLetterOrDigit((char)Taste.KeyCode))
                {
                    var StationList = verbindung.GetStations(cb.Text);

                    cb.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                    cb.Items.Clear();

                    try
                    {
                        if (StationList.StationList.Count == 0)
                        {
                            cb.Items.Add("Keine Übereinstimmungen");
                        }
                        else
                        {
                            foreach (Station StationItem in StationList.StationList)
                            {
                                if (StationItem.Name == null) break;
                                else cb.Items.Add(StationItem.Name);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bitte geben Sie eine valide Haltestelle an\n" + ex.Message);
                    }
                    cb.SelectionStart = cb.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}