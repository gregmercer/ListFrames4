﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataTemplates.ViewModels
{
    public class RoomViewModel : SimpleViewModel
    {
        public RoomViewModel ()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        // Commands

        // Properties

        public int Index { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<TimeSlotViewModel> TimeSlots { get; set; }

    }
}
