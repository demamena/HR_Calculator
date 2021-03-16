using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRCalculator
{
    public partial class FormGivenDate : Form
    {
        public FormGivenDate(string period)
        {
            InitializeComponent();
            elementHost_givenDate.Child = new UserControlGivenDate(period);
        }
    }
}
