namespace l8_03
{
    partial class PictureEditingForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveBuffer = new System.Windows.Forms.Button();
            this.loadBuffer = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.prohibitPaintingTimer = new System.Windows.Forms.Timer(this.components);
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 2;
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(39, 419);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(99, 23);
            this.color1.TabIndex = 3;
            this.color1.Text = "Первый цвет";
            this.color1.UseVisualStyleBackColor = true;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(39, 448);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(99, 23);
            this.color2.TabIndex = 4;
            this.color2.Text = "Второй цвет";
            this.color2.UseVisualStyleBackColor = true;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(525, 420);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 49);
            this.saveFile.TabIndex = 5;
            this.saveFile.Text = "Сохранить картинку";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveBuffer
            // 
            this.saveBuffer.Location = new System.Drawing.Point(322, 420);
            this.saveBuffer.Name = "saveBuffer";
            this.saveBuffer.Size = new System.Drawing.Size(197, 23);
            this.saveBuffer.TabIndex = 6;
            this.saveBuffer.Text = "Скопировать в буфер обмена";
            this.saveBuffer.UseVisualStyleBackColor = true;
            this.saveBuffer.Click += new System.EventHandler(this.saveBuffer_Click);
            // 
            // loadBuffer
            // 
            this.loadBuffer.Location = new System.Drawing.Point(322, 448);
            this.loadBuffer.Name = "loadBuffer";
            this.loadBuffer.Size = new System.Drawing.Size(197, 23);
            this.loadBuffer.TabIndex = 8;
            this.loadBuffer.Text = "Вставить из буфера обмена";
            this.loadBuffer.UseVisualStyleBackColor = true;
            this.loadBuffer.Click += new System.EventHandler(this.loadBuffer_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(602, 420);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(75, 49);
            this.loadFile.TabIndex = 9;
            this.loadFile.Text = "Загрузить картинку";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(664, 401);
            this.canvas.TabIndex = 10;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // prohibitPaintingTimer
            // 
            this.prohibitPaintingTimer.Interval = 10;
            this.prohibitPaintingTimer.Tick += new System.EventHandler(this.prohibitPaintingTimer_Tick);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(217, 448);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(99, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // PictureEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 481);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.loadBuffer);
            this.Controls.Add(this.saveBuffer);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PictureEditingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рисунок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button saveBuffer;
        private System.Windows.Forms.Button loadBuffer;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer prohibitPaintingTimer;
        private System.Windows.Forms.Button clear;
    }
}

