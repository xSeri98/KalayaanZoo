using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalayaanZoo
{
    //yung codes hanggang CreateRoundRectRgn pang shape lang siya ng UI para rounded yung mga edges bali yun lang yung function niya
    public partial class mainUI : Form
    {
        

        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);



        public mainUI()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Padding = new Padding(borderSize);


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainUI_Load(object sender, EventArgs e)
        {
            userNameLbl.Text = frmLogin.userName;
            IDLbl.Text = frmLogin.mngID; //try kung magbabago sa push
        }

        private void dashBtn_MouseHover(object sender, EventArgs e)
        {
            dashBtn.BackColor = Color.FromArgb(39, 174, 96);
        }
    }
}
