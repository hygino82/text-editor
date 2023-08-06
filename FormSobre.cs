using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTXT
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            //webBrowser.Navigate(Application.StartupPath + @"\sobre\index.html");
            webBrowser.Navigate(@"C:\curso\EditorTXT\bin\Debug\net6.0-windows\sobre\index.html");
            this.Controls.Add(webBrowser);
        }
    }
}
