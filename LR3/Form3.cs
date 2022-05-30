using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form3 : Form
    {
        async Task PutTaskDelay()
        {
            await Task.Delay(10000);
        }
        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            await PutTaskDelay();
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}