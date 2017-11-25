using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drakenya.AcelaControllerWPF.Model;

namespace Drakenya.AcelaControllerWPF.ViewModel
{
    class SmartCabViewModel
    {
        public ObservableCollection<SmartCab> SmartCabs
        {
            get;
            set;
        }

        public string ChkBrake
        {
            get { return "True"; }
        }

        public void LoadSmartCabs()
        {
            ObservableCollection<SmartCab> smartCabs = new ObservableCollection<SmartCab>();

            smartCabs.Add(new SmartCab { Brake = true, ForwardDirection = true, Inertia = 0, Speed = 0 });
            smartCabs.Add(new SmartCab { Brake = false, ForwardDirection = true, Inertia = 0, Speed = 0 });
            smartCabs.Add(new SmartCab { Brake = true, ForwardDirection = true, Inertia = 2, Speed = 75 });

            SmartCabs = smartCabs;
        }
    }
}
