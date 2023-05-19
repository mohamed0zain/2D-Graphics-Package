using Graphics.Graphics_package;
using System.Collections.Generic;

namespace Graphics
{
    public partial class form : Form
    {
        Bitmap pic;
        int width;
        int height;
        Transformations2D transformations = new Transformations2D();
        polygon shape;
        System.Drawing.Graphics draw;
        public form()
        {
            InitializeComponent();
            pic = clearDrawingWindow();
            draw = picture.CreateGraphics();

            picture.Image = pic;
            width = picture.Width / 2;
            height = picture.Height / 2;
        }

        private Bitmap clearDrawingWindow()
        {
            Bitmap p = new Bitmap(picture.Width, picture.Height);
            for (int i = 1; i < 600; i++)
            {
                p.SetPixel(300, i, Color.White);
            }
            for (int i = 1; i < 600; i++)
            {
                p.SetPixel(i, 300, Color.White);
            }
            return p;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics_package.point start = new Graphics_package.point(Convert.ToInt32(xStartPoint.Text) + width, height - Convert.ToInt32(yStartPoint.Text));
            Graphics_package.point end = new Graphics_package.point(Convert.ToInt32(xEndPoint.Text) + width, height - Convert.ToInt32(yEndPoint.Text));
            int x1 = Convert.ToInt32(xStartPoint.Text) + width;
            int y1 = height - Convert.ToInt32(yStartPoint.Text);

            int x2 = Convert.ToInt32(xEndPoint.Text) + width;
            int y2 = height - Convert.ToInt32(yEndPoint.Text);
            pic = new DDA_drawing(x1, y1, x2, y2).drawLine(pic);
            picture.Image = pic;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics_package.point start = new Graphics_package.point(Convert.ToInt32(xStartPoint.Text), Convert.ToInt32(yStartPoint.Text));
            Graphics_package.point end = new Graphics_package.point(Convert.ToInt32(xEndPoint.Text), Convert.ToInt32(yEndPoint.Text));
            Bersenham_Drawing Ber = new Bersenham_Drawing(start, end, height, width);
            pic = Ber.drawLine(pic);
            picture.Image = pic;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Drawer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Graphics_package.point Center = new Graphics_package.point(Convert.ToInt32(xCenter.Text) + width, height - Convert.ToInt32(yCenter.Text));
            int Radius = Convert.ToInt32(RadiusTextBox.Text);
            pic = new Circle(Center, Radius).drawCircle(pic);
            picture.Image = pic;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RadiusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yCenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void xCenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void yEndPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void xEndPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void yStartPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void xStartPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            Graphics_package.point Center = new Graphics_package.point(Convert.ToInt32(xCenterElipse.Text) + width,
                height - Convert.ToInt32(yCenterElipse.Text));
            int RadiusX = Convert.ToInt32(radiusX.Text);
            int RadiusY = Convert.ToInt32(radiusY.Text);
            pic = new Elipse(Center, RadiusX, RadiusY).drawElipse(pic);
            picture.Image = pic;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pic = clearDrawingWindow();
            picture.Image = pic;
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void checked3D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addPolygon_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(xPoint1.Text);
            int y1 = Convert.ToInt32(yPoint1.Text);
            int x2 = Convert.ToInt32(xPoint2.Text);
            int y2 = Convert.ToInt32(yPoint2.Text);
            int x3 = Convert.ToInt32(xPoint3.Text);
            int y3 = Convert.ToInt32(yPoint3.Text);
            int x4 = Convert.ToInt32(xPoint4.Text);
            int y4 = Convert.ToInt32(yPoint4.Text);
            List<point> points = new List<point>();
            points.Add(new point(x1, y1));
            points.Add(new point(x2, y2));
            points.Add(new point(x3, y3));
            points.Add(new point(x4, y4));
            shape = new polygon(points);

            Point p1 = new Point(x1 + width, height - y1);
            Point p2 = new Point(x2 + width, height - y2);
            Point p3 = new Point(x3 + width, height - y3);
            Point p4 = new Point(x4 + width, height - y4);
            Brush brush = new SolidBrush(Color.Red);
            Pen redBrush = new Pen(brush, 1);
            draw.DrawLine(redBrush, p1, p2);
            draw.DrawLine(redBrush, p2, p3);
            draw.DrawLine(redBrush, p3, p4);
            draw.DrawLine(redBrush, p1, p4);
        }
        static void multiply(int[,] mat1,
                       int[,] mat2, int[,] res)
        {
            int N = 3;
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < N; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }
        static void multiply(double[,] mat1,
                       double[,] mat2, double[,] res)
        {
            int N = 3;
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < N; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }


