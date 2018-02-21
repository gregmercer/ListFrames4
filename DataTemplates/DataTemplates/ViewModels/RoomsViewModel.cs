using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;

using DataTemplates.Model;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using DataTemplates.Views;

namespace DataTemplates.ViewModels
{
    public class RoomsViewModel : SimpleViewModel
    {
        public ICommand GetRoomsCommand { get; private set; }

        public RoomsViewModel()
        {
            GetRoomsCommand = new Command(async () => await GetRooms());
        }

        // Commands

        protected async Task GetRooms()
        {
            Rooms = new ObservableCollection<RoomViewModel>() 
            {
                new RoomViewModel() { Index = 1, Name = "Room 1", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:01a aa" },
                        new TimeSlotViewModel() { StartTime = "2:01a bb" },
                        new TimeSlotViewModel() { StartTime = "3:01a cc" },
                        new TimeSlotViewModel() { StartTime = "4:01a dd" },
                        new TimeSlotViewModel() { StartTime = "5:01a ee" },
                        new TimeSlotViewModel() { StartTime = "6:01a ff" },
                        new TimeSlotViewModel() { StartTime = "7:01a gg" },
                    } },

                new RoomViewModel() { Index = 2, Name = "Room 2", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:02a aa" },
                        new TimeSlotViewModel() { StartTime = "2:02a bb" },
                        new TimeSlotViewModel() { StartTime = "3:02a cc" },
                        new TimeSlotViewModel() { StartTime = "4:02a dd" },
                        new TimeSlotViewModel() { StartTime = "5:02a ee" },
                        new TimeSlotViewModel() { StartTime = "6:02a ff" },
                        new TimeSlotViewModel() { StartTime = "7:02a gg" },
                    } },

                new RoomViewModel() { Index = 3, Name = "Room 3", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:03a aa" },
                        new TimeSlotViewModel() { StartTime = "2:03a bb" },
                        new TimeSlotViewModel() { StartTime = "3:03a cc" },
                        new TimeSlotViewModel() { StartTime = "4:03a dd" },
                        new TimeSlotViewModel() { StartTime = "5:03a ee" },
                        new TimeSlotViewModel() { StartTime = "6:03a ff" },
                        new TimeSlotViewModel() { StartTime = "7:03a gg" },
                        new TimeSlotViewModel() { StartTime = "8:03a hh" },
                    } },

