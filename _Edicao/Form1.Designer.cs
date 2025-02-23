namespace Validata
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.tablelytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tablelytLista = new System.Windows.Forms.TableLayoutPanel();
            this.tablelytProcurar = new System.Windows.Forms.TableLayoutPanel();
            this.panelbtnClear = new System.Windows.Forms.Panel();
            this.btnClear = new Validata.CustomButton();
            this.paneltxtProcurarNome = new System.Windows.Forms.Panel();
            this.txtProcurarNome = new System.Windows.Forms.TextBox();
            this.paneltxtProcurarEntrada = new System.Windows.Forms.Panel();
            this.txtProcurarEntrada = new System.Windows.Forms.TextBox();
            this.paneltxtProcurarValidade = new System.Windows.Forms.Panel();
            this.txtProcurarValidade = new System.Windows.Forms.TextBox();
            this.paneltxtProcurarLocal = new System.Windows.Forms.Panel();
            this.txtProcurarLocal = new System.Windows.Forms.TextBox();
            this.paneltxtProcurarPreco = new System.Windows.Forms.Panel();
            this.txtProcurarPreco = new System.Windows.Forms.TextBox();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.panelEdition = new System.Windows.Forms.Panel();
            this.tablelytEdition = new System.Windows.Forms.TableLayoutPanel();
            this.tablelytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdicionar = new Validata.CustomButton();
            this.btnRemover = new Validata.CustomButton();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.tablelytAdicionar = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelValidade = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelLocal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPreco = new System.Windows.Forms.Label();
            this.paneltxtNomeProduto = new System.Windows.Forms.Panel();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.panelDataEntrada = new System.Windows.Forms.Panel();
            this.DataEntrada = new System.Windows.Forms.DateTimePicker();
            this.panelDataValidade = new System.Windows.Forms.Panel();
            this.DataValidade = new System.Windows.Forms.DateTimePicker();
            this.paneltxtLocal = new System.Windows.Forms.Panel();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.paneltxtPreco = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.toolBar1 = new Validata.ToolBar();
            this.windowBar1 = new Validata.WindowBar();
            this.panelBackground.SuspendLayout();
            this.tablelytMain.SuspendLayout();
            this.tablelytLista.SuspendLayout();
            this.tablelytProcurar.SuspendLayout();
            this.panelbtnClear.SuspendLayout();
            this.paneltxtProcurarNome.SuspendLayout();
            this.paneltxtProcurarEntrada.SuspendLayout();
            this.paneltxtProcurarValidade.SuspendLayout();
            this.paneltxtProcurarLocal.SuspendLayout();
            this.paneltxtProcurarPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.panelEdition.SuspendLayout();
            this.tablelytEdition.SuspendLayout();
            this.tablelytButtons.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.tablelytAdicionar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.paneltxtNomeProduto.SuspendLayout();
            this.panelDataEntrada.SuspendLayout();
            this.panelDataValidade.SuspendLayout();
            this.paneltxtLocal.SuspendLayout();
            this.paneltxtPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBackground.Controls.Add(this.tablelytMain);
            this.panelBackground.Location = new System.Drawing.Point(0, 55);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(8);
            this.panelBackground.Size = new System.Drawing.Size(752, 394);
            this.panelBackground.TabIndex = 100;
            // 
            // tablelytMain
            // 
            this.tablelytMain.ColumnCount = 1;
            this.tablelytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytMain.Controls.Add(this.tablelytLista, 0, 0);
            this.tablelytMain.Controls.Add(this.panelEdition, 0, 1);
            this.tablelytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelytMain.Location = new System.Drawing.Point(8, 8);
            this.tablelytMain.Margin = new System.Windows.Forms.Padding(0);
            this.tablelytMain.Name = "tablelytMain";
            this.tablelytMain.RowCount = 2;
            this.tablelytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tablelytMain.Size = new System.Drawing.Size(736, 378);
            this.tablelytMain.TabIndex = 100;
            // 
            // tablelytLista
            // 
            this.tablelytLista.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablelytLista.ColumnCount = 1;
            this.tablelytLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytLista.Controls.Add(this.tablelytProcurar, 0, 0);
            this.tablelytLista.Controls.Add(this.dataGridViewProdutos, 0, 1);
            this.tablelytLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelytLista.Location = new System.Drawing.Point(0, 0);
            this.tablelytLista.Margin = new System.Windows.Forms.Padding(0);
            this.tablelytLista.Name = "tablelytLista";
            this.tablelytLista.RowCount = 2;
            this.tablelytLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelytLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytLista.Size = new System.Drawing.Size(736, 301);
            this.tablelytLista.TabIndex = 100;
            // 
            // tablelytProcurar
            // 
            this.tablelytProcurar.ColumnCount = 6;
            this.tablelytProcurar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablelytProcurar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytProcurar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablelytProcurar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablelytProcurar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablelytProcurar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablelytProcurar.Controls.Add(this.panelbtnClear, 0, 0);
            this.tablelytProcurar.Controls.Add(this.paneltxtProcurarNome, 1, 0);
            this.tablelytProcurar.Controls.Add(this.paneltxtProcurarEntrada, 2, 0);
            this.tablelytProcurar.Controls.Add(this.paneltxtProcurarValidade, 3, 0);
            this.tablelytProcurar.Controls.Add(this.paneltxtProcurarLocal, 4, 0);
            this.tablelytProcurar.Controls.Add(this.paneltxtProcurarPreco, 5, 0);
            this.tablelytProcurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelytProcurar.Location = new System.Drawing.Point(1, 1);
            this.tablelytProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.tablelytProcurar.Name = "tablelytProcurar";
            this.tablelytProcurar.RowCount = 1;
            this.tablelytProcurar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytProcurar.Size = new System.Drawing.Size(734, 20);
            this.tablelytProcurar.TabIndex = 100;
            // 
            // panelbtnClear
            // 
            this.panelbtnClear.Controls.Add(this.btnClear);
            this.panelbtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbtnClear.Location = new System.Drawing.Point(0, 0);
            this.panelbtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.panelbtnClear.Name = "panelbtnClear";
            this.panelbtnClear.Size = new System.Drawing.Size(50, 20);
            this.panelbtnClear.TabIndex = 100;
            // 
            // btnClear
            // 
            this.btnClear.ButtonBackColor = System.Drawing.Color.White;
            this.btnClear.ButtonBackgroundImage = null;
            this.btnClear.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.ButtonBorderClickable = false;
            this.btnClear.ButtonBorderColor = System.Drawing.Color.Gray;
            this.btnClear.ButtonBorderHighlightColor = System.Drawing.Color.DarkCyan;
            this.btnClear.ButtonBorderWidth = new System.Windows.Forms.Padding(1);
            this.btnClear.ButtonFont = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.btnClear.ButtonForeColor = System.Drawing.Color.Black;
            this.btnClear.ButtonHighlight = true;
            this.btnClear.ButtonHighlightBackColor = System.Drawing.Color.White;
            this.btnClear.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.btnClear.ButtonText = "🔎";
            this.btnClear.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 20);
            this.btnClear.TabIndex = 100;
            this.btnClear.TabStop = false;
            this.btnClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseDown);
            // 
            // paneltxtProcurarNome
            // 
            this.paneltxtProcurarNome.Controls.Add(this.txtProcurarNome);
            this.paneltxtProcurarNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtProcurarNome.Location = new System.Drawing.Point(50, 0);
            this.paneltxtProcurarNome.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtProcurarNome.Name = "paneltxtProcurarNome";
            this.paneltxtProcurarNome.Size = new System.Drawing.Size(284, 20);
            this.paneltxtProcurarNome.TabIndex = 100;
            // 
            // txtProcurarNome
            // 
            this.txtProcurarNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcurarNome.Location = new System.Drawing.Point(0, 0);
            this.txtProcurarNome.MaxLength = 150;
            this.txtProcurarNome.Name = "txtProcurarNome";
            this.txtProcurarNome.Size = new System.Drawing.Size(284, 20);
            this.txtProcurarNome.TabIndex = 0;
            this.txtProcurarNome.TextChanged += new System.EventHandler(this.txtProcurarNome_TextChanged);
            // 
            // paneltxtProcurarEntrada
            // 
            this.paneltxtProcurarEntrada.Controls.Add(this.txtProcurarEntrada);
            this.paneltxtProcurarEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtProcurarEntrada.Location = new System.Drawing.Point(334, 0);
            this.paneltxtProcurarEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtProcurarEntrada.Name = "paneltxtProcurarEntrada";
            this.paneltxtProcurarEntrada.Size = new System.Drawing.Size(100, 20);
            this.paneltxtProcurarEntrada.TabIndex = 100;
            // 
            // txtProcurarEntrada
            // 
            this.txtProcurarEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcurarEntrada.Location = new System.Drawing.Point(0, 0);
            this.txtProcurarEntrada.Name = "txtProcurarEntrada";
            this.txtProcurarEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarEntrada.TabIndex = 0;
            this.txtProcurarEntrada.TextChanged += new System.EventHandler(this.txtProcurarEntrada_TextChanged);
            // 
            // paneltxtProcurarValidade
            // 
            this.paneltxtProcurarValidade.Controls.Add(this.txtProcurarValidade);
            this.paneltxtProcurarValidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtProcurarValidade.Location = new System.Drawing.Point(434, 0);
            this.paneltxtProcurarValidade.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtProcurarValidade.Name = "paneltxtProcurarValidade";
            this.paneltxtProcurarValidade.Size = new System.Drawing.Size(100, 20);
            this.paneltxtProcurarValidade.TabIndex = 100;
            // 
            // txtProcurarValidade
            // 
            this.txtProcurarValidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcurarValidade.Location = new System.Drawing.Point(0, 0);
            this.txtProcurarValidade.MaxLength = 150;
            this.txtProcurarValidade.Name = "txtProcurarValidade";
            this.txtProcurarValidade.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarValidade.TabIndex = 0;
            this.txtProcurarValidade.TextChanged += new System.EventHandler(this.txtProcurarValidade_TextChanged);
            // 
            // paneltxtProcurarLocal
            // 
            this.paneltxtProcurarLocal.Controls.Add(this.txtProcurarLocal);
            this.paneltxtProcurarLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtProcurarLocal.Location = new System.Drawing.Point(534, 0);
            this.paneltxtProcurarLocal.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtProcurarLocal.Name = "paneltxtProcurarLocal";
            this.paneltxtProcurarLocal.Size = new System.Drawing.Size(100, 20);
            this.paneltxtProcurarLocal.TabIndex = 100;
            // 
            // txtProcurarLocal
            // 
            this.txtProcurarLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcurarLocal.Location = new System.Drawing.Point(0, 0);
            this.txtProcurarLocal.MaxLength = 150;
            this.txtProcurarLocal.Name = "txtProcurarLocal";
            this.txtProcurarLocal.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarLocal.TabIndex = 0;
            this.txtProcurarLocal.TextChanged += new System.EventHandler(this.txtProcurarLocal_TextChanged);
            // 
            // paneltxtProcurarPreco
            // 
            this.paneltxtProcurarPreco.Controls.Add(this.txtProcurarPreco);
            this.paneltxtProcurarPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtProcurarPreco.Location = new System.Drawing.Point(634, 0);
            this.paneltxtProcurarPreco.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtProcurarPreco.Name = "paneltxtProcurarPreco";
            this.paneltxtProcurarPreco.Size = new System.Drawing.Size(100, 20);
            this.paneltxtProcurarPreco.TabIndex = 100;
            // 
            // txtProcurarPreco
            // 
            this.txtProcurarPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcurarPreco.Location = new System.Drawing.Point(0, 0);
            this.txtProcurarPreco.MaxLength = 150;
            this.txtProcurarPreco.Name = "txtProcurarPreco";
            this.txtProcurarPreco.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarPreco.TabIndex = 0;
            this.txtProcurarPreco.TextChanged += new System.EventHandler(this.txtProcurarPreco_TextChanged);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProdutos.EnableHeadersVisualStyles = false;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(1, 22);
            this.dataGridViewProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(734, 278);
            this.dataGridViewProdutos.TabIndex = 1;
            this.dataGridViewProdutos.TabStop = false;
            this.dataGridViewProdutos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewProdutos_CellBeginEdit);
            this.dataGridViewProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellEndEdit);
            this.dataGridViewProdutos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProdutos_ColumnHeaderMouseClick);
            this.dataGridViewProdutos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewProdutos_DataError);
            this.dataGridViewProdutos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewProdutos_RowPrePaint);
            this.dataGridViewProdutos.SelectionChanged += new System.EventHandler(this.dataGridViewProdutos_SelectionChanged);
            this.dataGridViewProdutos.Sorted += new System.EventHandler(this.dataGridViewProdutos_Sorted);
            // 
            // panelEdition
            // 
            this.panelEdition.Controls.Add(this.tablelytEdition);
            this.panelEdition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdition.Location = new System.Drawing.Point(0, 301);
            this.panelEdition.Margin = new System.Windows.Forms.Padding(0);
            this.panelEdition.Name = "panelEdition";
            this.panelEdition.Size = new System.Drawing.Size(736, 77);
            this.panelEdition.TabIndex = 100;
            // 
            // tablelytEdition
            // 
            this.tablelytEdition.ColumnCount = 1;
            this.tablelytEdition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytEdition.Controls.Add(this.tablelytButtons, 0, 1);
            this.tablelytEdition.Controls.Add(this.panelAdd, 0, 0);
            this.tablelytEdition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelytEdition.Location = new System.Drawing.Point(0, 0);
            this.tablelytEdition.Margin = new System.Windows.Forms.Padding(0);
            this.tablelytEdition.Name = "tablelytEdition";
            this.tablelytEdition.RowCount = 2;
            this.tablelytEdition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tablelytEdition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tablelytEdition.Size = new System.Drawing.Size(736, 77);
            this.tablelytEdition.TabIndex = 100;
            // 
            // tablelytButtons
            // 
            this.tablelytButtons.ColumnCount = 1;
            this.tablelytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelytButtons.Controls.Add(this.panelButtons, 0, 0);
            this.tablelytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelytButtons.Location = new System.Drawing.Point(0, 45);
            this.tablelytButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tablelytButtons.Name = "tablelytButtons";
            this.tablelytButtons.RowCount = 1;
            this.tablelytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelytButtons.Size = new System.Drawing.Size(736, 32);
            this.tablelytButtons.TabIndex = 100;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAdicionar);
            this.panelButtons.Controls.Add(this.btnRemover);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(736, 32);
            this.panelButtons.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.ButtonBackColor = System.Drawing.Color.White;
            this.btnAdicionar.ButtonBackgroundImage = null;
            this.btnAdicionar.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionar.ButtonBorderClickable = false;
            this.btnAdicionar.ButtonBorderColor = System.Drawing.Color.Gray;
            this.btnAdicionar.ButtonBorderHighlightColor = System.Drawing.Color.DarkCyan;
            this.btnAdicionar.ButtonBorderWidth = new System.Windows.Forms.Padding(1);
            this.btnAdicionar.ButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAdicionar.ButtonForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.ButtonHighlight = true;
            this.btnAdicionar.ButtonHighlightBackColor = System.Drawing.Color.White;
            this.btnAdicionar.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.btnAdicionar.ButtonText = "Adicionar";
            this.btnAdicionar.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(675, 3);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(60, 25);
            this.btnAdicionar.TabIndex = 100;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdicionar_MouseDown);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.ButtonBackColor = System.Drawing.Color.White;
            this.btnRemover.ButtonBackgroundImage = null;
            this.btnRemover.ButtonBackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemover.ButtonBorderClickable = false;
            this.btnRemover.ButtonBorderColor = System.Drawing.Color.Gray;
            this.btnRemover.ButtonBorderHighlightColor = System.Drawing.Color.DarkCyan;
            this.btnRemover.ButtonBorderWidth = new System.Windows.Forms.Padding(1);
            this.btnRemover.ButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRemover.ButtonForeColor = System.Drawing.Color.Black;
            this.btnRemover.ButtonHighlight = true;
            this.btnRemover.ButtonHighlightBackColor = System.Drawing.Color.White;
            this.btnRemover.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.btnRemover.ButtonText = "Remover";
            this.btnRemover.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemover.Location = new System.Drawing.Point(611, 3);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(60, 25);
            this.btnRemover.TabIndex = 0;
            this.btnRemover.TabStop = false;
            this.btnRemover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRemover_MouseDown);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.tablelytAdicionar);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(0, 0);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(736, 45);
            this.panelAdd.TabIndex = 101;
            // 
            // tablelytAdicionar
            // 
            this.tablelytAdicionar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablelytAdicionar.ColumnCount = 5;
            this.tablelytAdicionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelytAdicionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tablelytAdicionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablelytAdicionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tablelytAdicionar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tablelytAdicionar.Controls.Add(this.panel1, 0, 0);
            this.tablelytAdicionar.Controls.Add(this.panel2, 1, 0);
            this.tablelytAdicionar.Controls.Add(this.panel3, 2, 0);
            this.tablelytAdicionar.Controls.Add(this.panel4, 3, 0);
            this.tablelytAdicionar.Controls.Add(this.panel5, 4, 0);
            this.tablelytAdicionar.Controls.Add(this.paneltxtNomeProduto, 0, 1);
            this.tablelytAdicionar.Controls.Add(this.panelDataEntrada, 1, 1);
            this.tablelytAdicionar.Controls.Add(this.panelDataValidade, 2, 1);
            this.tablelytAdicionar.Controls.Add(this.paneltxtLocal, 3, 1);
            this.tablelytAdicionar.Controls.Add(this.paneltxtPreco, 4, 1);
            this.tablelytAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelytAdicionar.Location = new System.Drawing.Point(0, 0);
            this.tablelytAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.tablelytAdicionar.Name = "tablelytAdicionar";
            this.tablelytAdicionar.RowCount = 2;
            this.tablelytAdicionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tablelytAdicionar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tablelytAdicionar.Size = new System.Drawing.Size(736, 45);
            this.tablelytAdicionar.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 22);
            this.panel1.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(3, 4);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelEntrada);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(335, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 22);
            this.panel2.TabIndex = 102;
            // 
            // labelEntrada
            // 
            this.labelEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Location = new System.Drawing.Point(3, 4);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(44, 13);
            this.labelEntrada.TabIndex = 1;
            this.labelEntrada.Text = "Entrada";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelValidade);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(434, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 22);
            this.panel3.TabIndex = 100;
            // 
            // labelValidade
            // 
            this.labelValidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValidade.AutoSize = true;
            this.labelValidade.Location = new System.Drawing.Point(3, 4);
            this.labelValidade.Name = "labelValidade";
            this.labelValidade.Size = new System.Drawing.Size(48, 13);
            this.labelValidade.TabIndex = 0;
            this.labelValidade.Text = "Validade";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelLocal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(535, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 22);
            this.panel4.TabIndex = 100;
            // 
            // labelLocal
            // 
            this.labelLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(3, 4);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(33, 13);
            this.labelLocal.TabIndex = 0;
            this.labelLocal.Text = "Local";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelPreco);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(634, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 22);
            this.panel5.TabIndex = 100;
            // 
            // labelPreco
            // 
            this.labelPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(3, 4);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 0;
            this.labelPreco.Text = "Preço";
            // 
            // paneltxtNomeProduto
            // 
            this.paneltxtNomeProduto.Controls.Add(this.txtNomeProduto);
            this.paneltxtNomeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtNomeProduto.Location = new System.Drawing.Point(1, 24);
            this.paneltxtNomeProduto.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtNomeProduto.Name = "paneltxtNomeProduto";
            this.paneltxtNomeProduto.Size = new System.Drawing.Size(333, 23);
            this.paneltxtNomeProduto.TabIndex = 100;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeProduto.Location = new System.Drawing.Point(0, 0);
            this.txtNomeProduto.MaxLength = 150;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(333, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // panelDataEntrada
            // 
            this.panelDataEntrada.Controls.Add(this.DataEntrada);
            this.panelDataEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataEntrada.Location = new System.Drawing.Point(335, 24);
            this.panelDataEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataEntrada.Name = "panelDataEntrada";
            this.panelDataEntrada.Size = new System.Drawing.Size(98, 23);
            this.panelDataEntrada.TabIndex = 100;
            // 
            // DataEntrada
            // 
            this.DataEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEntrada.Location = new System.Drawing.Point(0, 0);
            this.DataEntrada.MaxDate = new System.DateTime(2049, 12, 31, 0, 0, 0, 0);
            this.DataEntrada.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.Size = new System.Drawing.Size(98, 20);
            this.DataEntrada.TabIndex = 0;
            // 
            // panelDataValidade
            // 
            this.panelDataValidade.Controls.Add(this.DataValidade);
            this.panelDataValidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataValidade.Location = new System.Drawing.Point(434, 24);
            this.panelDataValidade.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataValidade.Name = "panelDataValidade";
            this.panelDataValidade.Size = new System.Drawing.Size(100, 23);
            this.panelDataValidade.TabIndex = 100;
            // 
            // DataValidade
            // 
            this.DataValidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataValidade.Location = new System.Drawing.Point(0, 0);
            this.DataValidade.MaxDate = new System.DateTime(2049, 12, 31, 0, 0, 0, 0);
            this.DataValidade.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DataValidade.Name = "DataValidade";
            this.DataValidade.Size = new System.Drawing.Size(100, 20);
            this.DataValidade.TabIndex = 0;
            // 
            // paneltxtLocal
            // 
            this.paneltxtLocal.Controls.Add(this.txtLocal);
            this.paneltxtLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtLocal.Location = new System.Drawing.Point(535, 24);
            this.paneltxtLocal.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtLocal.Name = "paneltxtLocal";
            this.paneltxtLocal.Size = new System.Drawing.Size(98, 23);
            this.paneltxtLocal.TabIndex = 100;
            // 
            // txtLocal
            // 
            this.txtLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocal.Location = new System.Drawing.Point(0, 0);
            this.txtLocal.MaxLength = 120;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(98, 20);
            this.txtLocal.TabIndex = 0;
            // 
            // paneltxtPreco
            // 
            this.paneltxtPreco.Controls.Add(this.txtPreco);
            this.paneltxtPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtPreco.Location = new System.Drawing.Point(634, 24);
            this.paneltxtPreco.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtPreco.Name = "paneltxtPreco";
            this.paneltxtPreco.Size = new System.Drawing.Size(101, 23);
            this.paneltxtPreco.TabIndex = 100;
            // 
            // txtPreco
            // 
            this.txtPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreco.Location = new System.Drawing.Point(0, 0);
            this.txtPreco.MaxLength = 120;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(101, 20);
            this.txtPreco.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(6, 454);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 101;
            this.labelInfo.Text = "label1";
            // 
            // toolBar1
            // 
            this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolBar1.DarkMode = true;
            this.toolBar1.FixedPos = new System.Drawing.Point(0, 30);
            this.toolBar1.FixExtraWidth = false;
            this.toolBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toolBar1.Location = new System.Drawing.Point(0, 30);
            this.toolBar1.Margin = new System.Windows.Forms.Padding(0);
            this.toolBar1.MetroStyle = MetroFramework.MetroColorStyle.Blue;
            this.toolBar1.MetroTheme = MetroFramework.MetroThemeStyle.Dark;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Owner = this;
            this.toolBar1.Size = new System.Drawing.Size(752, 25);
            this.toolBar1.TabIndex = 100;
            this.toolBar1.TabStop = false;
            // 
            // windowBar1
            // 
            this.windowBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowBar1.CloseButton = true;
            this.windowBar1.DarkMode = true;
            this.windowBar1.FixedPos = new System.Drawing.Point(0, 0);
            this.windowBar1.FixExtraWidth = false;
            this.windowBar1.Location = new System.Drawing.Point(0, 0);
            this.windowBar1.Margin = new System.Windows.Forms.Padding(0);
            this.windowBar1.MaximizeButton = true;
            this.windowBar1.MetroStyle = MetroFramework.MetroColorStyle.Blue;
            this.windowBar1.MetroTheme = MetroFramework.MetroThemeStyle.Light;
            this.windowBar1.MinimizeButton = true;
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Owner = this;
            this.windowBar1.ShowIcon = true;
            this.windowBar1.Size = new System.Drawing.Size(752, 30);
            this.windowBar1.TabIndex = 100;
            this.windowBar1.TabStop = false;
            this.windowBar1.Title = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 471);
            this.ControlBox = false;
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.windowBar1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 22);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelBackground.ResumeLayout(false);
            this.tablelytMain.ResumeLayout(false);
            this.tablelytLista.ResumeLayout(false);
            this.tablelytProcurar.ResumeLayout(false);
            this.panelbtnClear.ResumeLayout(false);
            this.paneltxtProcurarNome.ResumeLayout(false);
            this.paneltxtProcurarNome.PerformLayout();
            this.paneltxtProcurarEntrada.ResumeLayout(false);
            this.paneltxtProcurarEntrada.PerformLayout();
            this.paneltxtProcurarValidade.ResumeLayout(false);
            this.paneltxtProcurarValidade.PerformLayout();
            this.paneltxtProcurarLocal.ResumeLayout(false);
            this.paneltxtProcurarLocal.PerformLayout();
            this.paneltxtProcurarPreco.ResumeLayout(false);
            this.paneltxtProcurarPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.panelEdition.ResumeLayout(false);
            this.tablelytEdition.ResumeLayout(false);
            this.tablelytButtons.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.tablelytAdicionar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.paneltxtNomeProduto.ResumeLayout(false);
            this.paneltxtNomeProduto.PerformLayout();
            this.panelDataEntrada.ResumeLayout(false);
            this.panelDataValidade.ResumeLayout(false);
            this.paneltxtLocal.ResumeLayout(false);
            this.paneltxtLocal.PerformLayout();
            this.paneltxtPreco.ResumeLayout(false);
            this.paneltxtPreco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowBar windowBar1;
        private ToolBar toolBar1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tablelytMain;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TableLayoutPanel tablelytAdicionar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelValidade;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.DateTimePicker DataValidade;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelEdition;
        private System.Windows.Forms.TableLayoutPanel tablelytProcurar;
        private System.Windows.Forms.TextBox txtProcurarNome;
        private System.Windows.Forms.TextBox txtProcurarValidade;
        private System.Windows.Forms.TextBox txtProcurarLocal;
        private System.Windows.Forms.TextBox txtProcurarPreco;
        private System.Windows.Forms.TableLayoutPanel tablelytLista;
        private CustomButton btnAdicionar;
        private CustomButton btnRemover;
        private System.Windows.Forms.TableLayoutPanel tablelytEdition;
        private System.Windows.Forms.TableLayoutPanel tablelytButtons;
        private System.Windows.Forms.Panel panelButtons;
        private CustomButton btnClear;
        private System.Windows.Forms.Panel paneltxtProcurarNome;
        private System.Windows.Forms.Panel paneltxtProcurarPreco;
        private System.Windows.Forms.Panel paneltxtProcurarLocal;
        private System.Windows.Forms.Panel paneltxtProcurarValidade;
        private System.Windows.Forms.Panel panelbtnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel paneltxtNomeProduto;
        private System.Windows.Forms.Panel panelDataValidade;
        private System.Windows.Forms.Panel paneltxtLocal;
        private System.Windows.Forms.Panel paneltxtPreco;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel paneltxtProcurarEntrada;
        private System.Windows.Forms.TextBox txtProcurarEntrada;
        private System.Windows.Forms.Panel panelDataEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.DateTimePicker DataEntrada;
    }
}

