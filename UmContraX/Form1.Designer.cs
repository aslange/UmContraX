namespace UmContraX
{
	partial class frmUmContraX
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
			this.tbcUmContraX = new System.Windows.Forms.TabControl();
			this.tbGame = new System.Windows.Forms.TabPage();
			this.gbxAlternatives = new System.Windows.Forms.GroupBox();
			this.gbxControls = new System.Windows.Forms.GroupBox();
			this.btnStartEndGame = new System.Windows.Forms.Button();
			this.btnNextQuestion = new System.Windows.Forms.Button();
			this.btnAnswer = new System.Windows.Forms.Button();
			this.gbxInfo = new System.Windows.Forms.GroupBox();
			this.txtPlayer = new System.Windows.Forms.TextBox();
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.lblPlayerScore = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblPlayer = new System.Windows.Forms.Label();
			this.gbxQuestion = new System.Windows.Forms.GroupBox();
			this.txtQuestion = new System.Windows.Forms.TextBox();
			this.tbConfig = new System.Windows.Forms.TabPage();
			this.gbxConfig = new System.Windows.Forms.GroupBox();
			this.gbxConfigFeatures = new System.Windows.Forms.GroupBox();
			this.gbxConfigFeatureSound = new System.Windows.Forms.GroupBox();
			this.cbxPlaySoundOnAnswer = new System.Windows.Forms.CheckBox();
			this.gbxConfigColors = new System.Windows.Forms.GroupBox();
			this.btnBackgroundAnswerIncorrectColor = new System.Windows.Forms.Button();
			this.lblForegroundAnswerIncorrectColor = new System.Windows.Forms.Label();
			this.btnBackgroundAnswerCorrectColor = new System.Windows.Forms.Button();
			this.lblBackgroundAnswerCorrectColor = new System.Windows.Forms.Label();
			this.btnForegroundAskColor = new System.Windows.Forms.Button();
			this.btnGroupControl = new System.Windows.Forms.Button();
			this.lblForegroundAskColor = new System.Windows.Forms.Label();
			this.lblGroupControl = new System.Windows.Forms.Label();
			this.btnForegroundSelectedAnswerColor = new System.Windows.Forms.Button();
			this.btnForegroundAnswerCorrectColor = new System.Windows.Forms.Button();
			this.btnForegroundAnswerColor = new System.Windows.Forms.Button();
			this.lblForegroundAnswerCorrectColor = new System.Windows.Forms.Label();
			this.lblForegroundSelectedAnswerColor = new System.Windows.Forms.Label();
			this.lblForegroundAnswerColor = new System.Windows.Forms.Label();
			this.btnGroupInfo = new System.Windows.Forms.Button();
			this.btnGroupAskColor = new System.Windows.Forms.Button();
			this.btnGroupAnswerColor = new System.Windows.Forms.Button();
			this.btnBackgroundGameColor = new System.Windows.Forms.Button();
			this.lblGroupInfo = new System.Windows.Forms.Label();
			this.lblGroupAnswerColor = new System.Windows.Forms.Label();
			this.lblGroupAskColor = new System.Windows.Forms.Label();
			this.lblBackgroundGameColor = new System.Windows.Forms.Label();
			this.tbAbout = new System.Windows.Forms.TabPage();
			this.gbxAbout = new System.Windows.Forms.GroupBox();
			this.pbAuthor = new System.Windows.Forms.PictureBox();
			this.lblAbout = new System.Windows.Forms.Label();
			this.cldColors = new System.Windows.Forms.ColorDialog();
			this.tbcUmContraX.SuspendLayout();
			this.tbGame.SuspendLayout();
			this.gbxControls.SuspendLayout();
			this.gbxInfo.SuspendLayout();
			this.gbxQuestion.SuspendLayout();
			this.tbConfig.SuspendLayout();
			this.gbxConfig.SuspendLayout();
			this.gbxConfigFeatures.SuspendLayout();
			this.gbxConfigFeatureSound.SuspendLayout();
			this.gbxConfigColors.SuspendLayout();
			this.tbAbout.SuspendLayout();
			this.gbxAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).BeginInit();
			this.SuspendLayout();
			// 
			// tbcUmContraX
			// 
			this.tbcUmContraX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbcUmContraX.Controls.Add(this.tbGame);
			this.tbcUmContraX.Controls.Add(this.tbConfig);
			this.tbcUmContraX.Controls.Add(this.tbAbout);
			this.tbcUmContraX.Location = new System.Drawing.Point(0, 0);
			this.tbcUmContraX.Name = "tbcUmContraX";
			this.tbcUmContraX.SelectedIndex = 0;
			this.tbcUmContraX.Size = new System.Drawing.Size(1173, 466);
			this.tbcUmContraX.TabIndex = 0;
			this.tbcUmContraX.SelectedIndexChanged += new System.EventHandler(this.tbcUmContraX_SelectedIndexChanged);
			// 
			// tbGame
			// 
			this.tbGame.Controls.Add(this.gbxAlternatives);
			this.tbGame.Controls.Add(this.gbxControls);
			this.tbGame.Controls.Add(this.gbxInfo);
			this.tbGame.Controls.Add(this.gbxQuestion);
			this.tbGame.Location = new System.Drawing.Point(4, 22);
			this.tbGame.Name = "tbGame";
			this.tbGame.Padding = new System.Windows.Forms.Padding(3);
			this.tbGame.Size = new System.Drawing.Size(1165, 440);
			this.tbGame.TabIndex = 0;
			this.tbGame.Text = "Jogo";
			this.tbGame.UseVisualStyleBackColor = true;
			// 
			// gbxAlternatives
			// 
			this.gbxAlternatives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxAlternatives.Location = new System.Drawing.Point(8, 283);
			this.gbxAlternatives.Name = "gbxAlternatives";
			this.gbxAlternatives.Size = new System.Drawing.Size(945, 149);
			this.gbxAlternatives.TabIndex = 3;
			this.gbxAlternatives.TabStop = false;
			this.gbxAlternatives.Text = "Alternativas";
			// 
			// gbxControls
			// 
			this.gbxControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxControls.Controls.Add(this.btnStartEndGame);
			this.gbxControls.Controls.Add(this.btnNextQuestion);
			this.gbxControls.Controls.Add(this.btnAnswer);
			this.gbxControls.Location = new System.Drawing.Point(960, 283);
			this.gbxControls.Name = "gbxControls";
			this.gbxControls.Size = new System.Drawing.Size(197, 149);
			this.gbxControls.TabIndex = 2;
			this.gbxControls.TabStop = false;
			this.gbxControls.Text = "Controle";
			// 
			// btnStartEndGame
			// 
			this.btnStartEndGame.Location = new System.Drawing.Point(6, 28);
			this.btnStartEndGame.Name = "btnStartEndGame";
			this.btnStartEndGame.Size = new System.Drawing.Size(75, 51);
			this.btnStartEndGame.TabIndex = 2;
			this.btnStartEndGame.Text = "Início de Jogo";
			this.btnStartEndGame.UseVisualStyleBackColor = true;
			this.btnStartEndGame.Click += new System.EventHandler(this.btnStartEndGame_Click);
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.Location = new System.Drawing.Point(87, 28);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(104, 115);
			this.btnNextQuestion.TabIndex = 1;
			this.btnNextQuestion.Text = "Próxima Pergunta";
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
			// 
			// btnAnswer
			// 
			this.btnAnswer.Location = new System.Drawing.Point(6, 92);
			this.btnAnswer.Name = "btnAnswer";
			this.btnAnswer.Size = new System.Drawing.Size(75, 51);
			this.btnAnswer.TabIndex = 0;
			this.btnAnswer.Text = "Resposta";
			this.btnAnswer.UseVisualStyleBackColor = true;
			this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// gbxInfo
			// 
			this.gbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxInfo.Controls.Add(this.txtPlayer);
			this.gbxInfo.Controls.Add(this.lblPlayerName);
			this.gbxInfo.Controls.Add(this.lblPlayerScore);
			this.gbxInfo.Controls.Add(this.lblScore);
			this.gbxInfo.Controls.Add(this.lblPlayer);
			this.gbxInfo.Location = new System.Drawing.Point(960, 7);
			this.gbxInfo.Name = "gbxInfo";
			this.gbxInfo.Size = new System.Drawing.Size(197, 270);
			this.gbxInfo.TabIndex = 1;
			this.gbxInfo.TabStop = false;
			this.gbxInfo.Text = "Informações";
			// 
			// txtPlayer
			// 
			this.txtPlayer.Location = new System.Drawing.Point(87, 17);
			this.txtPlayer.MaxLength = 15;
			this.txtPlayer.Name = "txtPlayer";
			this.txtPlayer.Size = new System.Drawing.Size(100, 20);
			this.txtPlayer.TabIndex = 4;
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Location = new System.Drawing.Point(84, 20);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(45, 13);
			this.lblPlayerName.TabIndex = 3;
			this.lblPlayerName.Text = "Player 1";
			// 
			// lblPlayerScore
			// 
			this.lblPlayerScore.AutoSize = true;
			this.lblPlayerScore.Location = new System.Drawing.Point(84, 87);
			this.lblPlayerScore.Name = "lblPlayerScore";
			this.lblPlayerScore.Size = new System.Drawing.Size(13, 13);
			this.lblPlayerScore.TabIndex = 2;
			this.lblPlayerScore.Text = "0";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(7, 87);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(62, 13);
			this.lblScore.TabIndex = 1;
			this.lblScore.Text = "Pontuação:";
			// 
			// lblPlayer
			// 
			this.lblPlayer.AutoSize = true;
			this.lblPlayer.Location = new System.Drawing.Point(7, 20);
			this.lblPlayer.Name = "lblPlayer";
			this.lblPlayer.Size = new System.Drawing.Size(48, 13);
			this.lblPlayer.TabIndex = 0;
			this.lblPlayer.Text = "Jogador:";
			// 
			// gbxQuestion
			// 
			this.gbxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxQuestion.AutoSize = true;
			this.gbxQuestion.Controls.Add(this.txtQuestion);
			this.gbxQuestion.Location = new System.Drawing.Point(7, 7);
			this.gbxQuestion.Name = "gbxQuestion";
			this.gbxQuestion.Size = new System.Drawing.Size(946, 271);
			this.gbxQuestion.TabIndex = 0;
			this.gbxQuestion.TabStop = false;
			this.gbxQuestion.Text = "Pergunta";
			// 
			// txtQuestion
			// 
			this.txtQuestion.BackColor = System.Drawing.SystemColors.Window;
			this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtQuestion.Location = new System.Drawing.Point(7, 20);
			this.txtQuestion.MaxLength = 500;
			this.txtQuestion.Multiline = true;
			this.txtQuestion.Name = "txtQuestion";
			this.txtQuestion.ReadOnly = true;
			this.txtQuestion.Size = new System.Drawing.Size(929, 232);
			this.txtQuestion.TabIndex = 0;
			this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbConfig
			// 
			this.tbConfig.Controls.Add(this.gbxConfig);
			this.tbConfig.Location = new System.Drawing.Point(4, 22);
			this.tbConfig.Name = "tbConfig";
			this.tbConfig.Padding = new System.Windows.Forms.Padding(3);
			this.tbConfig.Size = new System.Drawing.Size(1165, 440);
			this.tbConfig.TabIndex = 1;
			this.tbConfig.Text = "Configuração";
			this.tbConfig.UseVisualStyleBackColor = true;
			// 
			// gbxConfig
			// 
			this.gbxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxConfig.Controls.Add(this.gbxConfigFeatures);
			this.gbxConfig.Controls.Add(this.gbxConfigColors);
			this.gbxConfig.Location = new System.Drawing.Point(8, 6);
			this.gbxConfig.Name = "gbxConfig";
			this.gbxConfig.Size = new System.Drawing.Size(1148, 428);
			this.gbxConfig.TabIndex = 1;
			this.gbxConfig.TabStop = false;
			this.gbxConfig.Text = "Configurações";
			// 
			// gbxConfigFeatures
			// 
			this.gbxConfigFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxConfigFeatures.AutoSize = true;
			this.gbxConfigFeatures.Controls.Add(this.gbxConfigFeatureSound);
			this.gbxConfigFeatures.Location = new System.Drawing.Point(7, 10);
			this.gbxConfigFeatures.Name = "gbxConfigFeatures";
			this.gbxConfigFeatures.Size = new System.Drawing.Size(679, 218);
			this.gbxConfigFeatures.TabIndex = 2;
			this.gbxConfigFeatures.TabStop = false;
			this.gbxConfigFeatures.Text = "Funcionalidades";
			// 
			// gbxConfigFeatureSound
			// 
			this.gbxConfigFeatureSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxConfigFeatureSound.Controls.Add(this.cbxPlaySoundOnAnswer);
			this.gbxConfigFeatureSound.Location = new System.Drawing.Point(473, 9);
			this.gbxConfigFeatureSound.Name = "gbxConfigFeatureSound";
			this.gbxConfigFeatureSound.Size = new System.Drawing.Size(200, 95);
			this.gbxConfigFeatureSound.TabIndex = 1;
			this.gbxConfigFeatureSound.TabStop = false;
			this.gbxConfigFeatureSound.Text = "Sons";
			// 
			// cbxPlaySoundOnAnswer
			// 
			this.cbxPlaySoundOnAnswer.AutoSize = true;
			this.cbxPlaySoundOnAnswer.Checked = true;
			this.cbxPlaySoundOnAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxPlaySoundOnAnswer.Location = new System.Drawing.Point(6, 19);
			this.cbxPlaySoundOnAnswer.Name = "cbxPlaySoundOnAnswer";
			this.cbxPlaySoundOnAnswer.Size = new System.Drawing.Size(194, 17);
			this.cbxPlaySoundOnAnswer.TabIndex = 0;
			this.cbxPlaySoundOnAnswer.Text = "Tocar Som ao Responder Pergunta";
			this.cbxPlaySoundOnAnswer.UseVisualStyleBackColor = true;
			this.cbxPlaySoundOnAnswer.CheckedChanged += new System.EventHandler(this.cbxPlaySoundOnAnswer_CheckedChanged);
			// 
			// gbxConfigColors
			// 
			this.gbxConfigColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxConfigColors.Controls.Add(this.btnBackgroundAnswerIncorrectColor);
			this.gbxConfigColors.Controls.Add(this.lblForegroundAnswerIncorrectColor);
			this.gbxConfigColors.Controls.Add(this.btnBackgroundAnswerCorrectColor);
			this.gbxConfigColors.Controls.Add(this.lblBackgroundAnswerCorrectColor);
			this.gbxConfigColors.Controls.Add(this.btnForegroundAskColor);
			this.gbxConfigColors.Controls.Add(this.btnGroupControl);
			this.gbxConfigColors.Controls.Add(this.lblForegroundAskColor);
			this.gbxConfigColors.Controls.Add(this.lblGroupControl);
			this.gbxConfigColors.Controls.Add(this.btnForegroundSelectedAnswerColor);
			this.gbxConfigColors.Controls.Add(this.btnForegroundAnswerCorrectColor);
			this.gbxConfigColors.Controls.Add(this.btnForegroundAnswerColor);
			this.gbxConfigColors.Controls.Add(this.lblForegroundAnswerCorrectColor);
			this.gbxConfigColors.Controls.Add(this.lblForegroundSelectedAnswerColor);
			this.gbxConfigColors.Controls.Add(this.lblForegroundAnswerColor);
			this.gbxConfigColors.Controls.Add(this.btnGroupInfo);
			this.gbxConfigColors.Controls.Add(this.btnGroupAskColor);
			this.gbxConfigColors.Controls.Add(this.btnGroupAnswerColor);
			this.gbxConfigColors.Controls.Add(this.btnBackgroundGameColor);
			this.gbxConfigColors.Controls.Add(this.lblGroupInfo);
			this.gbxConfigColors.Controls.Add(this.lblGroupAnswerColor);
			this.gbxConfigColors.Controls.Add(this.lblGroupAskColor);
			this.gbxConfigColors.Controls.Add(this.lblBackgroundGameColor);
			this.gbxConfigColors.Location = new System.Drawing.Point(692, 10);
			this.gbxConfigColors.Name = "gbxConfigColors";
			this.gbxConfigColors.Size = new System.Drawing.Size(450, 218);
			this.gbxConfigColors.TabIndex = 1;
			this.gbxConfigColors.TabStop = false;
			this.gbxConfigColors.Text = "Cores da Aba Jogo";
			// 
			// btnBackgroundAnswerIncorrectColor
			// 
			this.btnBackgroundAnswerIncorrectColor.Location = new System.Drawing.Point(402, 152);
			this.btnBackgroundAnswerIncorrectColor.Name = "btnBackgroundAnswerIncorrectColor";
			this.btnBackgroundAnswerIncorrectColor.Size = new System.Drawing.Size(23, 23);
			this.btnBackgroundAnswerIncorrectColor.TabIndex = 21;
			this.btnBackgroundAnswerIncorrectColor.UseVisualStyleBackColor = true;
			this.btnBackgroundAnswerIncorrectColor.BackColorChanged += new System.EventHandler(this.btnBackgroundAnswerIncorrectColor_BackColorChanged);
			this.btnBackgroundAnswerIncorrectColor.Click += new System.EventHandler(this.btnBackgroundAnswerIncorrectColor_Click);
			// 
			// lblForegroundAnswerIncorrectColor
			// 
			this.lblForegroundAnswerIncorrectColor.AutoSize = true;
			this.lblForegroundAnswerIncorrectColor.Location = new System.Drawing.Point(230, 157);
			this.lblForegroundAnswerIncorrectColor.Name = "lblForegroundAnswerIncorrectColor";
			this.lblForegroundAnswerIncorrectColor.Size = new System.Drawing.Size(158, 13);
			this.lblForegroundAnswerIncorrectColor.TabIndex = 20;
			this.lblForegroundAnswerIncorrectColor.Text = "Cor Resposta Incorreta (Fundo):";
			// 
			// btnBackgroundAnswerCorrectColor
			// 
			this.btnBackgroundAnswerCorrectColor.Location = new System.Drawing.Point(402, 119);
			this.btnBackgroundAnswerCorrectColor.Name = "btnBackgroundAnswerCorrectColor";
			this.btnBackgroundAnswerCorrectColor.Size = new System.Drawing.Size(23, 23);
			this.btnBackgroundAnswerCorrectColor.TabIndex = 19;
			this.btnBackgroundAnswerCorrectColor.UseVisualStyleBackColor = true;
			this.btnBackgroundAnswerCorrectColor.BackColorChanged += new System.EventHandler(this.btnBackgroundAnswerCorrectColor_BackColorChanged);
			this.btnBackgroundAnswerCorrectColor.Click += new System.EventHandler(this.btnBackgroundAnswerCorrectColor_Click);
			// 
			// lblBackgroundAnswerCorrectColor
			// 
			this.lblBackgroundAnswerCorrectColor.AutoSize = true;
			this.lblBackgroundAnswerCorrectColor.Location = new System.Drawing.Point(230, 124);
			this.lblBackgroundAnswerCorrectColor.Name = "lblBackgroundAnswerCorrectColor";
			this.lblBackgroundAnswerCorrectColor.Size = new System.Drawing.Size(150, 13);
			this.lblBackgroundAnswerCorrectColor.TabIndex = 18;
			this.lblBackgroundAnswerCorrectColor.Text = "Cor Resposta Correta (Fundo):";
			// 
			// btnForegroundAskColor
			// 
			this.btnForegroundAskColor.Location = new System.Drawing.Point(179, 185);
			this.btnForegroundAskColor.Name = "btnForegroundAskColor";
			this.btnForegroundAskColor.Size = new System.Drawing.Size(23, 23);
			this.btnForegroundAskColor.TabIndex = 17;
			this.btnForegroundAskColor.UseVisualStyleBackColor = true;
			this.btnForegroundAskColor.BackColorChanged += new System.EventHandler(this.btnForegroundAskColor_BackColorChanged);
			this.btnForegroundAskColor.Click += new System.EventHandler(this.btnForegroundAskColor_Click);
			// 
			// btnGroupControl
			// 
			this.btnGroupControl.Location = new System.Drawing.Point(179, 152);
			this.btnGroupControl.Name = "btnGroupControl";
			this.btnGroupControl.Size = new System.Drawing.Size(23, 23);
			this.btnGroupControl.TabIndex = 16;
			this.btnGroupControl.UseVisualStyleBackColor = true;
			this.btnGroupControl.BackColorChanged += new System.EventHandler(this.btnGroupControl_BackColorChanged);
			this.btnGroupControl.Click += new System.EventHandler(this.btnGroupControl_Click);
			// 
			// lblForegroundAskColor
			// 
			this.lblForegroundAskColor.AutoSize = true;
			this.lblForegroundAskColor.Location = new System.Drawing.Point(7, 190);
			this.lblForegroundAskColor.Name = "lblForegroundAskColor";
			this.lblForegroundAskColor.Size = new System.Drawing.Size(149, 13);
			this.lblForegroundAskColor.TabIndex = 15;
			this.lblForegroundAskColor.Text = "Cor das Letras das Perguntas:";
			// 
			// lblGroupControl
			// 
			this.lblGroupControl.AutoSize = true;
			this.lblGroupControl.Location = new System.Drawing.Point(7, 157);
			this.lblGroupControl.Name = "lblGroupControl";
			this.lblGroupControl.Size = new System.Drawing.Size(115, 13);
			this.lblGroupControl.TabIndex = 14;
			this.lblGroupControl.Text = "Cor do Grupo Controle:";
			// 
			// btnForegroundSelectedAnswerColor
			// 
			this.btnForegroundSelectedAnswerColor.Location = new System.Drawing.Point(402, 53);
			this.btnForegroundSelectedAnswerColor.Name = "btnForegroundSelectedAnswerColor";
			this.btnForegroundSelectedAnswerColor.Size = new System.Drawing.Size(23, 23);
			this.btnForegroundSelectedAnswerColor.TabIndex = 13;
			this.btnForegroundSelectedAnswerColor.UseVisualStyleBackColor = true;
			this.btnForegroundSelectedAnswerColor.BackColorChanged += new System.EventHandler(this.btnForegroundAnswerSelectedColor_BackColorChanged);
			this.btnForegroundSelectedAnswerColor.Click += new System.EventHandler(this.btnForegroundAnswerSelectedColor_Click);
			// 
			// btnForegroundAnswerCorrectColor
			// 
			this.btnForegroundAnswerCorrectColor.Location = new System.Drawing.Point(402, 86);
			this.btnForegroundAnswerCorrectColor.Name = "btnForegroundAnswerCorrectColor";
			this.btnForegroundAnswerCorrectColor.Size = new System.Drawing.Size(23, 23);
			this.btnForegroundAnswerCorrectColor.TabIndex = 12;
			this.btnForegroundAnswerCorrectColor.UseVisualStyleBackColor = true;
			this.btnForegroundAnswerCorrectColor.BackColorChanged += new System.EventHandler(this.btnForegroundAnswerCorrectColor_BackColorChanged);
			this.btnForegroundAnswerCorrectColor.Click += new System.EventHandler(this.btnForegroundAnswerCorrectColor_Click);
			// 
			// btnForegroundAnswerColor
			// 
			this.btnForegroundAnswerColor.Location = new System.Drawing.Point(402, 20);
			this.btnForegroundAnswerColor.Name = "btnForegroundAnswerColor";
			this.btnForegroundAnswerColor.Size = new System.Drawing.Size(23, 23);
			this.btnForegroundAnswerColor.TabIndex = 11;
			this.btnForegroundAnswerColor.UseVisualStyleBackColor = true;
			this.btnForegroundAnswerColor.BackColorChanged += new System.EventHandler(this.btnForegroundAnswerColor_BackColorChanged);
			this.btnForegroundAnswerColor.Click += new System.EventHandler(this.btnForegroundAnswerColor_Click);
			// 
			// lblForegroundAnswerCorrectColor
			// 
			this.lblForegroundAnswerCorrectColor.AutoSize = true;
			this.lblForegroundAnswerCorrectColor.Location = new System.Drawing.Point(230, 91);
			this.lblForegroundAnswerCorrectColor.Name = "lblForegroundAnswerCorrectColor";
			this.lblForegroundAnswerCorrectColor.Size = new System.Drawing.Size(144, 13);
			this.lblForegroundAnswerCorrectColor.TabIndex = 10;
			this.lblForegroundAnswerCorrectColor.Text = "Cor Resposta Correta (Letra):";
			// 
			// lblForegroundSelectedAnswerColor
			// 
			this.lblForegroundSelectedAnswerColor.AutoSize = true;
			this.lblForegroundSelectedAnswerColor.Location = new System.Drawing.Point(230, 58);
			this.lblForegroundSelectedAnswerColor.Name = "lblForegroundSelectedAnswerColor";
			this.lblForegroundSelectedAnswerColor.Size = new System.Drawing.Size(169, 13);
			this.lblForegroundSelectedAnswerColor.TabIndex = 9;
			this.lblForegroundSelectedAnswerColor.Text = "Cor Resposta Selecionada: (Letra)";
			// 
			// lblForegroundAnswerColor
			// 
			this.lblForegroundAnswerColor.AutoSize = true;
			this.lblForegroundAnswerColor.Location = new System.Drawing.Point(230, 25);
			this.lblForegroundAnswerColor.Name = "lblForegroundAnswerColor";
			this.lblForegroundAnswerColor.Size = new System.Drawing.Size(99, 13);
			this.lblForegroundAnswerColor.TabIndex = 8;
			this.lblForegroundAnswerColor.Text = "Cor das Respostas:";
			// 
			// btnGroupInfo
			// 
			this.btnGroupInfo.Location = new System.Drawing.Point(179, 119);
			this.btnGroupInfo.Name = "btnGroupInfo";
			this.btnGroupInfo.Size = new System.Drawing.Size(23, 23);
			this.btnGroupInfo.TabIndex = 7;
			this.btnGroupInfo.UseVisualStyleBackColor = true;
			this.btnGroupInfo.BackColorChanged += new System.EventHandler(this.btnGroupInfo_BackColorChanged);
			this.btnGroupInfo.Click += new System.EventHandler(this.btnGroupInfo_Click);
			// 
			// btnGroupAskColor
			// 
			this.btnGroupAskColor.Location = new System.Drawing.Point(179, 53);
			this.btnGroupAskColor.Name = "btnGroupAskColor";
			this.btnGroupAskColor.Size = new System.Drawing.Size(23, 23);
			this.btnGroupAskColor.TabIndex = 6;
			this.btnGroupAskColor.UseVisualStyleBackColor = true;
			this.btnGroupAskColor.BackColorChanged += new System.EventHandler(this.btnGroupAskColor_BackColorChanged);
			this.btnGroupAskColor.Click += new System.EventHandler(this.btnGroupAskColor_Click);
			// 
			// btnGroupAnswerColor
			// 
			this.btnGroupAnswerColor.Location = new System.Drawing.Point(179, 86);
			this.btnGroupAnswerColor.Name = "btnGroupAnswerColor";
			this.btnGroupAnswerColor.Size = new System.Drawing.Size(23, 23);
			this.btnGroupAnswerColor.TabIndex = 5;
			this.btnGroupAnswerColor.UseVisualStyleBackColor = true;
			this.btnGroupAnswerColor.BackColorChanged += new System.EventHandler(this.btnGroupAnswerColor_BackColorChanged);
			this.btnGroupAnswerColor.Click += new System.EventHandler(this.btnGroupAnswerColor_Click);
			// 
			// btnBackgroundGameColor
			// 
			this.btnBackgroundGameColor.Location = new System.Drawing.Point(179, 20);
			this.btnBackgroundGameColor.Name = "btnBackgroundGameColor";
			this.btnBackgroundGameColor.Size = new System.Drawing.Size(23, 23);
			this.btnBackgroundGameColor.TabIndex = 4;
			this.btnBackgroundGameColor.UseVisualStyleBackColor = true;
			this.btnBackgroundGameColor.BackColorChanged += new System.EventHandler(this.btnBackgroundGameColor_BackColorChanged);
			this.btnBackgroundGameColor.Click += new System.EventHandler(this.btnBackgroundGameColor_Click);
			// 
			// lblGroupInfo
			// 
			this.lblGroupInfo.AutoSize = true;
			this.lblGroupInfo.Location = new System.Drawing.Point(7, 124);
			this.lblGroupInfo.Name = "lblGroupInfo";
			this.lblGroupInfo.Size = new System.Drawing.Size(134, 13);
			this.lblGroupInfo.TabIndex = 3;
			this.lblGroupInfo.Text = "Cor do Grupo Informações:";
			// 
			// lblGroupAnswerColor
			// 
			this.lblGroupAnswerColor.AutoSize = true;
			this.lblGroupAnswerColor.Location = new System.Drawing.Point(7, 91);
			this.lblGroupAnswerColor.Name = "lblGroupAnswerColor";
			this.lblGroupAnswerColor.Size = new System.Drawing.Size(124, 13);
			this.lblGroupAnswerColor.TabIndex = 2;
			this.lblGroupAnswerColor.Text = "Cor do Grupo Perguntas:";
			// 
			// lblGroupAskColor
			// 
			this.lblGroupAskColor.AutoSize = true;
			this.lblGroupAskColor.Location = new System.Drawing.Point(7, 58);
			this.lblGroupAskColor.Name = "lblGroupAskColor";
			this.lblGroupAskColor.Size = new System.Drawing.Size(124, 13);
			this.lblGroupAskColor.TabIndex = 1;
			this.lblGroupAskColor.Text = "Cor do Grupo Perguntas:";
			// 
			// lblBackgroundGameColor
			// 
			this.lblBackgroundGameColor.AutoSize = true;
			this.lblBackgroundGameColor.Location = new System.Drawing.Point(7, 25);
			this.lblBackgroundGameColor.Name = "lblBackgroundGameColor";
			this.lblBackgroundGameColor.Size = new System.Drawing.Size(137, 13);
			this.lblBackgroundGameColor.TabIndex = 0;
			this.lblBackgroundGameColor.Text = "Cor do Fundo da Aba Jogo:";
			// 
			// tbAbout
			// 
			this.tbAbout.Controls.Add(this.gbxAbout);
			this.tbAbout.Location = new System.Drawing.Point(4, 22);
			this.tbAbout.Name = "tbAbout";
			this.tbAbout.Size = new System.Drawing.Size(1165, 440);
			this.tbAbout.TabIndex = 2;
			this.tbAbout.Text = "Sobre";
			this.tbAbout.UseVisualStyleBackColor = true;
			// 
			// gbxAbout
			// 
			this.gbxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbxAbout.Controls.Add(this.pbAuthor);
			this.gbxAbout.Controls.Add(this.lblAbout);
			this.gbxAbout.Location = new System.Drawing.Point(9, 4);
			this.gbxAbout.Name = "gbxAbout";
			this.gbxAbout.Size = new System.Drawing.Size(1148, 428);
			this.gbxAbout.TabIndex = 0;
			this.gbxAbout.TabStop = false;
			this.gbxAbout.Text = "Sobre";
			// 
			// pbAuthor
			// 
			this.pbAuthor.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbAuthor.Location = new System.Drawing.Point(599, 16);
			this.pbAuthor.Name = "pbAuthor";
			this.pbAuthor.Size = new System.Drawing.Size(546, 409);
			this.pbAuthor.TabIndex = 1;
			this.pbAuthor.TabStop = false;
			// 
			// lblAbout
			// 
			this.lblAbout.AutoSize = true;
			this.lblAbout.Location = new System.Drawing.Point(7, 20);
			this.lblAbout.Name = "lblAbout";
			this.lblAbout.Size = new System.Drawing.Size(0, 13);
			this.lblAbout.TabIndex = 0;
			// 
			// frmUmContraX
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 466);
			this.Controls.Add(this.tbcUmContraX);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmUmContraX";
			this.Text = "Um Contra X";
			this.tbcUmContraX.ResumeLayout(false);
			this.tbGame.ResumeLayout(false);
			this.tbGame.PerformLayout();
			this.gbxControls.ResumeLayout(false);
			this.gbxInfo.ResumeLayout(false);
			this.gbxInfo.PerformLayout();
			this.gbxQuestion.ResumeLayout(false);
			this.gbxQuestion.PerformLayout();
			this.tbConfig.ResumeLayout(false);
			this.gbxConfig.ResumeLayout(false);
			this.gbxConfig.PerformLayout();
			this.gbxConfigFeatures.ResumeLayout(false);
			this.gbxConfigFeatureSound.ResumeLayout(false);
			this.gbxConfigFeatureSound.PerformLayout();
			this.gbxConfigColors.ResumeLayout(false);
			this.gbxConfigColors.PerformLayout();
			this.tbAbout.ResumeLayout(false);
			this.gbxAbout.ResumeLayout(false);
			this.gbxAbout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbcUmContraX;
		private System.Windows.Forms.TabPage tbGame;
		private System.Windows.Forms.GroupBox gbxAlternatives;
		private System.Windows.Forms.GroupBox gbxControls;
		private System.Windows.Forms.Button btnStartEndGame;
		private System.Windows.Forms.Button btnNextQuestion;
		private System.Windows.Forms.Button btnAnswer;
		private System.Windows.Forms.GroupBox gbxInfo;
		private System.Windows.Forms.Label lblPlayerName;
		private System.Windows.Forms.Label lblPlayerScore;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.GroupBox gbxQuestion;
		private System.Windows.Forms.TabPage tbConfig;
		private System.Windows.Forms.TabPage tbAbout;
		private System.Windows.Forms.GroupBox gbxAbout;
		private System.Windows.Forms.PictureBox pbAuthor;
		private System.Windows.Forms.Label lblAbout;
		private System.Windows.Forms.TextBox txtPlayer;
		private System.Windows.Forms.TextBox txtQuestion;
		private System.Windows.Forms.GroupBox gbxConfig;
		private System.Windows.Forms.GroupBox gbxConfigColors;
		private System.Windows.Forms.Label lblGroupAnswerColor;
		private System.Windows.Forms.Label lblGroupAskColor;
		private System.Windows.Forms.Label lblBackgroundGameColor;
		private System.Windows.Forms.Label lblGroupInfo;
		private System.Windows.Forms.ColorDialog cldColors;
		private System.Windows.Forms.Button btnGroupInfo;
		private System.Windows.Forms.Button btnGroupAskColor;
		private System.Windows.Forms.Button btnGroupAnswerColor;
		private System.Windows.Forms.Button btnBackgroundGameColor;
		private System.Windows.Forms.Button btnForegroundSelectedAnswerColor;
		private System.Windows.Forms.Button btnForegroundAnswerCorrectColor;
		private System.Windows.Forms.Button btnForegroundAnswerColor;
		private System.Windows.Forms.Label lblForegroundAnswerCorrectColor;
		private System.Windows.Forms.Label lblForegroundSelectedAnswerColor;
		private System.Windows.Forms.Label lblForegroundAnswerColor;
		private System.Windows.Forms.Button btnBackgroundAnswerIncorrectColor;
		private System.Windows.Forms.Label lblForegroundAnswerIncorrectColor;
		private System.Windows.Forms.Button btnBackgroundAnswerCorrectColor;
		private System.Windows.Forms.Label lblBackgroundAnswerCorrectColor;
		private System.Windows.Forms.Button btnForegroundAskColor;
		private System.Windows.Forms.Button btnGroupControl;
		private System.Windows.Forms.Label lblForegroundAskColor;
		private System.Windows.Forms.Label lblGroupControl;
		private System.Windows.Forms.GroupBox gbxConfigFeatures;
		private System.Windows.Forms.GroupBox gbxConfigFeatureSound;
		private System.Windows.Forms.CheckBox cbxPlaySoundOnAnswer;
	}
}

