using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RootSSH
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        List<string> sList = new List<string>();
        public List<string> SList
        {
            get
            {
                return sList;
            }

            set
            {
                sList = value;
            }
        }
    }
}
