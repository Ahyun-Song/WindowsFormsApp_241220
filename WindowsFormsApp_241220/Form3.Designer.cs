namespace WindowsFormsApp_241220
{
    partial class Form3
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
            this.button_scissors = new System.Windows.Forms.Button();
            this.button_rock = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_scissors
            // 
            this.button_scissors.Location = new System.Drawing.Point(40, 23);
            this.button_scissors.Name = "button_scissors";
            this.button_scissors.Size = new System.Drawing.Size(182, 28);
            this.button_scissors.TabIndex = 0;
            this.button_scissors.Text = "가위";
            this.button_scissors.UseVisualStyleBackColor = true;
            this.button_scissors.Click += new System.EventHandler(this.button_scissors_Click);
            // 
            // button_rock
            // 
            this.button_rock.Location = new System.Drawing.Point(293, 24);
            this.button_rock.Name = "button_rock";
            this.button_rock.Size = new System.Drawing.Size(194, 27);
            this.button_rock.TabIndex = 1;
            this.button_rock.Text = "바위";
            this.button_rock.UseVisualStyleBackColor = true;
            this.button_rock.Click += new System.EventHandler(this.button_rock_Click);
            // 
            // button_paper
            // 
            this.button_paper.Location = new System.Drawing.Point(552, 23);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(211, 28);
            this.button_paper.TabIndex = 2;
            this.button_paper.Text = "보";
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.button_paper_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(40, 57);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(723, 381);
            this.textBox_result.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_rock);
            this.Controls.Add(this.button_scissors);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_scissors;
        private System.Windows.Forms.Button button_rock;
        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.TextBox textBox_result;
    }
}