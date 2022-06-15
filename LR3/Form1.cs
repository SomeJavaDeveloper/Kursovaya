using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form1 : Form
    {
        string baseFile = "[{\"RoomNumber_\":1,\"IsVip_\":true,\"IsSeaLandscape_\":true,\"GuestArray_\":[{\"Id_\":1,\"IdCounter_\":2,\"Name_\":\"\\u0413\\u043E\\u0441\\u0442\\u044C-1\",\"IsVipClient_\":true,\"IsSeaLandscapeRequired_\":true,\"WantToBeAlone_\":false},null]},{\"RoomNumber_\":2,\"IsVip_\":false,\"IsSeaLandscape_\":false,\"GuestArray_\":[null,null]},{\"RoomNumber_\":3,\"IsVip_\":true,\"IsSeaLandscape_\":true,\"GuestArray_\":[null,null]},{\"RoomNumber_\":4,\"IsVip_\":true,\"IsSeaLandscape_\":true,\"GuestArray_\":[null]},{\"RoomNumber_\":5,\"IsVip_\":false,\"IsSeaLandscape_\":true,\"GuestArray_\":[null,null]},{\"RoomNumber_\":6,\"IsVip_\":false,\"IsSeaLandscape_\":false,\"GuestArray_\":[null]},{\"RoomNumber_\":7,\"IsVip_\":true,\"IsSeaLandscape_\":true,\"GuestArray_\":[null,null]},{\"RoomNumber_\":8,\"IsVip_\":true,\"IsSeaLandscape_\":false,\"GuestArray_\":[null]},{\"RoomNumber_\":9,\"IsVip_\":true,\"IsSeaLandscape_\":false,\"GuestArray_\":[null,null]},{\"RoomNumber_\":10,\"IsVip_\":false,\"IsSeaLandscape_\":false,\"GuestArray_\":[null]},{\"RoomNumber_\":11,\"IsVip_\":true,\"IsSeaLandscape_\":true,\"GuestArray_\":[null,null]},{\"RoomNumber_\":12,\"IsVip_\":false,\"IsSeaLandscape_\":false,\"GuestArray_\":[null]},{\"RoomNumber_\":13,\"IsVip_\":false,\"IsSeaLandscape_\":true,\"GuestArray_\":[null,null]},{\"RoomNumber_\":14,\"IsVip_\":true,\"IsSeaLandscape_\":true,\"GuestArray_\":[null]},{\"RoomNumber_\":15,\"IsVip_\":true,\"IsSeaLandscape_\":false,\"GuestArray_\":[null,null]}]";
        Hashtable Hotels = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();

            string Path = Directory.GetCurrentDirectory() + "/roomsFile.txt";
            FileInfo guestsJsonFile = new FileInfo(Path);
            if (!guestsJsonFile.Exists)
            {
                File.Create(Path).Close();
                StreamWriter jsonWriter = new StreamWriter(Path, false);
                jsonWriter.WriteLine(baseFile);
                jsonWriter.Flush();
                jsonWriter.Close();
            }

            List<Room> DeserRoomList;
            string jsonString = File.ReadAllText(Path);
            if (jsonString == "")
            {
                StreamWriter jsonWriter = new StreamWriter(Path, false);
                jsonWriter.WriteLine(baseFile);
                jsonWriter.Flush();
                jsonWriter.Close();
                DeserRoomList = new List<Room>();
            }
            else 
            { 
                DeserRoomList = JsonSerializer.Deserialize<List<Room>>(jsonString);
            }

            Hotel.getInstance().RoomList_ = DeserRoomList;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach (Room r in Hotel.getInstance().RoomList_)
            {
                roomsList.Items.Add(r.RoomNumber_);
            }
        }

        private void addObject_Click(object sender, EventArgs e)
        {

            if (!CheckName())
            {
                return;
            }
            string Name = Convert.ToString(guestName.Text);
            bool IsVipClient = isVip.Checked;
            bool IsSeaLandscapeRequired = isSeaLandscape.Checked;
            bool WantToBeAlone = isAlone.Checked;
            Guest newGuest = new Guest(Name, IsVipClient, IsSeaLandscapeRequired, WantToBeAlone);

            int roomNumber = -1;
            foreach (Room r in Hotel.getInstance().RoomList_)
            {
                roomNumber = r.AddGuest(newGuest);
                if (roomNumber != -1)
                {
                    MessageBox.Show("Гость заселен в комнату " + roomNumber);
                    break;
                }
            }
            if (roomNumber == -1)
            {
                MessageBox.Show("Для гостя нет подходящих номеров");
            }
            refreshView();
            refreshInfo();

        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            int guestToRemoveId = Int32.Parse(guestId.Text);
            foreach (Room r in Hotel.getInstance().RoomList_)
            {
                for (int i = 0; i < r.GuestArray_.Length; i++)
                {
                    if (r.GuestArray_[i] != null && r.GuestArray_[i].Id_ == guestToRemoveId)
                    {
                        r.GuestArray_[i] = null;
                        MessageBox.Show("Гость выселен из комнаты " + r.RoomNumber_);
                    }
                }
            }
            refreshView();
            refreshInfo();
        }

        private void refreshView()
        {
            foreach (DictionaryEntry hotel in Hotels)
            {
                Hotel currentHotel = (Hotel)hotel.Value;
                ListViewItem item = new ListViewItem();
            }
        }


        private bool CheckName()
        {
            if (guestName.Text.Length == 0)
            {
                MessageBox.Show("Введите имя гостя");
                return false;
            }
            return true;
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshInfo();
        }

        private void refreshInfo()
        {
            if (roomsList.SelectedIndex != -1)
            {
                outName.Text = "";
                Room selectedRoom = Hotel.getInstance().RoomList_[roomsList.SelectedIndex];
                outName.Text = "Комната номер: " + selectedRoom.RoomNumber_.ToString() + "\n" +
                    "Vip номер: " + selectedRoom.IsVip_.ToString() + "\n" +
                    "Вид на море: " + selectedRoom.IsSeaLandscape_.ToString() + "\n" +
                    "Количество номеров: " + selectedRoom.GuestArray_.Length.ToString() + "\n" +
                    "Информация о гостях: " + "\n";
                for (int i = 1; i <= selectedRoom.GuestArray_.Length; i++)
                {
                    if (selectedRoom.GuestArray_[i - 1] != null)
                    {
                        outName.Text += i + ". " + selectedRoom.GuestArray_[i - 1].ToString() + "\n";
                    }
                }
            }
        }

        private void roomsInfo_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            string Path = Directory.GetCurrentDirectory() + "/roomsFile.txt";
            FileInfo guestsJsonFile = new FileInfo(Path);

            if (!guestsJsonFile.Exists)
            {
                File.Create(Path).Close();
            }

            string serializedTree = JsonSerializer.Serialize(Hotel.getInstance().RoomList_);
            StreamWriter jsonWriter = new StreamWriter(Path, false);
            jsonWriter.WriteLine(serializedTree);
            jsonWriter.Flush();
            jsonWriter.Close();



            Path = Directory.GetCurrentDirectory() + "/guestsFile.txt";
            guestsJsonFile = new FileInfo(Path);

            if (!guestsJsonFile.Exists)
            {
                File.Create(Path).Close();
            }

            serializedTree = JsonSerializer.Serialize(Hotel.getInstance().RoomList_[0]);
            jsonWriter = new StreamWriter(Path, false);
            jsonWriter.WriteLine(serializedTree);
            jsonWriter.Flush();
            jsonWriter.Close();
        }

        private void outName_Click(object sender, EventArgs e)
        {

        }
    }
}
