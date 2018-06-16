using System.Windows.Forms;

namespace TuringMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            this.NextButton = new System.Windows.Forms.Button();
            this.ALLButton = new System.Windows.Forms.Button();
            this.NumberIteration = new System.Windows.Forms.NumericUpDown();
            this.IterationList = new System.Windows.Forms.ListBox();
            this.CardContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.cell11 = new System.Windows.Forms.TextBox();
            this.cell12 = new System.Windows.Forms.TextBox();
            this.cell13 = new System.Windows.Forms.TextBox();
            this.cell14 = new System.Windows.Forms.TextBox();
            this.cell21 = new System.Windows.Forms.TextBox();
            this.cell22 = new System.Windows.Forms.TextBox();
            this.cell23 = new System.Windows.Forms.TextBox();
            this.cell24 = new System.Windows.Forms.TextBox();
            this.cell31 = new System.Windows.Forms.TextBox();
            this.cell32 = new System.Windows.Forms.TextBox();
            this.cell33 = new System.Windows.Forms.TextBox();
            this.cell34 = new System.Windows.Forms.TextBox();
            this.cell41 = new System.Windows.Forms.TextBox();
            this.cell42 = new System.Windows.Forms.TextBox();
            this.cell43 = new System.Windows.Forms.TextBox();
            this.cell44 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberIteration)).BeginInit();
            this.CardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(582, 447);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(250, 50);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Следующая итерация";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ALLButton
            // 
            this.ALLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALLButton.Location = new System.Drawing.Point(123, 447);
            this.ALLButton.Name = "ALLButton";
            this.ALLButton.Size = new System.Drawing.Size(250, 50);
            this.ALLButton.TabIndex = 1;
            this.ALLButton.Text = "Все итерации";
            this.ALLButton.UseVisualStyleBackColor = true;
            this.ALLButton.Click += new System.EventHandler(this.ALLButton_Click);
            // 
            // NumberIteration
            // 
            this.NumberIteration.Location = new System.Drawing.Point(729, 12);
            this.NumberIteration.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumberIteration.Name = "NumberIteration";
            this.NumberIteration.Size = new System.Drawing.Size(120, 20);
            this.NumberIteration.TabIndex = 3;
            this.NumberIteration.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // IterationList
            // 
            this.IterationList.FormattingEnabled = true;
            this.IterationList.Location = new System.Drawing.Point(525, 47);
            this.IterationList.Name = "IterationList";
            this.IterationList.Size = new System.Drawing.Size(355, 394);
            this.IterationList.TabIndex = 4;
            // 
            // CardContainer
            // 
            this.CardContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            //this.CardContainer.Controls.Add(this.cell11);
            //this.CardContainer.Controls.Add(this.cell12);
            //this.CardContainer.Controls.Add(this.cell13);
            //this.CardContainer.Controls.Add(this.cell14);
            //this.CardContainer.Controls.Add(this.cell21);
            //this.CardContainer.Controls.Add(this.cell22);
            //this.CardContainer.Controls.Add(this.cell23);
            //this.CardContainer.Controls.Add(this.cell24);
            //this.CardContainer.Controls.Add(this.cell31);
            //this.CardContainer.Controls.Add(this.cell32);
            //this.CardContainer.Controls.Add(this.cell33);
            //this.CardContainer.Controls.Add(this.cell34);
            //this.CardContainer.Controls.Add(this.cell41);
            //this.CardContainer.Controls.Add(this.cell42);
            //this.CardContainer.Controls.Add(this.cell43);
            //this.CardContainer.Controls.Add(this.cell44);

            this.CardContainer.Controls.AddRange(Map.Instance.AllControlComponents);
            this.CardContainer.Location = new System.Drawing.Point(69, 131);
            this.CardContainer.Name = "CardContainer";
            this.CardContainer.Size = new System.Drawing.Size(425, 109);
            this.CardContainer.TabIndex = 5;
            // 
            // cell11
            // 
            this.cell11.Location = new System.Drawing.Point(3, 3);
            this.cell11.Name = "11";
            this.cell11.Size = new System.Drawing.Size(100, 20);
            this.cell11.TabIndex = 0;
            this.cell11.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell12
            // 
            this.cell12.Location = new System.Drawing.Point(109, 3);
            this.cell12.Name = "12";
            this.cell12.Size = new System.Drawing.Size(100, 20);
            this.cell12.TabIndex = 1;
            this.cell12.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell13
            // 
            this.cell13.Location = new System.Drawing.Point(215, 3);
            this.cell13.Name = "13";
            this.cell13.Size = new System.Drawing.Size(100, 20);
            this.cell13.TabIndex = 2;
            this.cell13.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell14
            // 
            this.cell14.Location = new System.Drawing.Point(321, 3);
            this.cell14.Name = "14";
            this.cell14.Size = new System.Drawing.Size(100, 20);
            this.cell14.TabIndex = 3;
            this.cell14.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell21
            // 
            this.cell21.Location = new System.Drawing.Point(3, 29);
            this.cell21.Name = "21";
            this.cell21.Size = new System.Drawing.Size(100, 20);
            this.cell21.TabIndex = 0;
            this.cell21.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell22
            // 
            this.cell22.Location = new System.Drawing.Point(109, 29);
            this.cell22.Name = "22";
            this.cell22.Size = new System.Drawing.Size(100, 20);
            this.cell22.TabIndex = 0;
            this.cell22.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell23
            // 
            this.cell23.Location = new System.Drawing.Point(215, 29);
            this.cell23.Name = "23";
            this.cell23.Size = new System.Drawing.Size(100, 20);
            this.cell23.TabIndex = 0;
            this.cell23.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell24
            // 
            this.cell24.Location = new System.Drawing.Point(321, 29);
            this.cell24.Name = "24";
            this.cell24.Size = new System.Drawing.Size(100, 20);
            this.cell24.TabIndex = 0;
            this.cell24.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell31
            // 
            this.cell31.Location = new System.Drawing.Point(3, 55);
            this.cell31.Name = "31";
            this.cell31.Size = new System.Drawing.Size(100, 20);
            this.cell31.TabIndex = 0;
            this.cell31.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell32
            // 
            this.cell32.Location = new System.Drawing.Point(109, 55);
            this.cell32.Name = "32";
            this.cell32.Size = new System.Drawing.Size(100, 20);
            this.cell32.TabIndex = 0;
            this.cell32.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell33
            // 
            this.cell33.Location = new System.Drawing.Point(215, 55);
            this.cell33.Name = "33";
            this.cell33.Size = new System.Drawing.Size(100, 20);
            this.cell33.TabIndex = 0;
            this.cell33.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell34
            // 
            this.cell34.Location = new System.Drawing.Point(321, 55);
            this.cell34.Name = "34";
            this.cell34.Size = new System.Drawing.Size(100, 20);
            this.cell34.TabIndex = 0;
            this.cell34.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell41
            // 
            this.cell41.Location = new System.Drawing.Point(3, 81);
            this.cell41.Name = "41";
            this.cell41.Size = new System.Drawing.Size(100, 20);
            this.cell41.TabIndex = 0;
            this.cell41.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell42
            // 
            this.cell42.Location = new System.Drawing.Point(109, 81);
            this.cell42.Name = "42";
            this.cell42.Size = new System.Drawing.Size(100, 20);
            this.cell42.TabIndex = 0;
            this.cell42.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell43
            // 
            this.cell43.Location = new System.Drawing.Point(215, 81);
            this.cell43.Name = "43";
            this.cell43.Size = new System.Drawing.Size(100, 20);
            this.cell43.TabIndex = 0;
            this.cell43.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // cell44
            // 
            this.cell44.Location = new System.Drawing.Point(321, 81);
            this.cell44.Name = "44";
            this.cell44.Size = new System.Drawing.Size(100, 20);
            this.cell44.TabIndex = 0;
            this.cell44.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "S0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(213, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // label3   
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(324, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(425, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "q1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "q2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "q3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "q4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 521);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardContainer);
            this.Controls.Add(this.IterationList);
            this.Controls.Add(this.NumberIteration);
            this.Controls.Add(this.ALLButton);
            this.Controls.Add(this.NextButton);
            this.Name = "Form1";
            this.Text = "TuringMachine";
            ((System.ComponentModel.ISupportInitialize)(this.NumberIteration)).EndInit();
            this.CardContainer.ResumeLayout(false);
            this.CardContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ALLButton;
        private System.Windows.Forms.NumericUpDown NumberIteration;
        private System.Windows.Forms.ListBox IterationList;
        private System.Windows.Forms.FlowLayoutPanel CardContainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox cell11;
        private TextBox cell12;
        private TextBox cell13;
        private TextBox cell14;
        private TextBox cell21;
        private TextBox cell22;
        private TextBox cell23;
        private TextBox cell24;
        private TextBox cell31;
        private TextBox cell32;
        private TextBox cell33;
        private TextBox cell34;
        private TextBox cell41;
        private TextBox cell42;
        private TextBox cell43;
        private TextBox cell44;
    }
}

