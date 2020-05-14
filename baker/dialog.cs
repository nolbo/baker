using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baker
{
    public partial class dialog : Form
    {
        main mainForm = null;
        

        public dialog()
        {
            InitializeComponent();
        }

        public dialog(main main)
        {
            InitializeComponent();
            this.mainForm = main;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.Transparent;
        }

        private void btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(255, 53, 119);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dialog_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ControlBox = false;

            new Style().DesignButtonBorder(btnOK);
            new Style().DesignButtonBorder(btnCancel);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mainForm.editBox.Text = System.IO.File.ReadAllText(mainForm.toPath);
            //mainForm.isFile = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //mainForm.isFile = false;
            Close();
        }

        private Point mousePoint;

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
