
namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.StarButtonn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sumar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(312, 35);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(377, 40);
            this.timeLabel.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.SkyBlue;
            this.Label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(232, 86);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Tiempo Restante";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(75, 136);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(75, 61);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.BackColor = System.Drawing.Color.Yellow;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(329, 132);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(81, 68);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(583, 141);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(136, 41);
            this.sumar.TabIndex = 1;
            this.sumar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.sumar.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(583, 221);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(136, 41);
            this.difference.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.BackColor = System.Drawing.Color.Yellow;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(329, 221);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(81, 59);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minusRightLabel.Click += new System.EventHandler(this.minusRightLabel_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSalmon;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 58);
            this.label8.TabIndex = 8;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(75, 213);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(75, 67);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(583, 301);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(136, 41);
            this.product.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 50);
            this.label10.TabIndex = 15;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.BackColor = System.Drawing.Color.Yellow;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(329, 303);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(81, 56);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSalmon;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(211, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 66);
            this.label12.TabIndex = 13;
            this.label12.Text = "x";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(75, 288);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(75, 66);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(583, 385);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(136, 41);
            this.quotient.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(445, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 50);
            this.label14.TabIndex = 20;
            this.label14.Text = "=";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.BackColor = System.Drawing.Color.Yellow;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(335, 375);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(75, 61);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dividedRightLabel.Click += new System.EventHandler(this.dividedRightLabel_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightSalmon;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(211, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 71);
            this.label16.TabIndex = 18;
            this.label16.Text = "÷";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(75, 380);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(75, 56);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StarButtonn
            // 
            this.StarButtonn.AutoSize = true;
            this.StarButtonn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StarButtonn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarButtonn.Location = new System.Drawing.Point(217, 452);
            this.StarButtonn.Name = "StarButtonn";
            this.StarButtonn.Size = new System.Drawing.Size(253, 77);
            this.StarButtonn.TabIndex = 0;
            this.StarButtonn.Text = "Iniciar la Prueba";
            this.StarButtonn.UseVisualStyleBackColor = false;
            this.StarButtonn.Click += new System.EventHandler(this.StarButtonn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathQuiz.Properties.Resources.descarga__19_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 541);
            this.Controls.Add(this.StarButtonn);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba Matematica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sumar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sumar;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button StarButtonn;
        private System.Windows.Forms.Timer timer1;
    }
}

