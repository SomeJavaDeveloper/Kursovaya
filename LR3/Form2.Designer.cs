
namespace LR3
{
    partial class Form2
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
            this.ViewResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guestName = new System.Windows.Forms.TextBox();
            this.isForOne = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isOccupied = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isVip = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isSeaLandscape = new System.Windows.Forms.CheckBox();
            this.applyFiltreB = new System.Windows.Forms.Button();
            this.showFullB = new System.Windows.Forms.Button();
            this.guestFindB = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewResults
            // 
            this.ViewResults.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ViewResults.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewResults.ForeColor = System.Drawing.SystemColors.Control;
            this.ViewResults.HideSelection = false;
            this.ViewResults.Location = new System.Drawing.Point(0, 0);
            this.ViewResults.Name = "ViewResults";
            this.ViewResults.Size = new System.Drawing.Size(798, 483);
            this.ViewResults.TabIndex = 0;
            this.ViewResults.UseCompatibleStateImageBehavior = false;
            this.ViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер комнаты";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Количество мест";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Свободно мест";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Имена постояльцев";
            this.columnHeader4.Width = 310;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.ViewResults);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 476);
            this.panel3.TabIndex = 33;
            // 
            // guestName
            // 
            this.guestName.BackColor = System.Drawing.Color.SteelBlue;
            this.guestName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guestName.ForeColor = System.Drawing.SystemColors.Control;
            this.guestName.Location = new System.Drawing.Point(12, 534);
            this.guestName.MaxLength = 30;
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(156, 27);
            this.guestName.TabIndex = 34;
            // 
            // isForOne
            // 
            this.isForOne.ForeColor = System.Drawing.SystemColors.Control;
            this.isForOne.Location = new System.Drawing.Point(172, 499);
            this.isForOne.Margin = new System.Windows.Forms.Padding(1);
            this.isForOne.Name = "isForOne";
            this.isForOne.Size = new System.Drawing.Size(14, 31);
            this.isForOne.TabIndex = 35;
            this.isForOne.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Номер на одного";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(205, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Номер занят";
            // 
            // isOccupied
            // 
            this.isOccupied.ForeColor = System.Drawing.SystemColors.Control;
            this.isOccupied.Location = new System.Drawing.Point(328, 499);
            this.isOccupied.Margin = new System.Windows.Forms.Padding(1);
            this.isOccupied.Name = "isOccupied";
            this.isOccupied.Size = new System.Drawing.Size(14, 31);
            this.isOccupied.TabIndex = 37;
            this.isOccupied.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(366, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "VIP номер";
            // 
            // isVip
            // 
            this.isVip.ForeColor = System.Drawing.SystemColors.Control;
            this.isVip.Location = new System.Drawing.Point(466, 499);
            this.isVip.Margin = new System.Windows.Forms.Padding(1);
            this.isVip.Name = "isVip";
            this.isVip.Size = new System.Drawing.Size(14, 31);
            this.isVip.TabIndex = 39;
            this.isVip.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(501, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Вид на море";
            // 
            // isSeaLandscape
            // 
            this.isSeaLandscape.ForeColor = System.Drawing.SystemColors.Control;
            this.isSeaLandscape.Location = new System.Drawing.Point(623, 499);
            this.isSeaLandscape.Margin = new System.Windows.Forms.Padding(1);
            this.isSeaLandscape.Name = "isSeaLandscape";
            this.isSeaLandscape.Size = new System.Drawing.Size(14, 31);
            this.isSeaLandscape.TabIndex = 41;
            this.isSeaLandscape.UseVisualStyleBackColor = true;
            // 
            // applyFiltreB
            // 
            this.applyFiltreB.BackColor = System.Drawing.Color.SteelBlue;
            this.applyFiltreB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.applyFiltreB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyFiltreB.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyFiltreB.ForeColor = System.Drawing.SystemColors.Control;
            this.applyFiltreB.Location = new System.Drawing.Point(641, 498);
            this.applyFiltreB.Name = "applyFiltreB";
            this.applyFiltreB.Size = new System.Drawing.Size(169, 32);
            this.applyFiltreB.TabIndex = 43;
            this.applyFiltreB.Text = "Применить фильтры";
            this.applyFiltreB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.applyFiltreB.UseVisualStyleBackColor = false;
            this.applyFiltreB.Click += new System.EventHandler(this.applyFiltreB_Click);
            // 
            // showFullB
            // 
            this.showFullB.BackColor = System.Drawing.Color.SteelBlue;
            this.showFullB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showFullB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showFullB.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showFullB.ForeColor = System.Drawing.SystemColors.Control;
            this.showFullB.Location = new System.Drawing.Point(641, 536);
            this.showFullB.Name = "showFullB";
            this.showFullB.Size = new System.Drawing.Size(169, 32);
            this.showFullB.TabIndex = 44;
            this.showFullB.Text = "Полная таблица";
            this.showFullB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showFullB.UseVisualStyleBackColor = false;
            this.showFullB.Click += new System.EventHandler(this.showFullB_Click);
            // 
            // guestFindB
            // 
            this.guestFindB.BackColor = System.Drawing.Color.SteelBlue;
            this.guestFindB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.guestFindB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guestFindB.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guestFindB.ForeColor = System.Drawing.SystemColors.Control;
            this.guestFindB.Location = new System.Drawing.Point(174, 534);
            this.guestFindB.Name = "guestFindB";
            this.guestFindB.Size = new System.Drawing.Size(169, 32);
            this.guestFindB.TabIndex = 45;
            this.guestFindB.Text = "Найти по имени";
            this.guestFindB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guestFindB.UseVisualStyleBackColor = false;
            this.guestFindB.Click += new System.EventHandler(this.guestFindB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(822, 577);
            this.Controls.Add(this.guestFindB);
            this.Controls.Add(this.showFullB);
            this.Controls.Add(this.applyFiltreB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isSeaLandscape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isVip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isOccupied);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isForOne);
            this.Controls.Add(this.guestName);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Список гостей";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox guestName;
        private System.Windows.Forms.CheckBox isForOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isOccupied;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isVip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isSeaLandscape;
        private System.Windows.Forms.Button applyFiltreB;
        private System.Windows.Forms.Button showFullB;
        private System.Windows.Forms.Button guestFindB;
    }
}