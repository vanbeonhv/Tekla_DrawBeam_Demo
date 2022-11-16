namespace Tekla_DrawBeam_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_beam_pick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_plane = new System.Windows.Forms.ComboBox();
            this.lable5 = new System.Windows.Forms.Label();
            this.cb_depth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.materialCatalog1 = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.structuresExtender.SetAttributeName(this.button1, null);
            this.structuresExtender.SetAttributeTypeName(this.button1, null);
            this.structuresExtender.SetBindPropertyName(this.button1, null);
            this.button1.Location = new System.Drawing.Point(444, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_beam_pick
            // 
            this.structuresExtender.SetAttributeName(this.btn_beam_pick, null);
            this.structuresExtender.SetAttributeTypeName(this.btn_beam_pick, null);
            this.structuresExtender.SetBindPropertyName(this.btn_beam_pick, null);
            this.btn_beam_pick.Location = new System.Drawing.Point(348, 255);
            this.btn_beam_pick.Name = "btn_beam_pick";
            this.btn_beam_pick.Size = new System.Drawing.Size(90, 45);
            this.btn_beam_pick.TabIndex = 3;
            this.btn_beam_pick.Text = "Ve Dam Pick";
            this.btn_beam_pick.UseVisualStyleBackColor = true;
            this.btn_beam_pick.Click += new System.EventHandler(this.btn_beam_pick_Click);
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.MinimumSize = new System.Drawing.Size(50, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profile";
            // 
            // txt_prof
            // 
            this.structuresExtender.SetAttributeName(this.txt_prof, null);
            this.structuresExtender.SetAttributeTypeName(this.txt_prof, null);
            this.structuresExtender.SetBindPropertyName(this.txt_prof, null);
            this.txt_prof.Location = new System.Drawing.Point(80, 16);
            this.txt_prof.Name = "txt_prof";
            this.txt_prof.Size = new System.Drawing.Size(121, 20);
            this.txt_prof.TabIndex = 6;
            this.txt_prof.Text = "800*400";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.MinimumSize = new System.Drawing.Size(50, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Material";
            // 
            // txt_mat
            // 
            this.structuresExtender.SetAttributeName(this.txt_mat, null);
            this.structuresExtender.SetAttributeTypeName(this.txt_mat, null);
            this.structuresExtender.SetBindPropertyName(this.txt_mat, null);
            this.txt_mat.Location = new System.Drawing.Point(80, 47);
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(121, 20);
            this.txt_mat.TabIndex = 6;
            this.txt_mat.Text = "C40";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.MinimumSize = new System.Drawing.Size(50, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class";
            // 
            // txt_class
            // 
            this.structuresExtender.SetAttributeName(this.txt_class, null);
            this.structuresExtender.SetAttributeTypeName(this.txt_class, null);
            this.structuresExtender.SetBindPropertyName(this.txt_class, null);
            this.txt_class.Location = new System.Drawing.Point(80, 79);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(121, 20);
            this.txt_class.TabIndex = 6;
            this.txt_class.Text = "3";
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(324, 16);
            this.label4.MinimumSize = new System.Drawing.Size(50, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plane";
            // 
            // cb_plane
            // 
            this.structuresExtender.SetAttributeName(this.cb_plane, null);
            this.structuresExtender.SetAttributeTypeName(this.cb_plane, null);
            this.structuresExtender.SetBindPropertyName(this.cb_plane, null);
            this.cb_plane.FormattingEnabled = true;
            this.cb_plane.Items.AddRange(new object[] {
            "Middle",
            "Right",
            "Left"});
            this.cb_plane.Location = new System.Drawing.Point(382, 16);
            this.cb_plane.Name = "cb_plane";
            this.cb_plane.Size = new System.Drawing.Size(121, 21);
            this.cb_plane.TabIndex = 7;
            // 
            // lable5
            // 
            this.structuresExtender.SetAttributeName(this.lable5, null);
            this.structuresExtender.SetAttributeTypeName(this.lable5, null);
            this.lable5.AutoSize = true;
            this.lable5.BackColor = System.Drawing.Color.Aqua;
            this.structuresExtender.SetBindPropertyName(this.lable5, null);
            this.lable5.Location = new System.Drawing.Point(324, 47);
            this.lable5.MinimumSize = new System.Drawing.Size(50, 0);
            this.lable5.Name = "lable5";
            this.lable5.Padding = new System.Windows.Forms.Padding(4);
            this.lable5.Size = new System.Drawing.Size(50, 21);
            this.lable5.TabIndex = 5;
            this.lable5.Text = "Depth";
            // 
            // cb_depth
            // 
            this.structuresExtender.SetAttributeName(this.cb_depth, null);
            this.structuresExtender.SetAttributeTypeName(this.cb_depth, null);
            this.structuresExtender.SetBindPropertyName(this.cb_depth, null);
            this.cb_depth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_depth.FormattingEnabled = true;
            this.cb_depth.Items.AddRange(new object[] {
            "Middle",
            "Front",
            "Behind"});
            this.cb_depth.Location = new System.Drawing.Point(382, 47);
            this.cb_depth.Name = "cb_depth";
            this.cb_depth.Size = new System.Drawing.Size(121, 21);
            this.cb_depth.TabIndex = 7;
            // 
            // label5
            // 
            this.structuresExtender.SetAttributeName(this.label5, null);
            this.structuresExtender.SetAttributeTypeName(this.label5, null);
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aqua;
            this.structuresExtender.SetBindPropertyName(this.label5, null);
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.MinimumSize = new System.Drawing.Size(50, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            // 
            // txt_height
            // 
            this.structuresExtender.SetAttributeName(this.txt_height, null);
            this.structuresExtender.SetAttributeTypeName(this.txt_height, null);
            this.structuresExtender.SetBindPropertyName(this.txt_height, null);
            this.txt_height.Location = new System.Drawing.Point(80, 158);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(121, 20);
            this.txt_height.TabIndex = 6;
            this.txt_height.Text = "3000";
            // 
            // button2
            // 
            this.structuresExtender.SetAttributeName(this.button2, null);
            this.structuresExtender.SetAttributeTypeName(this.button2, null);
            this.structuresExtender.SetBindPropertyName(this.button2, null);
            this.button2.Location = new System.Drawing.Point(254, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ve Cot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalog1, null);
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalog1, null);
            this.profileCatalog1.ButtonText = "Select...";
            this.profileCatalog1.Location = new System.Drawing.Point(213, 16);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(80, 19);
            this.profileCatalog1.TabIndex = 9;
            this.profileCatalog1.SelectionDone += new System.EventHandler(this.profileCatalog1_SelectionDone);
            // 
            // materialCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.materialCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.materialCatalog1, null);
            this.materialCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.materialCatalog1, null);
            this.materialCatalog1.ButtonText = "Select...";
            this.materialCatalog1.Location = new System.Drawing.Point(213, 47);
            this.materialCatalog1.Name = "materialCatalog1";
            this.materialCatalog1.SelectedMaterial = "";
            this.materialCatalog1.Size = new System.Drawing.Size(80, 21);
            this.materialCatalog1.TabIndex = 10;
            this.materialCatalog1.SelectionDone += new System.EventHandler(this.materialCatalog1_SelectionDone);
            // 
            // Form1
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(521, 311);
            this.Controls.Add(this.materialCatalog1);
            this.Controls.Add(this.profileCatalog1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_depth);
            this.Controls.Add(this.cb_plane);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txt_mat);
            this.Controls.Add(this.txt_prof);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_beam_pick);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_beam_pick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_plane;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.ComboBox cb_depth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Button button2;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalog1;
    }
}

