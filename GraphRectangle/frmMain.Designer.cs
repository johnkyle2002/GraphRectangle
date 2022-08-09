namespace GraphRectangle
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_RecX2 = new System.Windows.Forms.NumericUpDown();
            this.pnl_Command = new System.Windows.Forms.Panel();
            this.nud_RecX = new System.Windows.Forms.NumericUpDown();
            this.nud_RecY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_RecY2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_PointY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_PointX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuildGrap = new System.Windows.Forms.Button();
            this.pnl_DrawingBoard = new System.Windows.Forms.Panel();
            this.graphServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecX2)).BeginInit();
            this.pnl_Command.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.Location = new System.Drawing.Point(11, 174);
            this.txtErrorMessage.Multiline = true;
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(260, 388);
            this.txtErrorMessage.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // nud_RecX2
            // 
            this.nud_RecX2.Location = new System.Drawing.Point(48, 42);
            this.nud_RecX2.Name = "nud_RecX2";
            this.nud_RecX2.Size = new System.Drawing.Size(55, 23);
            this.nud_RecX2.TabIndex = 4;
            // 
            // pnl_Command
            // 
            this.pnl_Command.Controls.Add(this.nud_RecX);
            this.pnl_Command.Controls.Add(this.label6);
            this.pnl_Command.Controls.Add(this.button1);
            this.pnl_Command.Controls.Add(this.label4);
            this.pnl_Command.Controls.Add(this.nud_RecX2);
            this.pnl_Command.Controls.Add(this.nud_RecY);
            this.pnl_Command.Controls.Add(this.label5);
            this.pnl_Command.Controls.Add(this.nud_RecY2);
            this.pnl_Command.Controls.Add(this.label3);
            this.pnl_Command.Enabled = false;
            this.pnl_Command.Location = new System.Drawing.Point(12, 56);
            this.pnl_Command.Name = "pnl_Command";
            this.pnl_Command.Size = new System.Drawing.Size(259, 112);
            this.pnl_Command.TabIndex = 14;
            // 
            // nud_RecX
            // 
            this.nud_RecX.Location = new System.Drawing.Point(48, 13);
            this.nud_RecX.Name = "nud_RecX";
            this.nud_RecX.Size = new System.Drawing.Size(55, 23);
            this.nud_RecX.TabIndex = 4;
            // 
            // nud_RecY
            // 
            this.nud_RecY.Location = new System.Drawing.Point(162, 13);
            this.nud_RecY.Name = "nud_RecY";
            this.nud_RecY.Size = new System.Drawing.Size(55, 23);
            this.nud_RecY.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Width:";
            // 
            // nud_RecY2
            // 
            this.nud_RecY2.Location = new System.Drawing.Point(162, 42);
            this.nud_RecY2.Name = "nud_RecY2";
            this.nud_RecY2.Size = new System.Drawing.Size(55, 23);
            this.nud_RecY2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "X:";
            // 
            // nud_PointY
            // 
            this.nud_PointY.Location = new System.Drawing.Point(128, 12);
            this.nud_PointY.Name = "nud_PointY";
            this.nud_PointY.Size = new System.Drawing.Size(55, 23);
            this.nud_PointY.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "X:";
            // 
            // nud_PointX
            // 
            this.nud_PointX.Location = new System.Drawing.Point(34, 12);
            this.nud_PointX.Name = "nud_PointX";
            this.nud_PointX.Size = new System.Drawing.Size(55, 23);
            this.nud_PointX.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y:";
            // 
            // btn_BuildGrap
            // 
            this.btn_BuildGrap.Location = new System.Drawing.Point(198, 12);
            this.btn_BuildGrap.Name = "btn_BuildGrap";
            this.btn_BuildGrap.Size = new System.Drawing.Size(75, 23);
            this.btn_BuildGrap.TabIndex = 9;
            this.btn_BuildGrap.Text = "Build Grap";
            this.btn_BuildGrap.UseVisualStyleBackColor = true;
            this.btn_BuildGrap.Click += new System.EventHandler(this.btn_BuildGrap_Click);
            // 
            // pnl_DrawingBoard
            // 
            this.pnl_DrawingBoard.BackColor = System.Drawing.Color.White;
            this.pnl_DrawingBoard.Location = new System.Drawing.Point(279, 12);
            this.pnl_DrawingBoard.Name = "pnl_DrawingBoard";
            this.pnl_DrawingBoard.Size = new System.Drawing.Size(550, 550);
            this.pnl_DrawingBoard.TabIndex = 8;
            // 
            // graphServiceBindingSource
            // 
            this.graphServiceBindingSource.DataSource = typeof(GraphRectangle.Service.GraphService);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 573);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.pnl_Command);
            this.Controls.Add(this.nud_PointY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_PointX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_BuildGrap);
            this.Controls.Add(this.pnl_DrawingBoard);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecX2)).EndInit();
            this.pnl_Command.ResumeLayout(false);
            this.pnl_Command.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtErrorMessage;
        private Label label6;
        private Button button1;
        private Label label4;
        private NumericUpDown nud_RecX2;
        private Panel pnl_Command;
        private NumericUpDown nud_RecX;
        private NumericUpDown nud_RecY;
        private Label label5;
        private NumericUpDown nud_RecY2;
        private Label label3;
        private NumericUpDown nud_PointY;
        private Label label1;
        private NumericUpDown nud_PointX;
        private Label label2;
        private Button btn_BuildGrap;
        private Panel pnl_DrawingBoard;
        private BindingSource graphServiceBindingSource;
    }
}