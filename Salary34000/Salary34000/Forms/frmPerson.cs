using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary34000.Models;
using Salary34000.Utils;

namespace Salary34000.Forms
{
    public partial class frmPerson : Form
    {
        public Person Person { get; set; }

        public frmPerson()
        {
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            this.LoadForm(Person);
        }
    }
}
