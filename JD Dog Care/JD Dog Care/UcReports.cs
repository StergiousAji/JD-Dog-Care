using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Dog_Care
{
    public partial class UcReports : UserControl
    {

        public UcReports()
        {
            InitializeComponent();
        }

        public UcReports(Color colour, string tableName, string[] columns)
        {
            InitializeComponent();

            this.BackColor = colour;

            //for (int i = 0; i < columns.Length; i++)
            //{
            //    lvDisplay.Columns.Add(columns[i]);
            //}

            //FrmJDDogCare.DisplayItems(lvDisplay, tableName, columns);
            //lvDisplay.Refresh();
        }
    }
}
