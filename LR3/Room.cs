using System;
using System.Text.Json.Serialization;

namespace LR3
{
    class Room
    {
        private int RoomNumber;
        private bool IsVip;
        private bool IsSeaLandscape;
        private Guest[] GuestArray;

        public int RoomNumber_ { get => RoomNumber; set => RoomNumber = value; }
        public bool IsVip_ { get => IsVip; set => IsVip = value; }
        public bool IsSeaLandscape_ { get => IsSeaLandscape; set => IsSeaLandscape = value; }
        public Guest[] GuestArray_ { get => GuestArray; set => GuestArray = value; }

        public Room(int roomNumber, bool isVip, bool isSeaLandscape, int guestArraySize)
        {
            this.RoomNumber = roomNumber;
            this.IsVip = isVip;
            this.IsSeaLandscape = isSeaLandscape;
            this.GuestArray = new Guest[guestArraySize];
        }

        public Room(int roomNumber, bool isVip, bool isSeaLandscape)
        {
            this.RoomNumber = roomNumber;
            this.IsVip = isVip;
            this.IsSeaLandscape = isSeaLandscape;
        }

        public Room()
        {
        }

        public int AddGuest(Guest guest)
        {
            if(this.IsVip == guest.IsVipClient_ && this.IsSeaLandscape_ == guest.IsSeaLandscapeRequired_ 
                && (this.GuestArray.Length == 1) == guest.WantToBeAlone_)
            {
                for(int i = 0; i < GuestArray.Length; i++)
                {
                    if(GuestArray[i] == null)
                    {
                        GuestArray[i] = guest;
                        return this.RoomNumber_;
                    }
                }
                return -1;
            }
            return -1;
        }
    }
}
