
namespace LR3
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomsInfo = new System.Windows.Forms.Button();
            this.guestId = new System.Windows.Forms.TextBox();
            this.outName = new System.Windows.Forms.Label();
            this.roomsList = new System.Windows.Forms.ComboBox();
            this.deleteObject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveAll = new System.Windows.Forms.Button();
            this.isAlone = new System.Windows.Forms.CheckBox();
            this.isSeaLandscape = new System.Windows.Forms.CheckBox();
            this.isVip = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guestName = new System.Windows.Forms.TextBox();
            this.addObject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.roomsInfo);
            this.panel2.Controls.Add(this.guestId);
            this.panel2.Controls.Add(this.outName);
            this.panel2.Controls.Add(this.roomsList);
            this.panel2.Controls.Add(this.deleteObject);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 469);
            this.panel2.TabIndex = 31;
            // 
            // roomsInfo
            // 
            this.roomsInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.roomsInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roomsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsInfo.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomsInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.roomsInfo.Location = new System.Drawing.Point(174, 418);
            this.roomsInfo.Name = "roomsInfo";
            this.roomsInfo.Size = new System.Drawing.Size(271, 46);
            this.roomsInfo.TabIndex = 22;
            this.roomsInfo.Text = "Информация о комнатах";
            this.roomsInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roomsInfo.UseVisualStyleBackColor = false;
            this.roomsInfo.Click += new System.EventHandler(this.roomsInfo_Click_1);
            // 
            // guestId
            // 
            this.guestId.BackColor = System.Drawing.Color.SteelBlue;
            this.guestId.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guestId.ForeColor = System.Drawing.SystemColors.Control;
            this.guestId.Location = new System.Drawing.Point(174, 314);
            this.guestId.MaxLength = 30;
            this.guestId.Name = "guestId";
            this.guestId.Size = new System.Drawing.Size(61, 46);
            this.guestId.TabIndex = 21;
            // 
            // outName
            // 
            this.outName.BackColor = System.Drawing.Color.Transparent;
            this.outName.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outName.ForeColor = System.Drawing.SystemColors.Control;
            this.outName.Location = new System.Drawing.Point(13, 16);
            this.outName.Name = "outName";
            this.outName.Size = new System.Drawing.Size(565, 295);
            this.outName.TabIndex = 20;
            this.outName.Text = "Комната не выбрана";
            this.outName.Click += new System.EventHandler(this.outName_Click);
            // 
            // roomsList
            // 
            this.roomsList.BackColor = System.Drawing.Color.SteelBlue;
            this.roomsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsList.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomsList.ForeColor = System.Drawing.SystemColors.Control;
            this.roomsList.FormattingEnabled = true;
            this.roomsList.Location = new System.Drawing.Point(174, 368);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(271, 41);
            this.roomsList.TabIndex = 9;
            this.roomsList.SelectedIndexChanged += new System.EventHandler(this.roomsList_SelectedIndexChanged);
            // 
            // deleteObject
            // 
            this.deleteObject.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteObject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteObject.Font = new System.Drawing.Font("Bahnschrift Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteObject.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteObject.Location = new System.Drawing.Point(241, 314);
            this.deleteObject.Name = "deleteObject";
            this.deleteObject.Size = new System.Drawing.Size(204, 46);
            this.deleteObject.TabIndex = 20;
            this.deleteObject.Text = "Выселить по Id";
            this.deleteObject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteObject.UseVisualStyleBackColor = false;
            this.deleteObject.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.saveAll);
            this.panel1.Controls.Add(this.isAlone);
            this.panel1.Controls.Add(this.isSeaLandscape);
            this.panel1.Controls.Add(this.isVip);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guestName);
            this.panel1.Controls.Add(this.addObject);
            this.panel1.Location = new System.Drawing.Point(614, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 469);
            this.panel1.TabIndex = 30;
            // 
            // saveAll
            // 
            this.saveAll.BackColor = System.Drawing.Color.SteelBlue;
            this.saveAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAll.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveAll.ForeColor = System.Drawing.SystemColors.Control;
            this.saveAll.Location = new System.Drawing.Point(176, 418);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(239, 46);
            this.saveAll.TabIndex = 30;
            this.saveAll.Text = "Сохранить всё";
            this.saveAll.UseVisualStyleBackColor = false;
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // isAlone
            // 
            this.isAlone.ForeColor = System.Drawing.SystemColors.Control;
            this.isAlone.Location = new System.Drawing.Point(358, 145);
            this.isAlone.Margin = new System.Windows.Forms.Padding(1);
            this.isAlone.Name = "isAlone";
            this.isAlone.Size = new System.Drawing.Size(104, 31);
            this.isAlone.TabIndex = 29;
            this.isAlone.UseVisualStyleBackColor = true;
            // 
            // isSeaLandscape
            // 
            this.isSeaLandscape.ForeColor = System.Drawing.SystemColors.Control;
            this.isSeaLandscape.Location = new System.Drawing.Point(358, 105);
            this.isSeaLandscape.Margin = new System.Windows.Forms.Padding(1);
            this.isSeaLandscape.Name = "isSeaLandscape";
            this.isSeaLandscape.Size = new System.Drawing.Size(104, 31);
            this.isSeaLandscape.TabIndex = 28;
            this.isSeaLandscape.UseVisualStyleBackColor = true;
            // 
            // isVip
            // 
            this.isVip.ForeColor = System.Drawing.SystemColors.Control;
            this.isVip.Location = new System.Drawing.Point(358, 68);
            this.isVip.Margin = new System.Windows.Forms.Padding(1);
            this.isVip.Name = "isVip";
            this.isVip.Size = new System.Drawing.Size(104, 31);
            this.isVip.TabIndex = 27;
            this.isVip.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 33);
            this.label5.TabIndex = 23;
            this.label5.Text = "Номер на одного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Вид на море";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "VIP номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Имя постояльца";
            // 
            // guestName
            // 
            this.guestName.BackColor = System.Drawing.Color.SteelBlue;
            this.guestName.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guestName.ForeColor = System.Drawing.SystemColors.Control;
            this.guestName.Location = new System.Drawing.Point(358, 29);
            this.guestName.MaxLength = 30;
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(175, 35);
            this.guestName.TabIndex = 18;
            // 
            // addObject
            // 
            this.addObject.BackColor = System.Drawing.Color.SteelBlue;
            this.addObject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addObject.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addObject.ForeColor = System.Drawing.SystemColors.Control;
            this.addObject.Location = new System.Drawing.Point(176, 358);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(239, 51);
            this.addObject.TabIndex = 11;
            this.addObject.Text = "Добавить объект";
            this.addObject.UseVisualStyleBackColor = false;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 56);
            this.label1.TabIndex = 29;
            this.label1.Text = "Гостиница \"Рубин\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1177, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kosenko Kursovaya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label outName;
        private System.Windows.Forms.ComboBox roomsList;
        private System.Windows.Forms.Button deleteObject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox guestName;
        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isVip;
        private System.Windows.Forms.CheckBox isAlone;
        private System.Windows.Forms.CheckBox isSeaLandscape;
        private System.Windows.Forms.TextBox guestId;
        private System.Windows.Forms.Button roomsInfo;
        private System.Windows.Forms.Button saveAll;
    }
}

