using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Index : Form
    {
        CategorySetup _categorySetup;
        CompanySetup _companySetup;
        public Index()
        {
            InitializeComponent();
            _categorySetup = new CategorySetup();
            _companySetup = new CompanySetup();
        }

        public object CategorySetup { get; private set; }

        private void CategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            _categorySetup.Show();
        }

        private void CompanyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            _companySetup.Show();
        }
    }
}
