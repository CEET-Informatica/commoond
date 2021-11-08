
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
            this.groupVendaInfo = new System.Windows.Forms.GroupBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dateVenda = new System.Windows.Forms.DateTimePicker();
            this.lblVendaData = new System.Windows.Forms.Label();
            this.lblVendaQuantidade = new System.Windows.Forms.Label();
            this.txtVendaQuantidade = new System.Windows.Forms.TextBox();
            this.cbVendaProduto = new System.Windows.Forms.ComboBox();
            this.cbVendaCliente = new System.Windows.Forms.ComboBox();
            this.lblVendaCliente = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblVendaProduto = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.btnVendaAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnVendaEditar = new FontAwesome.Sharp.IconButton();
            this.dataVenda = new System.Windows.Forms.DataGridView();
            this.btnVendaCancelar = new FontAwesome.Sharp.IconButton();
            this.btnVendaExcluir = new FontAwesome.Sharp.IconButton();
            this.groupVendaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupVendaInfo
            // 
            this.groupVendaInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupVendaInfo.Controls.Add(this.cbFormaPagamento);
            this.groupVendaInfo.Controls.Add(this.dateVenda);
            this.groupVendaInfo.Controls.Add(this.lblVendaData);
            this.groupVendaInfo.Controls.Add(this.lblVendaQuantidade);
            this.groupVendaInfo.Controls.Add(this.txtVendaQuantidade);
            this.groupVendaInfo.Controls.Add(this.cbVendaProduto);
            this.groupVendaInfo.Controls.Add(this.cbVendaCliente);
            this.groupVendaInfo.Controls.Add(this.lblVendaCliente);
            this.groupVendaInfo.Controls.Add(this.txtValorTotal);
            this.groupVendaInfo.Controls.Add(this.lblValorTotal);
            this.groupVendaInfo.Controls.Add(this.lblVendaProduto);
            this.groupVendaInfo.Controls.Add(this.lblFormaPagamento);
            this.groupVendaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupVendaInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupVendaInfo.ForeColor = System.Drawing.Color.White;
            this.groupVendaInfo.Location = new System.Drawing.Point(11, 10);
            this.groupVendaInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupVendaInfo.Name = "groupVendaInfo";
            this.groupVendaInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupVendaInfo.Size = new System.Drawing.Size(601, 332);
            this.groupVendaInfo.TabIndex = 28;
            this.groupVendaInfo.TabStop = false;
            this.groupVendaInfo.Text = "Venda do Produto";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(20, 235);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(199, 36);
            this.cbFormaPagamento.TabIndex = 18;
            // 
            // dateVenda
            // 
            this.dateVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenda.Location = new System.Drawing.Point(435, 68);
            this.dateVenda.Name = "dateVenda";
            this.dateVenda.Size = new System.Drawing.Size(120, 34);
            this.dateVenda.TabIndex = 17;
            // 
            // lblVendaData
            // 
            this.lblVendaData.AutoSize = true;
            this.lblVendaData.ForeColor = System.Drawing.Color.White;
            this.lblVendaData.Location = new System.Drawing.Point(466, 44);
            this.lblVendaData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaData.Name = "lblVendaData";
            this.lblVendaData.Size = new System.Drawing.Size(53, 28);
            this.lblVendaData.TabIndex = 16;
            this.lblVendaData.Text = "Data";
            // 
            // lblVendaQuantidade
            // 
            this.lblVendaQuantidade.AutoSize = true;
            this.lblVendaQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblVendaQuantidade.Location = new System.Drawing.Point(435, 109);
            this.lblVendaQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaQuantidade.Name = "lblVendaQuantidade";
            this.lblVendaQuantidade.Size = new System.Drawing.Size(115, 28);
            this.lblVendaQuantidade.TabIndex = 15;
            this.lblVendaQuantidade.Text = "Quantidade";
            // 
            // txtVendaQuantidade
            // 
            this.txtVendaQuantidade.Location = new System.Drawing.Point(435, 139);
            this.txtVendaQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVendaQuantidade.Name = "txtVendaQuantidade";
            this.txtVendaQuantidade.Size = new System.Drawing.Size(120, 34);
            this.txtVendaQuantidade.TabIndex = 14;
            // 
            // cbVendaProduto
            // 
            this.cbVendaProduto.FormattingEnabled = true;
            this.cbVendaProduto.Location = new System.Drawing.Point(17, 137);
            this.cbVendaProduto.Name = "cbVendaProduto";
            this.cbVendaProduto.Size = new System.Drawing.Size(366, 36);
            this.cbVendaProduto.TabIndex = 13;
            // 
            // cbVendaCliente
            // 
            this.cbVendaCliente.FormattingEnabled = true;
            this.cbVendaCliente.Location = new System.Drawing.Point(17, 70);
            this.cbVendaCliente.Name = "cbVendaCliente";
            this.cbVendaCliente.Size = new System.Drawing.Size(366, 36);
            this.cbVendaCliente.TabIndex = 12;
            // 
            // lblVendaCliente
            // 
            this.lblVendaCliente.AutoSize = true;
            this.lblVendaCliente.ForeColor = System.Drawing.Color.White;
            this.lblVendaCliente.Location = new System.Drawing.Point(20, 44);
            this.lblVendaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaCliente.Name = "lblVendaCliente";
            this.lblVendaCliente.Size = new System.Drawing.Size(72, 28);
            this.lblVendaCliente.TabIndex = 0;
            this.lblVendaCliente.Text = "Cliente";
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
            // lblVendaProduto
            // 
            this.lblVendaProduto.AutoSize = true;
            this.lblVendaProduto.ForeColor = System.Drawing.Color.White;
            this.lblVendaProduto.Location = new System.Drawing.Point(20, 109);
            this.lblVendaProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaProduto.Name = "lblVendaProduto";
            this.lblVendaProduto.Size = new System.Drawing.Size(84, 28);
            this.lblVendaProduto.TabIndex = 2;
            this.lblVendaProduto.Text = "Produto";
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
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupVendaInfo);
            this.Controls.Add(this.btnVendaAdicionar);
            this.Controls.Add(this.btnVendaEditar);
            this.Controls.Add(this.dataVenda);
            this.Controls.Add(this.btnVendaCancelar);
            this.Controls.Add(this.btnVendaExcluir);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.groupVendaInfo.ResumeLayout(false);
            this.groupVendaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupVendaInfo;
        private System.Windows.Forms.Label lblVendaCliente;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblVendaProduto;
        private System.Windows.Forms.Label lblFormaPagamento;
        private FontAwesome.Sharp.IconButton btnVendaAdicionar;
        private FontAwesome.Sharp.IconButton btnVendaEditar;
        private System.Windows.Forms.DataGridView dataVenda;
        private FontAwesome.Sharp.IconButton btnVendaCancelar;
        private FontAwesome.Sharp.IconButton btnVendaExcluir;
        private System.Windows.Forms.ComboBox cbVendaCliente;
        private System.Windows.Forms.ComboBox cbVendaProduto;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.DateTimePicker dateVenda;
        private System.Windows.Forms.Label lblVendaData;
        private System.Windows.Forms.Label lblVendaQuantidade;
        private System.Windows.Forms.TextBox txtVendaQuantidade;
    }
}