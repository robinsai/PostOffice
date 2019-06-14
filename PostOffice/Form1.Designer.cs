namespace PostOffice
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.gifTimer = new System.Windows.Forms.Timer(this.components);
            this.EntranceDoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntranceDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(207, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.ClosedDoor_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.ClosedDoor_MouseLeave);
            // 
            // gifTimer
            // 
            this.gifTimer.Interval = 2500;
            this.gifTimer.Tick += new System.EventHandler(this.GifTimer_Tick);
            // 
            // EntranceDoor
            // 
            this.EntranceDoor.Image = global::PostOffice.Properties.Resources.ClosedDoor;
            this.EntranceDoor.Location = new System.Drawing.Point(150, 12);
            this.EntranceDoor.Name = "EntranceDoor";
            this.EntranceDoor.Size = new System.Drawing.Size(500, 274);
            this.EntranceDoor.TabIndex = 1;
            this.EntranceDoor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntranceDoor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntranceDoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox EntranceDoor;
        private System.Windows.Forms.Timer gifTimer;
    }
}

