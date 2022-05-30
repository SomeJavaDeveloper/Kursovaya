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

        private void ViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
