using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Ex_2
{
    public partial class FormLinkedList : Form
    {
        IOUtils f;
        List List;
        public FormLinkedList()
        {
            InitializeComponent();
            List = new List();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                f = new IOUtils(openFileDialog.FileName);
                textBoxIn.Lines = f.Str;
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string [] s = f.SetList(List.Head);
            List.Add(s);
            textBoxOut.Lines = f.Printer(List.Head);
        }

        private void FormLinkedList_Load(object sender, EventArgs e)
        {

        }
    }
}
