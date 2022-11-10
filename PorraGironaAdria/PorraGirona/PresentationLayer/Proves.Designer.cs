
namespace PorraGirona.PresentationLayer
{
    partial class Proves
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proves));
            this.BotoProvaUnitaria = new System.Windows.Forms.Button();
            this.BotoProvaIntegralEntity = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.puntuacionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntuacionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.puntuacionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.puntuacionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingNavigator)).BeginInit();
            this.puntuacionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BotoProvaUnitaria
            // 
            this.BotoProvaUnitaria.Location = new System.Drawing.Point(12, 154);
            this.BotoProvaUnitaria.Name = "BotoProvaUnitaria";
            this.BotoProvaUnitaria.Size = new System.Drawing.Size(237, 36);
            this.BotoProvaUnitaria.TabIndex = 0;
            this.BotoProvaUnitaria.Text = "Prova Unitaria";
            this.BotoProvaUnitaria.UseVisualStyleBackColor = true;
            // 
            // BotoProvaIntegralEntity
            // 
            this.BotoProvaIntegralEntity.Location = new System.Drawing.Point(12, 196);
            this.BotoProvaIntegralEntity.Name = "BotoProvaIntegralEntity";
            this.BotoProvaIntegralEntity.Size = new System.Drawing.Size(237, 39);
            this.BotoProvaIntegralEntity.TabIndex = 1;
            this.BotoProvaIntegralEntity.Text = "Prova Integral Calcul Puntuacions Entity";
            this.BotoProvaIntegralEntity.UseVisualStyleBackColor = true;
            this.BotoProvaIntegralEntity.Click += new System.EventHandler(this.BotoProvaIntegralEntity_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Prova Integral Càlcul Puntuacions SQL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // puntuacionsBindingSource
            // 
            this.puntuacionsBindingSource.DataSource = typeof(PorraGirona.DataLayer.Puntuacions);
            // 
            // puntuacionsBindingNavigator
            // 
            this.puntuacionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.puntuacionsBindingNavigator.BindingSource = this.puntuacionsBindingSource;
            this.puntuacionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.puntuacionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.puntuacionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.puntuacionsBindingNavigatorSaveItem});
            this.puntuacionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.puntuacionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.puntuacionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.puntuacionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.puntuacionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.puntuacionsBindingNavigator.Name = "puntuacionsBindingNavigator";
            this.puntuacionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.puntuacionsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.puntuacionsBindingNavigator.TabIndex = 3;
            this.puntuacionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // puntuacionsBindingNavigatorSaveItem
            // 
            this.puntuacionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.puntuacionsBindingNavigatorSaveItem.Enabled = false;
            this.puntuacionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("puntuacionsBindingNavigatorSaveItem.Image")));
            this.puntuacionsBindingNavigatorSaveItem.Name = "puntuacionsBindingNavigatorSaveItem";
            this.puntuacionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.puntuacionsBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // puntuacionsDataGridView
            // 
            this.puntuacionsDataGridView.AutoGenerateColumns = false;
            this.puntuacionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puntuacionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.puntuacionsDataGridView.DataSource = this.puntuacionsBindingSource;
            this.puntuacionsDataGridView.Location = new System.Drawing.Point(290, 28);
            this.puntuacionsDataGridView.Name = "puntuacionsDataGridView";
            this.puntuacionsDataGridView.Size = new System.Drawing.Size(498, 390);
            this.puntuacionsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idpuntuacio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idpuntuacio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Idpenyista";
            this.dataGridViewTextBoxColumn2.HeaderText = "Idpenyista";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Puntuacio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Puntuacio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Temporada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Temporada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Proves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.puntuacionsDataGridView);
            this.Controls.Add(this.puntuacionsBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BotoProvaIntegralEntity);
            this.Controls.Add(this.BotoProvaUnitaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proves";
            this.Text = "Proves";
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsBindingNavigator)).EndInit();
            this.puntuacionsBindingNavigator.ResumeLayout(false);
            this.puntuacionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotoProvaUnitaria;
        private System.Windows.Forms.Button BotoProvaIntegralEntity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource puntuacionsBindingSource;
        private System.Windows.Forms.BindingNavigator puntuacionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton puntuacionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView puntuacionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}