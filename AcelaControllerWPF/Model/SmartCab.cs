using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drakenya.AcelaControllerWPF.Model
{
    class SmartCab : INotifyPropertyChanged
    {
        public enum BrakeStatus { Off, Engaged }
        public enum Direction { Reverse, Forward }

        private bool brake;
        private bool forward;
        private byte inertia;
        private byte speed;

        public bool Brake
        {
            get { return brake; }
            set { if (brake != value) { brake = value; RaisePropertyChanged("Brake"); } }
        }

        public bool ForwardDirection
        {
            get { return forward; }
            set { if (forward != value) { forward = value; RaisePropertyChanged("ForwardDirection"); } }
        }

        public byte Inertia
        {
            get { return inertia; }
            set { if (inertia != value) { inertia = value; RaisePropertyChanged("Inertia"); } }
        }

        public byte Speed
        {
            get { return speed; }
            set { if (speed != value) { speed = value; RaisePropertyChanged("Speed"); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
