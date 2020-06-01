namespace GLobal_Mouse_Events
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mouse_Location_X_TextBox = new System.Windows.Forms.TextBox();
            this.X_label = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.Mouse_Location_Y_TextBox = new System.Windows.Forms.TextBox();
            this.key_press_label = new System.Windows.Forms.Label();
            this.Key_Press_textBox = new System.Windows.Forms.TextBox();
            this.mouse_key_Pressed_label = new System.Windows.Forms.Label();
            this.mouse_key_press_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(275, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 253);
            this.panel1.TabIndex = 0;
            // 
            // Mouse_Location_X_TextBox
            // 
            this.Mouse_Location_X_TextBox.Location = new System.Drawing.Point(312, 359);
            this.Mouse_Location_X_TextBox.Name = "Mouse_Location_X_TextBox";
            this.Mouse_Location_X_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Mouse_Location_X_TextBox.TabIndex = 1;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Location = new System.Drawing.Point(292, 362);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(14, 13);
            this.X_label.TabIndex = 2;
            this.X_label.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(292, 399);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 13);
            this.label_Y.TabIndex = 4;
            this.label_Y.Text = "Y";
            // 
            // Mouse_Location_Y_TextBox
            // 
            this.Mouse_Location_Y_TextBox.Location = new System.Drawing.Point(312, 396);
            this.Mouse_Location_Y_TextBox.Name = "Mouse_Location_Y_TextBox";
            this.Mouse_Location_Y_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Mouse_Location_Y_TextBox.TabIndex = 3;
            // 
            // key_press_label
            // 
            this.key_press_label.AutoSize = true;
            this.key_press_label.Location = new System.Drawing.Point(249, 297);
            this.key_press_label.Name = "key_press_label";
            this.key_press_label.Size = new System.Drawing.Size(57, 13);
            this.key_press_label.TabIndex = 6;
            this.key_press_label.Text = "Key Press:";
            // 
            // Key_Press_textBox
            // 
            this.Key_Press_textBox.Location = new System.Drawing.Point(312, 294);
            this.Key_Press_textBox.Name = "Key_Press_textBox";
            this.Key_Press_textBox.Size = new System.Drawing.Size(100, 20);
            this.Key_Press_textBox.TabIndex = 5;
            // 
            // mouse_key_Pressed_label
            // 
            this.mouse_key_Pressed_label.AutoSize = true;
            this.mouse_key_Pressed_label.Location = new System.Drawing.Point(214, 329);
            this.mouse_key_Pressed_label.Name = "mouse_key_Pressed_label";
            this.mouse_key_Pressed_label.Size = new System.Drawing.Size(92, 13);
            this.mouse_key_Pressed_label.TabIndex = 8;
            this.mouse_key_Pressed_label.Text = "Mouse Key Press:";
            // 
            // mouse_key_press_textBox
            // 
            this.mouse_key_press_textBox.Location = new System.Drawing.Point(312, 326);
            this.mouse_key_press_textBox.Name = "mouse_key_press_textBox";
            this.mouse_key_press_textBox.Size = new System.Drawing.Size(100, 20);
            this.mouse_key_press_textBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mouse_key_Pressed_label);
            this.Controls.Add(this.mouse_key_press_textBox);
            this.Controls.Add(this.key_press_label);
            this.Controls.Add(this.Key_Press_textBox);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.Mouse_Location_Y_TextBox);
            this.Controls.Add(this.X_label);
            this.Controls.Add(this.Mouse_Location_X_TextBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Mouse_Location_X_TextBox;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.TextBox Mouse_Location_Y_TextBox;
        private System.Windows.Forms.Label key_press_label;
        private System.Windows.Forms.TextBox Key_Press_textBox;
        private System.Windows.Forms.Label mouse_key_Pressed_label;
        private System.Windows.Forms.TextBox mouse_key_press_textBox;
    }
}

