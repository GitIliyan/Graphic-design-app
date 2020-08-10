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
    public partial class FormEditCircle : Form
    {
        public FormEditCircle()
        {
            InitializeComponent();
        }

        private Cirlce _circle;

        public Cirlce Circle
        {
            get
            {
                return _circle;
            }

            set
            {
                _circle = value;
                _circle.Radius = int.Parse(textBoxRadius.Text);
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
    }
}
