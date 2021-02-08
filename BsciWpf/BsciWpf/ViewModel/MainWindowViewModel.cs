using BsciWpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsciWpf.ViewModel
{
    public class MainWindowViewModel
    {
        public Covik covik { get; set; } = new Covik();
        public TimerContent model { get; set; } = new TimerContent();
    }

}
