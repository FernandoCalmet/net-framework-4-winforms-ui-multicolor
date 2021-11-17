using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsUIMultiColor.Utils;

namespace WinFormsUIMultiColor
{
    public partial class FormMainMenu : Form
    {
        #region "Fields"
        private IconButton currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        #endregion

        #region "Constructor"
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            iconButtonClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #endregion        

        #region "Methods"
        // Metodos que permiten mover el panel mediante la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            // Si el color ya ha sido seleccionado, selecciona nuevamente para elegir uno diferente
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            // Resaltar el boton que se ha hecho clic (formulario activo)
            // 1) Seleccionar un color aleatorio para el tema (opcional, puede usar un unico color para resaltar el boton)
            // 2) Cambiar color de fondo del boton
            // 3) Cambiar color de fuente del boton
            // 4) Cambiar el tamaño de fuente del boton
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    iconButtonClose.Visible = true;
                }
            }
        }
        private void DisableButton()
        {// Desactivar el resaltado del boton-valores predeterminados
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(46, 46, 46);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(31, 31, 31);
            panelLogo.BackColor = Color.FromArgb(31, 31, 31);
            currentButton = null;
            iconButtonClose.Visible = false;
        }
        #endregion

        #region "Events"
        private void iconButtonProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(), sender);
        }

        private void iconButtonOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrder(), sender);
        }

        private void iconButtonCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomer(), sender);
        }

        private void iconButtonReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReporting(), sender);
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonWinClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonWinMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void iconButtonWinMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}