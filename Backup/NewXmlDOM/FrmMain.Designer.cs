namespace NewXmlDOM
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtXmlValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXmlName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertAttribute = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsertBefore = new System.Windows.Forms.Button();
            this.btnInsertAfter = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trvXmlNodes = new System.Windows.Forms.TreeView();
            this.lblDocName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.22018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.77982F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtXmlValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtXmlName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInsertAttribute);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsertBefore);
            this.panel1.Controls.Add(this.btnInsertAfter);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(321, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 333);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 21);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除所有节点(&L)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtXmlValue
            // 
            this.txtXmlValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtXmlValue.Location = new System.Drawing.Point(0, 49);
            this.txtXmlValue.Name = "txtXmlValue";
            this.txtXmlValue.Size = new System.Drawing.Size(170, 21);
            this.txtXmlValue.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "属性值-->";
            // 
            // txtXmlName
            // 
            this.txtXmlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtXmlName.Location = new System.Drawing.Point(0, 14);
            this.txtXmlName.Name = "txtXmlName";
            this.txtXmlName.Size = new System.Drawing.Size(170, 21);
            this.txtXmlName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "节点名-->";
            // 
            // btnInsertAttribute
            // 
            this.btnInsertAttribute.Location = new System.Drawing.Point(3, 194);
            this.btnInsertAttribute.Name = "btnInsertAttribute";
            this.btnInsertAttribute.Size = new System.Drawing.Size(164, 21);
            this.btnInsertAttribute.TabIndex = 4;
            this.btnInsertAttribute.Text = "插入属性(&T)";
            this.btnInsertAttribute.UseVisualStyleBackColor = true;
            this.btnInsertAttribute.Click += new System.EventHandler(this.btnInsertAttribute_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(3, 275);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(164, 21);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "拷贝节点(&C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 21);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 21);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "更新(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsertBefore
            // 
            this.btnInsertBefore.Location = new System.Drawing.Point(3, 167);
            this.btnInsertBefore.Name = "btnInsertBefore";
            this.btnInsertBefore.Size = new System.Drawing.Size(164, 21);
            this.btnInsertBefore.TabIndex = 3;
            this.btnInsertBefore.Text = "插入前节点(&Z)";
            this.btnInsertBefore.UseVisualStyleBackColor = true;
            this.btnInsertBefore.Click += new System.EventHandler(this.btnInsertBefore_Click);
            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.Location = new System.Drawing.Point(3, 140);
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.Size = new System.Drawing.Size(164, 21);
            this.btnInsertAfter.TabIndex = 2;
            this.btnInsertAfter.Text = "插入后节点(&B)";
            this.btnInsertAfter.UseVisualStyleBackColor = true;
            this.btnInsertAfter.Click += new System.EventHandler(this.btnInsertAfter_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(3, 113);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(164, 21);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "插入子节点(&A)";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(3, 86);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(164, 21);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "解析(&S)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trvXmlNodes);
            this.panel2.Controls.Add(this.lblDocName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 333);
            this.panel2.TabIndex = 2;
            // 
            // trvXmlNodes
            // 
            this.trvXmlNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvXmlNodes.HideSelection = false;
            this.trvXmlNodes.HotTracking = true;
            this.trvXmlNodes.Location = new System.Drawing.Point(0, 14);
            this.trvXmlNodes.Name = "trvXmlNodes";
            this.trvXmlNodes.Size = new System.Drawing.Size(308, 319);
            this.trvXmlNodes.TabIndex = 0;
            this.trvXmlNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvXmlNodes_AfterSelect);
            // 
            // lblDocName
            // 
            this.lblDocName.BackColor = System.Drawing.Color.Blue;
            this.lblDocName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDocName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDocName.ForeColor = System.Drawing.Color.White;
            this.lblDocName.Location = new System.Drawing.Point(0, 0);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(308, 14);
            this.lblDocName.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOM解析";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtXmlValue;
        private System.Windows.Forms.TextBox txtXmlName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.TreeView trvXmlNodes;
        private System.Windows.Forms.Button btnInsertAttribute;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsertBefore;
        private System.Windows.Forms.Button btnInsertAfter;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}

