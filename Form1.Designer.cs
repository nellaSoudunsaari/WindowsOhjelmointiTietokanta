
namespace WindowsOhjelmointiTietokanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kappaleenLuku = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.albumi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.artisti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kappaleenNimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.uusiKappaleBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 89);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 69);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musiikkikirjasto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.kappaleenLuku);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.kesto);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.albumi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.artisti);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.kappaleenNimi);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 416);
            this.panel3.TabIndex = 1;
            // 
            // kappaleenLuku
            // 
            this.kappaleenLuku.Location = new System.Drawing.Point(176, 34);
            this.kappaleenLuku.Multiline = true;
            this.kappaleenLuku.Name = "kappaleenLuku";
            this.kappaleenLuku.Size = new System.Drawing.Size(631, 33);
            this.kappaleenLuku.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kappaleen luku";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 155);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kesto
            // 
            this.kesto.Location = new System.Drawing.Point(176, 190);
            this.kesto.Multiline = true;
            this.kesto.Name = "kesto";
            this.kesto.Size = new System.Drawing.Size(631, 33);
            this.kesto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kesto";
            // 
            // albumi
            // 
            this.albumi.Location = new System.Drawing.Point(176, 151);
            this.albumi.Multiline = true;
            this.albumi.Name = "albumi";
            this.albumi.Size = new System.Drawing.Size(631, 33);
            this.albumi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Albumi";
            // 
            // artisti
            // 
            this.artisti.Location = new System.Drawing.Point(176, 112);
            this.artisti.Multiline = true;
            this.artisti.Name = "artisti";
            this.artisti.Size = new System.Drawing.Size(631, 33);
            this.artisti.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artisti";
            // 
            // kappaleenNimi
            // 
            this.kappaleenNimi.Location = new System.Drawing.Point(176, 73);
            this.kappaleenNimi.Multiline = true;
            this.kappaleenNimi.Name = "kappaleenNimi";
            this.kappaleenNimi.Size = new System.Drawing.Size(631, 33);
            this.kappaleenNimi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kappaleen nimi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(12, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1164, 449);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.GhostWhite;
            this.panel6.Controls.Add(this.search);
            this.panel6.Location = new System.Drawing.Point(860, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(287, 81);
            this.panel6.TabIndex = 3;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(17, 16);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(253, 54);
            this.search.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.panel5.Controls.Add(this.exitBtn);
            this.panel5.Controls.Add(this.printBtn);
            this.panel5.Controls.Add(this.resetBtn);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Controls.Add(this.updateBtn);
            this.panel5.Controls.Add(this.uusiKappaleBtn);
            this.panel5.Location = new System.Drawing.Point(860, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 329);
            this.panel5.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(17, 273);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(253, 42);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Sulje ohjelma";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(16, 221);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(253, 42);
            this.printBtn.TabIndex = 4;
            this.printBtn.Text = "Tulosta";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(16, 169);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(253, 42);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(16, 117);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(253, 42);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Poista";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(16, 64);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(253, 42);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Päivitä";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // uusiKappaleBtn
            // 
            this.uusiKappaleBtn.Location = new System.Drawing.Point(16, 12);
            this.uusiKappaleBtn.Name = "uusiKappaleBtn";
            this.uusiKappaleBtn.Size = new System.Drawing.Size(253, 42);
            this.uusiKappaleBtn.TabIndex = 0;
            this.uusiKappaleBtn.Text = "Lisää uusi kappale";
            this.uusiKappaleBtn.UseVisualStyleBackColor = true;
            this.uusiKappaleBtn.Click += new System.EventHandler(this.uusiKappaleBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1188, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox kesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox albumi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox artisti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kappaleenNimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button uusiKappaleBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox kappaleenLuku;
        private System.Windows.Forms.Label label6;
    }
}

