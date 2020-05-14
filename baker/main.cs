using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baker
{
    public partial class main : Form
    {
        Style style = new Style();
        rhino rhino = new rhino();

        string txt = null;


        bool isFile = false;
        private string pathString;
        private string fileNameString;

        public string toPath
        {
            get
            {
                return pathString;
            }
            set
            {
                pathString = value;
            }
        }

        public string toFileName
        {
            get
            {
                return fileNameString;
            }
            set
            {
                fileNameString = value;
            }
        }

        

        public void getWidth()
        {
            lineBox.Width = 62;
 
            int line = editBox.Lines.Length;
            editContainer.Panel1.Controls.Add(lineBox);
            editContainer.Panel2.Controls.Add(editBox);
            editContainer.SplitterDistance = line.ToString().Length * 10 + (int)editBox.Font.Size + (lineBox.Width - 7);
            lineBox.Width = editContainer.SplitterDistance;
        }

        public void AddLineNumbers()
        {
            Point pt = new Point(0, 0);
            int First_Index = editBox.GetCharIndexFromPosition(pt);
            int First_Line = editBox.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int Last_Index = editBox.GetCharIndexFromPosition(pt);
            int Last_Line = editBox.GetLineFromCharIndex(Last_Index);
            lineBox.SelectionAlignment = HorizontalAlignment.Center;
            lineBox.Text = "";
            getWidth();

            for (int i = First_Line; i <= Last_Line + 2; i++)
            {
                lineBox.Text += i + 1 + "\r\n";
            }
        }
        public main()
        {
            InitializeComponent();
            this.Controls.Add(editBox);
        }
        private void main_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            style.DesignButtonBorder(btnPrint);
            style.DesignButtonBorder(btnLog);

            this.editBox.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            this.lineBox.LanguageOption = RichTextBoxLanguageOptions.UIFonts;

            editContainer.IsSplitterFixed = true;

            menu.Renderer = new ToolStripProfessionalRenderer(new BlackRenderer());

            lineBox.Font = editBox.Font;
            editBox.Select();
            AddLineNumbers();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(255, 53, 119);
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.Transparent;
        }

        private void btn_ctrWiw_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ctrWiw.BackColor = Color.Black;
        }

        private void btn_ctrWiw_MouseLeave(object sender, EventArgs e)
        {
            btn_ctrWiw.BackColor = Color.Transparent;
        }

        private void btn_hide_MouseMove(object sender, MouseEventArgs e)
        {
            btn_hide.BackColor = Color.Black;
        }

        private void btn_hide_MouseLeave(object sender, EventArgs e)
        {
            btn_hide.BackColor = Color.Transparent;
        }

        private void btn_ctrWiw_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                Rectangle bounds = Screen.FromHandle(this.Handle).WorkingArea;
                int x_offset = SystemInformation.HorizontalResizeBorderThickness + SystemInformation.FixedFrameBorderSize.Width - 6;
                int y_offset = SystemInformation.VerticalResizeBorderThickness + SystemInformation.FixedFrameBorderSize.Height - 6;

                bounds.X -= x_offset;
                bounds.Width += (x_offset * 2);
                bounds.Height += y_offset;
                this.MaximizedBounds = bounds;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                btn_ctrWiw.Image = Properties.Resources.moveWiw;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Text = "";
                this.ControlBox = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                btn_ctrWiw.Image = Properties.Resources.fullWiw;
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_compile_compile_Click(object sender, EventArgs e)
        {
            logBox.BringToFront();

            if(isFile == false)
            {
                if (rhino.getCompileString(txt) == false)
                {
                    logBox.SelectionColor = Color.FromArgb(255, 53, 119);
                    logBox.AppendText("[" + DateTime.Now.ToString("HH : mm : ss") + "] " + rhino.toError + "\r\n");
                    bottomPnl.BackColor = Color.FromArgb(255, 53, 119);
                }

                else
                {
                    logBox.AppendText("[" + DateTime.Now.ToString("HH : mm : ss") + "] " + rhino.toError + "\r\n");
                    bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
                }
            }
            else if(isFile == true)
            {
                if (rhino.getCompileFile(toPath, toFileName) == false)
                {
                    logBox.SelectionColor = Color.FromArgb(255, 53, 119);
                    logBox.AppendText("[" + DateTime.Now.ToString("HH : mm : ss") + "] " + rhino.toError + "\r\n");
                    bottomPnl.BackColor = Color.FromArgb(255, 53, 119);
                }

                else
                {
                    logBox.AppendText("[" + DateTime.Now.ToString("HH : mm : ss") + "] " + rhino.toError + "\r\n");
                    bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
                }
            }
        }

        private void editBox_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = editBox.GetPositionFromCharIndex(editBox.SelectionStart);
            if(pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void editBox_VScroll(object sender, EventArgs e)
        {
            lineBox.Text = "";
            AddLineNumbers();
            lineBox.Invalidate();
        }

        private void editBox_FontChanged(object sender, EventArgs e)
        {
            lineBox.Font = editBox.Font;
            editBox.Select();
            AddLineNumbers();
        }

        private void lineBox_MouseDown(object sender, MouseEventArgs e)
        {
            editBox.Select();
            lineBox.DeselectAll();
        }

        private void main_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void editBox_TextChanged(object sender, EventArgs e)
        {
            txt = editBox.Text;
            if(txt == "")
            {
                AddLineNumbers();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printBox.BringToFront();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            logBox.BringToFront();
        }

        private void menu_file_open_Click(object sender, EventArgs e)
        {
            openFile.InitialDirectory = "C:\\";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                toPath = openFile.FileName;
                toFileName = openFile.FileName.Split('\\')[openFile.FileName.Split('\\').Length - 1];

                isFile = true;
                menu_file_save.Text = "저장(&S)";
                editBox.Text = System.IO.File.ReadAllText(toPath);
                bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
            } 
        }

        private void menu_file_save_Click(object sender, EventArgs e)
        {
            if(isFile == false)
            {
                string saveFileName;
                saveFile.Title = "저장할 경로를 지정해주세요.";
                saveFile.InitialDirectory = "C:\\";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    saveFileName = saveFile.FileName;
                    StreamWriter save = new StreamWriter(saveFileName);
                    save.Write(txt);
                    save.Close();
                }
            }
            else
            {
                StreamWriter save = new StreamWriter(toPath);
                save.Write(txt);
                save.Close();
            }
        }

        private void menu_file_nameSave_Click(object sender, EventArgs e)
        {
            string saveFileName;
            saveFile.Title = "저장할 경로를 지정해주세요.";
            saveFile.InitialDirectory = "C:\\";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFile.FileName;
                StreamWriter save = new StreamWriter(saveFileName);
                save.Write(txt);
                save.Close();
            }
        }

        private void menu_file_closeFile_Click(object sender, EventArgs e)
        {
            isFile = false;
            menu_file_save.Text = "저장(&S)...";
            editBox.Text = "";
            bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
        }

        private void menu_file_saveAndCloseFile_Click(object sender, EventArgs e)
        {
            StreamWriter save = new StreamWriter(toPath);
            save.Write(txt);
            save.Close();
            isFile = false;
            menu_file_save.Text = "저장(&S)...";
            editBox.Text = "";
            bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
        }

        private void menu_file_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_debug_startD_Click(object sender, EventArgs e)
        {
            printBox.BringToFront();
            if(isFile == false)
            {
                if (rhino.getRunString(txt) == false)
                {
                    printBox.Text = "(JavaScript)\r\n" + rhino.toRun + "\r\n";
                    bottomPnl.BackColor = Color.FromArgb(255, 53, 119);

                    logBox.SelectionColor = Color.FromArgb(255, 53, 119);
                    logBox.AppendText("[Run " + DateTime.Now.ToString("HH : mm : ss") + "] " + rhino.toRun + "\r\n");

                }

                else
                {
                    printBox.AppendText("(JavaScript)\r\n" + rhino.toRun + "\r\n");
                    bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
                }
            }
            else
            {
                if (rhino.getRunFile(toPath, toFileName) == false)
                {
                    printBox.Text = toPath + "\r\n" + rhino.toRun + "\r\n";
                    bottomPnl.BackColor = Color.FromArgb(255, 53, 119);

                    logBox.SelectionColor = Color.FromArgb(255, 53, 119);
                    logBox.AppendText("[Run " + DateTime.Now.ToString("HH : mm : ss") + "] " + rhino.toRun + "\r\n");

                }

                else
                {
                    printBox.Text = toPath + "\r\n" + rhino.toRun + "\r\n";
                    bottomPnl.BackColor = Color.FromArgb(60, 0, 255);
                }
            }
        }
    }
}

