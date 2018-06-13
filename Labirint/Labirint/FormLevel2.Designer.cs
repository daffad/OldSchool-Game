namespace Labirint
{
    partial class FormLevel2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_finish = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_door = new System.Windows.Forms.Label();
            this.label_wall1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(232, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 312);
            this.label5.TabIndex = 13;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(479, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 449);
            this.label4.TabIndex = 12;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 446);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 10);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 10);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label_finish
            // 
            this.label_finish.BackColor = System.Drawing.Color.Green;
            this.label_finish.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_finish.Location = new System.Drawing.Point(376, 396);
            this.label_finish.Name = "label_finish";
            this.label_finish.Size = new System.Drawing.Size(114, 43);
            this.label_finish.TabIndex = 8;
            this.label_finish.Text = "Финиш";
            this.label_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_finish.MouseEnter += new System.EventHandler(this.label_finish_MouseEnter);
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.Brown;
            this.label_start.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.Location = new System.Drawing.Point(6, 10);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(106, 43);
            this.label_start.TabIndex = 7;
            this.label_start.Text = "Старт";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_key
            // 
            this.label_key.BackColor = System.Drawing.Color.Gold;
            this.label_key.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_key.Location = new System.Drawing.Point(263, 10);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(25, 72);
            this.label_key.TabIndex = 14;
            this.label_key.Text = " ";
            this.label_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_key.MouseEnter += new System.EventHandler(this.label_key_MouseEnter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(295, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 312);
            this.label7.TabIndex = 15;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(345, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 312);
            this.label8.TabIndex = 16;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label_door
            // 
            this.label_door.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_door.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_door.Location = new System.Drawing.Point(316, 55);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(54, 72);
            this.label_door.TabIndex = 18;
            this.label_door.Text = " ";
            this.label_door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_door.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label_wall1
            // 
            this.label_wall1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_wall1.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_wall1.Location = new System.Drawing.Point(232, 263);
            this.label_wall1.Name = "label_wall1";
            this.label_wall1.Size = new System.Drawing.Size(138, 59);
            this.label_wall1.TabIndex = 19;
            this.label_wall1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wall1.MouseEnter += new System.EventHandler(this.label_wall1_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 448);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_finish);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_door);
            this.Controls.Add(this.label_wall1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel2";
            this.Shown += new System.EventHandler(this.FormLevel2_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_finish;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_door;
        private System.Windows.Forms.Label label_wall1;
        private System.Windows.Forms.Timer timer1;
    }
}