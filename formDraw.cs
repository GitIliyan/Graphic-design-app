using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using static System.Math;


namespace Kursova
{
    public partial class formDraw : Form
    {
        private bool tracingMouse = false;
        public int Selector = 0;
        private Point mouseDownLocation;
        private Point mouseUpLocation;

        public static List<Figures> _figures = new List<Figures>();
        // private List<Figures> _selectedFigures = new List<Figures>();

        public formDraw()
        {
            _figures = new List<Figures>();

            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

        }
        public struct PointD
        {
            public double X;
            public double Y;

            public PointD(double x, double y)
            {
                X = x;
                Y = y;
            }

            public Point ToPoint()
            {
                return new Point((int)X, (int)Y);
            }

            public override bool Equals(object obj)
            {
                return obj is PointD && this == (PointD)obj;
            }
            public override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode();
            }
            public static bool operator ==(PointD a, PointD b)
            {
                return a.X == b.X && a.Y == b.Y;
            }
            public static bool operator !=(PointD a, PointD b)
            {
                return !(a == b);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            foreach(var figure in _figures)
            {
                figure.Paint(e.Graphics);
            }
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {

            Selector = 1;

        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Selector = 2;
        }

        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            Selector = 3;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Selector = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tracingMouse = true;
                mouseDownLocation = e.Location;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!tracingMouse)
                return;
            if (Selector == 1)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Color = Color.Gray;
                rectangle.Position = mouseDownLocation;
                rectangle.Width = e.Location.X - mouseDownLocation.X;
                rectangle.Height = e.Location.Y - mouseDownLocation.Y;

                Invalidate();
                Application.DoEvents();

                using (var graphics = CreateGraphics())
                    rectangle.Paint(graphics);
            }

            if (Selector == 2)
            {
                var X = new Point(mouseDownLocation.X,mouseDownLocation.Y);
                var Y = new Point(e.Location.X, e.Location.Y);
                Triangle triangle = new Triangle();
                triangle.Color = Color.Gray;
                triangle.Position = mouseDownLocation;
                triangle.X = mouseDownLocation;
                triangle.Z = e.Location;
                double distance = Sqrt(Pow(e.Location.X - mouseDownLocation.X, 2) + Pow(e.Location.Y - mouseDownLocation.Y, 2));
                triangle.Y = new Point(mouseDownLocation.X + e.Location.X, mouseDownLocation.Y);


                Invalidate();
                Application.DoEvents();

                using (var graphics = CreateGraphics())
                    triangle.Paint(graphics);

            }

            if (Selector == 3)
            {
                Square square = new Square();
                square.Color = Color.Gray;
                square.Position = mouseDownLocation;
                square.Height = e.Location.Y - mouseDownLocation.Y;

                Invalidate();
                Application.DoEvents();

                using (var graphics = CreateGraphics())
                    square.Paint(graphics);
            }
            if (Selector == 4)
            {
                Cirlce cirlce = new Cirlce();
                cirlce.Color = Color.Gray;
                cirlce.Position = mouseDownLocation;
                cirlce.Radius = e.Location.Y - mouseDownLocation.Y;

                Invalidate();
                Application.DoEvents();

                using (var graphics = CreateGraphics())
                    cirlce.Paint(graphics);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpLocation = e.Location;

            if(e.Button == MouseButtons.Left && tracingMouse)
            {
                if(Selector == 1)
                {
                    var x = Math.Min(mouseDownLocation.X, e.Location.X);
                    var y = Math.Min(mouseDownLocation.Y, e.Location.Y);

                    var width = Math.Abs(e.Location.X - mouseDownLocation.X);
                    var height = Math.Abs(e.Location.Y - mouseDownLocation.Y);

                    Rectangle newRectangle = new Rectangle();
                    newRectangle.Position = new Point(x, y);
                    newRectangle.Width = width;
                    newRectangle.Height = height;
                    newRectangle.Color = Color.Red;
                    newRectangle.Order = _figures
                        .OrderBy(o => o.Order)
                        .Select(s => s.Order)
                        .LastOrDefault() + 1;
                    _figures.Add(newRectangle);
                }
                if (Selector == 2)
                {
                    Triangle newTriangle = new Triangle();
                    newTriangle.Color = Color.Red;
                    newTriangle.Position = mouseDownLocation;
                    newTriangle.X = mouseDownLocation;
                    newTriangle.Z = e.Location;
                    newTriangle.Y = new Point(mouseDownLocation.X + e.Location.X, mouseDownLocation.Y);
                    newTriangle.Order = _figures
                        .OrderBy(o => o.Order)
                        .Select(s => s.Order)
                        .LastOrDefault() + 1;
                    _figures.Add(newTriangle);
                }
                if (Selector == 3)
                {
                    var x = Math.Min(mouseDownLocation.X, e.Location.X);
                    var y = Math.Min(mouseDownLocation.Y, e.Location.Y);

                    var width = Math.Abs(e.Location.X - mouseDownLocation.X);
                    var height = Math.Abs(e.Location.Y - mouseDownLocation.Y);

                    Square newSquare = new Square();
                    newSquare.Position = new Point(x, y);
                    newSquare.Height = height;
                    newSquare.Color = Color.Red;
                    newSquare.Order = _figures
                        .OrderBy(o => o.Order)
                        .Select(s => s.Order)
                        .LastOrDefault() + 1;
                    _figures.Add(newSquare);
                }
                if (Selector == 4)
                {
                    var x = Math.Min(mouseDownLocation.X, e.Location.X);
                    var y = Math.Min(mouseDownLocation.Y, e.Location.Y);

                    var width = Math.Abs(e.Location.X - mouseDownLocation.X);
                    var height = Math.Abs(e.Location.Y - mouseDownLocation.Y);

                    Cirlce newCircle = new Cirlce();
                    newCircle.Position = new Point(x, y);
                    newCircle.Radius = height;
                    newCircle.Color = Color.Red;
                    newCircle.Order = _figures
                        .OrderBy(o => o.Order)
                        .Select(s => s.Order)
                        .LastOrDefault() + 1;
                    _figures.Add(newCircle);
                }

            }
            tracingMouse = false;
            Invalidate();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            var formProperties = new formProperties(_figures);
            
            if(formProperties.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _figures.Clear();
            Invalidate();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var binFormater = new BinaryFormatter();
            using (var fileStream = new FileStream("figures", FileMode.Create, FileAccess.Write))
                binFormater.Serialize(fileStream, _figures);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("figures"))
                return;

            var binFormatter = new BinaryFormatter();
            using (var fileStream = new FileStream("figures", FileMode.Open, FileAccess.Read))
                _figures = (List < Figures >) binFormatter.Deserialize(fileStream);
            
            Invalidate();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


