using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form2 : Form
    {

        public Form2()
        {
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			InitializeComponent();

			foreach (Room r in Hotel.getInstance().RoomList_)
			{
				ListViewItem resultItem = new ListViewItem();
				resultItem.Text = r.RoomNumber_.ToString();
				resultItem.SubItems.Add(r.GuestArray_.Length.ToString());

				int freePlacesCount = 0;
				string guestsName = "";
				foreach (Guest g in r.GuestArray_)
                {
					if(g == null)
                    {
						freePlacesCount++;
					} else
                    {
						guestsName += g.Name_ + "; ";
					}
                }
				resultItem.SubItems.Add(freePlacesCount.ToString());
				resultItem.SubItems.Add(guestsName);

				ViewResults.Items.Add(resultItem);
			}
		}

        private void applyFiltreB_Click(object sender, EventArgs e)
        {
			ViewResults.Items.Clear();
			bool isForOneB = isForOne.Checked;
			bool isOccupiedB = isOccupied.Checked;
			bool isVipB = isVip.Checked;
			bool isSeaLandscapeB = isSeaLandscape.Checked;

			foreach (Room r in Hotel.getInstance().RoomList_)
			{
				ListViewItem resultItem = new ListViewItem();
				resultItem.Text = r.RoomNumber_.ToString();
				resultItem.SubItems.Add(r.GuestArray_.Length.ToString());

				int freePlacesCount = 0;
				string guestsName = "";
				foreach (Guest g in r.GuestArray_)
				{
					if (g == null)
					{
						freePlacesCount++;
					}
					else
					{
						guestsName += g.Name_ + "; ";
					}
				}
				if (isForOneB && (r.GuestArray_.Length != 1))
                {
					continue;
                }
				if (isOccupiedB && (freePlacesCount != 0))
				{
					continue;
				}
				if (isVipB && (r.IsVip_ != true))
				{
					continue;
				}
				if (isSeaLandscapeB && (r.IsSeaLandscape_ != true))
				{
					continue;
				}
				resultItem.SubItems.Add(freePlacesCount.ToString());
				resultItem.SubItems.Add(guestsName);

				ViewResults.Items.Add(resultItem);
			}
		}

		private void showFullB_Click(object sender, EventArgs e)
		{
			ViewResults.Items.Clear();
			foreach (Room r in Hotel.getInstance().RoomList_)
			{
				ListViewItem resultItem = new ListViewItem();
				resultItem.Text = r.RoomNumber_.ToString();
				resultItem.SubItems.Add(r.GuestArray_.Length.ToString());

				int freePlacesCount = 0;
				string guestsName = "";
				foreach (Guest g in r.GuestArray_)
				{
					if (g == null)
					{
						freePlacesCount++;
					}
					else
					{
						guestsName += g.Name_ + "; ";
					}
				}
				resultItem.SubItems.Add(freePlacesCount.ToString());
				resultItem.SubItems.Add(guestsName);

				ViewResults.Items.Add(resultItem);
			}
		}

        private void guestFindB_Click(object sender, EventArgs e)
        {
			string guestNameS = guestName.Text;
			ViewResults.Items.Clear();
			bool isForOneB = isForOne.Checked;
			bool isOccupiedB = isOccupied.Checked;
			bool isVipB = isVip.Checked;
			bool isSeaLandscapeB = isSeaLandscape.Checked;
			foreach (Room r in Hotel.getInstance().RoomList_)
			{
				ListViewItem resultItem = new ListViewItem();
				resultItem.Text = r.RoomNumber_.ToString();
				resultItem.SubItems.Add(r.GuestArray_.Length.ToString());
				bool isRequiredName = false;

				int freePlacesCount = 0;
				string guestsName = "";
				foreach (Guest g in r.GuestArray_)
				{
					if (g == null)
					{
						freePlacesCount++;
					}
					else
					{
						if(g.Name_ != guestNameS)
                        {
							continue;
                        }
                        else
                        {
							isRequiredName = true;
						}
						guestsName += g.Name_ + "; ";
					}
				}
                if (!isRequiredName)
                {
					continue;
				}
				if (isForOneB && (r.GuestArray_.Length != 1))
				{
					continue;
				}
				if (isOccupiedB && (freePlacesCount != 0))
				{
					continue;
				}
				if (isVipB && (r.IsVip_ != true))
				{
					continue;
				}
				if (isSeaLandscapeB && (r.IsSeaLandscape_ != true))
				{
					continue;
				}

				resultItem.SubItems.Add(freePlacesCount.ToString());
				resultItem.SubItems.Add(guestsName);

				ViewResults.Items.Add(resultItem);
			}
		}
    }
}
