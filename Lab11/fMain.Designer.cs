
namespace Lab11
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.cbCircles = new System.Windows.Forms.ComboBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(823, 459);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.cbCircles);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(563, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(260, 459);
            this.pnTools.TabIndex = 1;
            // 
            // cbCircles
            // 
            this.cbCircles.FormattingEnabled = true;
            this.cbCircles.Location = new System.Drawing.Point(38, 30);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(202, 21);
            this.cbCircles.TabIndex = 0;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(38, 70);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(202, 23);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Створити новий об\'єкт";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(38, 99);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(202, 23);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(38, 128);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(202, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(107, 255);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 33);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(175, 298);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(65, 31);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.Location = new System.Drawing.Point(107, 216);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(65, 33);
            this.btnUpFar.TabIndex = 7;
            this.btnUpFar.Text = "↑↑";
            this.btnUpFar.UseVisualStyleBackColor = true;
            this.btnUpFar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.Location = new System.Drawing.Point(190, 333);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(65, 31);
            this.btnRightFar.TabIndex = 8;
            this.btnRightFar.Text = "->>";
            this.btnRightFar.UseVisualStyleBackColor = true;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.Location = new System.Drawing.Point(20, 331);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(65, 33);
            this.btnLeftFar.TabIndex = 9;
            this.btnLeftFar.Text = "<<-";
            this.btnLeftFar.UseVisualStyleBackColor = true;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(38, 296);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(65, 33);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Text = "<-";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCollapse.Location = new System.Drawing.Point(107, 333);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(65, 31);
            this.btnCollapse.TabIndex = 12;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(107, 370);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(65, 31);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.Location = new System.Drawing.Point(107, 407);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(65, 31);
            this.btnDownFar.TabIndex = 14;
            this.btnDownFar.Text = "↓↓";
            this.btnDownFar.UseVisualStyleBackColor = true;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.SystemColors.Control;
            this.btnExpand.BackgroundImage = global::Lab11.Properties.Resources._1200px_Plus__svg;
            this.btnExpand.Location = new System.Drawing.Point(107, 296);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(65, 31);
            this.btnExpand.TabIndex = 11;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 459);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота No11";
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbCircles;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
    }
}

