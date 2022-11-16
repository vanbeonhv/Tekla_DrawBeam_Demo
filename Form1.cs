using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

using SD = System.Drawing;
using TSG = Tekla.Structures.Geometry3d;
using TSD = Tekla.Structures.Dialog;

namespace Tekla_DrawBeam_Demo
{
    public partial class Form1 : TSD.ApplicationFormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = SD.Color.Yellow;
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = SD.Color.Cyan;
            cb_plane.SelectedIndex = 0;
            cb_depth.SelectedIndex = 0;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            string newColor = "Red";
            this.BackColor = System.Drawing.Color.FromName(newColor);
        }

        private void btn_beam_pick_Click(object sender, EventArgs e)
        {
            Model activeModel = new Model();
            Picker picker = new Picker();
            TSG.Point startPoint = picker.PickPoint("pick first point");
            TSG.Point endPoint = picker.PickPoint("pick second point");
            string prof = txt_prof.Text;
            string mat = txt_mat.Text;
            string _class = txt_class.Text;
            string plane = cb_plane.GetItemText(cb_plane.SelectedItem);
            int depth = cb_depth.SelectedIndex;
            drawBeam(startPoint, endPoint, prof, mat, _class, plane, depth);
            activeModel.CommitChanges();
        }

        private void drawBeam(TSG.Point startPoint, TSG.Point endPoint, string prof, string mat, string _class, string plane, int depth)
        {
            Beam beam = new Beam(startPoint, endPoint);
            beam.Profile.ProfileString = prof;
            beam.Material.MaterialString = mat;
            beam.Material.MaterialString = mat;
            beam.Class = _class;
            if (plane == "Middle")
            {
                beam.Position.Plane = (Position.PlaneEnum)0;
            }
            else if (plane == "Left")
            {
                beam.Position.Plane = (Position.PlaneEnum)1;
            }
            else
            {
                beam.Position.Plane = Position.PlaneEnum.RIGHT;
            }

            switch (depth)
            {
                case 1:
                    beam.Position.Depth = Position.DepthEnum.MIDDLE;
                    break;

                case 2:
                    beam.Position.Depth = Position.DepthEnum.FRONT;
                    break;

                case 3:
                    beam.Position.Depth = Position.DepthEnum.BEHIND;
                    break;
            }
            beam.Insert();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool continueDraw = true;
            do
            {
                string prof = txt_prof.Text;
                string mat = txt_mat.Text;
                string _class = txt_class.Text;
                string plane = cb_plane.GetItemText(cb_plane.SelectedItem);
                int depth = cb_depth.SelectedIndex;
                double height = Convert.ToDouble(txt_height.Text);
                Model activeModel = new Model();
                try
                {
                    Picker picker = new Picker();
                    TSG.Point startPoint = picker.PickPoint("Pick first point");
                    TSG.Point endPoint = new TSG.Point(startPoint.X, startPoint.Y, startPoint.Z + height);

                    drawCol(prof, mat, _class, plane, depth, height, startPoint, endPoint);
                    activeModel.CommitChanges();
                    continueDraw = true;
                }
                catch
                {
                    continueDraw = false;
                }
            } while (continueDraw == true);
        }

        private void drawCol(string prof, string mat, string _class, string plane, int depth, double height, TSG.Point startPoint, TSG.Point endPoint)
        {
            Beam col = new Beam(Beam.BeamTypeEnum.COLUMN);
            col.Profile.ProfileString = prof;
            col.Material.MaterialString = mat;
            col.Class = _class;
            if (plane == "Middle")
            {
                col.Position.Plane = (Position.PlaneEnum)0;
            }
            else if (plane == "Left")
            {
                col.Position.Plane = (Position.PlaneEnum)1;
            }
            else
            {
                col.Position.Plane = Position.PlaneEnum.RIGHT;
            }

            switch (depth)
            {
                case 1:
                    col.Position.Depth = Position.DepthEnum.MIDDLE;
                    break;

                case 2:
                    col.Position.Depth = Position.DepthEnum.FRONT;
                    break;

                case 3:
                    col.Position.Depth = Position.DepthEnum.BEHIND;
                    break;
            }
            col.StartPoint = startPoint;
            col.EndPoint = endPoint;
            col.Insert();
        }

        private void profileCatalog1_SelectionDone(object sender, EventArgs e)
        {
            txt_prof.Text = profileCatalog1.SelectedProfile;
        }

        private void materialCatalog1_SelectionDone(object sender, EventArgs e)
        {
            txt_mat.Text = profileCatalog1.SelectedProfile;
        }
    }
}