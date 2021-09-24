using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UmContraX
{
	class Question
	{
		private String question;
		private String answer;
		private List<String> lstAlternatives;
		private int number;
		private bool jogada;

		public String Quest
		{
			get { return question; }
			set { question = value; }
		}

		public String Answer
		{
			get { return answer; }
			set { answer = value; }
		}

		public List<String> LstAlternatives
		{
			get { return lstAlternatives; }
			set { lstAlternatives = value; }
		}

		public int Number
		{
			get { return number; }
			set { number = value; }
		}

		public bool Jogada
		{
			get { return jogada; }
			set { jogada = value; }
		}
	}
}
