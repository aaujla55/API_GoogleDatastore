namespace _300823928_AUJLA_ASS2
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
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnModifyTask = new System.Windows.Forms.Button();
            this.txtBoxDeleteTask = new System.Windows.Forms.TextBox();
            this.txtBoxDes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(289, 44);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(12, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Google DataStore Program";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(289, 115);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 4;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnModifyTask
            // 
            this.btnModifyTask.Location = new System.Drawing.Point(122, 191);
            this.btnModifyTask.Name = "btnModifyTask";
            this.btnModifyTask.Size = new System.Drawing.Size(134, 23);
            this.btnModifyTask.TabIndex = 6;
            this.btnModifyTask.Text = "Modify";
            this.btnModifyTask.UseVisualStyleBackColor = true;
            this.btnModifyTask.Click += new System.EventHandler(this.btnModifyTask_Click);
            // 
            // txtBoxDeleteTask
            // 
            this.txtBoxDeleteTask.Location = new System.Drawing.Point(78, 117);
            this.txtBoxDeleteTask.Name = "txtBoxDeleteTask";
            this.txtBoxDeleteTask.Size = new System.Drawing.Size(191, 20);
            this.txtBoxDeleteTask.TabIndex = 7;
            // 
            // txtBoxDes
            // 
            this.txtBoxDes.Location = new System.Drawing.Point(78, 41);
            this.txtBoxDes.Name = "txtBoxDes";
            this.txtBoxDes.Size = new System.Drawing.Size(191, 46);
            this.txtBoxDes.TabIndex = 8;
            this.txtBoxDes.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project ID";
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.AutoSize = true;
            this.lblUpdateMessage.Location = new System.Drawing.Point(15, 236);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Size = new System.Drawing.Size(0, 13);
            this.lblUpdateMessage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 331);
            this.Controls.Add(this.lblUpdateMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDes);
            this.Controls.Add(this.txtBoxDeleteTask);
            this.Controls.Add(this.btnModifyTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddTask);
            this.Name = "Form1";
            this.Text = "Google DataStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnModifyTask;
        private System.Windows.Forms.TextBox txtBoxDeleteTask;
        private System.Windows.Forms.RichTextBox txtBoxDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdateMessage;
    }
}

