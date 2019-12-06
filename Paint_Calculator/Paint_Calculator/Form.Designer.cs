namespace Paint_Calculator
{
    partial class Form
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
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.cb_measure = new System.Windows.Forms.ComboBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.tb_length = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.gb_output = new System.Windows.Forms.GroupBox();
            this.tb_paintReq = new System.Windows.Forms.TextBox();
            this.tb_roomVolume = new System.Windows.Forms.TextBox();
            this.tb_floorArea = new System.Windows.Forms.TextBox();
            this.lbl_paintReq = new System.Windows.Forms.Label();
            this.lbl_roomVolume = new System.Windows.Forms.Label();
            this.lbl_floorArea = new System.Windows.Forms.Label();
            this.gb_input.SuspendLayout();
            this.gb_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.cb_measure);
            this.gb_input.Controls.Add(this.btn_calc);
            this.gb_input.Controls.Add(this.lbl_length);
            this.gb_input.Controls.Add(this.lbl_width);
            this.gb_input.Controls.Add(this.lbl_height);
            this.gb_input.Controls.Add(this.tb_width);
            this.gb_input.Controls.Add(this.tb_length);
            this.gb_input.Controls.Add(this.tb_height);
            this.gb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_input.Location = new System.Drawing.Point(24, 21);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(320, 243);
            this.gb_input.TabIndex = 1;
            this.gb_input.TabStop = false;
            this.gb_input.Text = "Input Room Measurements";
            // 
            // cb_measure
            // 
            this.cb_measure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_measure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_measure.FormattingEnabled = true;
            this.cb_measure.Items.AddRange(new object[] {
            "Feet (ft)",
            "Metres (m)"});
            this.cb_measure.Location = new System.Drawing.Point(139, 30);
            this.cb_measure.Name = "cb_measure";
            this.cb_measure.Size = new System.Drawing.Size(150, 24);
            this.cb_measure.TabIndex = 0;
            // 
            // btn_calc
            // 
            this.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(83, 194);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(142, 34);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_length.Location = new System.Drawing.Point(23, 156);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(102, 18);
            this.lbl_length.TabIndex = 5;
            this.lbl_length.Text = "Room Length:";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(29, 113);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(96, 18);
            this.lbl_width.TabIndex = 4;
            this.lbl_width.Text = "Room Width:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(25, 72);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(100, 18);
            this.lbl_height.TabIndex = 3;
            this.lbl_height.Text = "Room Height:";
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(139, 112);
            this.tb_width.MaxLength = 10;
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(150, 22);
            this.tb_width.TabIndex = 2;
            // 
            // tb_length
            // 
            this.tb_length.Location = new System.Drawing.Point(139, 155);
            this.tb_length.MaxLength = 10;
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(150, 22);
            this.tb_length.TabIndex = 3;
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(139, 71);
            this.tb_height.MaxLength = 10;
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(150, 22);
            this.tb_height.TabIndex = 1;
            // 
            // gb_output
            // 
            this.gb_output.Controls.Add(this.tb_paintReq);
            this.gb_output.Controls.Add(this.tb_roomVolume);
            this.gb_output.Controls.Add(this.tb_floorArea);
            this.gb_output.Controls.Add(this.lbl_paintReq);
            this.gb_output.Controls.Add(this.lbl_roomVolume);
            this.gb_output.Controls.Add(this.lbl_floorArea);
            this.gb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_output.Location = new System.Drawing.Point(24, 270);
            this.gb_output.Name = "gb_output";
            this.gb_output.Size = new System.Drawing.Size(320, 166);
            this.gb_output.TabIndex = 2;
            this.gb_output.TabStop = false;
            this.gb_output.Text = "Output";
            // 
            // tb_paintReq
            // 
            this.tb_paintReq.Enabled = false;
            this.tb_paintReq.Location = new System.Drawing.Point(179, 116);
            this.tb_paintReq.MaxLength = 20;
            this.tb_paintReq.Name = "tb_paintReq";
            this.tb_paintReq.Size = new System.Drawing.Size(123, 22);
            this.tb_paintReq.TabIndex = 10;
            // 
            // tb_roomVolume
            // 
            this.tb_roomVolume.Enabled = false;
            this.tb_roomVolume.Location = new System.Drawing.Point(179, 71);
            this.tb_roomVolume.MaxLength = 20;
            this.tb_roomVolume.Name = "tb_roomVolume";
            this.tb_roomVolume.Size = new System.Drawing.Size(123, 22);
            this.tb_roomVolume.TabIndex = 9;
            // 
            // tb_floorArea
            // 
            this.tb_floorArea.Enabled = false;
            this.tb_floorArea.Location = new System.Drawing.Point(179, 27);
            this.tb_floorArea.MaxLength = 20;
            this.tb_floorArea.Name = "tb_floorArea";
            this.tb_floorArea.Size = new System.Drawing.Size(123, 22);
            this.tb_floorArea.TabIndex = 7;
            // 
            // lbl_paintReq
            // 
            this.lbl_paintReq.AutoSize = true;
            this.lbl_paintReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paintReq.Location = new System.Drawing.Point(12, 117);
            this.lbl_paintReq.Name = "lbl_paintReq";
            this.lbl_paintReq.Size = new System.Drawing.Size(161, 18);
            this.lbl_paintReq.TabIndex = 8;
            this.lbl_paintReq.Text = "Paint required for walls:";
            // 
            // lbl_roomVolume
            // 
            this.lbl_roomVolume.AutoSize = true;
            this.lbl_roomVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomVolume.Location = new System.Drawing.Point(65, 72);
            this.lbl_roomVolume.Name = "lbl_roomVolume";
            this.lbl_roomVolume.Size = new System.Drawing.Size(108, 18);
            this.lbl_roomVolume.TabIndex = 7;
            this.lbl_roomVolume.Text = "Room Volume:";
            // 
            // lbl_floorArea
            // 
            this.lbl_floorArea.AutoSize = true;
            this.lbl_floorArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_floorArea.Location = new System.Drawing.Point(92, 28);
            this.lbl_floorArea.Name = "lbl_floorArea";
            this.lbl_floorArea.Size = new System.Drawing.Size(81, 18);
            this.lbl_floorArea.TabIndex = 6;
            this.lbl_floorArea.Text = "Floor Area:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 457);
            this.Controls.Add(this.gb_output);
            this.Controls.Add(this.gb_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Paint Calculator";
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.gb_output.ResumeLayout(false);
            this.gb_output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.GroupBox gb_output;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.TextBox tb_length;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_paintReq;
        private System.Windows.Forms.Label lbl_roomVolume;
        private System.Windows.Forms.Label lbl_floorArea;
        private System.Windows.Forms.ComboBox cb_measure;
        private System.Windows.Forms.TextBox tb_paintReq;
        private System.Windows.Forms.TextBox tb_roomVolume;
        private System.Windows.Forms.TextBox tb_floorArea;
    }
}

