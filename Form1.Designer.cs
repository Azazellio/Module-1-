namespace moduleWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Feed = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AnimalsLV = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StorageLV = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.CheckedLV = new System.Windows.Forms.ListView();
            this.CheckB = new System.Windows.Forms.Button();
            this.Feed.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Feed
            // 
            this.Feed.Controls.Add(this.tabPage1);
            this.Feed.Controls.Add(this.tabPage2);
            this.Feed.Location = new System.Drawing.Point(12, 12);
            this.Feed.Name = "Feed";
            this.Feed.SelectedIndex = 0;
            this.Feed.Size = new System.Drawing.Size(948, 565);
            this.Feed.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.StorageLV);
            this.tabPage1.Controls.Add(this.AnimalsLV);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AnimalsLV
            // 
            this.AnimalsLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalsLV.HideSelection = false;
            this.AnimalsLV.Location = new System.Drawing.Point(635, 6);
            this.AnimalsLV.Name = "AnimalsLV";
            this.AnimalsLV.Size = new System.Drawing.Size(299, 520);
            this.AnimalsLV.TabIndex = 0;
            this.AnimalsLV.UseCompatibleStateImageBehavior = false;
            this.AnimalsLV.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CheckB);
            this.tabPage2.Controls.Add(this.CheckedLV);
            this.tabPage2.Controls.Add(this.timeTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StorageLV
            // 
            this.StorageLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageLV.HideSelection = false;
            this.StorageLV.Location = new System.Drawing.Point(277, 6);
            this.StorageLV.Name = "StorageLV";
            this.StorageLV.Size = new System.Drawing.Size(325, 504);
            this.StorageLV.TabIndex = 1;
            this.StorageLV.UseCompatibleStateImageBehavior = false;
            this.StorageLV.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "feed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(144, 75);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(142, 26);
            this.timeTB.TabIndex = 0;
            // 
            // CheckedLV
            // 
            this.CheckedLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckedLV.HideSelection = false;
            this.CheckedLV.Location = new System.Drawing.Point(638, 6);
            this.CheckedLV.Name = "CheckedLV";
            this.CheckedLV.Size = new System.Drawing.Size(296, 520);
            this.CheckedLV.TabIndex = 1;
            this.CheckedLV.UseCompatibleStateImageBehavior = false;
            this.CheckedLV.View = System.Windows.Forms.View.List;
            // 
            // CheckB
            // 
            this.CheckB.Location = new System.Drawing.Point(190, 252);
            this.CheckB.Name = "CheckB";
            this.CheckB.Size = new System.Drawing.Size(75, 50);
            this.CheckB.TabIndex = 2;
            this.CheckB.Text = "check";
            this.CheckB.UseVisualStyleBackColor = true;
            this.CheckB.Click += new System.EventHandler(this.CheckB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 589);
            this.Controls.Add(this.Feed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Feed.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Feed;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView AnimalsLV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView StorageLV;
        private System.Windows.Forms.Button CheckB;
        private System.Windows.Forms.ListView CheckedLV;
        private System.Windows.Forms.TextBox timeTB;
    }
}

