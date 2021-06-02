using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Magic_8_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> questions = new List<string>();
        public int ms = 4000;

        public MainWindow()
        {
            InitializeComponent();
            questions.Add("It is Certain.");
            questions.Add("It is decidedly so.");
            questions.Add("Without a doubt.");
            questions.Add("Yes definitely.");
            questions.Add("You may rely on it.");
            questions.Add("As i see it, yes.");
            questions.Add("Most likely.");
            questions.Add("Outlook good.");
            questions.Add("Yes.");
            questions.Add("Signs point to yes.");
            questions.Add("Reply hazy, try again.");
            questions.Add("Ask again later.");
            questions.Add("Better not tell you now.");
            questions.Add("Cannot predict now.");
            questions.Add("Concentrate and ask again.");
            questions.Add("Don't count on it.");
            questions.Add("My reply is no.");
            questions.Add("My sources say no.");
            questions.Add("Outlook not so good.");
            questions.Add("Very doubtful.");

        }

        private void qBoxTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= qBoxTxt_GotFocus;
        }

        private void askBtn_Click(object sender, RoutedEventArgs e)
        {
            thinkBox.Text = "Thinking...";
            Thread.Sleep(ms);
            thinkBox.Text = "";
            Random r = new Random();
            int answ = r.Next(0, 19);
            magicAnswerTxt.Text = questions[answ];
        }

        private void clrBtn_Click(object sender, RoutedEventArgs e)
        {
            qBoxTxt.Text = "";
            thinkBox.Text = "";
            magicAnswerTxt.Text = "";
        }

        private void agnBtn_Click(object sender, RoutedEventArgs e)
        {
            thinkBox.Text = "Thinking...";
            Thread.Sleep(ms);
            thinkBox.Text = "";
            Random r = new Random();
            int answ = r.Next(0, 19);
            magicAnswerTxt.Text = questions[answ];
        }

        private void quitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
