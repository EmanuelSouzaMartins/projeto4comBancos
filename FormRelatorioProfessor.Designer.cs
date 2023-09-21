namespace projeto4
{
    partial class FormRelatorioProfessor
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
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtAreaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.gbAgrupamento = new System.Windows.Forms.GroupBox();
            this.cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            this.gbImpressora = new System.Windows.Forms.GroupBox();
            this.cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            this.gbFiltros.SuspendLayout();
            this.gbAgrupamento.SuspendLayout();
            this.gbImpressora.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.txtAreaFormacao);
            this.gbFiltros.Controls.Add(this.cboTitulacao);
            this.gbFiltros.Location = new System.Drawing.Point(33, 90);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(571, 100);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txtAreaFormacao
            // 
            this.txtAreaFormacao.AnimateReadOnly = false;
            this.txtAreaFormacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAreaFormacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAreaFormacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAreaFormacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAreaFormacao.Depth = 0;
            this.txtAreaFormacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAreaFormacao.HideSelection = true;
            this.txtAreaFormacao.Hint = "Área de formação";
            this.txtAreaFormacao.LeadingIcon = null;
            this.txtAreaFormacao.Location = new System.Drawing.Point(39, 32);
            this.txtAreaFormacao.MaxLength = 32767;
            this.txtAreaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAreaFormacao.Name = "txtAreaFormacao";
            this.txtAreaFormacao.PasswordChar = '\0';
            this.txtAreaFormacao.PrefixSuffixText = null;
            this.txtAreaFormacao.ReadOnly = false;
            this.txtAreaFormacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAreaFormacao.SelectedText = "";
            this.txtAreaFormacao.SelectionLength = 0;
            this.txtAreaFormacao.SelectionStart = 0;
            this.txtAreaFormacao.ShortcutsEnabled = true;
            this.txtAreaFormacao.Size = new System.Drawing.Size(244, 48);
            this.txtAreaFormacao.TabIndex = 10;
            this.txtAreaFormacao.TabStop = false;
            this.txtAreaFormacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAreaFormacao.TrailingIcon = null;
            this.txtAreaFormacao.UseSystemPasswordChar = false;
            // 
            // cboTitulacao
            // 
            this.cboTitulacao.AutoResize = false;
            this.cboTitulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTitulacao.Depth = 0;
            this.cboTitulacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTitulacao.DropDownHeight = 174;
            this.cboTitulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitulacao.DropDownWidth = 121;
            this.cboTitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTitulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTitulacao.FormattingEnabled = true;
            this.cboTitulacao.Hint = "Titulação";
            this.cboTitulacao.IntegralHeight = false;
            this.cboTitulacao.ItemHeight = 43;
            this.cboTitulacao.Items.AddRange(new object[] {
            "",
            "Graduação",
            "Especialização",
            "Mestrado",
            "Doutorado"});
            this.cboTitulacao.Location = new System.Drawing.Point(403, 31);
            this.cboTitulacao.MaxDropDownItems = 4;
            this.cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTitulacao.Name = "cboTitulacao";
            this.cboTitulacao.Size = new System.Drawing.Size(130, 49);
            this.cboTitulacao.StartIndex = 0;
            this.cboTitulacao.TabIndex = 9;
            // 
            // gbAgrupamento
            // 
            this.gbAgrupamento.Controls.Add(this.cboAgrupamento);
            this.gbAgrupamento.Location = new System.Drawing.Point(33, 196);
            this.gbAgrupamento.Name = "gbAgrupamento";
            this.gbAgrupamento.Size = new System.Drawing.Size(571, 87);
            this.gbAgrupamento.TabIndex = 4;
            this.gbAgrupamento.TabStop = false;
            this.gbAgrupamento.Text = "Agrupamento";
            // 
            // cboAgrupamento
            // 
            this.cboAgrupamento.AutoResize = false;
            this.cboAgrupamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboAgrupamento.Depth = 0;
            this.cboAgrupamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAgrupamento.DropDownHeight = 174;
            this.cboAgrupamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgrupamento.DropDownWidth = 121;
            this.cboAgrupamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboAgrupamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboAgrupamento.FormattingEnabled = true;
            this.cboAgrupamento.Hint = "Agrupamento";
            this.cboAgrupamento.IntegralHeight = false;
            this.cboAgrupamento.ItemHeight = 43;
            this.cboAgrupamento.Items.AddRange(new object[] {
            "Nenhum ",
            "Cidade",
            "Estado"});
            this.cboAgrupamento.Location = new System.Drawing.Point(32, 32);
            this.cboAgrupamento.MaxDropDownItems = 4;
            this.cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboAgrupamento.Name = "cboAgrupamento";
            this.cboAgrupamento.Size = new System.Drawing.Size(523, 49);
            this.cboAgrupamento.StartIndex = 0;
            this.cboAgrupamento.TabIndex = 4;
            // 
            // gbImpressora
            // 
            this.gbImpressora.Controls.Add(this.cboImpressora);
            this.gbImpressora.Location = new System.Drawing.Point(33, 298);
            this.gbImpressora.Name = "gbImpressora";
            this.gbImpressora.Size = new System.Drawing.Size(571, 80);
            this.gbImpressora.TabIndex = 5;
            this.gbImpressora.TabStop = false;
            this.gbImpressora.Text = "Impressora";
            // 
            // cboImpressora
            // 
            this.cboImpressora.AutoResize = false;
            this.cboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboImpressora.Depth = 0;
            this.cboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboImpressora.DropDownHeight = 174;
            this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpressora.DropDownWidth = 121;
            this.cboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Hint = "Impressora";
            this.cboImpressora.IntegralHeight = false;
            this.cboImpressora.ItemHeight = 43;
            this.cboImpressora.Location = new System.Drawing.Point(24, 22);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(523, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVisualizar.Depth = 0;
            this.btnVisualizar.HighEmphasis = true;
            this.btnVisualizar.Icon = null;
            this.btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVisualizar.Location = new System.Drawing.Point(512, 405);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVisualizar.Size = new System.Drawing.Size(112, 36);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVisualizar.UseAccentColor = false;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnImprimir.Location = new System.Drawing.Point(669, 405);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimir.Size = new System.Drawing.Size(97, 36);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormRelatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.gbImpressora);
            this.Controls.Add(this.gbAgrupamento);
            this.Controls.Add(this.gbFiltros);
            this.Name = "FormRelatorioProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Professor";
            this.gbFiltros.ResumeLayout(false);
            this.gbAgrupamento.ResumeLayout(false);
            this.gbImpressora.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbFiltros;
        private ReaLTaiizor.Controls.MaterialComboBox cboTitulacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAreaFormacao;
        private GroupBox gbAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private GroupBox gbImpressora;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
    }
}