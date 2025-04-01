namespace Presentacion
{
    partial class FormMenu
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxAÑO = new TextBox();
            textBoxAUTOR = new TextBox();
            textBoxNOMBRE = new TextBox();
            textBoxID = new TextBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            buttonSALIR = new Button();
            buttonELIMINAR = new Button();
            buttonMODIFICAR = new Button();
            buttonAÑADIR = new Button();
            groupBox3 = new GroupBox();
            dataGridLIBROS = new DataGridView();
            groupBox4 = new GroupBox();
            listBoxLIBROS = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLIBROS).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxAÑO);
            groupBox1.Controls.Add(textBoxAUTOR);
            groupBox1.Controls.Add(textBoxNOMBRE);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "AÑO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "AUTOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // textBoxAÑO
            // 
            textBoxAÑO.Location = new Point(119, 125);
            textBoxAÑO.Name = "textBoxAÑO";
            textBoxAÑO.Size = new Size(125, 27);
            textBoxAÑO.TabIndex = 3;
            // 
            // textBoxAUTOR
            // 
            textBoxAUTOR.Location = new Point(119, 92);
            textBoxAUTOR.Name = "textBoxAUTOR";
            textBoxAUTOR.Size = new Size(125, 27);
            textBoxAUTOR.TabIndex = 2;
            // 
            // textBoxNOMBRE
            // 
            textBoxNOMBRE.Location = new Point(119, 59);
            textBoxNOMBRE.Name = "textBoxNOMBRE";
            textBoxNOMBRE.Size = new Size(125, 27);
            textBoxNOMBRE.TabIndex = 1;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(119, 26);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(buttonSALIR);
            groupBox2.Controls.Add(buttonELIMINAR);
            groupBox2.Controls.Add(buttonMODIFICAR);
            groupBox2.Controls.Add(buttonAÑADIR);
            groupBox2.Location = new Point(12, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 245);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(6, 201);
            button6.Name = "button6";
            button6.Size = new Size(238, 29);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(6, 166);
            button5.Name = "button5";
            button5.Size = new Size(238, 29);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // buttonSALIR
            // 
            buttonSALIR.Location = new Point(6, 131);
            buttonSALIR.Name = "buttonSALIR";
            buttonSALIR.Size = new Size(238, 29);
            buttonSALIR.TabIndex = 3;
            buttonSALIR.Text = "SALIR";
            buttonSALIR.UseVisualStyleBackColor = true;
            buttonSALIR.Click += buttonSALIR_Click;
            // 
            // buttonELIMINAR
            // 
            buttonELIMINAR.Location = new Point(6, 96);
            buttonELIMINAR.Name = "buttonELIMINAR";
            buttonELIMINAR.Size = new Size(238, 29);
            buttonELIMINAR.TabIndex = 2;
            buttonELIMINAR.Text = "ELIMINAR";
            buttonELIMINAR.UseVisualStyleBackColor = true;
            buttonELIMINAR.Click += buttonELIMINAR_Click;
            // 
            // buttonMODIFICAR
            // 
            buttonMODIFICAR.Location = new Point(6, 61);
            buttonMODIFICAR.Name = "buttonMODIFICAR";
            buttonMODIFICAR.Size = new Size(238, 29);
            buttonMODIFICAR.TabIndex = 1;
            buttonMODIFICAR.Text = "MODIFICAR";
            buttonMODIFICAR.UseVisualStyleBackColor = true;
            buttonMODIFICAR.Click += buttonMODIFICAR_Click;
            // 
            // buttonAÑADIR
            // 
            buttonAÑADIR.Location = new Point(6, 26);
            buttonAÑADIR.Name = "buttonAÑADIR";
            buttonAÑADIR.Size = new Size(238, 29);
            buttonAÑADIR.TabIndex = 0;
            buttonAÑADIR.Text = "AÑADIR";
            buttonAÑADIR.UseVisualStyleBackColor = true;
            buttonAÑADIR.Click += buttonAÑADIR_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridLIBROS);
            groupBox3.Location = new Point(268, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(481, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dataGridLIBROS
            // 
            dataGridLIBROS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLIBROS.Location = new Point(6, 16);
            dataGridLIBROS.Name = "dataGridLIBROS";
            dataGridLIBROS.RowHeadersWidth = 51;
            dataGridLIBROS.Size = new Size(469, 404);
            dataGridLIBROS.TabIndex = 0;
            dataGridLIBROS.SelectionChanged += dataGridLIBROS_SelectionChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxLIBROS);
            groupBox4.Location = new Point(755, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 426);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // listBoxLIBROS
            // 
            listBoxLIBROS.FormattingEnabled = true;
            listBoxLIBROS.Location = new Point(6, 16);
            listBoxLIBROS.Name = "listBoxLIBROS";
            listBoxLIBROS.Size = new Size(296, 404);
            listBoxLIBROS.TabIndex = 0;
            listBoxLIBROS.SelectedIndexChanged += listBoxLIBROS_SelectedIndexChanged;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridLIBROS).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxAÑO;
        private TextBox textBoxAUTOR;
        private TextBox textBoxNOMBRE;
        private TextBox textBoxID;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
        private Button buttonSALIR;
        private Button buttonELIMINAR;
        private Button buttonMODIFICAR;
        private Button buttonAÑADIR;
        private GroupBox groupBox3;
        private DataGridView dataGridLIBROS;
        private GroupBox groupBox4;
        private ListBox listBoxLIBROS;
    }
}
