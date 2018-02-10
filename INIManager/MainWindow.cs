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

namespace INIManager
{
    public partial class MainWindow : Form
    {
        internal bool haveFile;
        string filename;
        private int selectedIndex = -1;
        private INIManager iniMgr;

        public MainWindow()
        {
            InitializeComponent();
            initStrings();
            setNoFile();

            updateUndoRedo();
            iniMgr = new INIManager();
            updateSelectedIndex();
            statProgressTitle.Visible = 
            statProgressBar.Visible = false;
        }

        private void initStrings()
        {
            this.Text = Properties.Resources.iniManager;

            menuCatFile.Text = Properties.Resources.file;
            menuOpen.Text = 
                tbtnOpen.Text = Properties.Resources.open;
            menuSave.Text = 
                tbtnSave.Text = Properties.Resources.save;
            menuSaveAs.Text = 
                tbtnSaveAs.Text = Properties.Resources.saveAs;
            menuClose.Text = 
                tbtnClose.Text = Properties.Resources.close;

            menuCatEdit.Text = Properties.Resources.edit;
            menuUndo.Text = Properties.Resources.undo;
            //tbtnUndo.Text = Properties.Resources.undo;
            menuRedo.Text = Properties.Resources.redo;
            //tbtnRedo.Text = Properties.Resources.redo;
            menuDelete.Text =
                tbtnDelete.Text = Properties.Resources.delete;

            menuCatAdd.Text = Properties.Resources.add;
            menuAddHeader.Text =
                tbtnAddHeader.Text = Properties.Resources.addHeader;
            menuAddKeyValue.Text =
                tbtnAddKeyValue.Text = Properties.Resources.addKeyValue;

            menuCatMove.Text = Properties.Resources.move;
            menuMoveUp.Text = 
                tbtnMoveUp.Text = Properties.Resources.moveUp;
            menuMoveDown.Text = 
                tbtnMoveDown.Text = Properties.Resources.moveDown;

            menuCatAbout.Text = Properties.Resources.about;
            menuVersion.Text = Properties.Resources.version;

            statIndexTitle.Text = Properties.Resources.selectedIndex + ":";
        }

        private void setTitleFile(string filepath)
        {
            this.Text = Properties.Resources.iniManager;
            if(filepath!=null && !filepath.Equals(""))
            {
                this.Text += " - ";
                this.Text += filepath;
            }
        }

        private void setNoFile()
        {
            setHaveFile(false);
        }

        private void setHaveFile(bool hasFile)
        {
            menuClose.Enabled =
            tbtnClose.Enabled = hasFile;
            /*menuSave.Enabled =
            tbtnSave.Enabled = hasFile;*/
            /*menuSaveAs.Enabled =
            tbtnSaveAs.Enabled = hasFile;*/
            haveFile = hasFile;
            setTitleFile(haveFile ? filename : null);
        }

        private void clearListItems()
        {
            listView1.Items.Clear();
        }

        ///// MENU BAR BUTTONS /////
        // FILE
        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            /*setHaveFile(true, "** DUMMY FILE **"); //DEBUG
            listView1.Items.Add("Key1").SubItems.Add("Value1");
            listView1.Items.Add("Key3").SubItems.Add("Value3");
            listView1.Items.Add("Key2").SubItems.Add("Value2");
            listView1.Items.Add("Key4").SubItems.Add("Value4");*/
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (haveFile && File.Exists(filename))
            {
                try
                {
                    File.Move(filename, filename + ".tmp");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                saveFile();
            }
            else
            {
                menuSaveAs.PerformClick();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".ini";
            saveFileDialog1.ShowDialog();
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            clearListItems();
            setNoFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD
        private void menuAddHeader_Click(object sender, EventArgs e)
        {
            EditItemForm form = new EditItemForm(false);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                listView1.Items.Add(form.getHeader());
                updateSelectedIndex();
            }
        }

        private void menuAddKeyValue_Click(object sender, EventArgs e)
        {
            EditItemForm form = new EditItemForm(true);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                listView1.Items.Add(form.getKey()).SubItems.Add(form.getValue());
                updateSelectedIndex();
            }
        }

