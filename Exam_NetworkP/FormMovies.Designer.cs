namespace Exam_NetworkP
{
	partial class FormMovies
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
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
			this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
			this.textBoxMetascore = new System.Windows.Forms.TextBox();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.textBoxGenre = new System.Windows.Forms.TextBox();
			this.textBoxYear = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxSearchYear = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxPlot = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxType = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSearch.Location = new System.Drawing.Point(13, 13);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(111, 108);
			this.buttonSearch.TabIndex = 0;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxSearchTitle
			// 
			this.textBoxSearchTitle.Location = new System.Drawing.Point(178, 17);
			this.textBoxSearchTitle.Name = "textBoxSearchTitle";
			this.textBoxSearchTitle.Size = new System.Drawing.Size(188, 22);
			this.textBoxSearchTitle.TabIndex = 1;
			// 
			// pictureBoxPoster
			// 
			this.pictureBoxPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPoster.Location = new System.Drawing.Point(12, 127);
			this.pictureBoxPoster.Name = "pictureBoxPoster";
			this.pictureBoxPoster.Size = new System.Drawing.Size(354, 419);
			this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPoster.TabIndex = 2;
			this.pictureBoxPoster.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(372, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Year";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(372, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Genre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(372, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Country";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(372, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Metascore";
			// 
			// richTextBoxDesc
			// 
			this.richTextBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxDesc.Location = new System.Drawing.Point(375, 252);
			this.richTextBoxDesc.Name = "richTextBoxDesc";
			this.richTextBoxDesc.ReadOnly = true;
			this.richTextBoxDesc.Size = new System.Drawing.Size(445, 294);
			this.richTextBoxDesc.TabIndex = 7;
			this.richTextBoxDesc.Text = "";
			// 
			// textBoxMetascore
			// 
			this.textBoxMetascore.Location = new System.Drawing.Point(458, 175);
			this.textBoxMetascore.Name = "textBoxMetascore";
			this.textBoxMetascore.ReadOnly = true;
			this.textBoxMetascore.Size = new System.Drawing.Size(362, 22);
			this.textBoxMetascore.TabIndex = 8;
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Location = new System.Drawing.Point(458, 135);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.ReadOnly = true;
			this.textBoxCountry.Size = new System.Drawing.Size(362, 22);
			this.textBoxCountry.TabIndex = 9;
			// 
			// textBoxGenre
			// 
			this.textBoxGenre.Location = new System.Drawing.Point(458, 96);
			this.textBoxGenre.Name = "textBoxGenre";
			this.textBoxGenre.ReadOnly = true;
			this.textBoxGenre.Size = new System.Drawing.Size(362, 22);
			this.textBoxGenre.TabIndex = 10;
			// 
			// textBoxYear
			// 
			this.textBoxYear.Location = new System.Drawing.Point(458, 53);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.ReadOnly = true;
			this.textBoxYear.Size = new System.Drawing.Size(362, 22);
			this.textBoxYear.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(130, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Title";
			// 
			// textBoxSearchYear
			// 
			this.textBoxSearchYear.Location = new System.Drawing.Point(178, 57);
			this.textBoxSearchYear.Name = "textBoxSearchYear";
			this.textBoxSearchYear.Size = new System.Drawing.Size(188, 22);
			this.textBoxSearchYear.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(130, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 18);
			this.label6.TabIndex = 14;
			this.label6.Text = "Year";
			// 
			// comboBoxPlot
			// 
			this.comboBoxPlot.FormattingEnabled = true;
			this.comboBoxPlot.Items.AddRange(new object[] {
            "Full",
            "Short"});
			this.comboBoxPlot.Location = new System.Drawing.Point(178, 94);
			this.comboBoxPlot.Name = "comboBoxPlot";
			this.comboBoxPlot.Size = new System.Drawing.Size(188, 24);
			this.comboBoxPlot.TabIndex = 15;
			this.comboBoxPlot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(134, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 18);
			this.label7.TabIndex = 16;
			this.label7.Text = "Plot";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(372, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 18);
			this.label8.TabIndex = 17;
			this.label8.Text = "Title";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(458, 18);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.ReadOnly = true;
			this.textBoxTitle.Size = new System.Drawing.Size(362, 22);
			this.textBoxTitle.TabIndex = 18;
			// 
			// textBoxType
			// 
			this.textBoxType.Location = new System.Drawing.Point(458, 214);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.ReadOnly = true;
			this.textBoxType.Size = new System.Drawing.Size(362, 22);
			this.textBoxType.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(372, 219);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 18);
			this.label9.TabIndex = 19;
			this.label9.Text = "Type";
			// 
			// FormMovies
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(832, 554);
			this.Controls.Add(this.textBoxType);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBoxPlot);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxSearchYear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxYear);
			this.Controls.Add(this.textBoxGenre);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.textBoxMetascore);
			this.Controls.Add(this.richTextBoxDesc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBoxPoster);
			this.Controls.Add(this.textBoxSearchTitle);
			this.Controls.Add(this.buttonSearch);
			this.Name = "FormMovies";
			this.ShowIcon = false;
			this.Text = "Movies";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearchTitle;
		private System.Windows.Forms.PictureBox pictureBoxPoster;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBoxDesc;
		private System.Windows.Forms.TextBox textBoxMetascore;
		private System.Windows.Forms.TextBox textBoxCountry;
		private System.Windows.Forms.TextBox textBoxGenre;
		private System.Windows.Forms.TextBox textBoxYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxSearchYear;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxPlot;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxType;
		private System.Windows.Forms.Label label9;
	}
}

