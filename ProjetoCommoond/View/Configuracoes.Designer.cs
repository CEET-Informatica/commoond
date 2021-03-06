
namespace ProjetoCommoond.View
{
    partial class Configuracoes
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
            this.groupConfigUsuario = new System.Windows.Forms.GroupBox();
            this.txtProdutoPeso = new System.Windows.Forms.TextBox();
            this.btnConfigExcluir = new FontAwesome.Sharp.IconButton();
            this.btnConfigAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnConfigEditar = new FontAwesome.Sharp.IconButton();
            this.btnConfigCancelar = new FontAwesome.Sharp.IconButton();
            this.dataConfigUsuario = new System.Windows.Forms.DataGridView();
            this.lblConfigUsuario = new System.Windows.Forms.Label();
            this.txtConfigUsuario = new System.Windows.Forms.TextBox();
            this.lblConfigSenha = new System.Windows.Forms.Label();
            this.txtConfigSenha = new System.Windows.Forms.TextBox();
            this.lblConfigSenhaRep = new System.Windows.Forms.Label();
            this.txtConfigSenhaRep = new System.Windows.Forms.TextBox();
            this.groupConfigLogo = new System.Windows.Forms.GroupBox();
            this.groupConfigUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConfigUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConfigUsuario
            // 
            this.groupConfigUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupConfigUsuario.Controls.Add(this.lblConfigSenhaRep);
            this.groupConfigUsuario.Controls.Add(this.txtConfigSenhaRep);
            this.groupConfigUsuario.Controls.Add(this.lblConfigSenha);
            this.groupConfigUsuario.Controls.Add(this.txtConfigSenha);
            this.groupConfigUsuario.Controls.Add(this.lblConfigUsuario);
            this.groupConfigUsuario.Controls.Add(this.txtConfigUsuario);
            this.groupConfigUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupConfigUsuario.ForeColor = System.Drawing.Color.White;
            this.groupConfigUsuario.Location = new System.Drawing.Point(2, 5);
            this.groupConfigUsuario.Name = "groupConfigUsuario";
            this.groupConfigUsuario.Size = new System.Drawing.Size(681, 430);
            this.groupConfigUsuario.TabIndex = 0;
            this.groupConfigUsuario.TabStop = false;
            this.groupConfigUsuario.Text = "Configurações de usuário";
            // 
            // txtProdutoPeso
            // 
            this.txtProdutoPeso.Location = new System.Drawing.Point(-251, 322);
            this.txtProdutoPeso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProdutoPeso.Name = "txtProdutoPeso";
            this.txtProdutoPeso.Size = new System.Drawing.Size(212, 23);
            this.txtProdutoPeso.TabIndex = 35;
            this.txtProdutoPeso.Text = " ";
            // 
            // btnConfigExcluir
            // 
            this.btnConfigExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfigExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfigExcluir.ForeColor = System.Drawing.Color.White;
            this.btnConfigExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigExcluir.IconColor = System.Drawing.Color.Black;
            this.btnConfigExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigExcluir.Location = new System.Drawing.Point(521, 495);
            this.btnConfigExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfigExcluir.Name = "btnConfigExcluir";
            this.btnConfigExcluir.Size = new System.Drawing.Size(159, 34);
            this.btnConfigExcluir.TabIndex = 39;
            this.btnConfigExcluir.Text = "Excluir";
            this.btnConfigExcluir.UseVisualStyleBackColor = false;
            // 
            // btnConfigAdicionar
            // 
            this.btnConfigAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfigAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfigAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnConfigAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnConfigAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigAdicionar.Location = new System.Drawing.Point(352, 454);
            this.btnConfigAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfigAdicionar.Name = "btnConfigAdicionar";
            this.btnConfigAdicionar.Size = new System.Drawing.Size(159, 34);
            this.btnConfigAdicionar.TabIndex = 36;
            this.btnConfigAdicionar.Text = "Adicionar";
            this.btnConfigAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnConfigEditar
            // 
            this.btnConfigEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfigEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfigEditar.ForeColor = System.Drawing.Color.White;
            this.btnConfigEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigEditar.IconColor = System.Drawing.Color.Black;
            this.btnConfigEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigEditar.Location = new System.Drawing.Point(352, 495);
            this.btnConfigEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfigEditar.Name = "btnConfigEditar";
            this.btnConfigEditar.Size = new System.Drawing.Size(159, 34);
            this.btnConfigEditar.TabIndex = 37;
            this.btnConfigEditar.Text = "Editar";
            this.btnConfigEditar.UseVisualStyleBackColor = false;
            // 
            // btnConfigCancelar
            // 
            this.btnConfigCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnConfigCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfigCancelar.ForeColor = System.Drawing.Color.White;
            this.btnConfigCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigCancelar.IconColor = System.Drawing.Color.Black;
            this.btnConfigCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigCancelar.Location = new System.Drawing.Point(521, 454);
            this.btnConfigCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfigCancelar.Name = "btnConfigCancelar";
            this.btnConfigCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnConfigCancelar.TabIndex = 38;
            this.btnConfigCancelar.Text = "Cancelar";
            this.btnConfigCancelar.UseVisualStyleBackColor = false;
            // 
            // dataConfigUsuario
            // 
            this.dataConfigUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataConfigUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConfigUsuario.Location = new System.Drawing.Point(696, 15);
            this.dataConfigUsuario.Name = "dataConfigUsuario";
            this.dataConfigUsuario.RowTemplate.Height = 25;
            this.dataConfigUsuario.Size = new System.Drawing.Size(254, 513);
            this.dataConfigUsuario.TabIndex = 40;
            // 
            // lblConfigUsuario
            // 
            this.lblConfigUsuario.AutoSize = true;
            this.lblConfigUsuario.ForeColor = System.Drawing.Color.White;
            this.lblConfigUsuario.Location = new System.Drawing.Point(225, 70);
            this.lblConfigUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigUsuario.Name = "lblConfigUsuario";
            this.lblConfigUsuario.Size = new System.Drawing.Size(79, 28);
            this.lblConfigUsuario.TabIndex = 2;
            this.lblConfigUsuario.Text = "Usuario";
            // 
            // txtConfigUsuario
            // 
            this.txtConfigUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfigUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigUsuario.Location = new System.Drawing.Point(224, 99);
            this.txtConfigUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfigUsuario.MaxLength = 22;
            this.txtConfigUsuario.Name = "txtConfigUsuario";
            this.txtConfigUsuario.Size = new System.Drawing.Size(212, 34);
            this.txtConfigUsuario.TabIndex = 3;
            // 
            // lblConfigSenha
            // 
            this.lblConfigSenha.AutoSize = true;
            this.lblConfigSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfigSenha.Location = new System.Drawing.Point(225, 141);
            this.lblConfigSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigSenha.Name = "lblConfigSenha";
            this.lblConfigSenha.Size = new System.Drawing.Size(65, 28);
            this.lblConfigSenha.TabIndex = 4;
            this.lblConfigSenha.Text = "Senha";
            // 
            // txtConfigSenha
            // 
            this.txtConfigSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfigSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigSenha.Location = new System.Drawing.Point(224, 170);
            this.txtConfigSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfigSenha.MaxLength = 22;
            this.txtConfigSenha.Name = "txtConfigSenha";
            this.txtConfigSenha.Size = new System.Drawing.Size(212, 34);
            this.txtConfigSenha.TabIndex = 5;
            // 
            // lblConfigSenhaRep
            // 
            this.lblConfigSenhaRep.AutoSize = true;
            this.lblConfigSenhaRep.ForeColor = System.Drawing.Color.White;
            this.lblConfigSenhaRep.Location = new System.Drawing.Point(225, 214);
            this.lblConfigSenhaRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigSenhaRep.Name = "lblConfigSenhaRep";
            this.lblConfigSenhaRep.Size = new System.Drawing.Size(129, 28);
            this.lblConfigSenhaRep.TabIndex = 6;
            this.lblConfigSenhaRep.Text = "Repetir senha";
            // 
            // txtConfigSenhaRep
            // 
            this.txtConfigSenhaRep.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfigSenhaRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigSenhaRep.Location = new System.Drawing.Point(224, 243);
            this.txtConfigSenhaRep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfigSenhaRep.MaxLength = 22;
            this.txtConfigSenhaRep.Name = "txtConfigSenhaRep";
            this.txtConfigSenhaRep.Size = new System.Drawing.Size(212, 34);
            this.txtConfigSenhaRep.TabIndex = 7;
            // 
            // groupConfigLogo
            // 
            this.groupConfigLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupConfigLogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupConfigLogo.ForeColor = System.Drawing.Color.White;
            this.groupConfigLogo.Location = new System.Drawing.Point(2, 441);
            this.groupConfigLogo.Name = "groupConfigLogo";
            this.groupConfigLogo.Size = new System.Drawing.Size(319, 89);
            this.groupConfigLogo.TabIndex = 41;
            this.groupConfigLogo.TabStop = false;
            this.groupConfigLogo.Text = "Logo do menu";
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupConfigLogo);
            this.Controls.Add(this.dataConfigUsuario);
            this.Controls.Add(this.txtProdutoPeso);
            this.Controls.Add(this.btnConfigExcluir);
            this.Controls.Add(this.btnConfigAdicionar);
            this.Controls.Add(this.btnConfigEditar);
            this.Controls.Add(this.btnConfigCancelar);
            this.Controls.Add(this.groupConfigUsuario);
            this.Name = "Configuracoes";
            this.Text = "Configurações";
            this.groupConfigUsuario.ResumeLayout(false);
            this.groupConfigUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConfigUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConfigUsuario;
        private System.Windows.Forms.TextBox txtProdutoPeso;
        private FontAwesome.Sharp.IconButton btnConfigExcluir;
        private FontAwesome.Sharp.IconButton btnConfigAdicionar;
        private FontAwesome.Sharp.IconButton btnConfigEditar;
        private FontAwesome.Sharp.IconButton btnConfigCancelar;
        private System.Windows.Forms.DataGridView dataConfigUsuario;
        private System.Windows.Forms.Label lblConfigSenhaRep;
        private System.Windows.Forms.TextBox txtConfigSenhaRep;
        private System.Windows.Forms.Label lblConfigSenha;
        private System.Windows.Forms.TextBox txtConfigSenha;
        private System.Windows.Forms.Label lblConfigUsuario;
        private System.Windows.Forms.TextBox txtConfigUsuario;
        private System.Windows.Forms.GroupBox groupConfigLogo;
    }
}