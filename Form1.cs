namespace WinFormsAppGameMillioner
{
    public partial class Form1 : Form
    {
        private int currentQuestionIndex = 0;
        private List<Question> questions;
        private bool isPhoneFriendUsed = false;
        private Label labelQuestion;
        private Button buttonAnswer1;
        private Button buttonAnswer2;
        private Button buttonAnswer3;
        private Button buttonAnswer4;

        private Button buttonPhoneFriend;
        private object currentQuestion;

        public Form1()
        {
            InitializeQuestions();
            InitializeUI();
            DisplayQuestion();
        }

        private void InitializeUI()
        {
            buttonAnswer = new Button();
            labelQuestion = new Label
            {
                Text = "",
                Dock = DockStyle.Top,
                AutoSize = true
            };

            buttonAnswer1 = new Button
            {
                Text = "",
                Dock = DockStyle.Top,
                AutoSize = true,


            };
            buttonAnswer1.Click += (sender, e) => CheckAnswer(1);

            buttonAnswer2 = new Button
            {
                Text = "",
                Dock = DockStyle.Top,
                AutoSize = true,

            };
            buttonAnswer2.Click += (sender, e) => CheckAnswer(2);

            buttonAnswer3 = new Button
            {
                Text = "",
                Dock = DockStyle.Top,
                AutoSize = true,

            };
            buttonAnswer3.Click += (sender, e) => CheckAnswer(3);

            buttonAnswer4 = new Button
            {
                Text = "",
                Dock = DockStyle.Top,
                AutoSize = true,
            };
            buttonAnswer4.Click += (sender, e) => CheckAnswer(4);

            buttonPhoneFriend = new Button
            {
                Text = "Звонок другу",
                Dock = DockStyle.Top,
                AutoSize = true,
            };
            buttonPhoneFriend.Click += (sender, e) => buttonPhoneFriend_Click(sender, e);

            Controls.Add(buttonPhoneFriend);
            Controls.Add(buttonAnswer4);
            Controls.Add(buttonAnswer3);
            Controls.Add(buttonAnswer2);
            Controls.Add(buttonAnswer1);
            Controls.Add(labelQuestion);
        }
        private void InitializeQuestions()
        {
            questions = new List<Question>
            {
               new Question("Вопрос 1:Какая из планет Солнечной системы самая горячая?", new[] { "Ответ 1:Меркурий", "Ответ 2:Венера", "Ответ 3:Марс", "Ответ 4:Уран" }, 2),
               new Question("Вопрос 2:Из какого цветка получают шафран — одну из самых дорогих пряностей?", new[] { "Ответ 1:Шафран посевной", "Ответ 2:Шафран пряный", "Ответ 3:Крокус", "Ответ 4:Шафран пахучий" }, 1),

            };
        }
        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                labelQuestion.Text = currentQuestion.Text;

                buttonAnswer1.Text = currentQuestion.Answers[0];
                buttonAnswer2.Text = currentQuestion.Answers[1];
                buttonAnswer3.Text = currentQuestion.Answers[2];
                buttonAnswer4.Text = currentQuestion.Answers[3];
            }
            else
            {
                MessageBox.Show("Вы выиграли миллион!");

            }
        }

        private void CheckAnswer(int chosenAnswer)
        {
            Question currentQuestion = questions[currentQuestionIndex];

            if (chosenAnswer == currentQuestion.CorrectAnswer)
            {
                MessageBox.Show("Верно!");
                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Неверно! Игра окончена.");

            }
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(4);
        }
        private void buttonPhoneFriend_Click(object sender, EventArgs e)
        {
            if (!isPhoneFriendUsed)
            {
                string friendResponse = GetFriendResponse();
                PhoneFriendForm phoneFriendForm = new PhoneFriendForm(friendResponse);
                phoneFriendForm.ShowDialog();
                isPhoneFriendUsed = true;
            }
            else
            {
                MessageBox.Show("Вы уже использовали подсказку \"Звонок другу\".");
            }
        }


        private string GetFriendResponse()
        {

            return "Я думаю, правильный ответ - 2.";
        }
    }


}