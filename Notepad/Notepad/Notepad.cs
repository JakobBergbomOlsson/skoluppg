using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {

        //Video, 27 min in :)

        public Notepad()
        {
            InitializeComponent();
            UpdateTitle();
        }

        private string fileName = null;
        private bool IsUnsaved = false;
        private bool IgnoreTextEvent = false;

        private void UpdateTitle()//Title Update
        {
            string file;
            if (string.IsNullOrEmpty(fileName))
                file = "Unamed";
            else
                file = Path.GetFileName(fileName);

            if(IsUnsaved)
                Text = file + "* - Notepad";
            else
                Text = file + " - Notepad";
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(fileName))
            {
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    fileName = saveFileDialog.FileName;
                else
                    return;
            }

            File.WriteAllText(fileName, textBox1.Text);
            IsUnsaved = false;
            UpdateTitle();
        }
        private void OpenFile()
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IgnoreTextEvent = true;
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                fileName = openFileDialog1.FileName;
                IsUnsaved = false;
                UpdateTitle();
            }
        }
        private void NewFile()
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            textBox1.Text = string.Empty;
            fileName = null;
            IsUnsaved = false;
            UpdateTitle();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)//???
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)//New
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)//Open
        {
            OpenFile();
         
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)//Exit
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//Save
        {
            SaveFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Textändning
        {
            if (IgnoreTextEvent)
            {
                IgnoreTextEvent = false;
                return;
            }
            IsUnsaved = true;
            UpdateTitle();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUnsaved)
            {
                var res = MessageBox.Show(this, "Would you like to save?", "Notepad", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (res == System.Windows.Forms.DialogResult.No)
                {
                    //Do nothing
                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }           
        }

        private void Notepad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                SaveFile();
            }
            else if (e.KeyData == (Keys.Control | Keys.O))
            {
                OpenFile();
            }
            else if (e.KeyData == (Keys.Control | Keys.N))
            {
                NewFile();
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    fileName = saveFileDialog.FileName;
                else
                    return;
            

            File.WriteAllText(fileName, textBox1.Text);
            IsUnsaved = false;
            UpdateTitle();
        }

    }
}
