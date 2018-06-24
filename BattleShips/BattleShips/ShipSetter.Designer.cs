namespace BattleShips
{
    partial class ShipSetter
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
            this.letterBoxFrom = new System.Windows.Forms.TextBox();
            this.numberBoxFrom = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberBoxTo = new System.Windows.Forms.TextBox();
            this.letterBoxTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // letterBoxFrom
            // 
            this.letterBoxFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterBoxFrom.Location = new System.Drawing.Point(65, 40);
            this.letterBoxFrom.MaxLength = 1;
            this.letterBoxFrom.Name = "letterBoxFrom";
            this.letterBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.letterBoxFrom.TabIndex = 0;
            // 
            // numberBoxFrom
            // 
            this.numberBoxFrom.Location = new System.Drawing.Point(65, 68);
            this.numberBoxFrom.MaxLength = 2;
            this.numberBoxFrom.Name = "numberBoxFrom";
            this.numberBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.numberBoxFrom.TabIndex = 1;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(269, 113);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Letter:";
            // 
            // numberBoxTo
            // 
            this.numberBoxTo.Location = new System.Drawing.Point(232, 68);
            this.numberBoxTo.MaxLength = 2;
            this.numberBoxTo.Name = "numberBoxTo";
            this.numberBoxTo.Size = new System.Drawing.Size(100, 20);
            this.numberBoxTo.TabIndex = 6;
            // 
            // letterBoxTo
            // 
            this.letterBoxTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letterBoxTo.Location = new System.Drawing.Point(232, 40);
            this.letterBoxTo.MaxLength = 1;
            this.letterBoxTo.Name = "letterBoxTo";
            this.letterBoxTo.Size = new System.Drawing.Size(100, 20);
            this.letterBoxTo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "To:";
            // 
            // ShipSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 149);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberBoxTo);
            this.Controls.Add(this.letterBoxTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.numberBoxFrom);
            this.Controls.Add(this.letterBoxFrom);
            this.Name = "ShipSetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShipSetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letterBoxFrom;
        private System.Windows.Forms.TextBox numberBoxFrom;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberBoxTo;
        private System.Windows.Forms.TextBox letterBoxTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}