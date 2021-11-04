
namespace ProjetoCommoond.View
{
    partial class Vendas
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
            this.groupInfoVenda = new System.Windows.Forms.GroupBox();
            this.lblClienteVenda = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblProdutoVenda = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.btnVendaAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnVendaEditar = new FontAwesome.Sharp.IconButton();
            this.dataVenda = new System.Windows.Forms.DataGridView();
            this.btnVendaCancelar = new FontAwesome.Sharp.IconButton();
            this.btnVendaExcluir = new FontAwesome.Sharp.IconButton();
            this.cbClienteVenda = new System.Windows.Forms.ComboBox();
            this.cbProdutoVenda = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeVenda = new System.Windows.Forms.TextBox();
            this.lblQuantidadeVenda = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePickerVenda = new System.Windows.Forms.DateTimePicker();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.groupInfoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInfoVenda
            // 
            this.groupInfoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupInfoVenda.Controls.Add(this.cbFormaPagamento);
            this.groupInfoVenda.Controls.Add(this.dateTimePickerVenda);
            this.groupInfoVenda.Controls.Add(this.lblData);
            this.groupInfoVenda.Controls.Add(this.lblQuantidadeVenda);
            this.groupInfoVenda.Controls.Add(this.txtQuantidadeVenda);
            this.groupInfoVenda.Controls.Add(this.cbProdutoVenda);
            this.groupInfoVenda.Controls.Add(this.cbClienteVenda);
            this.groupInfoVenda.Controls.Add(this.lblClienteVenda);
            this.groupInfoVenda.Controls.Add(this.txtValorTotal);
            this.groupInfoVenda.Controls.Add(this.lblValorTotal);
            this.groupInfoVenda.Controls.Add(this.lblProdutoVenda);
            this.groupInfoVenda.Controls.Add(this.lblFormaPagamento);
            this.groupInfoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInfoVenda.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupInfoVenda.ForeColor = System.Drawing.Color.White;
            this.groupInfoVenda.Location = new System.Drawing.Point(11, 10);
            this.groupInfoVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoVenda.Name = "groupInfoVenda";
            this.groupInfoVenda.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoVenda.Size = new System.Drawing.Size(601, 332);
            this.groupInfoVenda.TabIndex = 28;
            this.groupInfoVenda.TabStop = false;
            this.groupInfoVenda.Text = "Venda do Produto";
            // 
            // lblClienteVenda
            // 
            this.lblClienteVenda.AutoSize = true;
            this.lblClienteVenda.ForeColor = System.Drawing.Color.White;
            this.lblClienteVenda.Location = new System.Drawing.Point(20, 44);
            this.lblClienteVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteVenda.Name = "lblClienteVenda";
            this.lblClienteVenda.Size = new System.Drawing.Size(72, 28);
            this.lblClienteVenda.TabIndex = 0;
            this.lblClienteVenda.Text = "Cliente";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(435, 237);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(120, 34);
            this.txtValorTotal.TabIndex = 9;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(446, 206);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(104, 28);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblProdutoVenda
            // 
            this.lblProdutoVenda.AutoSize = true;
            this.lblProdutoVenda.ForeColor = System.Drawing.Color.White;
            this.lblProdutoVenda.Location = new System.Drawing.Point(20, 109);
            this.lblProdutoVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoVenda.Name = "lblProdutoVenda";
            this.lblProdutoVenda.Size = new System.Drawing.Size(84, 28);
            this.lblProdutoVenda.TabIndex = 2;
            this.lblProdutoVenda.Text = "Produto";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblFormaPagamento.Location = new System.Drawing.Point(20, 206);
            this.lblFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(199, 28);
            this.lblFormaPagamento.TabIndex = 6;
            this.lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // btnVendaAdicionar
            // 
            this.btnVendaAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendaAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnVendaAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnVendaAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaAdicionar.Location = new System.Drawing.Point(620, 267);
            this.btnVendaAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVendaAdicionar.Name = "btnVendaAdicionar";
            this.btnVendaAdicionar.Size = new System.Drawing.Size(159, 34);
            this.btnVendaAdicionar.TabIndex = 31;
            this.btnVendaAdicionar.Text = "Adicionar";
            this.btnVendaAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnVendaEditar
            // 
            this.btnVendaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendaEditar.ForeColor = System.Drawing.Color.White;
            this.btnVendaEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaEditar.IconColor = System.Drawing.Color.Black;
            this.btnVendaEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaEditar.Location = new System.Drawing.Point(620, 308);
            this.btnVendaEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVendaEditar.Name = "btnVendaEditar";
            this.btnVendaEditar.Size = new System.Drawing.Size(159, 34);
            this.btnVendaEditar.TabIndex = 32;
            this.btnVendaEditar.Text = "Editar";
            this.btnVendaEditar.UseVisualStyleBackColor = false;
            // 
            // dataVenda
            // 
            this.dataVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenda.Location = new System.Drawing.Point(11, 348);
            this.dataVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.RowHeadersWidth = 51;
            this.dataVenda.RowTemplate.Height = 25;
            this.dataVenda.Size = new System.Drawing.Size(937, 184);
            this.dataVenda.TabIndex = 30;
            // 
            // btnVendaCancelar
            // 
            this.btnVendaCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnVendaCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaCancelar.IconColor = System.Drawing.Color.Black;
            this.btnVendaCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaCancelar.Location = new System.Drawing.Point(789, 267);
            this.btnVendaCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVendaCancelar.Name = "btnVendaCancelar";
            this.btnVendaCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnVendaCancelar.TabIndex = 33;
            this.btnVendaCancelar.Text = "Cancelar";
            this.btnVendaCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVendaExcluir
            // 
            this.btnVendaExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVendaExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendaExcluir.ForeColor = System.Drawing.Color.White;
            this.btnVendaExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVendaExcluir.IconColor = System.Drawing.Color.Black;
            this.btnVendaExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendaExcluir.Location = new System.Drawing.Point(789, 308);
            this.btnVendaExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVendaExcluir.Name = "btnVendaExcluir";
            this.btnVendaExcluir.Size = new System.Drawing.Size(159, 34);
            this.btnVendaExcluir.TabIndex = 34;
            this.btnVendaExcluir.Text = "Excluir";
            this.btnVendaExcluir.UseVisualStyleBackColor = false;
            // 
            // cbClienteVenda
            // 
            this.cbClienteVenda.FormattingEnabled = true;
            this.cbClienteVenda.Location = new System.Drawing.Point(17, 70);
            this.cbClienteVenda.Name = "cbClienteVenda";
            this.cbClienteVenda.Size = new System.Drawing.Size(366, 36);
            this.cbClienteVenda.TabIndex = 12;
            // 
            // cbProdutoVenda
            // 
            this.cbProdutoVenda.FormattingEnabled = true;
            this.cbProdutoVenda.Location = new System.Drawing.Point(17, 137);
            this.cbProdutoVenda.Name = "cbProdutoVenda";
            this.cbProdutoVenda.Size = new System.Drawing.Size(366, 36);
            this.cbProdutoVenda.TabIndex = 13;
            // 
            // txtQuantidadeVenda
            // 
            this.txtQuantidadeVenda.Location = new System.Drawing.Point(435, 139);
            this.txtQuantidadeVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantidadeVenda.Name = "txtQuantidadeVenda";
            this.txtQuantidadeVenda.Size = new System.Drawing.Size(120, 34);
            this.txtQuantidadeVenda.TabIndex = 14;
            // 
            // lblQuantidadeVenda
            // 
            this.lblQuantidadeVenda.AutoSize = true;
            this.lblQuantidadeVenda.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeVenda.Location = new System.Drawing.Point(435, 109);
            this.lblQuantidadeVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidadeVenda.Name = "lblQuantidadeVenda";
            this.lblQuantidadeVenda.Size = new System.Drawing.Size(115, 28);
            this.lblQuantidadeVenda.TabIndex = 15;
            this.lblQuantidadeVenda.Text = "Quantidade";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(466, 44);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 28);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data";
            // 
            // dateTimePickerVenda
            // 
            this.dateTimePickerVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVenda.Location = new System.Drawing.Point(435, 68);
            this.dateTimePickerVenda.Name = "dateTimePickerVenda";
            this.dateTimePickerVenda.Size = new System.Drawing.Size(120, 34);
            this.dateTimePickerVenda.TabIndex = 17;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(20, 235);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(199, 36);
            this.cbFormaPagamento.TabIndex = 18;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupInfoVenda);
            this.Controls.Add(this.btnVendaAdicionar);
            this.Controls.Add(this.btnVendaEditar);
            this.Controls.Add(this.dataVenda);
            this.Controls.Add(this.btnVendaCancelar);
            this.Controls.Add(this.btnVendaExcluir);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.groupInfoVenda.ResumeLayout(false);
            this.groupInfoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoVenda;
        private System.Windows.Forms.Label lblClienteVenda;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblProdutoVenda;
        private System.Windows.Forms.Label lblFormaPagamento;
        private FontAwesome.Sharp.IconButton btnVendaAdicionar;
        private FontAwesome.Sharp.IconButton btnVendaEditar;
        private System.Windows.Forms.DataGridView dataVenda;
        private FontAwesome.Sharp.IconButton btnVendaCancelar;
        private FontAwesome.Sharp.IconButton btnVendaExcluir;
        private System.Windows.Forms.ComboBox cbClienteVenda;
        private System.Windows.Forms.ComboBox cbProdutoVenda;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.DateTimePicker dateTimePickerVenda;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblQuantidadeVenda;
        private System.Windows.Forms.TextBox txtQuantidadeVenda;
    }
}