        private void Translation2DBtn_Click(object sender, EventArgs e)
        {
            int translationX = 0;
            int translationY = 0;
            if (xMatrix.Text != "")
            {
                translationX = Convert.ToInt32(xMatrix.Text);
            }
            if (yMatrix.Text != "")
            {
                translationY = Convert.ToInt32(yMatrix.Text);
            }
            polygon translated = transformations.Translation(shape, translationX, translationY);
            drawPolygon(translated);

        }

        private void xReflectBtn_Click(object sender, EventArgs e)
        {
            drawPolygon(transformations.reflectX(shape));
        }

        private void yReflectBtn_Click(object sender, EventArgs e)
        {
            drawPolygon(transformations.reflectY(shape));

        }

        private void originReflectBtn_Click(object sender, EventArgs e)
        {
            drawPolygon(transformations.reflectOrigin(shape));

        }



        private void Scalling2DBtn_Click(object sender, EventArgs e)
        {
            int ScaleX = 1;
            int ScaleY = 1;
            if (xMatrix.Text != "")
            {
                ScaleX = Convert.ToInt32(xMatrix.Text);
            }
            if (yMatrix.Text != "")
            {
                ScaleY = Convert.ToInt32(yMatrix.Text);
            }
            polygon ScalledPolygon = transformations.Scalling(shape, ScaleX, ScaleY);
            drawPolygon(ScalledPolygon);
        }

        private void ShearXBtn_Click(object sender, EventArgs e)
        {
            if (ShearX.Text != null)
            {
                polygon ShearedPolygon = transformations.polygonShearX(shape, Convert.ToInt32(ShearX.Text));
                drawPolygon(ShearedPolygon);

            }
        }

        private void ShearYBtn_Click(object sender, EventArgs e)
        {
            if (ShearY.Text != null)
            {
                polygon ShearedPolygon = transformations.polygonShearY(shape, Convert.ToInt32(ShearY.Text));
                drawPolygon(ShearedPolygon);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (angle.Text != null)
            {
                polygon result = transformations.Rotation(shape, Convert.ToInt32(angle.Text));
                drawPolygon(result);
            }
        }
        private void drawPolygon(polygon shape)
        {
            List<point> polygonPoints = shape.GetPoints();
            Brush brush = new SolidBrush(Color.Blue);
            Pen blueBrush = new Pen(brush, 1);
            draw.DrawLine(blueBrush,
                width + polygonPoints[0].GetXPoint(),
                height - polygonPoints[0].GetYPoint(),
                width + polygonPoints[1].GetXPoint(),
                height - polygonPoints[1].GetYPoint());
            draw.DrawLine(blueBrush,
                width + polygonPoints[1].GetXPoint(),
                height - polygonPoints[1].GetYPoint(),
                width + polygonPoints[2].GetXPoint(),
                height - polygonPoints[2].GetYPoint());
            draw.DrawLine(blueBrush,
                width + polygonPoints[2].GetXPoint(),
                height - polygonPoints[2].GetYPoint(),
                width + polygonPoints[3].GetXPoint(),
                height - polygonPoints[3].GetYPoint());
            draw.DrawLine(blueBrush,
                width + polygonPoints[3].GetXPoint(),
                height - polygonPoints[3].GetYPoint(),
                width + polygonPoints[0].GetXPoint(),
                height - polygonPoints[0].GetYPoint());
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ShearY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}