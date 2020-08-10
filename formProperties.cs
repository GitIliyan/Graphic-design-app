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
    public partial class formProperties : Form
    {
        public static List<Figures> figures;

        public formProperties(List<Figures> _figures)
        {
            figures = _figures;

            InitializeComponent();
        }

        public void ApplicationClose()
        {
            this.Close();
        }


        private void formProperties_Load(object sender, EventArgs e)
        {
            foreach(var figure in figures)
            {
                if(figure is Rectangle)
                {
                    Rectangle rec = (Rectangle)figure;
                    listBoxProperties.Items.Add(string.Format("Rectangle with a Width of {0}, Height of {1} and an Area of {2}"
                    ,rec.Height,rec.Width,rec.Area));
                }
                if(figure is Square)
                {
                    Square sq = (Square)figure;
                    listBoxProperties.Items.Add(string.Format("Square with a Width of {0}, Height of {1} and an Area of {2}"
                    ,sq.Height, sq.Height,sq.Area));
                }
                if(figure is Triangle)
                {
                    Triangle tr = (Triangle)figure;
                    listBoxProperties.Items.Add(string.Format("Triangle with coordinates: {0}, {1}, {2}, and an Area of {3}", tr.X, tr.Y,tr.Z,tr.Area));
                }
                if(figure is Cirlce)
                {
                    Cirlce circle = (Cirlce)figure;
                    listBoxProperties.Items.Add(string.Format("Circle with a radius of {0} and an Area of: {1}", circle.Radius,circle.Area));
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxProperties.SelectedItem == null)
            {
                return;
            }

            int index = listBoxProperties.SelectedIndex;

            if (figures[index] is Rectangle)
            {
                var formEdit = new formEditRectangle();

                var rec = (Rectangle)figures[index];

                if (formEdit.ShowDialog() == DialogResult.OK)
                {

                    formEdit.Rectangle = rec;
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {

                        listBoxProperties.Items.RemoveAt(index);
                        listBoxProperties.Items.Insert(index, string.Format("Rectangle with a Width of {0}, Height of {1} and an Area of {2}",
                        rec.Width, rec.Height,rec.Area));
                    }
                }
            }
            if (figures[index] is Square)
            {
                var formEdit = new formEditRectangle();

                var sq = (Square)figures[index];

                if (formEdit.ShowDialog() == DialogResult.OK)
                {

                    formEdit.Square = sq;
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {

                        listBoxProperties.Items.RemoveAt(index);
                        listBoxProperties.Items.Insert(index, string.Format("Square with a Width of {0}, Height of {1} and an Area of {2}",
                        sq.Height, sq.Height,sq.Area));
                    }
                }
            }

            if (figures[index] is Triangle)
            {
                var FormEditTriangle = new FormEditTriangle();
                var triangle = (Triangle)figures[index];

                if(FormEditTriangle.ShowDialog()==DialogResult.OK)
                {
                    FormEditTriangle.Triangle = triangle;
                    listBoxProperties.Items.RemoveAt(index);
                    listBoxProperties.Items.Insert(index,string.Format("Triangle with coordinates: {0}, {1}, {2}, and an Area of {3}", triangle.X, triangle.Y, triangle.Z, triangle.Area));


                }
            }

            if(figures[index] is Cirlce)
            {
                var FormEditedCircle = new FormEditCircle();
                var circle = (Cirlce)figures[index];

                if(FormEditedCircle.ShowDialog()==DialogResult.OK)
                {
                    FormEditedCircle.Circle = circle;
                    listBoxProperties.Items.RemoveAt(index);
                    listBoxProperties.Items.Insert(index, string.Format("Circle with a readius of {0} and an Area of {1}", circle.Radius, circle.Area));
                }
            }
        }

        private void listBoxProperties_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void listBoxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxProperties.SelectedIndex;
            if(listBoxProperties.SelectedItem == null)
            {
                return;
            }
            else
            {
                figures.RemoveAt(index);
                listBoxProperties.Items.RemoveAt(index);
            }
            Invalidate();
        }
    }
}
