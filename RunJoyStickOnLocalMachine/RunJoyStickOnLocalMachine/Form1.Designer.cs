﻿namespace RunJoyStickOnLocalMachine
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
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear Output Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // joystickTimer
            // 
            this.joystickTimer.Enabled = true;
            this.joystickTimer.Tick += new System.EventHandler(this.joystickTimer_Tick_1);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 34);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(253, 192);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Window";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Joystick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label1;
    }
}

