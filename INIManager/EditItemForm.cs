using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INIManager
{
    public partial class EditItemForm : Form
    {
        KeyValueInput kvi;
        HeaderEntry he;
        public EditItemForm(bool isKeyValue)
        {
            InitializeComponent();
            btnDelete.Visible = false;
            if (isKeyValue)
            {
                this.Text = "Add Key/Value";
                initKeyValue();
            }
            else
            {
                this.Text = "Add Header";
                initHeader();
            }
        }
        public EditItemForm(string header)
        {
            InitializeComponent();
            initHeader(header);
        }

        public EditItemForm(string key, string value)
        {
            InitializeComponent();
            initKeyValue(key, value);
        }

        public void initHeader()
        {
            he = new HeaderEntry();
            kvi = null;
            tableLayoutPanel1.Controls.Add(he);
            tableLayoutPanel1.SetColumnSpan(he, 3);
            he.Dock = DockStyle.Fill;
        }
        public void initHeader(string header)
        {
            initHeader();
            setEditItem();
            if (header != null) { he.setHeader(header); }
        }

        public void setEditItem()
        {
            this.Text = "Edit Item";
            btnDelete.Visible = true;
        }

        public void initKeyValue()
        {
            he = null;
            kvi = new KeyValueInput();
            tableLayoutPanel1.Controls.Add(kvi);
            tableLayoutPanel1.SetColumnSpan(kvi, 3);
            kvi.Dock = DockStyle.Fill;
        }

        public void initKeyValue(string key, string value)
        {
            initKeyValue();
            setEditItem();
            if (key != null) { kvi.setKey(key); }
            if (value != null) { kvi.setValue(value); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getHeader()
        {
            if (he == null || he.getHeader().Equals("")) return null;
            return he.getHeader();
        }

        public string getKey()
        {
            if (kvi == null) return null;
            return kvi.getKey();
        }

        public string getValue()
        {
            if (kvi == null) return null;
            return kvi.getValue();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (he != null && he.getHeader().Equals(""))
            {
                this.DialogResult = DialogResult.Cancel;
            }
            if(kvi != null && (kvi.getKey().Equals("") && kvi.getValue().Equals("")))
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
