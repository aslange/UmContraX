/*******************************************************
 * Um Contra X Game
 * 
 * Creator: Augusto Lange
 * 
 * Last Change: 29/06/2011
 * Version: 1.02
 *  
 * ****************************************************/
/*****************************************************
 *  Version 1.00:
 *  
 *  Date: 13/06/2011
 * 
 * - Code the Idea;
 * - Form with tabs and options;
 * - Design the protocol for each question and answers;
 * - A file was created for questions and answers named PeR.qaa;
 * - Use Regular Expressions to que questions from the text file.
 * 
 *****************************************************/
/*****************************************************
 *  Version 1.01:
 *  
 *  Date: 23/06/2011
 * 
 * - Rank of Players in a file "PontuaçãoJogadores.plp" and in a new Form, when the user indicates end of Game;
 * - New options for color the game screen;
 * - Songs are played in each final asnwer.
 *
 *****************************************************/
/*****************************************************
 *  Version 1.02:
 *  
 *  Date: 29/06/2011
 * 
 * - New option wich indicate if the music will play or not after each question (make the game faster);
 * - Creation of a config file that make able to restore the last settings.
 *
 *****************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace UmContraX
{
	public partial class frmUmContraX : Form
	{
		private const string APP_VERSION = "1.02";
		private const string QUESTIONS_FILE = "PeR.qaa";
		private const string PICTURE = "Pic.jpg";
		private const string CONFIG_TAB = "Configuração";
		private const String PLAYER_FILENAME = "PontuaçãoJogadores.plp";
		private const String CORRECT_FILENAME = "Correto.wav";
		private const String WRONG_FILENAME = "Errado.wav";

		private static List<Question> lstQuestions;
		private static PlayerRank playerRank;
		private static Question currentQuestion;
		private static String answer;
		private static RadioButton rdbPrevious;
		private static int indxQuestion;
		private static Player plrGamer;
		private static Color rdbForegroundAskColor;
		private static bool firstTime;
		private static bool configured;
		private static Config config;
		private static bool playSound;

		private static Color rdbForegroundAnswerColor;
		private static Color rdbForegroundAnswerSelectedColor;
		private static Color rdbForegroundAnswerCorrectColor;
		private static Color rdbBackgroundAnswerCorrectColor;
		private static Color rdbBackgroundAnswerIncorrectColor;

		private static int tbLastIndex;
		
		public frmUmContraX()
		{
			InitializeComponent();

			playerRank = new PlayerRank();
			config = new Config();

			answer = String.Empty;
			indxQuestion = 0;
			lblPlayerName.Visible = false;
			btnNextQuestion.Enabled = false;
			btnAnswer.Enabled = false;
			firstTime = true;
			configured = false;
			playSound = true;

			tbLastIndex = tbcUmContraX.SelectedIndex;

			DefaultColors();

			this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

			if (File.Exists(PICTURE))
			{
				pbAuthor.Image = new Bitmap(PICTURE);
				Size imgSize = GenerateImageDimensions(pbAuthor.Image.Width, pbAuthor.Image.Height, pbAuthor.Width, pbAuthor.Height);
				Bitmap finalImg = new Bitmap(pbAuthor.Image, imgSize.Width, imgSize.Height);

				Graphics gfx = Graphics.FromImage(pbAuthor.Image);
				gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

				pbAuthor.Image = null;
				pbAuthor.SizeMode = PictureBoxSizeMode.CenterImage;
				pbAuthor.Image = finalImg;
			}
			else
				pbAuthor.Image = null;

			lblAbout.Text = "Jogo clássico de Preguntas e Respostas, onde um jogador concorre contra todos os outros participantes.\n\nCreator:\n   Augusto Lange - Glix The Cowboy\n\n\nVersion " + APP_VERSION + " Copyright © 2011";

			GetPlayers();
			GetConfig();
		}

		private void DefaultColors()
		{
			rdbForegroundAskColor = Color.Black;

			rdbForegroundAnswerColor = Color.Black;
			rdbForegroundAnswerSelectedColor = Color.Red;
			rdbForegroundAnswerCorrectColor = Color.White;
			rdbBackgroundAnswerCorrectColor = Color.Green;
			rdbBackgroundAnswerIncorrectColor = Color.DarkRed;
		}

		private bool SetupGame()
		{
			if (File.Exists(QUESTIONS_FILE))
			{
				lstQuestions = new List<Question>();
				List<String> lstQuestionAnswers = new List<String>();
				Question question;
				MatchCollection ListMatches;
				MatchCollection ListMatchesAlternatives;
				String strFile = File.ReadAllText(QUESTIONS_FILE, Encoding.Default);
				
				String regex = @"%(?<1>[0-9]*?)#(?<2>.*?)#(?<3>.*)@";

				ListMatches = Regex.Matches(strFile, regex, RegexOptions.Multiline);

				regex = "((?<4>&)(?<5>.*?)|(?<5>.*?))\\*";

				if (ListMatches.Count == 0)
					throw new Exception("Este arquivo não está no formato correto das perguntas!");

				for (int i = 0; i < ListMatches.Count; i++)
				{
					question = new Question();

					question.Number = int.Parse(ListMatches[i].Groups["1"].Value);
					question.Quest = ListMatches[i].Groups["2"].Value;
					question.Jogada = false;

					ListMatchesAlternatives = Regex.Matches(ListMatches[i].Groups["3"].Value, regex, RegexOptions.ExplicitCapture);
					lstQuestionAnswers = new List<String>();

					for (int j = 0; j < ListMatchesAlternatives.Count; j++)
					{
						if (ListMatchesAlternatives[j].Groups["4"].Value == "&")
						{
							question.Answer = ListMatchesAlternatives[j].Groups["5"].Value;
						}

						lstQuestionAnswers.Add(ListMatchesAlternatives[j].Groups["5"].Value);
					}

					question.LstAlternatives = lstQuestionAnswers;

					lstQuestions.Add(question);
				}

				return true;
			}

			return false;
		}

		private void ShowQuestion()
		{
			Random rdQuestion = new Random();
			int szAlternativesWd = gbxAlternatives.Size.Width - 100;
			int szAlternativesHt = gbxAlternatives.Size.Height;
			RadioButton rdbAlternative;
			bool nextQuestion = true;
			int count = 0;

			gbxAlternatives.Controls.Clear(); 

			while (nextQuestion)
			{
				indxQuestion = rdQuestion.Next(0, lstQuestions.Count);

				nextQuestion = false;

				if (currentQuestion != null)
				{
					if (currentQuestion.Number == lstQuestions[indxQuestion].Number)
					{
						count = 0;

						foreach (Question qt in lstQuestions)
						{
							if (!qt.Jogada)
							{
								count++;
							}
						}

						if (count == 1)
						{
							MessageBox.Show("Última Pergunta!");
							nextQuestion = false;
						}
						else
						{
							nextQuestion = true;
						}
					}
				}

				if (!lstQuestions[indxQuestion].Jogada)
				{
					if (!nextQuestion)
					{
						currentQuestion = lstQuestions[indxQuestion];

						RealocateQuestion(lstQuestions[indxQuestion].Quest);

						for (int i = 0; i < lstQuestions[indxQuestion].LstAlternatives.Count; i++)
						{
							rdbAlternative = new RadioButton();
							rdbAlternative.Name = "rdbAlternative" + i.ToString();
							rdbAlternative.Font = new Font("Comic Sans MS", 20);
							rdbAlternative.Size = new Size(szAlternativesWd, 50);
							rdbAlternative.Location = new Point(50, ((80 * i) + 30));
							rdbAlternative.Text = (i + 1).ToString() + ") " + lstQuestions[indxQuestion].LstAlternatives[i];
							rdbAlternative.ForeColor = rdbForegroundAnswerColor;
							rdbAlternative.BringToFront();
							rdbAlternative.Visible = true;
							rdbAlternative.CheckedChanged += new EventHandler(rdbAlternative_CheckedChanged);
							gbxAlternatives.Controls.Add(rdbAlternative);
						}

						nextQuestion = false;
					}
				}
				else
				{
					foreach (Question qt in lstQuestions)
					{
						if (!qt.Jogada)
						{
							nextQuestion = true;
						}
					}

					if (!nextQuestion)
					{
						gbxAlternatives.Controls.Clear();
						txtQuestion.Text = "";
						MessageBox.Show("Fim de Jogo, Não existem mais perguntas disponíveis!");
						break;
					}
				}
			}
		}

		private void RealocateQuestion(String question)
		{
			int szQuestionWd = gbxQuestion.Size.Width;
			int szQuestionHt = gbxQuestion.Size.Height;

			int strTam = (question.Length * 40);

			int brkTimes = 0;

			txtQuestion.Font = new Font("Microsoft Sans Serif", 50);

			if (strTam >= szQuestionWd)
			{
				brkTimes = (int)(strTam / szQuestionWd);

				if (brkTimes > 2)
				{
					txtQuestion.Font = new Font("Microsoft Sans Serif", ((int)txtQuestion.Font.SizeInPoints - ((brkTimes - 1) * 5)));
				}
			}

			txtQuestion.Text = question;
		}

		private void PlayerScore()
		{
			plrGamer.Score();
			lblPlayerScore.Text = plrGamer.Points.ToString();
		}

		private void UpdateRanks()
		{
			playerRank.LstPlayerRank.Sort((x, y) => y.Points.CompareTo(x.Points));

			for(int i = 0; i < playerRank.LstPlayerRank.Count; i++)
			{
				playerRank.LstPlayerRank[i].Position = i + 1;
			}
		}

		private void GetPlayers()
		{
			if (File.Exists(PLAYER_FILENAME))
			{
				Serializer serializer = new Serializer();

				playerRank = null;
				playerRank = serializer.DeSerializeObject(PLAYER_FILENAME);
			}
		}

		private void SavePlayers()
		{
			Serializer serializer = new Serializer();

			serializer.SerializeObject(PLAYER_FILENAME, playerRank);
		}

		private void ShowRank()
		{
			String rank = String.Empty;
			int count = 0;
			Rank frmPlayerRank = new Rank();

			frmPlayerRank.Show(this);

			Label lblRank = (Label)frmPlayerRank.Controls.Find("lblRank", true).First();

			rank = "Os 10 Maiores Pontuadores: \n\n";

			if (playerRank.LstPlayerRank.Count > 10)
				count = 10;
			else
				count = playerRank.LstPlayerRank.Count;

			for (int i = 0; i < count; i++)
			{
				rank += "                " + playerRank.LstPlayerRank[i].Position + (i == 9 ? "º - " : "º   - ") + playerRank.LstPlayerRank[i].Name + " - " + playerRank.LstPlayerRank[i].Points + "\n";
			}

			rank += "\nJogador Atual: \n                " + plrGamer.Position + "º   - " + plrGamer.Name + " - " + plrGamer.Points;

			lblRank.Text = rank;
		}

		public void GetConfigChanges()
		{
			List<ConfigItem> lstConfigItemAux = new List<ConfigItem>();

			//Features - CheckBox
			foreach (Control ctrl in gbxConfigFeatureSound.Controls)
			{
				if (ctrl.Name.Contains("cbx"))
				{
					lstConfigItemAux.Add(new ConfigItem(((CheckBox)ctrl).Name, ((CheckBox)ctrl).Checked.ToString()));
				}
			}

			// Colors - Button
			foreach (Control ctrl in gbxConfigColors.Controls)
			{
				if (ctrl.Name.Contains("btn"))
				{
					lstConfigItemAux.Add(new ConfigItem(((Button)ctrl).Name, ((Button)ctrl).BackColor.ToArgb().ToString()));
				}
			}

			config.LstConfigItem = lstConfigItemAux;
		}

		public void GetConfig()
		{
			if (!configured)
			{
				Button btn;
				CheckBox cbx;

				if (config.GetConfig())
				{
					if (config.LstConfigItem != null)
					{
						foreach (ConfigItem ci in config.LstConfigItem)
						{
							switch (ci.Name.Substring(0, 3))
							{
								case "btn":
									btn = (Button)gbxConfigColors.Controls.Find(ci.Name, true).First();
									if (ci.ItemValue != "16777215")
										btn.BackColor = Color.FromArgb(Int32.Parse(ci.ItemValue));
									break;

								case "cbx":
									cbx = (CheckBox)gbxConfigFeatureSound.Controls.Find(ci.Name, true).First();
									cbx.Checked = bool.Parse(ci.ItemValue);
									break;
							}
						}
					}
				}

				configured = true;
			}
		}

		public Size GenerateImageDimensions(int currW, int currH, int destW, int destH)
		{
			double multiplier = 0;
			string layout;

			if (currH > currW)
			{
				layout = "portrait";
			}
			else
			{
				layout = "landscape";
			}

			switch (layout.ToLower())
			{
				case "portrait":
					if (destH > destW)
					{
						multiplier = (double)destW / (double)currW;
					}
					else
					{
						multiplier = (double)destH / (double)currH;
					}
					break;

				case "landscape":
					if (destH > destW)
					{
						multiplier = (double)destW / (double)currW;
					}
					else
					{
						multiplier = (double)destH / (double)currH;
					}
					break;
			}

			return new Size((int)(currW * multiplier), (int)(currH * multiplier));
		}

		private void btnStartEndGame_Click(object sender, EventArgs e)
		{
			if (btnStartEndGame.Text == "Início de Jogo")
			{
				plrGamer = new Player();
				if (txtPlayer.Text != String.Empty)
					plrGamer.Name = txtPlayer.Text;
				else
					plrGamer.Name = "Jogador 1";

				plrGamer.ClearScore();

				lblPlayerScore.Text = "0";

				txtPlayer.Visible = false;

				lblPlayerName.Text = plrGamer.Name;
				lblPlayerName.Visible = true;

				btnStartEndGame.Text = "Fim de Jogo";

				btnNextQuestion.Enabled = true;
				btnAnswer.Enabled = true;

				if (firstTime)
				{
					firstTime = false;
					SetupGame();
				}

				ShowQuestion();
			}
			else if (btnStartEndGame.Text == "Fim de Jogo")
			{
				btnStartEndGame.Text = "Início de Jogo";

				txtPlayer.Text = plrGamer.Name;
				txtPlayer.Visible = true;

				lblPlayerName.Text = plrGamer.Name;
				lblPlayerName.Visible = false;

				btnNextQuestion.Enabled = false;
				btnAnswer.Enabled = false;

				gbxAlternatives.Controls.Clear();
				txtQuestion.Text = "";

				playerRank.LstPlayerRank.Add(plrGamer);

				UpdateRanks();

				SavePlayers();

				ShowRank();
			}
		}

		private void btnAnswer_Click(object sender, EventArgs e)
		{
			foreach (Control ctrl in gbxAlternatives.Controls)
			{
				if (ctrl.GetType() == typeof(RadioButton))
				{
					if (((RadioButton)ctrl).Text.Substring(3) == currentQuestion.Answer)
					{
						if (((RadioButton)ctrl).Checked)
						{
							((RadioButton)ctrl).ForeColor = rdbForegroundAnswerCorrectColor;
							((RadioButton)ctrl).BackColor = rdbBackgroundAnswerCorrectColor;

							PlayerScore();

							if (playSound)
							{
								Sound.Play(CORRECT_FILENAME, PlaySoundFlags.SND_FILENAME);
							}
						}
						else
						{
							((RadioButton)ctrl).BackColor = rdbBackgroundAnswerIncorrectColor;

							if (playSound)
							{
								Sound.Play(WRONG_FILENAME, PlaySoundFlags.SND_FILENAME);
							}
						}

						lstQuestions[indxQuestion].Jogada = true;

						btnAnswer.Enabled = false;

						break;
					}
				}
			}
		}

		private void btnNextQuestion_Click(object sender, EventArgs e)
		{
			ShowQuestion();

			btnAnswer.Enabled = true;
		}

		private void rdbAlternative_CheckedChanged(object sender, EventArgs e)
		{
			if (((RadioButton)sender).Checked)
			{
				if (rdbPrevious != null)
				{
					rdbPrevious.ForeColor = rdbForegroundAnswerColor;
				}

				((RadioButton)sender).ForeColor = rdbForegroundAnswerSelectedColor;

				rdbPrevious = (RadioButton)sender;
			}
		}

		private void btnBackgroundGameColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnBackgroundGameColor.BackColor = cldColors.Color;
			}
		}

		private void btnGroupAskColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnGroupAskColor.BackColor = cldColors.Color;
			}
		}

		private void btnGroupAnswerColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnGroupAnswerColor.BackColor = cldColors.Color;
			}
		}

		private void btnGroupInfo_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnGroupInfo.BackColor = cldColors.Color;
			}
		}

		private void btnGroupControl_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnGroupControl.BackColor = cldColors.Color;
			}
		}

		private void btnForegroundAskColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnForegroundAskColor.BackColor = cldColors.Color;
			}
		}

		private void btnForegroundAnswerColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnForegroundAnswerColor.BackColor = cldColors.Color;
			}
		}

		private void btnForegroundAnswerSelectedColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnForegroundSelectedAnswerColor.BackColor = cldColors.Color;
			}
		}

		private void btnForegroundAnswerCorrectColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnForegroundAnswerCorrectColor.BackColor = cldColors.Color;
			}
		}

		private void btnBackgroundAnswerCorrectColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnBackgroundAnswerCorrectColor.BackColor = cldColors.Color;
			}
		}

		private void btnBackgroundAnswerIncorrectColor_Click(object sender, EventArgs e)
		{
			if (cldColors.ShowDialog() == DialogResult.OK)
			{
				btnBackgroundAnswerIncorrectColor.BackColor = cldColors.Color;
			}
		}

		private void btnBackgroundGameColor_BackColorChanged(object sender, EventArgs e)
		{
			txtQuestion.BackColor = tbGame.BackColor = btnBackgroundGameColor.BackColor;
		}

		private void btnGroupAskColor_BackColorChanged(object sender, EventArgs e)
		{
			gbxQuestion.ForeColor = btnGroupAskColor.BackColor;
		}

		private void btnGroupAnswerColor_BackColorChanged(object sender, EventArgs e)
		{
			gbxAlternatives.ForeColor = btnGroupAnswerColor.BackColor;
		}

		private void btnGroupInfo_BackColorChanged(object sender, EventArgs e)
		{
			gbxInfo.ForeColor = btnGroupInfo.BackColor;
		}

		private void btnGroupControl_BackColorChanged(object sender, EventArgs e)
		{
			gbxControls.ForeColor = btnGroupControl.BackColor;
		}

		private void btnForegroundAskColor_BackColorChanged(object sender, EventArgs e)
		{
			txtQuestion.ForeColor = btnForegroundAskColor.BackColor;
		}

		private void btnForegroundAnswerColor_BackColorChanged(object sender, EventArgs e)
		{
			rdbForegroundAnswerColor = btnForegroundAnswerColor.BackColor;
		}

		private void btnForegroundAnswerSelectedColor_BackColorChanged(object sender, EventArgs e)
		{
			rdbForegroundAnswerSelectedColor = btnForegroundSelectedAnswerColor.BackColor;
		}

		private void btnForegroundAnswerCorrectColor_BackColorChanged(object sender, EventArgs e)
		{
			rdbForegroundAnswerCorrectColor = btnForegroundAnswerCorrectColor.BackColor;
		}

		private void btnBackgroundAnswerCorrectColor_BackColorChanged(object sender, EventArgs e)
		{
			rdbBackgroundAnswerCorrectColor = btnBackgroundAnswerCorrectColor.BackColor;
		}

		private void btnBackgroundAnswerIncorrectColor_BackColorChanged(object sender, EventArgs e)
		{
			rdbBackgroundAnswerIncorrectColor = btnBackgroundAnswerIncorrectColor.BackColor;
		}

		private void tbcUmContraX_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tbcUmContraX.TabPages[tbLastIndex].Text == CONFIG_TAB)
			{
				GetConfigChanges();
				config.SaveConfig();
			}
			else 
			{
				GetConfig();
			}

			tbLastIndex = tbcUmContraX.SelectedIndex;
		}

		private void cbxPlaySoundOnAnswer_CheckedChanged(object sender, EventArgs e)
		{
			playSound = cbxPlaySoundOnAnswer.Checked;
		}
	}
}
