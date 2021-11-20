using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsUIMultiColor.Utils;

namespace WinFormsUIMultiColor.Forms
{
    public partial class FormCustomer : Form
    {
        #region "Constructores"
        public FormCustomer()
        {
            InitializeComponent();
        }
        #endregion

        #region "Definición de Métodos"
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }
        #endregion

        #region "Métodos de Eventos"
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        #endregion
    }
}
