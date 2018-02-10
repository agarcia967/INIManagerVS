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
    public partial class HeaderEntry : UserControl
    {
        public HeaderEntry()
        {
            InitializeComponent();
        }

        public void setHeader(string header)
        {
            textBox1.Text = header;
        }

        public string getHeader()
        {
            return textBox1.Text;
        }
    }
}
