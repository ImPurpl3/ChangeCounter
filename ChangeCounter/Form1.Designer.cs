namespace ChangeCounter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ToonieCount = new System.Windows.Forms.Label();
            this.LoonieCount = new System.Windows.Forms.Label();
            this.QuarterCount = new System.Windows.Forms.Label();
            this.DimeCount = new System.Windows.Forms.Label();
            this.NickelCount = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.ToonieAdd = new System.Windows.Forms.Button();
            this.ToonieSub = new System.Windows.Forms.Button();
            this.LoonieSub = new System.Windows.Forms.Button();
            this.LoonieAdd = new System.Windows.Forms.Button();
            this.QuarterSub = new System.Windows.Forms.Button();
            this.QuarterAdd = new System.Windows.Forms.Button();
            this.DimeSub = new System.Windows.Forms.Button();
            this.DimeAdd = new System.Windows.Forms.Button();
            this.NickelSub = new System.Windows.Forms.Button();
            this.NickelAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ToonieInput = new System.Windows.Forms.TextBox();
            this.LoonieInput = new System.Windows.Forms.TextBox();
            this.QuarterInput = new System.Windows.Forms.TextBox();
            this.DimeInput = new System.Windows.Forms.TextBox();
            this.NickelInput = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.FileDateLabel = new System.Windows.Forms.Label();
            this.ValueTip = new System.Windows.Forms.ToolTip(this.components);
            this.HelpButton = new System.Windows.Forms.Button();
            this.HelpButtonTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toonies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(181, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loonies";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(348, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quarters";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(528, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dime";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(647, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nickel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(361, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 76);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToonieCount
            // 
            this.ToonieCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ToonieCount.Location = new System.Drawing.Point(52, 115);
            this.ToonieCount.Name = "ToonieCount";
            this.ToonieCount.Size = new System.Drawing.Size(75, 31);
            this.ToonieCount.TabIndex = 6;
            this.ToonieCount.Text = "0";
            this.ToonieCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoonieCount
            // 
            this.LoonieCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoonieCount.Location = new System.Drawing.Point(218, 115);
            this.LoonieCount.Name = "LoonieCount";
            this.LoonieCount.Size = new System.Drawing.Size(78, 31);
            this.LoonieCount.TabIndex = 7;
            this.LoonieCount.Text = "0";
            this.LoonieCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuarterCount
            // 
            this.QuarterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuarterCount.Location = new System.Drawing.Point(392, 115);
            this.QuarterCount.Name = "QuarterCount";
            this.QuarterCount.Size = new System.Drawing.Size(80, 31);
            this.QuarterCount.TabIndex = 8;
            this.QuarterCount.Text = "0";
            this.QuarterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DimeCount
            // 
            this.DimeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DimeCount.Location = new System.Drawing.Point(543, 115);
            this.DimeCount.Name = "DimeCount";
            this.DimeCount.Size = new System.Drawing.Size(80, 31);
            this.DimeCount.TabIndex = 9;
            this.DimeCount.Text = "0";
            this.DimeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NickelCount
            // 
            this.NickelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NickelCount.Location = new System.Drawing.Point(664, 115);
            this.NickelCount.Name = "NickelCount";
            this.NickelCount.Size = new System.Drawing.Size(88, 31);
            this.NickelCount.TabIndex = 10;
            this.NickelCount.Text = "0";
            this.NickelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.total.ForeColor = System.Drawing.Color.Green;
            this.total.Location = new System.Drawing.Point(14, 264);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(772, 151);
            this.total.TabIndex = 11;
            this.total.Text = "0";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToonieAdd
            // 
            this.ToonieAdd.Location = new System.Drawing.Point(52, 76);
            this.ToonieAdd.Name = "ToonieAdd";
            this.ToonieAdd.Size = new System.Drawing.Size(75, 23);
            this.ToonieAdd.TabIndex = 12;
            this.ToonieAdd.Text = "Add 1 (+)";
            this.ToonieAdd.UseVisualStyleBackColor = true;
            this.ToonieAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // ToonieSub
            // 
            this.ToonieSub.Location = new System.Drawing.Point(45, 162);
            this.ToonieSub.Name = "ToonieSub";
            this.ToonieSub.Size = new System.Drawing.Size(89, 23);
            this.ToonieSub.TabIndex = 13;
            this.ToonieSub.Text = "Subtract 1 (-)";
            this.ToonieSub.UseVisualStyleBackColor = true;
            this.ToonieSub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // LoonieSub
            // 
            this.LoonieSub.Location = new System.Drawing.Point(213, 162);
            this.LoonieSub.Name = "LoonieSub";
            this.LoonieSub.Size = new System.Drawing.Size(89, 23);
            this.LoonieSub.TabIndex = 15;
            this.LoonieSub.Text = "Subtract 1 (-)";
            this.LoonieSub.UseVisualStyleBackColor = true;
            this.LoonieSub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // LoonieAdd
            // 
            this.LoonieAdd.Location = new System.Drawing.Point(220, 76);
            this.LoonieAdd.Name = "LoonieAdd";
            this.LoonieAdd.Size = new System.Drawing.Size(75, 23);
            this.LoonieAdd.TabIndex = 14;
            this.LoonieAdd.Text = "Add 1 (+)";
            this.LoonieAdd.UseVisualStyleBackColor = true;
            this.LoonieAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // QuarterSub
            // 
            this.QuarterSub.Location = new System.Drawing.Point(388, 162);
            this.QuarterSub.Name = "QuarterSub";
            this.QuarterSub.Size = new System.Drawing.Size(89, 23);
            this.QuarterSub.TabIndex = 17;
            this.QuarterSub.Text = "Subtract 1 (-)";
            this.QuarterSub.UseVisualStyleBackColor = true;
            this.QuarterSub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // QuarterAdd
            // 
            this.QuarterAdd.Location = new System.Drawing.Point(395, 76);
            this.QuarterAdd.Name = "QuarterAdd";
            this.QuarterAdd.Size = new System.Drawing.Size(75, 23);
            this.QuarterAdd.TabIndex = 16;
            this.QuarterAdd.Text = "Add 1 (+)";
            this.QuarterAdd.UseVisualStyleBackColor = true;
            this.QuarterAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // DimeSub
            // 
            this.DimeSub.Location = new System.Drawing.Point(539, 162);
            this.DimeSub.Name = "DimeSub";
            this.DimeSub.Size = new System.Drawing.Size(89, 23);
            this.DimeSub.TabIndex = 19;
            this.DimeSub.Text = "Subtract 1 (-)";
            this.DimeSub.UseVisualStyleBackColor = true;
            this.DimeSub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // DimeAdd
            // 
            this.DimeAdd.Location = new System.Drawing.Point(546, 76);
            this.DimeAdd.Name = "DimeAdd";
            this.DimeAdd.Size = new System.Drawing.Size(75, 23);
            this.DimeAdd.TabIndex = 18;
            this.DimeAdd.Text = "Add 1 (+)";
            this.DimeAdd.UseVisualStyleBackColor = true;
            this.DimeAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // NickelSub
            // 
            this.NickelSub.Location = new System.Drawing.Point(664, 162);
            this.NickelSub.Name = "NickelSub";
            this.NickelSub.Size = new System.Drawing.Size(89, 23);
            this.NickelSub.TabIndex = 21;
            this.NickelSub.Text = "Subtract 1 (-)";
            this.NickelSub.UseVisualStyleBackColor = true;
            this.NickelSub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // NickelAdd
            // 
            this.NickelAdd.Location = new System.Drawing.Point(671, 76);
            this.NickelAdd.Name = "NickelAdd";
            this.NickelAdd.Size = new System.Drawing.Size(75, 23);
            this.NickelAdd.TabIndex = 20;
            this.NickelAdd.Text = "Add 1 (+)";
            this.NickelAdd.UseVisualStyleBackColor = true;
            this.NickelAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(157, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(331, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 31);
            this.label13.TabIndex = 23;
            this.label13.Text = "+";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(495, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "+";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(634, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 31);
            this.label15.TabIndex = 25;
            this.label15.Text = "+";
            // 
            // ToonieInput
            // 
            this.ToonieInput.AcceptsTab = true;
            this.ToonieInput.Location = new System.Drawing.Point(52, 191);
            this.ToonieInput.Name = "ToonieInput";
            this.ToonieInput.Size = new System.Drawing.Size(73, 20);
            this.ToonieInput.TabIndex = 26;
            this.ToonieInput.TabStop = false;
            this.ToonieInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToonieInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextChanged);
            // 
            // LoonieInput
            // 
            this.LoonieInput.AcceptsTab = true;
            this.LoonieInput.Location = new System.Drawing.Point(220, 191);
            this.LoonieInput.Name = "LoonieInput";
            this.LoonieInput.Size = new System.Drawing.Size(73, 20);
            this.LoonieInput.TabIndex = 27;
            this.LoonieInput.TabStop = false;
            this.LoonieInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoonieInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextChanged);
            // 
            // QuarterInput
            // 
            this.QuarterInput.AcceptsTab = true;
            this.QuarterInput.Location = new System.Drawing.Point(397, 191);
            this.QuarterInput.Name = "QuarterInput";
            this.QuarterInput.Size = new System.Drawing.Size(73, 20);
            this.QuarterInput.TabIndex = 28;
            this.QuarterInput.TabStop = false;
            this.QuarterInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuarterInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextChanged);
            // 
            // DimeInput
            // 
            this.DimeInput.AcceptsTab = true;
            this.DimeInput.Location = new System.Drawing.Point(546, 191);
            this.DimeInput.Name = "DimeInput";
            this.DimeInput.Size = new System.Drawing.Size(73, 20);
            this.DimeInput.TabIndex = 29;
            this.DimeInput.TabStop = false;
            this.DimeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DimeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextChanged);
            // 
            // NickelInput
            // 
            this.NickelInput.AcceptsTab = true;
            this.NickelInput.Location = new System.Drawing.Point(671, 191);
            this.NickelInput.Name = "NickelInput";
            this.NickelInput.Size = new System.Drawing.Size(73, 20);
            this.NickelInput.TabIndex = 30;
            this.NickelInput.TabStop = false;
            this.NickelInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NickelInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(713, 418);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 31;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportBttnClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(632, 418);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 32;
            this.SaveButton.Text = "Save to File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveBttnClick);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(551, 418);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(75, 23);
            this.ZeroButton.TabIndex = 33;
            this.ZeroButton.Text = "Zero Out";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroOut);
            // 
            // FileDateLabel
            // 
            this.FileDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileDateLabel.Location = new System.Drawing.Point(14, 416);
            this.FileDateLabel.Name = "FileDateLabel";
            this.FileDateLabel.Size = new System.Drawing.Size(533, 26);
            this.FileDateLabel.TabIndex = 34;
            this.FileDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValueTip
            // 
            this.ValueTip.AutomaticDelay = 100;
            this.ValueTip.BackColor = System.Drawing.SystemColors.Window;
            this.ValueTip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ValueTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HelpButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.Location = new System.Drawing.Point(10, 413);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(29, 28);
            this.HelpButton.TabIndex = 35;
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpBttnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.FileDateLabel);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.NickelInput);
            this.Controls.Add(this.DimeInput);
            this.Controls.Add(this.QuarterInput);
            this.Controls.Add(this.LoonieInput);
            this.Controls.Add(this.ToonieInput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NickelSub);
            this.Controls.Add(this.NickelAdd);
            this.Controls.Add(this.DimeSub);
            this.Controls.Add(this.DimeAdd);
            this.Controls.Add(this.QuarterSub);
            this.Controls.Add(this.QuarterAdd);
            this.Controls.Add(this.LoonieSub);
            this.Controls.Add(this.LoonieAdd);
            this.Controls.Add(this.ToonieSub);
            this.Controls.Add(this.ToonieAdd);
            this.Controls.Add(this.total);
            this.Controls.Add(this.NickelCount);
            this.Controls.Add(this.DimeCount);
            this.Controls.Add(this.QuarterCount);
            this.Controls.Add(this.LoonieCount);
            this.Controls.Add(this.ToonieCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Change Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ToonieCount;
        private System.Windows.Forms.Label LoonieCount;
        private System.Windows.Forms.Label QuarterCount;
        private System.Windows.Forms.Label DimeCount;
        private System.Windows.Forms.Label NickelCount;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button ToonieAdd;
        private System.Windows.Forms.Button ToonieSub;
        private System.Windows.Forms.Button LoonieSub;
        private System.Windows.Forms.Button LoonieAdd;
        private System.Windows.Forms.Button QuarterSub;
        private System.Windows.Forms.Button QuarterAdd;
        private System.Windows.Forms.Button DimeSub;
        private System.Windows.Forms.Button DimeAdd;
        private System.Windows.Forms.Button NickelSub;
        private System.Windows.Forms.Button NickelAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ToonieInput;
        private System.Windows.Forms.TextBox LoonieInput;
        private System.Windows.Forms.TextBox QuarterInput;
        private System.Windows.Forms.TextBox DimeInput;
        private System.Windows.Forms.TextBox NickelInput;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Label FileDateLabel;
        private System.Windows.Forms.ToolTip ValueTip;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ToolTip HelpButtonTip;
    }
}

