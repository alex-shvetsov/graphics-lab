namespace l8
{
    partial class PyramidForm
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
            this.contextMenuStrip_Canvas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoMovingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoResizingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCrossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMoving = new System.Windows.Forms.Panel();
            this.labelMoving = new System.Windows.Forms.Label();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.checkBoxAutoResizing = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoMoving = new System.Windows.Forms.CheckBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.checkBoxShowFigure = new System.Windows.Forms.CheckBox();
            this.checkBoxShowCross = new System.Windows.Forms.CheckBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip_Canvas.SuspendLayout();
            this.panelMoving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip_Canvas
            // 
            this.contextMenuStrip_Canvas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoMovingToolStripMenuItem,
            this.autoResizingToolStripMenuItem,
            this.toolStripMenuItem1,
            this.translationToolStripMenuItem,
            this.showFigureToolStripMenuItem,
            this.showCrossToolStripMenuItem});
            this.contextMenuStrip_Canvas.Name = "contextMenuStrip_Canvas";
            this.contextMenuStrip_Canvas.Size = new System.Drawing.Size(278, 120);
            // 
            // autoMovingToolStripMenuItem
            // 
            this.autoMovingToolStripMenuItem.CheckOnClick = true;
            this.autoMovingToolStripMenuItem.Name = "autoMovingToolStripMenuItem";
            this.autoMovingToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.autoMovingToolStripMenuItem.Text = "Автоматическое перемешение";
            this.autoMovingToolStripMenuItem.Click += new System.EventHandler(this.autoMovingToolStripMenuItem_Click);
            // 
            // autoResizingToolStripMenuItem
            // 
            this.autoResizingToolStripMenuItem.CheckOnClick = true;
            this.autoResizingToolStripMenuItem.Name = "autoResizingToolStripMenuItem";
            this.autoResizingToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.autoResizingToolStripMenuItem.Text = "Автоматическое изменение размера";
            this.autoResizingToolStripMenuItem.Click += new System.EventHandler(this.autoResizingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(274, 6);
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.rightToolStripMenuItem,
            this.leftToolStripMenuItem});
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.translationToolStripMenuItem.Text = "Перемещение";
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.CheckOnClick = true;
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.upToolStripMenuItem.Text = "Вверх";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.CheckOnClick = true;
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.downToolStripMenuItem.Text = "Вниз";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Checked = true;
            this.rightToolStripMenuItem.CheckOnClick = true;
            this.rightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rightToolStripMenuItem.Text = "Вправо";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.CheckOnClick = true;
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leftToolStripMenuItem.Text = "Влево";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // showFigureToolStripMenuItem
            // 
            this.showFigureToolStripMenuItem.Checked = true;
            this.showFigureToolStripMenuItem.CheckOnClick = true;
            this.showFigureToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFigureToolStripMenuItem.Name = "showFigureToolStripMenuItem";
            this.showFigureToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.showFigureToolStripMenuItem.Text = "Отобразить фигуру";
            this.showFigureToolStripMenuItem.Click += new System.EventHandler(this.showFigureToolStripMenuItem_Click);
            // 
            // showCrossToolStripMenuItem
            // 
            this.showCrossToolStripMenuItem.CheckOnClick = true;
            this.showCrossToolStripMenuItem.Name = "showCrossToolStripMenuItem";
            this.showCrossToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.showCrossToolStripMenuItem.Text = "Отобразить сечение";
            this.showCrossToolStripMenuItem.Click += new System.EventHandler(this.showCrossToolStripMenuItem_Click);
            // 
            // panelMoving
            // 
            this.panelMoving.Controls.Add(this.labelMoving);
            this.panelMoving.Controls.Add(this.radioButtonDown);
            this.panelMoving.Controls.Add(this.radioButtonUp);
            this.panelMoving.Controls.Add(this.radioButtonLeft);
            this.panelMoving.Controls.Add(this.radioButtonRight);
            this.panelMoving.Controls.Add(this.checkBoxAutoResizing);
            this.panelMoving.Controls.Add(this.checkBoxAutoMoving);
            this.panelMoving.Location = new System.Drawing.Point(16, 54);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(289, 126);
            this.panelMoving.TabIndex = 0;
            // 
            // labelMoving
            // 
            this.labelMoving.AutoSize = true;
            this.labelMoving.Location = new System.Drawing.Point(-3, 56);
            this.labelMoving.Name = "labelMoving";
            this.labelMoving.Size = new System.Drawing.Size(78, 13);
            this.labelMoving.TabIndex = 0;
            this.labelMoving.Text = "Направление:";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(173, 79);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(50, 17);
            this.radioButtonDown.TabIndex = 4;
            this.radioButtonDown.Text = "Вниз";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            this.radioButtonDown.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(173, 56);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(55, 17);
            this.radioButtonUp.TabIndex = 3;
            this.radioButtonUp.Text = "Вверх";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            this.radioButtonUp.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(96, 79);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(56, 17);
            this.radioButtonLeft.TabIndex = 2;
            this.radioButtonLeft.Text = "Влево";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            this.radioButtonLeft.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Checked = true;
            this.radioButtonRight.Location = new System.Drawing.Point(96, 56);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRight.TabIndex = 1;
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.Text = "Вправо";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            this.radioButtonRight.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // checkBoxAutoResizing
            // 
            this.checkBoxAutoResizing.AutoSize = true;
            this.checkBoxAutoResizing.Location = new System.Drawing.Point(3, 26);
            this.checkBoxAutoResizing.Name = "checkBoxAutoResizing";
            this.checkBoxAutoResizing.Size = new System.Drawing.Size(216, 17);
            this.checkBoxAutoResizing.TabIndex = 0;
            this.checkBoxAutoResizing.TabStop = false;
            this.checkBoxAutoResizing.Text = "Автоматическое изменение размера";
            this.checkBoxAutoResizing.UseVisualStyleBackColor = true;
            this.checkBoxAutoResizing.CheckedChanged += new System.EventHandler(this.checkBoxAutoResizing_CheckedChanged);
            // 
            // checkBoxAutoMoving
            // 
            this.checkBoxAutoMoving.AutoSize = true;
            this.checkBoxAutoMoving.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAutoMoving.Name = "checkBoxAutoMoving";
            this.checkBoxAutoMoving.Size = new System.Drawing.Size(184, 17);
            this.checkBoxAutoMoving.TabIndex = 0;
            this.checkBoxAutoMoving.TabStop = false;
            this.checkBoxAutoMoving.Text = "Автоматическое перемещение";
            this.checkBoxAutoMoving.UseVisualStyleBackColor = true;
            this.checkBoxAutoMoving.CheckedChanged += new System.EventHandler(this.checkBoxAutoMoving_CheckedChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(13, 16);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(49, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер:";
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(68, 3);
            this.trackBarSize.Maximum = 300;
            this.trackBarSize.Minimum = 10;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(237, 45);
            this.trackBarSize.TabIndex = 4;
            this.trackBarSize.TickFrequency = 2;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSize.Value = 145;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // checkBoxShowFigure
            // 
            this.checkBoxShowFigure.AutoSize = true;
            this.checkBoxShowFigure.Checked = true;
            this.checkBoxShowFigure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowFigure.Location = new System.Drawing.Point(16, 360);
            this.checkBoxShowFigure.Name = "checkBoxShowFigure";
            this.checkBoxShowFigure.Size = new System.Drawing.Size(124, 17);
            this.checkBoxShowFigure.TabIndex = 5;
            this.checkBoxShowFigure.Text = "Отобразить фигуру";
            this.checkBoxShowFigure.UseVisualStyleBackColor = true;
            this.checkBoxShowFigure.CheckedChanged += new System.EventHandler(this.checkBoxShowFigure_CheckedChanged);
            // 
            // checkBoxShowCross
            // 
            this.checkBoxShowCross.AutoSize = true;
            this.checkBoxShowCross.Location = new System.Drawing.Point(156, 360);
            this.checkBoxShowCross.Name = "checkBoxShowCross";
            this.checkBoxShowCross.Size = new System.Drawing.Size(130, 17);
            this.checkBoxShowCross.TabIndex = 6;
            this.checkBoxShowCross.Text = "Отобразить сечение";
            this.checkBoxShowCross.UseVisualStyleBackColor = true;
            this.checkBoxShowCross.CheckedChanged += new System.EventHandler(this.checkBoxShowCross_CheckedChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItem2.Text = "Автоматическое вращение";
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(380, 380);
            this.canvas.TabIndex = 7;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // autoTimer
            // 
            this.autoTimer.Interval = 40;
            this.autoTimer.Tick += new System.EventHandler(this.autoTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Нажмите правой кнопкой мыши по области вне холста,\r\nчтобы открыть контекстное мен" +
    "ю.\r\nНажатие правой кнопкой мыши по холсту вызовет \r\nперемещение фигуры, если она" +
    " отображена.";
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip_Canvas;
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.panelMoving);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarSize);
            this.panel1.Controls.Add(this.checkBoxShowFigure);
            this.panel1.Controls.Add(this.checkBoxShowCross);
            this.panel1.Location = new System.Drawing.Point(393, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 406);
            this.panel1.TabIndex = 9;
            // 
            // PyramidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PyramidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пирамида с сечением";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PyramidForm_FormClosing);
            this.contextMenuStrip_Canvas.ResumeLayout(false);
            this.panelMoving.ResumeLayout(false);
            this.panelMoving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMoving;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.CheckBox checkBoxAutoResizing;
        private System.Windows.Forms.CheckBox checkBoxAutoMoving;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Canvas;
        private System.Windows.Forms.ToolStripMenuItem autoMovingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoResizingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelMoving;
        private System.Windows.Forms.CheckBox checkBoxShowFigure;
        private System.Windows.Forms.CheckBox checkBoxShowCross;
        private System.Windows.Forms.ToolStripMenuItem showFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCrossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer autoTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

