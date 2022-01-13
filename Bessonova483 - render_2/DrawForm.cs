using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483___render
{
    public partial class DrawForm : Form
    {
        int old_x, old_y;
        List<Figure> lst = new List<Figure>();
        Bitmap bmp;


        public DrawForm()
        {
            InitializeComponent();
        }

        void buttonRender_Click(object sender, EventArgs e)
        {
            int h = pictureBoxfigures.Height;
            int w = pictureBoxfigures.Width;

            switch (comboBoxColor.Text)
            {
                case "Random":
                   
                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            RGB c = new RGB(0.5f);

                            foreach (Figure fig in lst)

                                if (fig.test(x, y))
                                    c = fig.clr;
                            bmp.SetPixel(x, y, c.getColor()); 
                        }
                    }
                    pictureBoxfigures.Invalidate();
                    break;
                case "Writing":

                    float r1 = Convert.ToSingle(textBoxred.Text);
                    float g1 = Convert.ToSingle(textBoxgreen.Text);
                    float b1 = Convert.ToSingle(textBoxblue.Text);

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {

                            RGB c = new RGB(r1, g1, b1);
                            foreach (Figure fig in lst)

                                if (fig.test(x, y))
                                    bmp.SetPixel(x, y, c.getColor()); 
                        }
                    }
                    pictureBoxfigures.Invalidate();
                    break;

              

            }


        }

     void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lst.Count)
            {
                if (listBoxfigures.SelectedIndex == i) lst.RemoveAt(i);
                listBoxfigures.Items.RemoveAt(i);
                i++;
            }
            pictureBoxfigures.Invalidate();
        }

       void buttonAdd_Click(object sender, EventArgs e)
        {
            Figure fig = Createfigure(comboBoxFigures.Text);
            if (fig == null) return;
            fig.pos_x = pictureBoxfigures.Width * 0.5f;
            fig.pos_y = pictureBoxfigures.Height * 0.5f;
            listBoxfigures.Items.Add(fig.id);
            lst.Add(fig);
            pictureBoxfigures.Invalidate();
        }

       private void DrawForm_Load(object sender, EventArgs e)
       {
           textBoxRad.Visible = false;
           labelforcircle.Visible = false;

           textBoxside.Visible = false;
           labelforsquare.Visible = false;
            int h = pictureBoxfigures.Height;
            int w = pictureBoxfigures.Width;

            bmp = new Bitmap(w, h);
            pictureBoxfigures.Image = bmp;
           //FormDraw_Resize(null, null);
       }

      void pictureBoxfigures_MouseMove(object sender, MouseEventArgs e)
       {
           if (e.Button == MouseButtons.Left)
           {
               int dx = e.X - old_x;
               int dy = e.Y - old_y;
               foreach (Figure fig in lst)
               {
                   if (fig.selected == false) continue;
                   fig.pos_x += dx;
                   fig.pos_y += dy;

               }
               pictureBoxfigures.Invalidate();

           }
           old_x = e.X;
           old_y = e.Y;
          
       }

      private void comboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
      {
          switch (comboBoxFigures.Text)
          {
              case "circle":
                  textBoxRad.Visible = true; labelforcircle.Text = "Radius: "; labelforcircle.Visible = true; textBoxside.Visible = false;
                  labelforsquare.Visible = false; break;
              case "square":
                  textBoxside.Visible = true; labelforsquare.Text = "Side: "; labelforsquare.Visible = true; textBoxRad.Visible = false;
                  labelforcircle.Visible = false; break;
          }
      }

      void pictureBoxfigures_MouseDown(object sender, MouseEventArgs e)
      {
          foreach (Figure fig in lst)
              fig.selected = false;
          for (int i = lst.Count - 1; i >= 0; i--)
          {
              Figure fig = lst[i];
              fig.selected |= fig.test(e.X, e.Y);
              if (fig.selected == true) break;
          }
          pictureBoxfigures.Invalidate();
        
      }

      void pictureBoxfigures_Paint(object sender, PaintEventArgs e)
      {
          foreach (Figure fig in lst)
              fig.draw(e.Graphics);
      }

      private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
      {
           switch (comboBoxColor.Text)
            {
                case "Random":
                   textBoxgreen.Enabled = false;
                    textBoxred.Enabled = false;
                    textBoxblue.Enabled = false;
                    textBoxNum.Enabled = false;
                    break;

                case "Writing":
                    textBoxgreen.Enabled = true;
                    textBoxred.Enabled = true;
                    textBoxblue.Enabled = true;
                  
                    break;

            }
      }

        private void buttonRen2_Click(object sender, EventArgs e)
        {
            int h = pictureBoxfigures.Height;
            int w = pictureBoxfigures.Width;

                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            RGB c = new RGB();
                    Vec2 p = new Vec2(x, y);
                    float dmin = 100.0f;

                    foreach (Figure fig in lst)
                    {
                        float d = fig.sdf(p);
                        if (d < dmin) dmin = d;
                    }
                    c = new RGB(dmin / 100.0f);
                            bmp.SetPixel(x, y, c.getColor());
                        }
                    }
                    pictureBoxfigures.Invalidate();
            
            
        }

        private void buttonRender3_Click(object sender, EventArgs e)
        {
            int h = pictureBoxfigures.Height;
            int w = pictureBoxfigures.Width;

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    RGB c = new RGB();
                    Vec2 p = new Vec2(x, y);
                    
                    float dmin = 100.0f;

                    foreach (Figure fig in lst)
                    {
                        float d = fig.sdf(p);
                        if (d < dmin) dmin = d;
                    }
                    c = new RGB(dmin / 100.0f);
                    bmp.SetPixel(x, y, c.getColor());
                }
            }
            pictureBoxfigures.Invalidate();
        }

        private void buttonren3_Click(object sender, EventArgs e)
        {
            float t = Convert.ToSingle(textBoxT.Text);
            int h = pictureBoxfigures.Height;
            int w = pictureBoxfigures.Width;

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    RGB c = new RGB();
                    Ray p = new Ray(Vec2.fromPolar(x), Vec2.fromPolar(y));

                    float dmin = 100.0f;

                    foreach (Figure fig in lst)
                    {
                        float d = Convert.ToSingle(p.pointAtDistance(t));
                        if (d < dmin) dmin = d;
                    }
                    c = new RGB(dmin / 100.0f);
                    bmp.SetPixel(x, y, c.getColor());
                }
            }
            pictureBoxfigures.Invalidate();
        }

        Figure Createfigure(string fig_type)
      {

          switch (fig_type)
          {
              case "circle": return new Circle(textBoxRad.Text);
              case "square": return new Square(textBoxside.Text);

          }

          return null;
      }

        

    }
}
