using AnimaliContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AnimaliDataContext ctx = new AnimaliDataContext())
            {
                var gab1 = new Gabbia();
                gab1.Lunghezza = "15";
                ctx.Gabbias.InsertOnSubmit(gab1);
                ctx.SubmitChanges();
            }
        }
    }
}
