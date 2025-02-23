using MetroFramework;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Validata
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string programFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        private string appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Asen Lab", "ASL Validata");
        private string caminhoArquivoAtual = null;
        private string ultimoArquivo = Properties.Settings.Default.UltimoArquivo;
        private string ultimoTema, ultimoEstilo;
        //private readonly bool _isDarkMode = DarkModeHelper.IsDarkModeEnabled();
        private int minWidth, minHeight;
        private Color HeaderBackColor, ThemeBackColor, ThemeForeColor, ExpiringColor15, ExpiringColor6, ExpiredColor;
        private MetroStyleManager mStyleManager = new();
        private ConfigsForm configs = new();
        private SobreForm sobre = new();
        private object valorOriginalCelula;


        private List<Produto> listaProdutos = new List<Produto>();
        private string colunaOrdenada = "";
        private bool ordemAscendente = true;
        private bool listaModificada = false;

        public string NomeDoProjeto { get; } = "ASL Validata";
        public string VersaoDoArquivo { get; } = ObterVersaoDoArquivo();
        public string NomeDaEmpresa { get; } = "Asen Lab Corporation";

        public event EventHandler DarkModeChanged;
        private bool _isDarkMode = DarkModeHelper.IsDarkModeEnabled();
        public bool DarkMode
        {
            get { return _isDarkMode; }
            set
            {
                if (_isDarkMode != value)
                {
                    _isDarkMode = value;
                    OnDarkModeChanged();
                }
            }
        }

        protected virtual void OnDarkModeChanged()
        {
            DarkModeChanged?.Invoke(this, EventArgs.Empty);
            UpdateTheme();
        }

        private MetroThemeStyle _metroTheme;
        public MetroThemeStyle MetroTheme
        {
            get { return mStyleManager.Theme; }
            set
            {
                if (_metroTheme != value)
                {
                    mStyleManager.Theme = value;
                    _metroTheme = value;
                    mStyleManager.Update();
                }
            }
        }

        private MetroColorStyle _metroStyle;
        public MetroColorStyle MetroStyle
        {
            get { return mStyleManager.Style; }
            set
            {
                if (_metroStyle != value)
                {
                    mStyleManager.Style = value;
                    _metroStyle = value;
                    mStyleManager.Update();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            configs.cbThemeChanged += Configs_ThemeChanged;
            configs.cbStyleChanged += Configs_StyleChanged;
            mStyleManager.Owner = this;
            this.StyleManager = mStyleManager;
            //Application.AddMessageFilter(new ToolbarMessageFilter(toolBar1)); // Desfocar ao clicar fora
            //Application.AddMessageFilter(new DropDownMessageFilter(comboCheckBox1)); // Desfocar ao clicar fora

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserSettings();
            UpdateThisAppearence();
            InitializeToolBar();
            LoadPreviousDocument();
        }

        private void LoadPreviousDocument()
        {
            if (!string.IsNullOrEmpty(ultimoArquivo) && File.Exists(ultimoArquivo))
            {
                // Se existir, carregue o último arquivo
                CarregarListaDeArquivo(ultimoArquivo);
                caminhoArquivoAtual = ultimoArquivo;
                UpdateTitle();
            }
            else
            {
                LimparLista();
                // Caso contrário, inicie um novo arquivo ou tome outras ações necessárias
                // ...
            }
            UpdateTitle();
        }

        private void LoadUserSettings()
        {
            string dataFolder = Path.Combine(appData, "Data");
            string userSettingsPath = Path.Combine(dataFolder, "user.xml");

            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
            if (Directory.Exists(dataFolder))
            {
                if (File.Exists(userSettingsPath))
                {
                    var xml = XDocument.Load(userSettingsPath);
                    var settingsElement = xml.Element("Settings");

                    if (settingsElement != null)
                    {
                        var ultimoTemaElement = settingsElement.Element("UltimoTema");
                        var ultimoEstiloElement = settingsElement.Element("UltimoEstilo");

                        if (ultimoTemaElement != null && ultimoEstiloElement != null)
                        {
                            ultimoTema = ultimoTemaElement.Value;
                            ultimoEstilo = ultimoEstiloElement.Value;
                        }
                    }
                }
            }
        }

        private void SaveUserSettings()
        {
            string dataFolder = Path.Combine(appData, "Data");
            string userSettingsPath = Path.Combine(dataFolder, "user.xml");
            var xml = new XDocument();

            if (File.Exists(userSettingsPath))
            {
                xml = XDocument.Load(userSettingsPath);
            }
            else
            {
                xml.Add(new XElement("Settings"));
            }

            var settingsElement = xml.Element("Settings");

            if (settingsElement == null)
            {
                settingsElement = new XElement("Settings");
                xml.Add(settingsElement);
            }

            settingsElement.SetElementValue("UltimoTema", MetroTheme.ToString());
            settingsElement.SetElementValue("UltimoEstilo", MetroStyle.ToString());

            xml.Save(userSettingsPath);
        }

        public void Configs_ThemeChanged(object sender, EventArgs e)
        {
            MetroTheme = configs.SelectedTheme;
            UpdateTheme();
        }

        public void Configs_StyleChanged(object sender, EventArgs e)
        {
            MetroStyle = configs.SelectedStyle;
            UpdateTheme();
        }

        private void UpdateThisAppearence()
        {
            minWidth = 638; //ClientSize.Width / 2 - (minWidth % 1); // Largura minima da janela
            minHeight = 471; //ClientSize.Height / 2 - (minHeight % 1); // Altura minima da janela

            DataValidade.MinDate = DateTime.Today;
            DataValidade.MaxDate = DateTime.Today.AddYears(10);
            DataEntrada.MinDate = DateTime.Today.AddDays(-30);
            DataEntrada.MaxDate = DateTime.Today.AddDays(30);

            MetroThemeStyle temaConvertido;
            MetroColorStyle estiloConvertido;
            MetroTheme = Enum.TryParse(ultimoTema, out temaConvertido) ? temaConvertido : MetroThemeStyle.Dark;
            MetroStyle = Enum.TryParse(ultimoEstilo, out estiloConvertido) ? estiloConvertido : MetroColorStyle.Blue;

            UpdateTheme();
            UpdateTitle();
        }
        private void UpdateTitle()
        {
            // Verifica se há um arquivo carregado
            if (caminhoArquivoAtual != null)
            {
                // Obtém apenas o nome do arquivo do caminho completo
                string nomeArquivo = Path.GetFileName(caminhoArquivoAtual);

                // Atualiza o título com o nome do arquivo
                string titleName = $"{NomeDoProjeto} {VersaoDoArquivo} ({nomeArquivo})";
                this.Text = titleName;
                windowBar1.Title = titleName;
            }
            else
            {
                // Se nenhum arquivo estiver carregado, exibe apenas a versão do projeto
                this.Text = $"{NomeDoProjeto} {VersaoDoArquivo}";
                windowBar1.Title = $"{NomeDoProjeto} {VersaoDoArquivo}";
            }
            windowBar1.Width = +1;
            windowBar1.Width = -1;
            UpdateInfo();
        }


        private void UpdateTheme()
        {
            HeaderBackColor = _isDarkMode ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255, 255, 255);
            ThemeBackColor = _isDarkMode ? Color.FromArgb(27, 27, 27) : Color.FromArgb(255, 255, 255);
            ThemeForeColor = _isDarkMode ? Color.FromArgb(190, 190, 190) : Color.FromArgb(17, 17, 17);

            ExpiringColor15 = _isDarkMode ? Color.FromArgb(115, 99, 18) : Color.FromArgb(255, 242, 176);
            ExpiringColor6 = _isDarkMode ? Color.FromArgb(115, 65, 18) : Color.FromArgb(255, 193, 138);
            ExpiredColor = _isDarkMode ? Color.FromArgb(115, 18, 18) : Color.FromArgb(255, 117, 117);

            dataGridViewProdutos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 115, 255);
            dataGridViewProdutos.ColumnHeadersDefaultCellStyle.BackColor = ThemeBackColor;
            dataGridViewProdutos.ColumnHeadersDefaultCellStyle.ForeColor = ThemeForeColor;
            dataGridViewProdutos.RowHeadersDefaultCellStyle.BackColor = ThemeBackColor;
            dataGridViewProdutos.RowHeadersDefaultCellStyle.ForeColor = ThemeForeColor;

            labelNome.ForeColor = ThemeForeColor;
            labelEntrada.ForeColor = ThemeForeColor;
            labelValidade.ForeColor = ThemeForeColor;
            labelLocal.ForeColor = ThemeForeColor;
            labelPreco.ForeColor = ThemeForeColor;
            labelInfo.ForeColor = ThemeForeColor;

            panel1.BackColor = ThemeBackColor;
            panel4.BackColor = ThemeBackColor;
            panel3.BackColor = ThemeBackColor;
            panel5.BackColor = ThemeBackColor;

            btnAdicionar.ButtonForeColor = ThemeForeColor;
            btnRemover.ButtonForeColor = ThemeForeColor;
            btnClear.ButtonForeColor = ThemeForeColor;
            btnAdicionar.ButtonBackColor = ThemeBackColor;
            btnRemover.ButtonBackColor = ThemeBackColor;
            btnClear.ButtonBackColor = ThemeBackColor;

            btnAdicionar.ButtonHighlightBackColor = ThemeBackColor;
            btnRemover.ButtonHighlightBackColor = ThemeBackColor;
            btnClear.ButtonHighlightBackColor = ThemeBackColor;
            btnAdicionar.ButtonHighlightForeColor = ThemeForeColor;
            btnRemover.ButtonHighlightForeColor = ThemeForeColor;
            btnClear.ButtonHighlightForeColor = ThemeForeColor;
            btnAdicionar.ButtonBorderHighlightColor = Color.FromArgb(0, 115, 255);
            btnRemover.ButtonBorderHighlightColor = Color.FromArgb(0, 115, 255);
            btnClear.ButtonBorderHighlightColor = Color.FromArgb(0, 115, 255);

            dataGridViewProdutos.BackgroundColor = ThemeBackColor;
            dataGridViewProdutos.DefaultCellStyle.BackColor = ThemeBackColor;
            dataGridViewProdutos.DefaultCellStyle.ForeColor = ThemeForeColor;

            txtProcurarNome.BackColor = ThemeBackColor;
            txtProcurarEntrada.BackColor = ThemeBackColor;
            txtProcurarValidade.BackColor = ThemeBackColor;
            txtProcurarLocal.BackColor = ThemeBackColor;
            txtProcurarPreco.BackColor = ThemeBackColor;

            txtNomeProduto.BackColor = ThemeBackColor;
            DataEntrada.BackColor = ThemeBackColor;
            DataValidade.BackColor = ThemeBackColor;
            txtLocal.BackColor = ThemeBackColor;
            txtPreco.BackColor = ThemeBackColor;

            txtProcurarNome.ForeColor = ThemeForeColor;
            txtProcurarEntrada.ForeColor = ThemeForeColor;
            txtProcurarValidade.ForeColor = ThemeForeColor;
            txtProcurarLocal.ForeColor = ThemeForeColor;
            txtProcurarPreco.ForeColor = ThemeForeColor;

            txtNomeProduto.ForeColor = ThemeForeColor;
            DataEntrada.ForeColor = ThemeForeColor;
            DataValidade.ForeColor = ThemeForeColor;
            txtLocal.ForeColor = ThemeForeColor;
            txtPreco.ForeColor = ThemeForeColor;

            mStyleManager.Theme = MetroTheme;
            configs.MetroTheme = MetroTheme;
            windowBar1.MetroTheme = MetroTheme;
            toolBar1.MetroTheme = MetroTheme;

            this.DarkMode = (MetroTheme == MetroThemeStyle.Dark);
            configs.DarkMode = (MetroTheme == MetroThemeStyle.Dark);
            sobre.DarkMode = (MetroTheme == MetroThemeStyle.Dark);
            windowBar1.DarkMode = (MetroTheme == MetroThemeStyle.Dark);
            toolBar1.DarkMode = (MetroTheme == MetroThemeStyle.Dark);

            mStyleManager.Style = MetroStyle;
            configs.MetroStyle = MetroStyle;
            windowBar1.MetroStyle = MetroStyle;
            toolBar1.MetroStyle = MetroStyle;

            labelInfo.Text = "";
        }

        private void InitializeToolBar()
        {
            // Adicione botões à barra de ferramentas (use "-" como separador)
            toolBar1.AddButton("Arquivo", new List<string> { "Novo", "Abrir", "-", "Salvar", "Salvar Como..", "-", "Fechar" }, index =>
            {
                if (index == 0) // Novo
                {
                    if (PerguntarSalvarAntesDeFechar())
                    {
                        LimparLista();
                    }
                }
                else if (index == 1) // Abrir
                {
                    if (PerguntarSalvarAntesDeFechar())
                    {
                        AbrirArquivo();
                    }
                }
                else if (index == 3) // Salvar
                {
                    if (string.IsNullOrEmpty(caminhoArquivoAtual))
                    {
                        SalvarArquivoComo();
                    }
                    else
                    {
                        SalvarArquivo(caminhoArquivoAtual);
                    }
                }
                else if (index == 4) // Salvar Como
                {
                    SalvarArquivoComo();
                }
                else if (index == 6) // Fechar
                {
                    Application.Exit();
                }
            });


            toolBar1.AddButton("Sobre", new List<string> { "Personalizar", "-", "Sobre" }, index =>
            {
                if (index == 0)
                {
                    configs.UpdateUserSettings(MetroTheme, MetroStyle);
                    configs.ShowDialog();
                }
                else if (index == 2)
                {
                    sobre.UpdateUserSettings(MetroTheme, MetroStyle);
                    sobre.ShowDialog();
                }
            });
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
            MinimumSize = new Size(minWidth, minHeight);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            if (Width < minWidth) Width = minWidth;
            if (Height < minHeight) Height = minHeight;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Desabilitar redimensionamento estando maximizado
            this.Resizable = WindowState != FormWindowState.Maximized;
            if (dataGridViewProdutos.Columns.Count >= 5)
            {
                dataGridViewProdutos.Columns[0].Width = dataGridViewProdutos.Width - dataGridViewProdutos.Columns[1].Width - dataGridViewProdutos.Columns[2].Width - dataGridViewProdutos.Columns[3].Width - dataGridViewProdutos.Columns[4].Width - 52;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UltimoArquivo = caminhoArquivoAtual;
            Properties.Settings.Default.Save();
            SaveUserSettings();
            e.Cancel = !PerguntarSalvarAntesDeFechar();
        }

        private static string ObterVersaoDoArquivo()
        {
            FileVersionInfo versaoArquivo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            return versaoArquivo.FileVersion;
        }
        private void btnAdicionar_MouseDown(object sender, MouseEventArgs e)
        {
            // Verifica se o campo de nome está vazio
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("Por favor, insira um nome para o produto.", "Aviso", MessageBoxButtons.OK);
                return; // Não adiciona o produto à lista se o campo de nome estiver vazio
            }

            // Cria um novo produto
            Produto novoProduto = new Produto
            {
                Nome = txtNomeProduto.Text,
                Entrada = DataEntrada.Value,
                Validade = DataValidade.Value,
                Local = txtLocal.Text,
                Preco = txtPreco.Text
            };

            // Adiciona o produto à lista
            listaProdutos.Add(novoProduto);

            // Atualiza o DataGridView
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = listaProdutos;
            dataGridViewProdutos.Refresh();  // Força o redraw

            UpdateGridStyle();
            ListaFoiModificada();

            // Força atualização do CurrencyManager
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridViewProdutos.DataSource];
            cm.Refresh();

            // Define o foco na nova linha adicionada
            int index = dataGridViewProdutos.Rows.Count - 1;
            if (index >= 0 && dataGridViewProdutos.Rows[index].Cells.Count > 0)
            {
                dataGridViewProdutos.CurrentCell = dataGridViewProdutos.Rows[index].Cells[0];
                dataGridViewProdutos.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show("Erro ao selecionar o novo item adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AtualizarGridOrdenadoEFiltrado(string colunaOrdenada)
        {
            // Obtém a lista ordenada
            List<Produto> produtosOrdenados = ordemAscendente ?
                listaProdutos.OrderBy(p => GetPropertyValue(p, colunaOrdenada)).ToList() :
                listaProdutos.OrderByDescending(p => GetPropertyValue(p, colunaOrdenada)).ToList();

            // Filtra a lista ordenada com base no termo de pesquisa
            string termoPesquisaNome = txtProcurarNome.Text.ToLower();
            string termoPesquisaEntrada = txtProcurarEntrada.Text.ToLower();
            string termoPesquisaValidade = txtProcurarValidade.Text.ToLower();
            string termoPesquisaLocal = txtProcurarLocal.Text.ToLower();
            string termoPesquisaPreco = txtProcurarPreco.Text.ToLower();

            List<Produto> produtosFiltrados = produtosOrdenados
                .Where(produto =>
                    produto.Nome.ToLower().Contains(termoPesquisaNome) &&
                    produto.Entrada.ToString("dd/MM/yyyy").ToLower().Contains(termoPesquisaEntrada) &&
                    produto.Validade.ToString("dd/MM/yyyy").ToLower().Contains(termoPesquisaValidade) &&
                    produto.Local.ToLower().Contains(termoPesquisaLocal) &&
                    produto.Preco.ToLower().Contains(termoPesquisaPreco))
                .ToList();

            // Atualiza a fonte de dados da DataGridView
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = produtosFiltrados;
            UpdateGridStyle();
        }

        private void dataGridViewProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewProdutos.Columns.Count)
            {
                string colunaClicada = dataGridViewProdutos.Columns[e.ColumnIndex].HeaderText;

                // Inverte a ordem de classificação se a mesma coluna for clicada
                if (colunaClicada.Equals(colunaOrdenada, StringComparison.OrdinalIgnoreCase))
                    ordemAscendente = !ordemAscendente;
                else
                    ordemAscendente = true;

                colunaOrdenada = colunaClicada;

                // Atualiza a fonte de dados da DataGridView com ordenação e filtragem
                AtualizarGridOrdenadoEFiltrado(colunaOrdenada);
            }
        }



        private object GetPropertyValue(Produto produto, string propertyName)
        {
            // Use reflexão para obter o valor da propriedade da coluna
            var propriedade = typeof(Produto).GetProperty(propertyName);
            return propriedade.GetValue(produto, null);
        }

        private void dataGridViewProdutos_Sorted(object sender, EventArgs e)
        {
            UpdateGridStyle();
        }

        private bool PerguntarSalvarAntesDeFechar()
        {
            if (listaModificada)
            {
                if (listaProdutos.Count > 0 || !string.IsNullOrEmpty(caminhoArquivoAtual))
                {
                    DialogResult resultado = MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        if (string.IsNullOrEmpty(caminhoArquivoAtual))
                        {
                            // Se for um novo arquivo e o usuário clicar em "Cancelar" no diálogo Salvar Como, evita o fechamento
                            if (!SalvarArquivoComo())
                            {
                                return false;
                            }
                        }
                        else
                        {
                            SalvarArquivo(caminhoArquivoAtual);
                        }
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        return false; // Cancelar fechamento do formulário
                    }
                }
            }

            return true; // Se a lista estiver vazia ou se o usuário optar por não salvar, prosseguir com o fechamento
        }

        private void LimparLista()
        {
            listaProdutos.Clear();
            dataGridViewProdutos.DataSource = null;
            caminhoArquivoAtual = null;
            listaModificada = false;
            Properties.Settings.Default.UltimoArquivo = null;
            Properties.Settings.Default.Save();
            UpdateTitle();
            UpdateInfo();
        }

        private void AbrirArquivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Texto|*.txt";
            openFileDialog.Title = "Abrir Arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoAtual = openFileDialog.FileName;
                Properties.Settings.Default.UltimoArquivo = caminhoArquivoAtual;
                Properties.Settings.Default.Save();
                CarregarListaDeArquivo(caminhoArquivoAtual);
            }
        }

        private void SalvarArquivo(string caminho)
        {
            SalvarListaParaArquivo(caminho);
        }

        private bool SalvarArquivoComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos de Texto|*.txt";
            saveFileDialog.Title = "Salvar Como";

            // Defina um nome padrão baseado na data e hora atuais
            string nomePadrao = $"Produtos_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            saveFileDialog.FileName = nomePadrao;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoAtual = saveFileDialog.FileName;
                Properties.Settings.Default.UltimoArquivo = caminhoArquivoAtual;
                Properties.Settings.Default.Save();
                SalvarArquivo(caminhoArquivoAtual);
                return true; // Indica que o usuário selecionou um local de salvamento
            }

            return false; // Indica que o usuário cancelou a operação de salvamento
        }


        private void SalvarListaParaArquivo(string caminhoArquivo)
        {
            try
            {
                // Ordena a lista por validade ascendente antes de salvar
                List<Produto> listaOrdenada = listaProdutos.OrderBy(p => p.Validade).ToList();

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    foreach (Produto produto in listaOrdenada)
                    {
                        // Formata a data para salvar apenas a data (sem a hora)
                        string entradaFormatada = produto.Entrada.ToString("dd/MM/yyyy");
                        string validadeFormatada = produto.Validade.ToString("dd/MM/yyyy");

                        // Salva os dados formatados no arquivo
                        writer.WriteLine($"{produto.Nome}|{entradaFormatada}|{validadeFormatada}|{produto.Local}|{produto.Preco}");
                    }
                }

                // Atualiza a lista do programa com a lista ordenada
                listaProdutos = listaOrdenada;

                //MessageBox.Show("Lista salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaModificada = false;
                UpdateTitle();
                //SeparateUsings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar lista: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeparateUsings()
        {
            string ProjUsings = ListUsings("C:\\_VSFiles\\Projects\\PC Solutions\\Validata");
            string CSProjUsings = ExtractUsingsFromFile("C:\\_VSFiles\\Projects\\PC Solutions\\Validata\\csprojusings.txt");
            string ToRemoveUsings = "C:\\_VSFiles\\Projects\\PC Solutions\\Validata\\csprojusings_toremove.txt";

            // Garante que o arquivo seja criado e fechado corretamente
            if (!File.Exists(ToRemoveUsings))
            {
                using (File.Create(ToRemoveUsings)) { }
            }

            string notUsed = NotUsedUsings(ProjUsings, CSProjUsings);

            if (!string.IsNullOrEmpty(notUsed))
            {
                File.WriteAllText(ToRemoveUsings, $"Remove Usings:\r\n{notUsed}");
            }
            else
            {
                File.WriteAllText(ToRemoveUsings, "Nenhum using para remover.");
            }
        }

        public string ListUsings(string directoryPath)
        {
            HashSet<string> usingsWithEqual = new HashSet<string>();  // Para 'using' com '='
            HashSet<string> usingsSet = new HashSet<string>();  // Para 'using' sem '='

            // Verifica se o diretório existe
            if (Directory.Exists(directoryPath))
            {
                // Obtém todos os arquivos .cs no diretório e subdiretórios
                var csFiles = Directory.GetFiles(directoryPath, "*.cs", SearchOption.AllDirectories);

                foreach (var file in csFiles)
                {
                    // Lê o conteúdo do arquivo
                    var fileContent = File.ReadLines(file);

                    // Filtra as linhas que começam com 'using'
                    foreach (var line in fileContent)
                    {
                        var trimmedLine = line.Trim();

                        if (trimmedLine.StartsWith("using") && !trimmedLine.Contains("("))  // Ignora 'using' de objetos
                        {
                            if (trimmedLine.Contains("="))  // Se contém '=', adiciona à lista separada
                            {
                                usingsWithEqual.Add(trimmedLine);
                            }
                            else  // Caso contrário, adiciona à lista normal
                            {
                                usingsSet.Add(trimmedLine);
                            }
                        }
                    }
                }
            }
            else
            {
                throw new DirectoryNotFoundException("O diretório especificado não foi encontrado.");
            }

            // Ordena ambas as listas e as concatena
            var sortedUsingsWithEqual = usingsWithEqual.OrderBy(u => u).ToList();
            var sortedUsings = usingsSet.OrderBy(u => u).ToList();

            // Junta as listas, com as que têm '=' no início
            var finalUsings = sortedUsingsWithEqual.Concat(sortedUsings).ToList();

            return string.Join(Environment.NewLine, finalUsings);
        }

        public string ExtractUsingsFromFile(string filePath)
        {
            HashSet<string> usingsSet = new HashSet<string>();  // Para garantir que não há duplicatas

            // Verifica se o arquivo existe
            if (File.Exists(filePath))
            {
                // Lê o conteúdo do arquivo
                var fileContent = File.ReadLines(filePath);

                // Expressões regulares para identificar as referências
                string referencePattern = @"<Reference Include=""([^""]+)"" />";
                string packagePattern = @"<PackageReference Include=""([^""]+)""[^>]*>";

                // Processa as linhas do arquivo
                foreach (var line in fileContent)
                {
                    // Verifica se a linha contém uma referência de <Reference> ou <PackageReference>
                    Match referenceMatch = Regex.Match(line, referencePattern);
                    Match packageMatch = Regex.Match(line, packagePattern);

                    if (referenceMatch.Success)
                    {
                        // Adiciona o namespace extraído à lista de usings
                        usingsSet.Add("using " + referenceMatch.Groups[1].Value + ";");
                    }
                    else if (packageMatch.Success)
                    {
                        // Adiciona o pacote extraído à lista de usings
                        usingsSet.Add("using " + packageMatch.Groups[1].Value + ";");
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("O arquivo especificado não foi encontrado.");
            }

            // Ordena e retorna as diretivas 'using' como uma string
            var sortedUsings = usingsSet.OrderBy(u => u).ToList();
            return string.Join(Environment.NewLine, sortedUsings);
        }

        public string NotUsedUsings(string folderUsings, string docUsings)
        {
            // Converte as strings em listas e remove espaços em branco
            var folderList = folderUsings.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(u => u.Trim().Replace("using ", "").Replace(";", ""))
                                         .ToList();

            var docList = docUsings.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(u => u.Trim().Replace("using ", "").Replace(";", ""))
                                   .ToList();

            // Filtra os usings que não estão na lista do folder (considerando hierarquia)
            var notUsed = docList.Where(docUsing =>
                !folderList.Any(folderUsing => docUsing == folderUsing || docUsing.StartsWith(folderUsing + ".")))
                .Distinct()
                .OrderBy(u => u) // Ordena alfabeticamente
                .ToList();

            // Converte de volta para o formato de "using Namespace;"
            return string.Join(Environment.NewLine, notUsed.Select(u => $"using {u};"));
        }

        private void CarregarListaDeArquivo(string caminhoArquivo)
        {
            try
            {
                listaProdutos.Clear(); // Limpa a lista atual antes de carregar novos dados
                /*txtNomeProduto.Clear();
                dateTimePickerValidade.Value = DateTime.Now;
                txtLocal.Clear();
                txtPreco.Clear();*/

                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] dados = linha.Split('|');

                        if (dados.Length == 5)
                        {
                            Produto produto = new Produto
                            {
                                Nome = dados[0],
                                Entrada = DateTime.Parse(dados[1]),
                                Validade = DateTime.Parse(dados[2]),
                                Local = dados[3],
                                Preco = dados[4]
                            };

                            listaProdutos.Add(produto);
                        }
                    }
                }

                dataGridViewProdutos.DataSource = null;
                dataGridViewProdutos.DataSource = listaProdutos;
                UpdateGridStyle();

                //MessageBox.Show("Lista carregada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaModificada = false;
                UpdateTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar lista: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_MouseDown(object sender, MouseEventArgs e)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {

                // Exibe um diálogo de confirmação
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir os produtos selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Lista para armazenar os produtos a serem removidos
                    List<Produto> produtosParaRemover = new List<Produto>();

                    // Itera sobre todas as linhas selecionadas
                    foreach (DataGridViewRow selectedRow in dataGridViewProdutos.SelectedRows)
                    {
                        // Obtém o produto associado à linha selecionada
                        Produto produtoParaRemover = (Produto)selectedRow.DataBoundItem;

                        // Adiciona o produto à lista de produtos a serem removidos
                        produtosParaRemover.Add(produtoParaRemover);
                    }

                    // Remove os produtos da lista
                    foreach (Produto produtoParaRemover in produtosParaRemover)
                    {
                        listaProdutos.Remove(produtoParaRemover);
                    }

                    // Atualiza a exibição do DataGridView
                    dataGridViewProdutos.DataSource = null;
                    dataGridViewProdutos.DataSource = listaProdutos;
                    UpdateGridStyle();
                    ListaFoiModificada();
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma linha para remover.", "Aviso", MessageBoxButtons.OK);
            }
        }


        private void txtProcurarNome_TextChanged(object sender, EventArgs e)
        {

            // Obtém o texto da caixa de pesquisa
            string termoPesquisa = txtProcurarNome.Text.ToLower();

            // Filtra a lista de produtos com base no termo de pesquisa
            List<Produto> produtosFiltrados = listaProdutos
                .Where(produto => produto.Nome.ToLower().Contains(termoPesquisa))
                .ToList();

            // Atualiza o DataGridView com a lista filtrada
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = produtosFiltrados;
            UpdateGridStyle();
        }

        private void txtProcurarEntrada_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto da caixa de pesquisa
            string termoPesquisa = txtProcurarEntrada.Text.ToLower();

            // Filtra a lista de produtos com base no termo de pesquisa
            List<Produto> produtosFiltrados = listaProdutos
                .Where(produto => produto.Entrada.ToString("dd/MM/yyyy").ToLower().Contains(termoPesquisa))
                .ToList();

            // Atualiza o DataGridView com a lista filtrada
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = produtosFiltrados;
            UpdateGridStyle();
        }

        private void txtProcurarValidade_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto da caixa de pesquisa
            string termoPesquisa = txtProcurarValidade.Text.ToLower();

            // Filtra a lista de produtos com base no termo de pesquisa
            List<Produto> produtosFiltrados = listaProdutos
                .Where(produto => produto.Validade.ToString("dd/MM/yyyy").ToLower().Contains(termoPesquisa))
                .ToList();

            // Atualiza o DataGridView com a lista filtrada
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = produtosFiltrados;
            UpdateGridStyle();
        }


        private void txtProcurarLocal_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto da caixa de pesquisa
            string termoPesquisa = txtProcurarLocal.Text.ToLower();

            // Filtra a lista de produtos com base no termo de pesquisa
            List<Produto> produtosFiltrados = listaProdutos
                .Where(produto => produto.Local.ToLower().Contains(termoPesquisa))
                .ToList();

            // Atualiza o DataGridView com a lista filtrada
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = produtosFiltrados;
            UpdateGridStyle();

        }

        private void txtProcurarPreco_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto da caixa de pesquisa
            string termoPesquisa = txtProcurarPreco.Text.ToLower();

            // Filtra a lista de produtos com base no termo de pesquisa
            List<Produto> produtosFiltrados = listaProdutos
                .Where(produto => produto.Preco.ToLower().Contains(termoPesquisa))
                .ToList();

            // Atualiza o DataGridView com a lista filtrada
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource = produtosFiltrados;
            UpdateGridStyle();

        }

        private void ListaFoiModificada()
        {
            listaModificada = true;
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            int selectedItemsCount = dataGridViewProdutos.SelectedRows.Count;
            string salvarInfo = "Você tem alterações não salvas...";

            if (listaModificada)
            {
                labelInfo.Text = $"({selectedItemsCount}) {salvarInfo}";
            }
            else
            {
                labelInfo.Text = $"({selectedItemsCount})";
            }
        }

        private void dataGridViewProdutos_SelectionChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {/* NAO FUNCIONANDO
            // Verificar se Ctrl e S estão pressionados simultaneamente
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Chamar a lógica de salvamento aqui
                if (string.IsNullOrEmpty(caminhoArquivoAtual))
                {
                    SalvarArquivoComo();
                }
                else
                {
                    SalvarArquivo(caminhoArquivoAtual);
                }                // Impedir que o caractere 'S' seja inserido no controle (evita o beep)
                e.SuppressKeyPress = true;
                listaModificada = false;
            }*/
        }

        private void btnClear_MouseDown(object sender, MouseEventArgs e)
        {
            txtProcurarNome.Clear();
            txtProcurarEntrada.Clear();
            txtProcurarValidade.Clear();
            txtProcurarLocal.Clear();
            txtProcurarPreco.Clear();
        }

        private void dataGridViewProdutos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Certifique-se de que a linha está dentro dos limites do DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewProdutos.Rows.Count)
            {
                // Obtém o valor da célula da coluna "Validade" para a linha atual
                DateTime dataValidade = (DateTime)dataGridViewProdutos.Rows[e.RowIndex].Cells["Validade"].Value;

                // Calcula a diferença de dias entre a data de validade e a data atual
                int diasRestantes = (int)(dataValidade - DateTime.Today).TotalDays;

                if (diasRestantes > 20)
                {
                    // Se não estiver dentro desses critérios, restaura a cor padrão
                    dataGridViewProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = ThemeBackColor;
                }
                else if (diasRestantes <= 21 && diasRestantes > 10)
                {
                    // Cor amarela para 15 dias ou mais
                    dataGridViewProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = ExpiringColor15;
                }
                else if (diasRestantes <= 11 && diasRestantes > 0)
                {
                    // Cor laranja para 6 a 14 dias
                    dataGridViewProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = ExpiringColor6;
                }
                else if (diasRestantes <= 0)
                {
                    // Cor vermelha para o dia atual ou dias anteriores
                    dataGridViewProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = ExpiredColor;
                }

            }
        }


        private void UpdateGridStyle()
        {
            dataGridViewProdutos.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewProdutos.Columns[0].Width = dataGridViewProdutos.Width - dataGridViewProdutos.Columns[1].Width - dataGridViewProdutos.Columns[2].Width - dataGridViewProdutos.Columns[3].Width - dataGridViewProdutos.Columns[4].Width - 52;
        }

        private void dataGridViewProdutos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            // Cancela a edição
            view.CancelEdit();

            // Remove a indicação de erro da célula
            view.Rows[e.RowIndex].ErrorText = string.Empty;

            // Altera o título da mensagem
            MessageBox.Show("Valor inválido.", "Aviso", MessageBoxButtons.OK);
        }


        private void dataGridViewProdutos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            valorOriginalCelula = dataGridViewProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dataGridViewProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object novoValor = dataGridViewProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Comparação considerando possíveis valores nulos
            if (!object.Equals(novoValor, valorOriginalCelula))
            {
                ListaFoiModificada();
            }
        }

    }

    public class Produto
    {
        public string Nome { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Validade { get; set; }
        public string Local { get; set; }
        public string Preco { get; set; }
    }

}
