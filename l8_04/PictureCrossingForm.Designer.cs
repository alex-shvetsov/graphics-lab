namespace l8_04
{
    partial class PictureCrossingForm
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
            this.loadPicture = new System.Windows.Forms.Button();
            this.deletePicture = new System.Windows.Forms.Button();
            this.wait = new System.Windows.Forms.Timer(this.components);
            this.canvas = new l8_04.DoubleBufferPanel();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadPicture
            // 
            this.loadPicture.Location = new System.Drawing.Point(12, 484);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(123, 52);
            this.loadPicture.TabIndex = 2;
            this.loadPicture.Text = "Загрузить рисунок";
            this.loadPicture.UseVisualStyleBackColor = true;
            this.loadPicture.Click += new System.EventHandler(this.loadPicture_Click);
            // 
            // deletePicture
            // 
            this.deletePicture.Location = new System.Drawing.Point(12, 542);
            this.deletePicture.Name = "deletePicture";
            this.deletePicture.Size = new System.Drawing.Size(123, 50);
            this.deletePicture.TabIndex = 3;
            this.deletePicture.Text = "Удалить последний рисунок";
            this.deletePicture.UseVisualStyleBackColor = true;
            this.deletePicture.Click += new System.EventHandler(this.deletePicture_Click);
            // 
            // wait
            // 
            this.wait.Interval = 20;
            this.wait.Tick += new System.EventHandler(this.wait_Tick);
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(814, 466);
            this.canvas.TabIndex = 5;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(142, 485);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 6;
            // 
            // PictureCrossingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 598);
            this.Controls.Add(this.info);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.deletePicture);
            this.Controls.Add(this.loadPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PictureCrossingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пересечение картинок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadPicture;
        private System.Windows.Forms.Button deletePicture;
        private System.Windows.Forms.Timer wait;
        private DoubleBufferPanel canvas;
        private System.Windows.Forms.Label info;
    }
}

