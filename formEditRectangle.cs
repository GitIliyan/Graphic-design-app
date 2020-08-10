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
    public partial class formEditRectangle : Form
    {
        public formEditRectangle()
        {
            InitializeComponent();
        }

        private Rectangle _rectangle;
        private Square _square;

        public Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }
            set
            {
                _rectangle = value;
                _rectangle.Width = int.Parse(textBoxHeight.Text);
                _rectangle.Height = int.Parse(textBoxWidth.Text);
            }
        }

        public Square Square
        {
            get
            {
                return _square;
            }
            set
            {
                _square = value;

                _square.Height = int.Parse(textBoxHeight.Text);
            }
        }
        private void formEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
