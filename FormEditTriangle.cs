using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class FormEditTriangle : Form
    {
        public FormEditTriangle()
        {
            InitializeComponent();
        }

        private Triangle _triangle;

        public Triangle Triangle
        {
            get
            {
                return _triangle;
            }

            set
            {
                _triangle = value;
                _triangle.X = new Point(int.Parse(textBoxA1.Text), int.Parse(textBoxA2.Text));
                _triangle.Y = new Point(int.Parse(textBoxB1.Text), int.Parse(textBoxB2.Text));
                _triangle.Z = new Point(int.Parse(textBoxC1.Text), int.Parse(textBoxC2.Text));
            }
        }



        private void FormEditTriangle_Load(object sender, EventArgs e)
        {

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
