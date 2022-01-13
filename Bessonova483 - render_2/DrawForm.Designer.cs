namespace Bessonova483___render
{
    partial class DrawForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelgreen = new System.Windows.Forms.Label();
            this.labelred = new System.Windows.Forms.Label();
            this.textBoxblue = new System.Windows.Forms.TextBox();
            this.textBoxgreen = new System.Windows.Forms.TextBox();
            this.textBoxred = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.buttonRender = new System.Windows.Forms.Button();
            this.textBoxside = new System.Windows.Forms.TextBox();
            this.labelforsquare = new System.Windows.Forms.Label();
            this.textBoxRad = new System.Windows.Forms.TextBox();
            this.labelforcircle = new System.Windows.Forms.Label();
            this.listBoxfigures = new System.Windows.Forms.ListBox();
            this.pictureBoxfigures = new System.Windows.Forms.PictureBox();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRen2 = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.groupBoxVec = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonren3 = new System.Windows.Forms.Button();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfigures)).BeginInit();
            this.groupBoxVec.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelBlue);
            this.groupBox1.Controls.Add(this.labelgreen);
            this.groupBox1.Controls.Add(this.labelred);
            this.groupBox1.Controls.Add(this.textBoxblue);
            this.groupBox1.Controls.Add(this.textBoxgreen);
            this.groupBox1.Controls.Add(this.textBoxred);
            this.groupBox1.Controls.Add(this.comboBoxColor);
            this.groupBox1.Location = new System.Drawing.Point(796, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 149);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(58, 105);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(56, 20);
            this.textBoxNum.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Число";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(245, 59);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(28, 13);
            this.labelBlue.TabIndex = 25;
            this.labelBlue.Text = "Blue";
            // 
            // labelgreen
            // 
            this.labelgreen.AutoSize = true;
            this.labelgreen.Location = new System.Drawing.Point(130, 59);
            this.labelgreen.Name = "labelgreen";
            this.labelgreen.Size = new System.Drawing.Size(36, 13);
            this.labelgreen.TabIndex = 24;
            this.labelgreen.Text = "Green";
            // 
            // labelred
            // 
            this.labelred.AutoSize = true;
            this.labelred.Location = new System.Drawing.Point(7, 62);
            this.labelred.Name = "labelred";
            this.labelred.Size = new System.Drawing.Size(27, 13);
            this.labelred.TabIndex = 23;
            this.labelred.Text = "Red";
            // 
            // textBoxblue
            // 
            this.textBoxblue.Location = new System.Drawing.Point(287, 56);
            this.textBoxblue.Name = "textBoxblue";
            this.textBoxblue.Size = new System.Drawing.Size(58, 20);
            this.textBoxblue.TabIndex = 22;
            // 
            // textBoxgreen
            // 
            this.textBoxgreen.Location = new System.Drawing.Point(172, 56);
            this.textBoxgreen.Name = "textBoxgreen";
            this.textBoxgreen.Size = new System.Drawing.Size(55, 20);
            this.textBoxgreen.TabIndex = 21;
            // 
            // textBoxred
            // 
            this.textBoxred.Location = new System.Drawing.Point(58, 56);
            this.textBoxred.Name = "textBoxred";
            this.textBoxred.Size = new System.Drawing.Size(56, 20);
            this.textBoxred.TabIndex = 20;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Random",
            "Writing",
            "Mix",
            "On number"});
            this.comboBoxColor.Location = new System.Drawing.Point(7, 20);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 0;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // buttonRender
            // 
            this.buttonRender.Location = new System.Drawing.Point(564, 21);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(75, 23);
            this.buttonRender.TabIndex = 40;
            this.buttonRender.Text = "Render";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // textBoxside
            // 
            this.textBoxside.Location = new System.Drawing.Point(430, 49);
            this.textBoxside.Name = "textBoxside";
            this.textBoxside.Size = new System.Drawing.Size(100, 20);
            this.textBoxside.TabIndex = 39;
            // 
            // labelforsquare
            // 
            this.labelforsquare.AutoSize = true;
            this.labelforsquare.Location = new System.Drawing.Point(388, 49);
            this.labelforsquare.Name = "labelforsquare";
            this.labelforsquare.Size = new System.Drawing.Size(0, 13);
            this.labelforsquare.TabIndex = 38;
            // 
            // textBoxRad
            // 
            this.textBoxRad.Location = new System.Drawing.Point(430, 18);
            this.textBoxRad.Name = "textBoxRad";
            this.textBoxRad.Size = new System.Drawing.Size(100, 20);
            this.textBoxRad.TabIndex = 37;
            // 
            // labelforcircle
            // 
            this.labelforcircle.AutoSize = true;
            this.labelforcircle.Location = new System.Drawing.Point(388, 18);
            this.labelforcircle.Name = "labelforcircle";
            this.labelforcircle.Size = new System.Drawing.Size(0, 13);
            this.labelforcircle.TabIndex = 36;
            // 
            // listBoxfigures
            // 
            this.listBoxfigures.FormattingEnabled = true;
            this.listBoxfigures.Location = new System.Drawing.Point(21, 74);
            this.listBoxfigures.Name = "listBoxfigures";
            this.listBoxfigures.Size = new System.Drawing.Size(188, 329);
            this.listBoxfigures.TabIndex = 35;
            // 
            // pictureBoxfigures
            // 
            this.pictureBoxfigures.Location = new System.Drawing.Point(219, 74);
            this.pictureBoxfigures.Name = "pictureBoxfigures";
            this.pictureBoxfigures.Size = new System.Drawing.Size(524, 333);
            this.pictureBoxfigures.TabIndex = 34;
            this.pictureBoxfigures.TabStop = false;
            this.pictureBoxfigures.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxfigures_Paint);
            this.pictureBoxfigures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxfigures_MouseDown);
            this.pictureBoxfigures.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxfigures_MouseMove);
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Items.AddRange(new object[] {
            "circle",
            "square"});
            this.comboBoxFigures.Location = new System.Drawing.Point(242, 23);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigures.TabIndex = 33;
            this.comboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigures_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(134, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(30, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRen2
            // 
            this.buttonRen2.Location = new System.Drawing.Point(645, 21);
            this.buttonRen2.Name = "buttonRen2";
            this.buttonRen2.Size = new System.Drawing.Size(75, 23);
            this.buttonRen2.TabIndex = 44;
            this.buttonRen2.Text = "Render2";
            this.buttonRen2.UseVisualStyleBackColor = true;
            this.buttonRen2.Click += new System.EventHandler(this.buttonRen2_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(186, 33);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(55, 20);
            this.textBoxY.TabIndex = 27;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(21, 39);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 28;
            this.labelX.Text = "X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(72, 33);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(56, 20);
            this.textBoxX.TabIndex = 26;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(144, 36);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 29;
            this.labelY.Text = "Y";
            // 
            // groupBoxVec
            // 
            this.groupBoxVec.Controls.Add(this.labelY);
            this.groupBoxVec.Controls.Add(this.textBoxX);
            this.groupBoxVec.Controls.Add(this.labelX);
            this.groupBoxVec.Controls.Add(this.textBoxY);
            this.groupBoxVec.Location = new System.Drawing.Point(796, 187);
            this.groupBoxVec.Name = "groupBoxVec";
            this.groupBoxVec.Size = new System.Drawing.Size(351, 90);
            this.groupBoxVec.TabIndex = 42;
            this.groupBoxVec.TabStop = false;
            this.groupBoxVec.Text = "Vec";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelT);
            this.groupBox2.Controls.Add(this.textBoxT);
            this.groupBox2.Location = new System.Drawing.Point(796, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 90);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ray";
            // 
            // buttonren3
            // 
            this.buttonren3.Location = new System.Drawing.Point(645, 50);
            this.buttonren3.Name = "buttonren3";
            this.buttonren3.Size = new System.Drawing.Size(75, 23);
            this.buttonren3.TabIndex = 45;
            this.buttonren3.Text = "Render3";
            this.buttonren3.UseVisualStyleBackColor = true;
            this.buttonren3.Click += new System.EventHandler(this.buttonren3_Click);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(72, 38);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(56, 20);
            this.textBoxT.TabIndex = 30;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(22, 38);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(14, 13);
            this.labelT.TabIndex = 28;
            this.labelT.Text = "T";
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 434);
            this.Controls.Add(this.buttonren3);
            this.Controls.Add(this.buttonRen2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxVec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRender);
            this.Controls.Add(this.textBoxside);
            this.Controls.Add(this.labelforsquare);
            this.Controls.Add(this.textBoxRad);
            this.Controls.Add(this.labelforcircle);
            this.Controls.Add(this.listBoxfigures);
            this.Controls.Add(this.pictureBoxfigures);
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "DrawForm";
            this.Text = "Bessonova483 - render";
            this.Load += new System.EventHandler(this.DrawForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfigures)).EndInit();
            this.groupBoxVec.ResumeLayout(false);
            this.groupBoxVec.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelgreen;
        private System.Windows.Forms.Label labelred;
        private System.Windows.Forms.TextBox textBoxblue;
        private System.Windows.Forms.TextBox textBoxgreen;
        private System.Windows.Forms.TextBox textBoxred;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.TextBox textBoxside;
        private System.Windows.Forms.Label labelforsquare;
        private System.Windows.Forms.TextBox textBoxRad;
        private System.Windows.Forms.Label labelforcircle;
        private System.Windows.Forms.ListBox listBoxfigures;
        private System.Windows.Forms.PictureBox pictureBoxfigures;
        private System.Windows.Forms.ComboBox comboBoxFigures;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRen2;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBoxVec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonren3;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.TextBox textBoxT;
    }
}