        //EDIT
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.selectedIndex >= 0)
            {
                listView1.Items.RemoveAt(this.selectedIndex);
            }
            updateSelectedIndex();
        }

        // MOVE
        private void menuMoveUp_Click(object sender, EventArgs e)
        {
            int lastIndex = this.selectedIndex;
            if (this.selectedIndex > 0 && this.selectedIndex < listView1.Items.Count)
            {
                ListViewItem item = listView1.Items[lastIndex];
                listView1.Items.RemoveAt(lastIndex);
                listView1.Items.Insert(lastIndex - 1, item);
            }
            updateSelectedIndex();
        }

        private void menuMoveDown_Click(object sender, EventArgs e)
        {
            int lastIndex = this.selectedIndex;
            if (this.selectedIndex >= 0 && this.selectedIndex < listView1.Items.Count-1)
            {
                ListViewItem item = listView1.Items[lastIndex];
                listView1.Items.RemoveAt(lastIndex);
                listView1.Items.Insert(lastIndex + 1, item);
            }
            updateSelectedIndex();
        }

        // ABOUT
        private void menuVersion_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        ///// File Dialogs /////
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filename = openFileDialog1.FileName;
            clearListItems();
            workerOpenFile.RunWorkerAsync();
            setHaveFile(true);
            statProgressTitle.Visible = true;
            statProgressBar.Visible = true;
            /*listView1.Items.Add("Key5").SubItems.Add("Value5");
            listView1.Items.Add("Key6").SubItems.Add("Value6");
            listView1.Items.Add("Key7").SubItems.Add("Value7");
            listView1.Items.Add("Key8").SubItems.Add("Value8");*/
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filename = saveFileDialog1.FileName;
            saveFile();
        }

        private void saveFile()
        {
            workerSaveFile.RunWorkerAsync();
            setHaveFile(true);
            statProgressTitle.Visible = true;
            statProgressBar.Visible = true;
        }

        ///// Toolbar Buttons /////
        //FILE
        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            menuOpen.PerformClick();
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            menuSave.PerformClick();
        }

        private void tbtnSaveAs_Click(object sender, EventArgs e)
        {
            menuSaveAs.PerformClick();
        }

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            menuClose.PerformClick();
        }

        //EDIT
        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            menuDelete.PerformClick();
        }

        //ADD
        private void tbtnAddHeader_Click(object sender, EventArgs e)
        {
            menuAddHeader.PerformClick();
        }

        private void tbtnAddKeyValue_Click(object sender, EventArgs e)
        {
            menuAddKeyValue.PerformClick();
        }

        //MOVE
        private void tbtnMoveUp_Click(object sender, EventArgs e)
        {
            menuMoveUp.PerformClick();
        }

        private void tbtnMoveDown_Click(object sender, EventArgs e)
        {
            menuMoveDown.PerformClick();
        }

        ///// INTERFACE UPDATES /////
        private void updateSelectedIndex()
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                this.selectedIndex = listView1.SelectedIndices[0];
                statIndex.Text = (this.selectedIndex + 1).ToString() + "/" + listView1.Items.Count;
            }
            else
            {
                this.selectedIndex = -1;
                statIndex.Text = "-/" + listView1.Items.Count;
            }
            updateMoveAndDeleteButtons();
        }

        private void updateMoveAndDeleteButtons()
        {
            if (this.selectedIndex <= 0)
            {
                menuMoveUp.Enabled = 
                tbtnMoveUp.Enabled = false;
            }
            else
            {
                menuMoveUp.Enabled = 
                tbtnMoveUp.Enabled = true;
            }

            if (this.selectedIndex >= listView1.Items.Count - 1)
            {
                menuMoveDown.Enabled = 
                tbtnMoveDown.Enabled = false;
            }
            else
            {
                menuMoveDown.Enabled = 
                tbtnMoveDown.Enabled = true;
            }

            if (this.selectedIndex < 0)
            {
                menuMoveUp.Enabled =
                tbtnMoveUp.Enabled = false;
                menuMoveDown.Enabled =
                tbtnMoveDown.Enabled = false;
                menuDelete.Enabled =
                tbtnDelete.Enabled = false;
            }
            else
            {
                menuDelete.Enabled =
                tbtnDelete.Enabled = true;
            }
        }

        private void updateUndoRedo()
        {
            menuUndo.Visible = false;
            menuRedo.Visible = false;
        }

        private void editListAndManager(int index, string header, string key, string value)
        {
            listView1.Items[index].Text = key;
            listView1.Items[index].SubItems[1].Text = value;
            foreach (string h in iniMgr.getHeaders())
            {
                if (iniMgr.getKeys(h).Contains(key))
                {
                    iniMgr.addValue(h, key, value);
                }
            }
        }

        private void deleteFromListAndManager(int index, string header, string key)
        {
            listView1.Items.RemoveAt(index);
            //iniMgr.removeKey(header, key);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditItemForm eif;

            string key = "",
                value = "";

            key = listView1.Items[this.selectedIndex].Text;
            value = listView1.Items[this.selectedIndex].SubItems[1].Text;
            eif = new EditItemForm(key, value);
            eif.ShowDialog();
            if (eif.DialogResult == DialogResult.OK)
            {
                editListAndManager(this.selectedIndex, null, eif.getKey(), eif.getValue());
            }
            else if(eif.DialogResult == DialogResult.Abort)
            {
                deleteFromListAndManager(this.selectedIndex, null, key);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedIndex();
            updateMoveAndDeleteButtons();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //listView1.Columns[e.Column].Sort();
        }

        ///// BACKGROUND WORKERS /////
        private void workerOpenFile_DoWork(object sender, DoWorkEventArgs e)
        {
            iniMgr.readFile(filename);
        }

        private void workerOpenFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statProgressBar.Value = e.ProgressPercentage;
        }

        private void workerOpenFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                statProgressBar.Visible = false;
                statProgressTitle.Visible = true;
                statProgressTitle.Text = "Opening file cancelled.";
            }
            else if (e.Error != null)
            {
                statProgressBar.Visible = false;
                statProgressTitle.Visible = true;
                statProgressTitle.Text = e.Error.Message;
            }
            else
            {
                foreach (string header in iniMgr.getHeaders())
                {
                    listView1.Items.Add("[" + header + "]");
                    foreach (string key in iniMgr.getKeys(header))
                    {
                        listView1.Items.Add(key).SubItems.Add(iniMgr.getValue(header, key));
                    }
                }
                updateSelectedIndex();
                statProgressTitle.Visible = false;
                statProgressBar.Visible = false;
            }
        }

        private void workerSaveFile_DoWork(object sender, DoWorkEventArgs e)
        {
            iniMgr.writeFile(filename);
        }

        private void workerSaveFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statProgressBar.Value = e.ProgressPercentage;
        }

        private void workerSaveFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                statProgressBar.Visible = false;
                statProgressTitle.Visible = true;
                statProgressTitle.Text = "Saving file cancelled.";
                File.Move(filename + ".tmp", filename);
            }
            else if (e.Error != null)
            {
                statProgressBar.Visible = false;
                statProgressTitle.Visible = true;
                statProgressTitle.Text = e.Error.Message;
                File.Move(filename + ".tmp", filename);
            }
            else
            {
                File.Delete(filename + ".tmp");
                updateSelectedIndex();
                statProgressTitle.Visible = false;
                statProgressBar.Visible = false;
            }
        }
        ///// END BACKGROUND WORKERS /////
    }
}
