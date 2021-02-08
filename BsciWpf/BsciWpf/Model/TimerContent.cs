using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BsciWpf.Model
{
    public class TimerContent : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string Ime { get; set; }
        public int Content { get; set; }
        private static System.Timers.Timer aTimer;
        public TimerContent()
        {
            Content = 1;
            Ime = "Rota";
            SetTimer();

        }
        public void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Content++;
            Ime = RandomString(4);
            OnPropertyChanged("Content");
            OnPropertyChanged("Ime");
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
