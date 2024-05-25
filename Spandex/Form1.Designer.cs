namespace Spandex
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openbutton = new Button();
            savebutton = new Button();
            stringGrid = new DataGridView();
            IDdisplay = new DataGridViewTextBoxColumn();
            InternalValue = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            TemplateValue = new DataGridViewTextBoxColumn();
            spanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDdisplayDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            internalValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            templateValueDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            stringGridEntryBindingSource = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            valueGrid = new DataGridView();
            iDdisplayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            templateValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueGridBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            removeUndefInts = new CheckBox();
            removeUndefFloats = new CheckBox();
            removeUndefTextures = new CheckBox();
            panel3 = new Panel();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)stringGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stringGridEntryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valueGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valueGridBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openbutton
            // 
            openbutton.BackColor = Color.FromArgb(64, 64, 64);
            openbutton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            openbutton.FlatStyle = FlatStyle.Flat;
            openbutton.ForeColor = Color.White;
            openbutton.Location = new Point(9, 8);
            openbutton.Margin = new Padding(2);
            openbutton.Name = "openbutton";
            openbutton.Size = new Size(126, 24);
            openbutton.TabIndex = 0;
            openbutton.Text = "Load Material...";
            openbutton.UseVisualStyleBackColor = true;
            openbutton.Click += openbutton_Click;
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.FromArgb(64, 64, 64);
            savebutton.Enabled = false;
            savebutton.FlatAppearance.BorderColor = Color.Black;
            savebutton.FlatStyle = FlatStyle.Flat;
            savebutton.ForeColor = SystemColors.Control;
            savebutton.Location = new Point(9, 44);
            savebutton.Margin = new Padding(2);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(126, 24);
            savebutton.TabIndex = 0;
            savebutton.Text = "Save Material As...";
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // stringGrid
            // 
            stringGrid.AllowUserToAddRows = false;
            stringGrid.AllowUserToDeleteRows = false;
            stringGrid.AllowUserToOrderColumns = true;
            stringGrid.AllowUserToResizeRows = false;
            stringGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stringGrid.AutoGenerateColumns = false;
            stringGrid.BackgroundColor = Color.FromArgb(21, 21, 21);
            stringGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            stringGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            stringGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stringGrid.Columns.AddRange(new DataGridViewColumn[] { IDdisplay, InternalValue, Value, TemplateValue, spanDataGridViewTextBoxColumn, iDDataGridViewTextBoxColumn, iDdisplayDataGridViewTextBoxColumn1, typeDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn1, internalValueDataGridViewTextBoxColumn, templateValueDataGridViewTextBoxColumn1 });
            stringGrid.DataSource = stringGridEntryBindingSource;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Black;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            stringGrid.DefaultCellStyle = dataGridViewCellStyle13;
            stringGrid.EnableHeadersVisualStyles = false;
            stringGrid.GridColor = SystemColors.ActiveCaptionText;
            stringGrid.Location = new Point(8, 20);
            stringGrid.Margin = new Padding(9, 8, 9, 8);
            stringGrid.MinimumSize = new Size(636, 119);
            stringGrid.Name = "stringGrid";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Black;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            stringGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            stringGrid.RowHeadersVisible = false;
            stringGrid.RowHeadersWidth = 72;
            dataGridViewCellStyle15.BackColor = Color.Black;
            dataGridViewCellStyle15.ForeColor = Color.White;
            stringGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            stringGrid.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            stringGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            stringGrid.RowTemplate.Height = 37;
            stringGrid.Size = new Size(1198, 230);
            stringGrid.TabIndex = 1;
            stringGrid.CellBeginEdit += stringGrid_CellBeginEdit;
            stringGrid.CellContentClick += stringGrid_CellContentClick;
            stringGrid.CellValueChanged += stringGrid_CellValueChanged;
            stringGrid.DataBindingComplete += stringGrid_DataBindingComplete;
            // 
            // IDdisplay
            // 
            IDdisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IDdisplay.DataPropertyName = "IDdisplay";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle2.ForeColor = Color.White;
            IDdisplay.DefaultCellStyle = dataGridViewCellStyle2;
            IDdisplay.HeaderText = "ID";
            IDdisplay.MinimumWidth = 9;
            IDdisplay.Name = "IDdisplay";
            IDdisplay.ReadOnly = true;
            IDdisplay.Width = 42;
            // 
            // InternalValue
            // 
            InternalValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InternalValue.DataPropertyName = "InternalValue";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle3.ForeColor = Color.White;
            InternalValue.DefaultCellStyle = dataGridViewCellStyle3;
            InternalValue.HeaderText = "Internal Shader";
            InternalValue.MinimumWidth = 9;
            InternalValue.Name = "InternalValue";
            InternalValue.Width = 101;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Value.DataPropertyName = "Value";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle4.ForeColor = Color.White;
            Value.DefaultCellStyle = dataGridViewCellStyle4;
            Value.HeaderText = "External Template Overrides";
            Value.MinimumWidth = 9;
            Value.Name = "Value";
            Value.Width = 161;
            // 
            // TemplateValue
            // 
            TemplateValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TemplateValue.DataPropertyName = "TemplateValue";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle5.ForeColor = Color.RosyBrown;
            TemplateValue.DefaultCellStyle = dataGridViewCellStyle5;
            TemplateValue.HeaderText = "External Template Defaults";
            TemplateValue.MinimumWidth = 9;
            TemplateValue.Name = "TemplateValue";
            TemplateValue.ReadOnly = true;
            TemplateValue.Width = 155;
            // 
            // spanDataGridViewTextBoxColumn
            // 
            spanDataGridViewTextBoxColumn.DataPropertyName = "Span";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle6.ForeColor = Color.White;
            spanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            spanDataGridViewTextBoxColumn.HeaderText = "Span";
            spanDataGridViewTextBoxColumn.Name = "spanDataGridViewTextBoxColumn";
            spanDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle7.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle7.ForeColor = Color.White;
            iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDdisplayDataGridViewTextBoxColumn1
            // 
            iDdisplayDataGridViewTextBoxColumn1.DataPropertyName = "IDdisplay";
            dataGridViewCellStyle8.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle8.ForeColor = Color.White;
            iDdisplayDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            iDdisplayDataGridViewTextBoxColumn1.HeaderText = "IDdisplay";
            iDdisplayDataGridViewTextBoxColumn1.Name = "iDdisplayDataGridViewTextBoxColumn1";
            iDdisplayDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            dataGridViewCellStyle9.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle9.ForeColor = Color.White;
            typeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // valueDataGridViewTextBoxColumn1
            // 
            valueDataGridViewTextBoxColumn1.DataPropertyName = "Value";
            dataGridViewCellStyle10.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle10.ForeColor = Color.White;
            valueDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            valueDataGridViewTextBoxColumn1.HeaderText = "Value";
            valueDataGridViewTextBoxColumn1.Name = "valueDataGridViewTextBoxColumn1";
            valueDataGridViewTextBoxColumn1.Visible = false;
            // 
            // internalValueDataGridViewTextBoxColumn
            // 
            internalValueDataGridViewTextBoxColumn.DataPropertyName = "InternalValue";
            dataGridViewCellStyle11.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle11.ForeColor = Color.White;
            internalValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            internalValueDataGridViewTextBoxColumn.HeaderText = "InternalValue";
            internalValueDataGridViewTextBoxColumn.Name = "internalValueDataGridViewTextBoxColumn";
            internalValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // templateValueDataGridViewTextBoxColumn1
            // 
            templateValueDataGridViewTextBoxColumn1.DataPropertyName = "TemplateValue";
            dataGridViewCellStyle12.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle12.ForeColor = Color.White;
            templateValueDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            templateValueDataGridViewTextBoxColumn1.HeaderText = "TemplateValue";
            templateValueDataGridViewTextBoxColumn1.Name = "templateValueDataGridViewTextBoxColumn1";
            templateValueDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stringGridEntryBindingSource
            // 
            stringGridEntryBindingSource.DataSource = typeof(GridEntry);
            // 
            // valueGrid
            // 
            valueGrid.AllowUserToAddRows = false;
            valueGrid.AllowUserToDeleteRows = false;
            valueGrid.AllowUserToResizeRows = false;
            valueGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valueGrid.AutoGenerateColumns = false;
            valueGrid.BackgroundColor = Color.FromArgb(21, 21, 21);
            valueGrid.BorderStyle = BorderStyle.None;
            valueGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            valueGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.Window;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            valueGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            valueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            valueGrid.Columns.AddRange(new DataGridViewColumn[] { iDdisplayDataGridViewTextBoxColumn, Type, dataGridViewTextBoxColumn1, valueDataGridViewTextBoxColumn, templateValueDataGridViewTextBoxColumn });
            valueGrid.DataSource = valueGridBindingSource;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.Control;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            valueGrid.DefaultCellStyle = dataGridViewCellStyle22;
            valueGrid.EnableHeadersVisualStyles = false;
            valueGrid.GridColor = SystemColors.ActiveCaptionText;
            valueGrid.Location = new Point(9, 24);
            valueGrid.Margin = new Padding(9, 8, 9, 8);
            valueGrid.MinimumSize = new Size(338, 116);
            valueGrid.Name = "valueGrid";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            valueGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            valueGrid.RowHeadersVisible = false;
            valueGrid.RowHeadersWidth = 72;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle24.ForeColor = Color.White;
            valueGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            valueGrid.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            valueGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            valueGrid.RowTemplate.Height = 37;
            valueGrid.Size = new Size(911, 225);
            valueGrid.TabIndex = 3;
            valueGrid.CellPainting += valueGrid_CellPainting;
            valueGrid.DataBindingComplete += valueGrid_DataBindingComplete;
            // 
            // iDdisplayDataGridViewTextBoxColumn
            // 
            iDdisplayDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            iDdisplayDataGridViewTextBoxColumn.DataPropertyName = "IDdisplay";
            dataGridViewCellStyle17.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle17.ForeColor = Color.White;
            iDdisplayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            iDdisplayDataGridViewTextBoxColumn.HeaderText = "ID";
            iDdisplayDataGridViewTextBoxColumn.MinimumWidth = 9;
            iDdisplayDataGridViewTextBoxColumn.Name = "iDdisplayDataGridViewTextBoxColumn";
            iDdisplayDataGridViewTextBoxColumn.ReadOnly = true;
            iDdisplayDataGridViewTextBoxColumn.Width = 42;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Type.DataPropertyName = "Type";
            dataGridViewCellStyle18.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle18.ForeColor = Color.White;
            Type.DefaultCellStyle = dataGridViewCellStyle18;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 9;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "InternalValue";
            dataGridViewCellStyle19.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn1.HeaderText = "Internal Shader";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 101;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            dataGridViewCellStyle20.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle20.ForeColor = Color.White;
            valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            valueDataGridViewTextBoxColumn.HeaderText = "External Template Overrides";
            valueDataGridViewTextBoxColumn.MinimumWidth = 9;
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            valueDataGridViewTextBoxColumn.Width = 161;
            // 
            // templateValueDataGridViewTextBoxColumn
            // 
            templateValueDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            templateValueDataGridViewTextBoxColumn.DataPropertyName = "TemplateValue";
            dataGridViewCellStyle21.BackColor = Color.FromArgb(21, 21, 21);
            dataGridViewCellStyle21.ForeColor = SystemColors.ControlDark;
            templateValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            templateValueDataGridViewTextBoxColumn.HeaderText = "External Template Default";
            templateValueDataGridViewTextBoxColumn.MinimumWidth = 9;
            templateValueDataGridViewTextBoxColumn.Name = "templateValueDataGridViewTextBoxColumn";
            templateValueDataGridViewTextBoxColumn.ReadOnly = true;
            templateValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // valueGridBindingSource
            // 
            valueGridBindingSource.DataSource = typeof(GridEntry);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3);
            tableLayoutPanel1.Location = new Point(7, 6);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1223, 531);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(valueGrid);
            panel2.Location = new Point(290, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 261);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(413, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 4;
            label2.Text = "Numeric inputs";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(removeUndefInts);
            panel1.Controls.Add(removeUndefFloats);
            panel1.Controls.Add(removeUndefTextures);
            panel1.Controls.Add(openbutton);
            panel1.Controls.Add(savebutton);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.MinimumSize = new Size(284, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 261);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.AccessibleName = "folderButton";
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(60, 212);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 5;
            button1.Text = "Batch Convert to Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += folderButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(26, 26, 26);
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // removeUndefInts
            // 
            removeUndefInts.AutoSize = true;
            removeUndefInts.Location = new Point(10, 122);
            removeUndefInts.Margin = new Padding(2);
            removeUndefInts.Name = "removeUndefInts";
            removeUndefInts.Size = new Size(245, 19);
            removeUndefInts.TabIndex = 3;
            removeUndefInts.Text = "Remove undefined (red) integer overrides";
            removeUndefInts.UseVisualStyleBackColor = true;
            // 
            // removeUndefFloats
            // 
            removeUndefFloats.AutoSize = true;
            removeUndefFloats.Location = new Point(10, 102);
            removeUndefFloats.Margin = new Padding(2);
            removeUndefFloats.Name = "removeUndefFloats";
            removeUndefFloats.Size = new Size(232, 19);
            removeUndefFloats.TabIndex = 3;
            removeUndefFloats.Text = "Remove undefined (red) float overrides";
            removeUndefFloats.UseVisualStyleBackColor = true;
            // 
            // removeUndefTextures
            // 
            removeUndefTextures.AutoSize = true;
            removeUndefTextures.Location = new Point(10, 82);
            removeUndefTextures.Margin = new Padding(2);
            removeUndefTextures.Name = "removeUndefTextures";
            removeUndefTextures.Size = new Size(245, 19);
            removeUndefTextures.TabIndex = 3;
            removeUndefTextures.Text = "Remove undefined (red) texture overrides";
            removeUndefTextures.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(stringGrid);
            panel3.Location = new Point(2, 267);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1219, 262);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(548, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Texture inputs";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(20, 20, 20);
            statusStrip1.ImageScalingSize = new Size(28, 28);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusLabel });
            statusStrip1.Location = new Point(0, 532);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 8, 0);
            statusStrip1.Size = new Size(1242, 37);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 32);
            // 
            // statusLabel
            // 
            statusLabel.Image = Properties.Resources.ok;
            statusLabel.Margin = new Padding(8, 5, 0, 4);
            statusLabel.Name = "statusLabel";
            statusLabel.Padding = new Padding(10, 0, 0, 0);
            statusLabel.Size = new Size(38, 28);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1242, 569);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(701, 389);
            Name = "Form1";
            Text = "Spandex";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)stringGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)stringGridEntryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)valueGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)valueGridBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openbutton;
        private Button savebutton;
        private DataGridView stringGrid;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn assetPathDataGridViewTextBoxColumn;
        private BindingSource bindingSource2;
        private BindingSource stringGridEntryBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView valueGrid;
        private BindingSource valueGridBindingSource;
        private DataGridViewTextBoxColumn templateTypeDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private CheckBox removeUndefInts;
        private CheckBox removeUndefFloats;
        private CheckBox removeUndefTextures;
        private Label label2;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusLabel;
        private DataGridViewTextBoxColumn iDdisplayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn templateValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IDdisplay;
        private DataGridViewTextBoxColumn InternalValue;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn TemplateValue;
        private DataGridViewTextBoxColumn spanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDdisplayDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn internalValueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn templateValueDataGridViewTextBoxColumn1;
        private ComboBox comboBox1;
        private Button button1;
    }
}
