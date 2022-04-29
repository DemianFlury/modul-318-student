using System.Diagnostics;

namespace SwissTransportGUI
{
    internal class Email
    {
        private string _Abfahrtsort { get; set; }
        private string _Ankunftsort { get; set; }
        private string _Abfahrtszeit { get; set; }
        private string _Dauer { get; set; }
        private string _Gleis { get; set; }
        public string _MailMessage
        {
            get
            {
                return $"mailto:{"mail@domain.com"}?subject={"Ich habe dir eine Verbindung rausgesucht!"}" +
                    $"&body=Von {_Abfahrtsort} nach {_Ankunftsort} um {_Abfahrtszeit} {_Gleis}. Die Fahrtdauer beträgt {_Dauer}";
            }
        }

        public Email(string Abfahrtsort, string Destination, string Abfahrtszeit, string Fahrtdauer, string Gleis)
        {
            _Abfahrtsort = Abfahrtsort;
            _Ankunftsort = Destination;
            _Abfahrtszeit = Abfahrtszeit;
            _Dauer = Fahrtdauer;
            _Gleis = Gleis;
        }


        public void SendMail()
        {
            Process.Start(new ProcessStartInfo(_MailMessage) 
            { 
                UseShellExecute = true 
            }
            );
        }
    }
}
