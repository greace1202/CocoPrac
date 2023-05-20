namespace Coco
{
    partial class Form1
    {
    
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label21 = new System.Windows.Forms.Label();
            this.cnbCostohonorario = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cnbModelo = new System.Windows.Forms.ComboBox();
            this.txtHonorario = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioindividual = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProductividad = new System.Windows.Forms.TextBox();
            this.txtIndividualdesarrollador = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPersonalnesesario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTiempodesarrollo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEsfuerzonominal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMileslineas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidaddeinstrucciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalflujo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ndParametro = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ndParametro)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(761, 487);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 16);
            this.label21.TabIndex = 83;
            this.label21.Text = "Bs.";
            // 
            // cnbCostohonorario
            // 
            this.cnbCostohonorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnbCostohonorario.FormattingEnabled = true;
            this.cnbCostohonorario.Location = new System.Drawing.Point(554, 283);
            this.cnbCostohonorario.Margin = new System.Windows.Forms.Padding(2);
            this.cnbCostohonorario.Name = "cnbCostohonorario";
            this.cnbCostohonorario.Size = new System.Drawing.Size(192, 21);
            this.cnbCostohonorario.TabIndex = 82;
            this.cnbCostohonorario.SelectedIndexChanged += new System.EventHandler(this.cnbCostohonorario_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label20.Location = new System.Drawing.Point(520, 249);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(226, 20);
            this.label20.TabIndex = 81;
            this.label20.Text = "Eleccion de costo honorario";
            // 
            // cnbModelo
            // 
            this.cnbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnbModelo.FormattingEnabled = true;
            this.cnbModelo.Location = new System.Drawing.Point(651, 174);
            this.cnbModelo.Margin = new System.Windows.Forms.Padding(2);
            this.cnbModelo.Name = "cnbModelo";
            this.cnbModelo.Size = new System.Drawing.Size(132, 21);
            this.cnbModelo.TabIndex = 77;
            this.cnbModelo.SelectedIndexChanged += new System.EventHandler(this.cnbModelo_SelectedIndexChanged);
            // 
            // txtHonorario
            // 
            this.txtHonorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHonorario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHonorario.Location = new System.Drawing.Point(591, 408);
            this.txtHonorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHonorario.Name = "txtHonorario";
            this.txtHonorario.ReadOnly = true;
            this.txtHonorario.Size = new System.Drawing.Size(132, 21);
            this.txtHonorario.TabIndex = 71;
            this.txtHonorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.Color.Indigo;
            this.label16.Location = new System.Drawing.Point(479, 386);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 20);
            this.label16.TabIndex = 70;
            this.label16.Text = "Costo honorario";
            // 
            // txtPrecioindividual
            // 
            this.txtPrecioindividual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioindividual.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPrecioindividual.Location = new System.Drawing.Point(572, 551);
            this.txtPrecioindividual.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioindividual.Name = "txtPrecioindividual";
            this.txtPrecioindividual.ReadOnly = true;
            this.txtPrecioindividual.Size = new System.Drawing.Size(194, 21);
            this.txtPrecioindividual.TabIndex = 69;
            this.txtPrecioindividual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.Indigo;
            this.label15.Location = new System.Drawing.Point(476, 516);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(290, 20);
            this.label15.TabIndex = 68;
            this.label15.Text = "Costo individual de lineas de codigo";
            // 
            // txtCosto
            // 
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCosto.Location = new System.Drawing.Point(591, 487);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(160, 21);
            this.txtCosto.TabIndex = 67;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(478, 452);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Estimacion de costo desarrollo";
            // 
            // txtProductividad
            // 
            this.txtProductividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductividad.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtProductividad.Location = new System.Drawing.Point(123, 452);
            this.txtProductividad.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductividad.Name = "txtProductividad";
            this.txtProductividad.ReadOnly = true;
            this.txtProductividad.Size = new System.Drawing.Size(195, 21);
            this.txtProductividad.TabIndex = 64;
            // 
            // txtIndividualdesarrollador
            // 
            this.txtIndividualdesarrollador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIndividualdesarrollador.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIndividualdesarrollador.Location = new System.Drawing.Point(123, 516);
            this.txtIndividualdesarrollador.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndividualdesarrollador.Name = "txtIndividualdesarrollador";
            this.txtIndividualdesarrollador.ReadOnly = true;
            this.txtIndividualdesarrollador.Size = new System.Drawing.Size(191, 21);
            this.txtIndividualdesarrollador.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label13.Location = new System.Drawing.Point(30, 427);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "Estimacion de la productividad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Location = new System.Drawing.Point(30, 488);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Costo individual al desarrollador";
            // 
            // txtPersonalnesesario
            // 
            this.txtPersonalnesesario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonalnesesario.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPersonalnesesario.Location = new System.Drawing.Point(121, 404);
            this.txtPersonalnesesario.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonalnesesario.Name = "txtPersonalnesesario";
            this.txtPersonalnesesario.ReadOnly = true;
            this.txtPersonalnesesario.Size = new System.Drawing.Size(195, 21);
            this.txtPersonalnesesario.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(29, 369);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Estimacion del personal nesesario";
            // 
            // txtTiempodesarrollo
            // 
            this.txtTiempodesarrollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempodesarrollo.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTiempodesarrollo.Location = new System.Drawing.Point(119, 335);
            this.txtTiempodesarrollo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempodesarrollo.Name = "txtTiempodesarrollo";
            this.txtTiempodesarrollo.ReadOnly = true;
            this.txtTiempodesarrollo.Size = new System.Drawing.Size(195, 21);
            this.txtTiempodesarrollo.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label10.Location = new System.Drawing.Point(28, 301);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Estimacion del tiempo de desarrollo";
            // 
            // txtEsfuerzonominal
            // 
            this.txtEsfuerzonominal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEsfuerzonominal.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEsfuerzonominal.Location = new System.Drawing.Point(122, 262);
            this.txtEsfuerzonominal.Margin = new System.Windows.Forms.Padding(2);
            this.txtEsfuerzonominal.Name = "txtEsfuerzonominal";
            this.txtEsfuerzonominal.ReadOnly = true;
            this.txtEsfuerzonominal.Size = new System.Drawing.Size(194, 21);
            this.txtEsfuerzonominal.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(28, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Estimacion del esfuerzo nominal";
            // 
            // txtMileslineas
            // 
            this.txtMileslineas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMileslineas.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMileslineas.Location = new System.Drawing.Point(122, 210);
            this.txtMileslineas.Margin = new System.Windows.Forms.Padding(2);
            this.txtMileslineas.Name = "txtMileslineas";
            this.txtMileslineas.ReadOnly = true;
            this.txtMileslineas.Size = new System.Drawing.Size(194, 21);
            this.txtMileslineas.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(30, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Miles de lineas de codigo";
            // 
            // txtCantidaddeinstrucciones
            // 
            this.txtCantidaddeinstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidaddeinstrucciones.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCantidaddeinstrucciones.Location = new System.Drawing.Point(123, 149);
            this.txtCantidaddeinstrucciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidaddeinstrucciones.Name = "txtCantidaddeinstrucciones";
            this.txtCantidaddeinstrucciones.ReadOnly = true;
            this.txtCantidaddeinstrucciones.Size = new System.Drawing.Size(194, 21);
            this.txtCantidaddeinstrucciones.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(30, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Estimacion de la cantidad de instrucciones";
            // 
            // txtTotalflujo
            // 
            this.txtTotalflujo.Location = new System.Drawing.Point(650, 143);
            this.txtTotalflujo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalflujo.Name = "txtTotalflujo";
            this.txtTotalflujo.ReadOnly = true;
            this.txtTotalflujo.Size = new System.Drawing.Size(132, 20);
            this.txtTotalflujo.TabIndex = 51;
            this.txtTotalflujo.TextChanged += new System.EventHandler(this.txtTotalflujo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(456, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Total de flujo";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(650, 119);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(132, 20);
            this.txtSalida.TabIndex = 49;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(650, 95);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(132, 20);
            this.txtEntrada.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(527, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Parametro";
            // 
            // ndParametro
            // 
            this.ndParametro.Location = new System.Drawing.Point(651, 213);
            this.ndParametro.Margin = new System.Windows.Forms.Padding(2);
            this.ndParametro.Name = "ndParametro";
            this.ndParametro.Size = new System.Drawing.Size(131, 20);
            this.ndParametro.TabIndex = 46;
            this.ndParametro.ValueChanged += new System.EventHandler(this.ndParametro_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(455, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Modelo de desarrollo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(456, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Flujo de salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Flujo de entrada:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(212, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA COCOMO";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(592, 320);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(95, 36);
            this.materialButton1.TabIndex = 84;
            this.materialButton1.Text = "CALCULAR";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 594);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cnbCostohonorario);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cnbModelo);
            this.Controls.Add(this.txtHonorario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPrecioindividual);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProductividad);
            this.Controls.Add(this.txtIndividualdesarrollador);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPersonalnesesario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTiempodesarrollo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEsfuerzonominal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMileslineas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidaddeinstrucciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalflujo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ndParametro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndParametro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cnbCostohonorario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cnbModelo;
        private System.Windows.Forms.TextBox txtHonorario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecioindividual;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProductividad;
        private System.Windows.Forms.TextBox txtIndividualdesarrollador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPersonalnesesario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTiempodesarrollo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEsfuerzonominal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMileslineas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidaddeinstrucciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalflujo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ndParametro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

