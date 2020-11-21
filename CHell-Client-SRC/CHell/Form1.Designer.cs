
namespace CHell
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Copyout = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Target
            // 
            this.Target.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Target.Location = new System.Drawing.Point(24, 47);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(750, 27);
            this.Target.TabIndex = 0;
            this.Target.Text = "http://<TARGET>/chell.php";
            this.Target.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Target_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target";
            // 
            // Command
            // 
            this.Command.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Command.Location = new System.Drawing.Point(24, 115);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(750, 27);
            this.Command.TabIndex = 2;
            this.Command.Text = "id";
            this.Command.TextChanged += new System.EventHandler(this.Command_TextChanged);
            this.Command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Command_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button1.Location = new System.Drawing.Point(24, 211);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(86, 31);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Run";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Output
            // 
            this.Output.AcceptsReturn = true;
            this.Output.AcceptsTab = true;
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Output.Location = new System.Drawing.Point(127, 176);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(647, 262);
            this.Output.TabIndex = 5;
            this.Output.Text = "Please fill the Target and Command fields and push the Run button.";
            this.Output.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // Copyout
            // 
            this.Copyout.Cursor = System.Windows.Forms.Cursors.Default;
            this.Copyout.Location = new System.Drawing.Point(24, 258);
            this.Copyout.Name = "Copyout";
            this.Copyout.Size = new System.Drawing.Size(86, 31);
            this.Copyout.TabIndex = 7;
            this.Copyout.Text = "Copy";
            this.Copyout.UseVisualStyleBackColor = true;
            this.Copyout.Click += new System.EventHandler(this.Copyout_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1.Location = new System.Drawing.Point(24, 310);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Append";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Copyout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Target);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form";
            this.Text = "CHell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Copyout;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

