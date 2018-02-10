using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INIManager
{
    public partial class KeyValueInput : UserControl
    {
        public KeyValueInput()
        {
            InitializeComponent();
        }

        public KeyValueInput(string key, string value)
        {
            InitializeComponent();
        }
        
        internal void setKey(string key)
        {
            tbKey.Text = key;
        }

        internal void setValue(string value)
        {
            tbValue.Text = value;
        }

        internal string getKey()
        {
            return tbKey.Text;
        }

        internal string getValue()
        {
            return tbValue.Text;
        }
    }
}
