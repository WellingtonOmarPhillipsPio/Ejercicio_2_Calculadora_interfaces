namespace Calculadora_interfeces
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
            btn_Calculate=new Button();
            btn_Clear=new Button();
            btn_Leave=new Button();
            Valor1=new Label();
            Valor2=new Label();
            Resultado=new Label();
            Resta=new Label();
            Multiplicacion=new Label();
            Division=new Label();
            txt_Resultado=new TextBox();
            txt_Valor2=new TextBox();
            txt_Division=new TextBox();
            txt_Valor1=new TextBox();
            txt_Multiplicacion=new TextBox();
            txt_Resta=new TextBox();
            label1=new Label();
            SuspendLayout();
            // 
            // btn_Calculate
            // 
            btn_Calculate.BackColor=Color.RosyBrown;
            btn_Calculate.Font=new Font("Varela Round", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calculate.ForeColor=SystemColors.ActiveCaptionText;
            btn_Calculate.Location=new Point(564, 106);
            btn_Calculate.Name="btn_Calculate";
            btn_Calculate.Size=new Size(100, 36);
            btn_Calculate.TabIndex=0;
            btn_Calculate.Text="Calculate";
            btn_Calculate.UseVisualStyleBackColor=false;
            btn_Calculate.Click+=btn_Calculate_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor=Color.RosyBrown;
            btn_Clear.Font=new Font("Varela Round", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor=SystemColors.ActiveCaptionText;
            btn_Clear.Location=new Point(564, 165);
            btn_Clear.Name="btn_Clear";
            btn_Clear.Size=new Size(100, 36);
            btn_Clear.TabIndex=1;
            btn_Clear.Text="Clear";
            btn_Clear.UseVisualStyleBackColor=false;
            btn_Clear.Click+=btn_Clear_Click;
            // 
            // btn_Leave
            // 
            btn_Leave.BackColor=Color.RosyBrown;
            btn_Leave.Font=new Font("Varela Round", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Leave.ForeColor=SystemColors.ActiveCaptionText;
            btn_Leave.Location=new Point(564, 221);
            btn_Leave.Name="btn_Leave";
            btn_Leave.Size=new Size(100, 36);
            btn_Leave.TabIndex=2;
            btn_Leave.Text="Leave";
            btn_Leave.UseVisualStyleBackColor=false;
            btn_Leave.Click+=btn_Leave_Click;
            // 
            // Valor1
            // 
            Valor1.AutoSize=true;
            Valor1.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Valor1.Location=new Point(251, 65);
            Valor1.Name="Valor1";
            Valor1.Size=new Size(41, 15);
            Valor1.TabIndex=3;
            Valor1.Text="Valor1";
            // 
            // Valor2
            // 
            Valor2.AutoSize=true;
            Valor2.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Valor2.Location=new Point(251, 113);
            Valor2.Name="Valor2";
            Valor2.Size=new Size(41, 15);
            Valor2.TabIndex=4;
            Valor2.Text="Valor2";
            // 
            // Resultado
            // 
            Resultado.AutoSize=true;
            Resultado.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Resultado.Location=new Point(251, 165);
            Resultado.Name="Resultado";
            Resultado.Size=new Size(59, 15);
            Resultado.TabIndex=5;
            Resultado.Text="Resultado";
            // 
            // Resta
            // 
            Resta.AutoSize=true;
            Resta.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Resta.Location=new Point(251, 219);
            Resta.Name="Resta";
            Resta.Size=new Size(36, 15);
            Resta.TabIndex=6;
            Resta.Text="Resta";
            // 
            // Multiplicacion
            // 
            Multiplicacion.AutoSize=true;
            Multiplicacion.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Multiplicacion.Location=new Point(251, 267);
            Multiplicacion.Name="Multiplicacion";
            Multiplicacion.Size=new Size(84, 15);
            Multiplicacion.TabIndex=7;
            Multiplicacion.Text="Multiplicacion";
            // 
            // Division
            // 
            Division.AutoSize=true;
            Division.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Division.Location=new Point(253, 309);
            Division.Name="Division";
            Division.Size=new Size(51, 15);
            Division.TabIndex=8;
            Division.Text="Division";
            // 
            // txt_Resultado
            // 
            txt_Resultado.Location=new Point(371, 162);
            txt_Resultado.Name="txt_Resultado";
            txt_Resultado.Size=new Size(113, 23);
            txt_Resultado.TabIndex=9;
            // 
            // txt_Valor2
            // 
            txt_Valor2.Location=new Point(371, 110);
            txt_Valor2.Name="txt_Valor2";
            txt_Valor2.Size=new Size(113, 23);
            txt_Valor2.TabIndex=10;
            // 
            // txt_Division
            // 
            txt_Division.Location=new Point(371, 314);
            txt_Division.Name="txt_Division";
            txt_Division.Size=new Size(113, 23);
            txt_Division.TabIndex=11;
            // 
            // txt_Valor1
            // 
            txt_Valor1.Location=new Point(371, 62);
            txt_Valor1.Name="txt_Valor1";
            txt_Valor1.Size=new Size(113, 23);
            txt_Valor1.TabIndex=12;
            // 
            // txt_Multiplicacion
            // 
            txt_Multiplicacion.Location=new Point(371, 264);
            txt_Multiplicacion.Name="txt_Multiplicacion";
            txt_Multiplicacion.Size=new Size(113, 23);
            txt_Multiplicacion.TabIndex=13;
            // 
            // txt_Resta
            // 
            txt_Resta.Location=new Point(371, 216);
            txt_Resta.Name="txt_Resta";
            txt_Resta.Size=new Size(113, 23);
            txt_Resta.TabIndex=14;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Impact", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(305, 0);
            label1.Name="label1";
            label1.Size=new Size(179, 34);
            label1.TabIndex=15;
            label1.Text="CALCULADORA";
            label1.Click+=label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightGray;
            ClientSize=new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt_Resta);
            Controls.Add(txt_Multiplicacion);
            Controls.Add(txt_Valor1);
            Controls.Add(txt_Division);
            Controls.Add(txt_Valor2);
            Controls.Add(txt_Resultado);
            Controls.Add(Division);
            Controls.Add(Multiplicacion);
            Controls.Add(Resta);
            Controls.Add(Resultado);
            Controls.Add(Valor2);
            Controls.Add(Valor1);
            Controls.Add(btn_Leave);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Calculate);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calculate;
        private Button btn_Clear;
        private Button btn_Leave;
        private Label Valor1;
        private Label Valor2;
        private Label Resultado;
        private Label Resta;
        private Label Multiplicacion;
        private Label Division;
        private TextBox txt_Resultado;
        private TextBox txt_Valor2;
        private TextBox txt_Division;
        private TextBox txt_Valor1;
        private TextBox txt_Multiplicacion;
        private TextBox txt_Resta;
        private Label label1;
    }
}