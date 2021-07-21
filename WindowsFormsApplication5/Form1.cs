using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication5
{
    public partial class note : Form
    {  
        public note()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Today Is:  " + DateTime.Now + "    ||    " + "Computer Name Is : " + Environment.MachineName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Save The Change?", "Note", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    MessageBox.Show("Save Successfully ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { }
            }
            else if (result == DialogResult.No)
            { richTextBox1.Clear(); }
            else
            { }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
         {
           this.Close();
         }

       private void openToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (openFileDialog1.ShowDialog()==DialogResult.OK)
           {
               richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
           }
           else
           { }
       }
       private void saveToolStripMenuItem_Click(object sender, EventArgs e)
       {
              if (saveFileDialog1.ShowDialog()==DialogResult.OK)
           {
               File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
               MessageBox.Show("Save Successfully ","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
       }

       private void colorToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (colorDialog1.ShowDialog() == DialogResult.OK)
           {
               richTextBox1.SelectionColor = colorDialog1.Color;
           }

       }
       private void fontToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (fontDialog1.ShowDialog() == DialogResult.OK)
           {
               richTextBox1.SelectionFont = fontDialog1.Font;
           }
       }
       private void Undo_Click(object sender, EventArgs e)
       {
           richTextBox1.Undo();
       }

       private void Save_Click(object sender, EventArgs e)
       {
           if (saveFileDialog1.ShowDialog() == DialogResult.OK)
           {
               saveFileDialog1.ShowDialog();
               File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
               MessageBox.Show("Save Successfully ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else { }
       }
     private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           richTextBox1.Copy();
       }

       private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           richTextBox1.Cut();
       }

       private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           richTextBox1.Paste();
       }

       private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           richTextBox1.SendToBack();
       }

       private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
       {
           richTextBox1.Clear();
       }

       private void Redo_Click(object sender, EventArgs e)
       {
           richTextBox1.Redo();
       }

       private void deleteUndoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           richTextBox1.ClearUndo();
       }

       private void printToolStripMenuItem_Click(object sender, EventArgs e)
       {
           printDialog1.ShowDialog();
       }
       private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
       {
           e.Graphics.DrawString(richTextBox1.Text,new Font("Bold",12),Brushes.Black,10,20);
       }

       private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
       {
           pageSetupDialog1.ShowDialog();
       }

       private void previewToolStripMenuItem_Click(object sender, EventArgs e)
       {
           printPreviewDialog1.ShowDialog();
       }

       private void Preview_Click(object sender, EventArgs e)
       {
           printPreviewDialog1.ShowDialog();
       }
    }
}
