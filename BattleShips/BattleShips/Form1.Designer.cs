namespace BattleShips
{
    partial class Form1
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
            this.mapA = new System.Windows.Forms.Panel();
            this.hideA = new System.Windows.Forms.Button();
            this.ship2A = new System.Windows.Forms.Button();
            this.ship3A = new System.Windows.Forms.Button();
            this.ship4A = new System.Windows.Forms.Button();
            this.ship5A = new System.Windows.Forms.Button();
            this.mapB = new System.Windows.Forms.Panel();
            this.hideB = new System.Windows.Forms.Button();
            this.ship2B = new System.Windows.Forms.Button();
            this.ship5B = new System.Windows.Forms.Button();
            this.ship3B = new System.Windows.Forms.Button();
            this.ship4B = new System.Windows.Forms.Button();
            this.showA = new System.Windows.Forms.Button();
            this.showB = new System.Windows.Forms.Button();
            this.gridA = new System.Windows.Forms.Panel();
            this.turnLabel = new System.Windows.Forms.Label();
            this.gridB = new System.Windows.Forms.Panel();
            this.readyAButton = new System.Windows.Forms.Button();
            this.readyBButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerAPasswordSet = new System.Windows.Forms.TextBox();
            this.playerBPasswordSet = new System.Windows.Forms.TextBox();
            this.playerAPassword = new System.Windows.Forms.TextBox();
            this.playerBPassword = new System.Windows.Forms.TextBox();
            this.passLabelA = new System.Windows.Forms.Label();
            this.passLabelB = new System.Windows.Forms.Label();
            this.mapA.SuspendLayout();
            this.mapB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapA
            // 
            this.mapA.Controls.Add(this.passLabelA);
            this.mapA.Controls.Add(this.playerAPasswordSet);
            this.mapA.Controls.Add(this.readyAButton);
            this.mapA.Controls.Add(this.hideA);
            this.mapA.Controls.Add(this.ship2A);
            this.mapA.Controls.Add(this.ship3A);
            this.mapA.Controls.Add(this.ship4A);
            this.mapA.Controls.Add(this.ship5A);
            this.mapA.Location = new System.Drawing.Point(12, 38);
            this.mapA.Name = "mapA";
            this.mapA.Size = new System.Drawing.Size(455, 305);
            this.mapA.TabIndex = 0;
            this.mapA.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // hideA
            // 
            this.hideA.Location = new System.Drawing.Point(3, 277);
            this.hideA.Name = "hideA";
            this.hideA.Size = new System.Drawing.Size(75, 23);
            this.hideA.TabIndex = 4;
            this.hideA.Text = "Hide";
            this.hideA.UseVisualStyleBackColor = true;
            this.hideA.Click += new System.EventHandler(this.HideA_Click);
            // 
            // ship2A
            // 
            this.ship2A.Location = new System.Drawing.Point(282, 107);
            this.ship2A.Name = "ship2A";
            this.ship2A.Size = new System.Drawing.Size(75, 23);
            this.ship2A.TabIndex = 3;
            this.ship2A.Text = "2 Ship (4)";
            this.ship2A.UseVisualStyleBackColor = true;
            this.ship2A.Click += new System.EventHandler(this.ship2A_Click);
            // 
            // ship3A
            // 
            this.ship3A.Location = new System.Drawing.Point(282, 78);
            this.ship3A.Name = "ship3A";
            this.ship3A.Size = new System.Drawing.Size(75, 23);
            this.ship3A.TabIndex = 2;
            this.ship3A.Text = "3 Ship (3)";
            this.ship3A.UseVisualStyleBackColor = true;
            this.ship3A.Click += new System.EventHandler(this.ship3A_Click);
            // 
            // ship4A
            // 
            this.ship4A.Location = new System.Drawing.Point(282, 49);
            this.ship4A.Name = "ship4A";
            this.ship4A.Size = new System.Drawing.Size(75, 23);
            this.ship4A.TabIndex = 1;
            this.ship4A.Text = "4 Ship (2)";
            this.ship4A.UseVisualStyleBackColor = true;
            this.ship4A.Click += new System.EventHandler(this.Ship4A_Click);
            // 
            // ship5A
            // 
            this.ship5A.Location = new System.Drawing.Point(282, 20);
            this.ship5A.Name = "ship5A";
            this.ship5A.Size = new System.Drawing.Size(75, 23);
            this.ship5A.TabIndex = 0;
            this.ship5A.Text = "5 Ship (1)";
            this.ship5A.UseVisualStyleBackColor = true;
            this.ship5A.Click += new System.EventHandler(this.Ship5A_Click);
            // 
            // mapB
            // 
            this.mapB.Controls.Add(this.passLabelB);
            this.mapB.Controls.Add(this.playerBPasswordSet);
            this.mapB.Controls.Add(this.readyBButton);
            this.mapB.Controls.Add(this.hideB);
            this.mapB.Controls.Add(this.ship2B);
            this.mapB.Controls.Add(this.ship5B);
            this.mapB.Controls.Add(this.ship3B);
            this.mapB.Controls.Add(this.ship4B);
            this.mapB.Location = new System.Drawing.Point(494, 38);
            this.mapB.Name = "mapB";
            this.mapB.Size = new System.Drawing.Size(471, 305);
            this.mapB.TabIndex = 1;
            this.mapB.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // hideB
            // 
            this.hideB.Location = new System.Drawing.Point(3, 277);
            this.hideB.Name = "hideB";
            this.hideB.Size = new System.Drawing.Size(75, 23);
            this.hideB.TabIndex = 5;
            this.hideB.Text = "Hide";
            this.hideB.UseVisualStyleBackColor = true;
            this.hideB.Click += new System.EventHandler(this.HideB_Click);
            // 
            // ship2B
            // 
            this.ship2B.Location = new System.Drawing.Point(282, 107);
            this.ship2B.Name = "ship2B";
            this.ship2B.Size = new System.Drawing.Size(75, 23);
            this.ship2B.TabIndex = 7;
            this.ship2B.Text = "2 Ship (4)";
            this.ship2B.UseVisualStyleBackColor = true;
            this.ship2B.Click += new System.EventHandler(this.ship2B_Click);
            // 
            // ship5B
            // 
            this.ship5B.Location = new System.Drawing.Point(282, 20);
            this.ship5B.Name = "ship5B";
            this.ship5B.Size = new System.Drawing.Size(75, 23);
            this.ship5B.TabIndex = 4;
            this.ship5B.Text = "5 Ship (1)";
            this.ship5B.UseVisualStyleBackColor = true;
            this.ship5B.Click += new System.EventHandler(this.ship5B_Click);
            // 
            // ship3B
            // 
            this.ship3B.Location = new System.Drawing.Point(282, 78);
            this.ship3B.Name = "ship3B";
            this.ship3B.Size = new System.Drawing.Size(75, 23);
            this.ship3B.TabIndex = 6;
            this.ship3B.Text = "3 Ship (3)";
            this.ship3B.UseVisualStyleBackColor = true;
            this.ship3B.Click += new System.EventHandler(this.ship3B_Click);
            // 
            // ship4B
            // 
            this.ship4B.Location = new System.Drawing.Point(282, 49);
            this.ship4B.Name = "ship4B";
            this.ship4B.Size = new System.Drawing.Size(75, 23);
            this.ship4B.TabIndex = 5;
            this.ship4B.Text = "4 Ship (2)";
            this.ship4B.UseVisualStyleBackColor = true;
            this.ship4B.Click += new System.EventHandler(this.ship4B_Click);
            // 
            // showA
            // 
            this.showA.Location = new System.Drawing.Point(15, 349);
            this.showA.Name = "showA";
            this.showA.Size = new System.Drawing.Size(75, 23);
            this.showA.TabIndex = 5;
            this.showA.Text = "Show";
            this.showA.UseVisualStyleBackColor = true;
            this.showA.Click += new System.EventHandler(this.ShowA_Click);
            // 
            // showB
            // 
            this.showB.Location = new System.Drawing.Point(497, 349);
            this.showB.Name = "showB";
            this.showB.Size = new System.Drawing.Size(75, 23);
            this.showB.TabIndex = 6;
            this.showB.Text = "Show";
            this.showB.UseVisualStyleBackColor = true;
            this.showB.Click += new System.EventHandler(this.ShowB_Click);
            // 
            // gridA
            // 
            this.gridA.Location = new System.Drawing.Point(15, 379);
            this.gridA.Name = "gridA";
            this.gridA.Size = new System.Drawing.Size(452, 300);
            this.gridA.TabIndex = 7;
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(386, 355);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(108, 17);
            this.turnLabel.TabIndex = 8;
            this.turnLabel.Text = "Player A Turn";
            // 
            // gridB
            // 
            this.gridB.Location = new System.Drawing.Point(497, 378);
            this.gridB.Name = "gridB";
            this.gridB.Size = new System.Drawing.Size(468, 300);
            this.gridB.TabIndex = 8;
            // 
            // readyAButton
            // 
            this.readyAButton.Location = new System.Drawing.Point(377, 277);
            this.readyAButton.Name = "readyAButton";
            this.readyAButton.Size = new System.Drawing.Size(75, 23);
            this.readyAButton.TabIndex = 5;
            this.readyAButton.Text = "Ready";
            this.readyAButton.UseVisualStyleBackColor = true;
            this.readyAButton.Click += new System.EventHandler(this.readyAButton_Click);
            // 
            // readyBButton
            // 
            this.readyBButton.Location = new System.Drawing.Point(393, 277);
            this.readyBButton.Name = "readyBButton";
            this.readyBButton.Size = new System.Drawing.Size(75, 23);
            this.readyBButton.TabIndex = 6;
            this.readyBButton.Text = "Ready";
            this.readyBButton.UseVisualStyleBackColor = true;
            this.readyBButton.Click += new System.EventHandler(this.readyBButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGameToolStripMenuItem1});
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.restartGameToolStripMenuItem.Text = "Menu";
            // 
            // restartGameToolStripMenuItem1
            // 
            this.restartGameToolStripMenuItem1.Name = "restartGameToolStripMenuItem1";
            this.restartGameToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.restartGameToolStripMenuItem1.Text = "Restart Game";
            this.restartGameToolStripMenuItem1.Click += new System.EventHandler(this.restartGameToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Player A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player B";
            // 
            // playerAPasswordSet
            // 
            this.playerAPasswordSet.Location = new System.Drawing.Point(271, 279);
            this.playerAPasswordSet.Name = "playerAPasswordSet";
            this.playerAPasswordSet.Size = new System.Drawing.Size(100, 20);
            this.playerAPasswordSet.TabIndex = 6;
            // 
            // playerBPasswordSet
            // 
            this.playerBPasswordSet.Location = new System.Drawing.Point(287, 279);
            this.playerBPasswordSet.Name = "playerBPasswordSet";
            this.playerBPasswordSet.Size = new System.Drawing.Size(100, 20);
            this.playerBPasswordSet.TabIndex = 7;
            // 
            // playerAPassword
            // 
            this.playerAPassword.Location = new System.Drawing.Point(90, 351);
            this.playerAPassword.Name = "playerAPassword";
            this.playerAPassword.PasswordChar = '*';
            this.playerAPassword.Size = new System.Drawing.Size(100, 20);
            this.playerAPassword.TabIndex = 7;
            // 
            // playerBPassword
            // 
            this.playerBPassword.AccessibleDescription = "";
            this.playerBPassword.AccessibleName = "";
            this.playerBPassword.Location = new System.Drawing.Point(578, 352);
            this.playerBPassword.Name = "playerBPassword";
            this.playerBPassword.PasswordChar = '*';
            this.playerBPassword.Size = new System.Drawing.Size(100, 20);
            this.playerBPassword.TabIndex = 8;
            this.playerBPassword.Tag = "";
            // 
            // passLabelA
            // 
            this.passLabelA.AutoSize = true;
            this.passLabelA.Location = new System.Drawing.Point(209, 282);
            this.passLabelA.Name = "passLabelA";
            this.passLabelA.Size = new System.Drawing.Size(56, 13);
            this.passLabelA.TabIndex = 13;
            this.passLabelA.Text = "Password:";
            // 
            // passLabelB
            // 
            this.passLabelB.AutoSize = true;
            this.passLabelB.Location = new System.Drawing.Point(225, 282);
            this.passLabelB.Name = "passLabelB";
            this.passLabelB.Size = new System.Drawing.Size(56, 13);
            this.passLabelB.TabIndex = 14;
            this.passLabelB.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.playerBPassword);
            this.Controls.Add(this.playerAPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridB);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.gridA);
            this.Controls.Add(this.showB);
            this.Controls.Add(this.showA);
            this.Controls.Add(this.mapB);
            this.Controls.Add(this.mapA);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleShip";
            this.mapA.ResumeLayout(false);
            this.mapA.PerformLayout();
            this.mapB.ResumeLayout(false);
            this.mapB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mapA;
        private System.Windows.Forms.Panel mapB;
        private System.Windows.Forms.Button ship5A;
        private System.Windows.Forms.Button ship2A;
        private System.Windows.Forms.Button ship3A;
        private System.Windows.Forms.Button ship4A;
        private System.Windows.Forms.Button ship2B;
        private System.Windows.Forms.Button ship5B;
        private System.Windows.Forms.Button ship3B;
        private System.Windows.Forms.Button ship4B;
        private System.Windows.Forms.Button hideA;
        private System.Windows.Forms.Button showA;
        private System.Windows.Forms.Button hideB;
        private System.Windows.Forms.Button showB;
        private System.Windows.Forms.Panel gridA;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Panel gridB;
        private System.Windows.Forms.Button readyAButton;
        private System.Windows.Forms.Button readyBButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerAPasswordSet;
        private System.Windows.Forms.TextBox playerBPasswordSet;
        private System.Windows.Forms.TextBox playerAPassword;
        private System.Windows.Forms.TextBox playerBPassword;
        private System.Windows.Forms.Label passLabelA;
        private System.Windows.Forms.Label passLabelB;
    }
}

