using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace sit737
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private int _whatever;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        static HttpClient client = new HttpClient();

        public frmMain()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://deakinsit.cloudapp.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void panTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void cmdRegister_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "" && int.TryParse(txtID.Text, out _whatever))
            {
                HttpResponseMessage response = await client.PostAsync("Monitor/RegisterNewTarget/" + txtID.Text, null);
                if (response.IsSuccessStatusCode)
                {
                    txtResponse.Text = await response.Content.ReadAsStringAsync();
                }
            }
            else
            {
                MessageBox.Show("Need to Specific ID");
            }
        }

        private async void cmdunRegister_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && int.TryParse(txtID.Text, out _whatever))
            {
                HttpResponseMessage response = await client.PostAsync("Monitor/unRegisterNewTarget/" + txtID.Text, null);
                if (response.IsSuccessStatusCode)
                {
                    txtResponse.Text = await response.Content.ReadAsStringAsync();
                }
            }
            else
            {
                MessageBox.Show("Need to Specific ID");
            }
        }

        private async void cmdSaveLocation_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && int.TryParse(txtID.Text, out _whatever) && txtArea.Text != "" && txtSection.Text !="")
            {
                HttpResponseMessage response = await client.PostAsync("Monitor/SaveLocation/" + txtID.Text + "/" +
                                                                      txtArea.Text + "/" + txtSection.Text + "/0/" , null);
                if (response.IsSuccessStatusCode)
                {
                    txtResponse.Text = await response.Content.ReadAsStringAsync();
                }
            }
            else
            {
                MessageBox.Show("Need to Specific Area and Section (Example: Area: MELCBD, Section: 5705)");
            }
        }

        private async void cmdReadLocation_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && int.TryParse(txtID.Text, out _whatever))
            {
                HttpResponseMessage response = await client.GetAsync("Monitor/GetCurrentLocation/" + txtID.Text);
                if (response.IsSuccessStatusCode)
                {
                    txtResponse.Text = await response.Content.ReadAsStringAsync();
                }
            }
            else
            {
                MessageBox.Show("Need to Specific ID");
            }

        }

        private async void cmdPath_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && int.TryParse(txtID.Text, out _whatever))
            {
                HttpResponseMessage response = await client.GetAsync("Monitor/GetPath/" + txtID.Text);
                if (response.IsSuccessStatusCode)
                {
                    txtResponse.Text = await response.Content.ReadAsStringAsync();
                }
            }
            else
            {
                MessageBox.Show("Need to Specific ID");
            }
        }
        private Stream stream = new MemoryStream();
        private CancellationTokenSource cts;
        private async void cmdSavePicture_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && int.TryParse(txtID.Text, out _whatever))
            {
                opFile.Title = "Open Picture";
                opFile.Filter = "Image files(*.jpg)|*.jpg|(*.png)|*.png";
                opFile.InitialDirectory = @"C:\";
                if (opFile.ShowDialog() == DialogResult.OK)
                {
                    
                    //opFile.FileName.ToString()
                    HttpResponseMessage response = await client.PostAsync("Monitor/SavePicture/" + txtID.Text, new MultipartFormDataContent(opFile.FileName));
                    if (response.IsSuccessStatusCode)
                    {
                        txtResponse.Text = await response.Content.ReadAsStringAsync();
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Need to Specific ID");
            }
        }

        private async void cmdEmotion_Click(object sender, EventArgs e)
        {

        }

        private async void cmdCheck_Click(object sender, EventArgs e)
        {
            
            HttpResponseMessage response = await client.GetAsync("Monitor/GetStatus");
            if (response.IsSuccessStatusCode)
            {
                txtResponse.Text = await response.Content.ReadAsStringAsync();
            }
        }

        private async void cmdCheckReg_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("Monitor/GetCurrentTarget");
            if (response.IsSuccessStatusCode)
            {
                txtResponse.Text = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
