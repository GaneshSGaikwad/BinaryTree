namespace BinarySearchTree
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.insertData = new System.Windows.Forms.Button();
            this.displayData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(6, 35);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(125, 26);
            this.txtData.TabIndex = 1;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // insertData
            // 
            this.insertData.Location = new System.Drawing.Point(166, 33);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(75, 30);
            this.insertData.TabIndex = 2;
            this.insertData.Text = "Add";
            this.insertData.UseVisualStyleBackColor = true;
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // displayData
            // 
            this.displayData.Location = new System.Drawing.Point(107, 51);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(90, 36);
            this.displayData.TabIndex = 4;
            this.displayData.Text = "view";
            this.displayData.UseVisualStyleBackColor = true;
            this.displayData.Click += new System.EventHandler(this.displayData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.insertData);
            this.groupBox1.Location = new System.Drawing.Point(276, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayData);
            this.groupBox2.Location = new System.Drawing.Point(276, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 102);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click here to View Data in console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button insertData;
        private System.Windows.Forms.Button displayData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