                new RoomViewModel() { Index = 4, Name = "Room 4", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:04a aa" },
                        new TimeSlotViewModel() { StartTime = "2:04a bb" },
                        new TimeSlotViewModel() { StartTime = "3:04a cc" },
                        new TimeSlotViewModel() { StartTime = "4:04a dd" },
                        new TimeSlotViewModel() { StartTime = "5:04a ee" },
                        new TimeSlotViewModel() { StartTime = "6:04a ff" },
                        new TimeSlotViewModel() { StartTime = "7:04a gg" },
                        new TimeSlotViewModel() { StartTime = "8:04a hh" },
                    } },

                new RoomViewModel() { Index = 5, Name = "Room 5", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:05a aa" },
                        new TimeSlotViewModel() { StartTime = "2:05a bb" },
                        new TimeSlotViewModel() { StartTime = "3:05a cc" },
                        new TimeSlotViewModel() { StartTime = "4:05a dd" },
                        new TimeSlotViewModel() { StartTime = "5:05a ee" },
                        new TimeSlotViewModel() { StartTime = "6:05a ff" },
                        new TimeSlotViewModel() { StartTime = "7:05a gg" },
                        new TimeSlotViewModel() { StartTime = "8:05a hh" },
                        new TimeSlotViewModel() { StartTime = "9:05a ii" },
                        new TimeSlotViewModel() { StartTime = "10:05a jj" },
                    } },

                new RoomViewModel() { Index = 6, Name = "Room 6", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:06a aa" },
                        new TimeSlotViewModel() { StartTime = "2:06a bb" },
                        new TimeSlotViewModel() { StartTime = "3:06a cc" },
                        new TimeSlotViewModel() { StartTime = "4:06a dd" },
                        new TimeSlotViewModel() { StartTime = "5:06a ee" },
                        new TimeSlotViewModel() { StartTime = "6:06a ff" },
                        new TimeSlotViewModel() { StartTime = "7:06a gg" },
                        new TimeSlotViewModel() { StartTime = "8:06a hh" },
                        new TimeSlotViewModel() { StartTime = "9:06a ii" },
                        new TimeSlotViewModel() { StartTime = "10:06a jj" },
                    } },
                new RoomViewModel() { Index = 7, Name = "Room 7", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:07a aa" },
                        new TimeSlotViewModel() { StartTime = "2:07a bb" },
                        new TimeSlotViewModel() { StartTime = "3:07a cc" },
                        new TimeSlotViewModel() { StartTime = "4:07a dd" },
                        new TimeSlotViewModel() { StartTime = "5:07a ee" },
                        new TimeSlotViewModel() { StartTime = "6:07a ff" },
                        new TimeSlotViewModel() { StartTime = "7:07a gg" },
                    } },

                new RoomViewModel() { Index = 8, Name = "Room 8", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:08a aa" },
                        new TimeSlotViewModel() { StartTime = "2:08a bb" },
                        new TimeSlotViewModel() { StartTime = "3:08a cc" },
                        new TimeSlotViewModel() { StartTime = "4:08a dd" },
                        new TimeSlotViewModel() { StartTime = "5:08a ee" },
                        new TimeSlotViewModel() { StartTime = "6:08a ff" },
                        new TimeSlotViewModel() { StartTime = "7:08a gg" },
                    } },

                new RoomViewModel() { Index = 9, Name = "Room 9", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:09a aa" },
                        new TimeSlotViewModel() { StartTime = "2:09a bb" },
                        new TimeSlotViewModel() { StartTime = "3:09a cc" },
                        new TimeSlotViewModel() { StartTime = "4:09a dd" },
                        new TimeSlotViewModel() { StartTime = "5:09a ee" },
                        new TimeSlotViewModel() { StartTime = "6:09a ff" },
                        new TimeSlotViewModel() { StartTime = "7:09a gg" },
                        new TimeSlotViewModel() { StartTime = "8:09a hh" },
                    } },

                new RoomViewModel() { Index = 10, Name = "Room 10", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:10a aa" },
                        new TimeSlotViewModel() { StartTime = "2:10a bb" },
                        new TimeSlotViewModel() { StartTime = "3:10a cc" },
                        new TimeSlotViewModel() { StartTime = "4:10a dd" },
                        new TimeSlotViewModel() { StartTime = "5:10a ee" },
                        new TimeSlotViewModel() { StartTime = "6:10a ff" },
                        new TimeSlotViewModel() { StartTime = "7:10a gg" },
                        new TimeSlotViewModel() { StartTime = "8:10a hh" },
                    } },

                new RoomViewModel() { Index = 11, Name = "Room 11", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:11a aa" },
                        new TimeSlotViewModel() { StartTime = "2:11a bb" },
                        new TimeSlotViewModel() { StartTime = "3:11a cc" },
                        new TimeSlotViewModel() { StartTime = "4:11a dd" },
                        new TimeSlotViewModel() { StartTime = "5:11a ee" },
                        new TimeSlotViewModel() { StartTime = "6:11a ff" },
                        new TimeSlotViewModel() { StartTime = "7:11a gg" },
                        new TimeSlotViewModel() { StartTime = "8:11a hh" },
                        new TimeSlotViewModel() { StartTime = "9:11a ii" },
                        new TimeSlotViewModel() { StartTime = "10:11a jj" },
                    } },

                new RoomViewModel() { Index = 12, Name = "Room 12", TimeSlots = new ObservableCollection<TimeSlotViewModel>()
                    {   new TimeSlotViewModel() { StartTime = "1:12a aa" },
                        new TimeSlotViewModel() { StartTime = "2:12a bb" },
                        new TimeSlotViewModel() { StartTime = "3:12a cc" },
                        new TimeSlotViewModel() { StartTime = "4:12a dd" },
                        new TimeSlotViewModel() { StartTime = "5:12a ee" },
                        new TimeSlotViewModel() { StartTime = "6:12a ff" },
                        new TimeSlotViewModel() { StartTime = "7:12a gg" },
                        new TimeSlotViewModel() { StartTime = "8:12a hh" },
                        new TimeSlotViewModel() { StartTime = "9:12a ii" },
                        new TimeSlotViewModel() { StartTime = "10:12a jj" },
                    } },
            };
        }

        // Properties

        private ObservableCollection<RoomViewModel> rooms;
        public ObservableCollection<RoomViewModel> Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                rooms = value;
                RaisePropertyChanged();
            }
        }

    }
}
