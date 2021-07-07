namespace Modelo
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
            this.btnSobre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.listPessoas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnAddBefore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnAddAfter = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 688);
            this.panel1.TabIndex = 1;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(0, 0);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(141, 90);
            this.btnSobre.TabIndex = 9;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(141, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 154);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1017, -1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 85);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 36);
            this.txtNome.TabIndex = 5;
            // 
            // listPessoas
            // 
            this.listPessoas.FormattingEnabled = true;
            this.listPessoas.ItemHeight = 28;
            this.listPessoas.Location = new System.Drawing.Point(713, 313);
            this.listPessoas.Name = "listPessoas";
            this.listPessoas.Size = new System.Drawing.Size(263, 368);
            this.listPessoas.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRemoveLast);
            this.groupBox1.Controls.Add(this.btnAddBefore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPosicao);
            this.groupBox1.Controls.Add(this.btnRemoveFirst);
            this.groupBox1.Controls.Add(this.btnAddLast);
            this.groupBox1.Controls.Add(this.btnAddAfter);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(221, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 364);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.FlatAppearance.BorderSize = 0;
            this.btnRemoveLast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveLast.Location = new System.Drawing.Point(11, 226);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(195, 36);
            this.btnRemoveLast.TabIndex = 23;
            this.btnRemoveLast.Text = "RemoveLast ()";
            this.btnRemoveLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click_1);
            // 
            // btnAddBefore
            // 
            this.btnAddBefore.FlatAppearance.BorderSize = 0;
            this.btnAddBefore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddBefore.Location = new System.Drawing.Point(11, 184);
            this.btnAddBefore.Name = "btnAddBefore";
            this.btnAddBefore.Size = new System.Drawing.Size(195, 36);
            this.btnAddBefore.TabIndex = 22;
            this.btnAddBefore.Text = "AddBefore ()";
            this.btnAddBefore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddBefore.UseVisualStyleBackColor = true;
            this.btnAddBefore.Click += new System.EventHandler(this.btnAddBefore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Posição:";
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(106, 71);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(284, 36);
            this.txtPosicao.TabIndex = 19;
            this.txtPosicao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.FlatAppearance.BorderSize = 0;
            this.btnRemoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveFirst.Location = new System.Drawing.Point(226, 226);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(164, 36);
            this.btnRemoveFirst.TabIndex = 16;
            this.btnRemoveFirst.Text = "RemoveFirst ()";
            this.btnRemoveFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.FlatAppearance.BorderSize = 0;
            this.btnAddAfter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddAfter.Location = new System.Drawing.Point(226, 184);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(164, 36);
            this.btnAddAfter.TabIndex = 18;
            this.btnAddAfter.Text = "AddAfter ()";
            this.btnAddAfter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAfter.UseVisualStyleBackColor = true;
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLast.Location = new System.Drawing.Point(11, 268);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(195, 36);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = "Last";
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.FlatAppearance.BorderSize = 0;
            this.btnAddLast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddLast.Location = new System.Drawing.Point(11, 142);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(195, 36);
            this.btnAddLast.TabIndex = 13;
            this.btnAddLast.Text = "AddLast ()";
            this.btnAddLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFirst.Location = new System.Drawing.Point(226, 268);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(164, 36);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "First";
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(226, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "AddFirst ()";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Usado no AddBefore e AddAfter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listPessoas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listPessoas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnAddAfter;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnAddBefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

