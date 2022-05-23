using System;
using System.Collections.Generic;

namespace LR3
{
    class Hotel
    {
        private static Hotel instance;

        List<Room> RoomList = new List<Room>();

        public List<Room> RoomList_ { get => RoomList; set => RoomList = value; }

        private Hotel() {
            int i = 1;
            Random random = new Random();
            Room newRoom1 = new Room(i, true, true, 2);
            RoomList.Add(newRoom1);
            i++;
            Room newRoom2 = new Room(i, false, false, 2);
            RoomList.Add(newRoom2);
            i++;
            Room newRoom3 = new Room(i, true, true, 2);
            RoomList.Add(newRoom3);
            i++;
            Room newRoom4 = new Room(i, true, true, 1);
            RoomList.Add(newRoom4);
            i++;
            Room newRoom5 = new Room(i, false, true, 2);
            RoomList.Add(newRoom5);
            i++;
            Room newRoom6 = new Room(i, false, false, 1);
            RoomList.Add(newRoom6);
            i++;
            Room newRoom7 = new Room(i, true, true, 2);
            RoomList.Add(newRoom7);
            i++;
            Room newRoom8 = new Room(i, true, false, 1);
            RoomList.Add(newRoom8);
            i++;
            Room newRoom9 = new Room(i, true, false, 2);
            RoomList.Add(newRoom9);
            i++;
            Room newRoom10 = new Room(i, false, false, 1);
            RoomList.Add(newRoom10);
            i++;
            Room newRoom11 = new Room(i, true, true, 2);
            RoomList.Add(newRoom11);
            i++;
            Room newRoom12 = new Room(i, false, false, 1);
            RoomList.Add(newRoom12);
            i++;
            Room newRoom13 = new Room(i, false, true, 2);
            RoomList.Add(newRoom13);
            i++;
            Room newRoom14 = new Room(i, true, true, 1);
            RoomList.Add(newRoom14);
            i++;
            Room newRoom15 = new Room(i, true, false, 2);
            RoomList.Add(newRoom15);
        }

        public static Hotel getInstance()
        {
            if (instance == null)
                instance = new Hotel();
            return instance;
        }
    }
}
