using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypno_Codes_Stuffs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stack<string> CountAwayThoughts(Stack<string> yourThoughts)
        {
            //TODO Remove each thought from the thoughts lst as they are removed from brain
            int secondsBetweenCounting = Convert.ToInt32(Numsecondscount.Value * 1000);
            Stack<string> takenThoughts = new Stack<string>();
            string takenThought;
            if (RBcountdown.Checked == true)
            {
                while (yourThoughts.Count > 0)
                {
                    LByourheadspace.Items.Add(yourThoughts.Count);
                    takenThought = yourThoughts.Pop();
                    LByourheadspace.Items.Add(takenThought + " Has been taken away");
                    takenThoughts.Push(takenThought);
                    Task.Delay(secondsBetweenCounting).Wait();
                };
                LByourheadspace.Items.Add("And all thoughts have been taken from you");
                LByourheadspace.Items.Add(yourThoughts.Count);
                return takenThoughts;
            }
            else
            {
                int amountOfThoughts = yourThoughts.Count;
                LByourheadspace.Items.Add("0");
                Task.Delay(secondsBetweenCounting).Wait();
                for (int i = 1; i < amountOfThoughts; i++)
                {
                    LByourheadspace.Items.Add(i);
                    takenThought = yourThoughts.Pop();
                    LByourheadspace.Items.Add(takenThought + " Has been taken away");
                    takenThoughts.Push(takenThought);
                    Task.Delay(secondsBetweenCounting).Wait();
                }
                LByourheadspace.Items.Add("And all thoughts have been taken from you");
                LByourheadspace.Items.Add(amountOfThoughts++);
                return takenThoughts;
            }
        }

        private Stack<string> ReturnThoughts(Stack<string> takenThoughts)
        {
            //TODO Add each thought to the list of thoughts as it is returned
            int secondsBetweenCounting = Convert.ToInt32(Numsecondscount.Value * 1000);
            Stack<string> returnedThoughts = new Stack<string>();
            string returnedThought;
            if (RBawakenup.Checked)
            {
                LByourheadspace.Items.Add("Your thoughts now returning as I count them back up, upon finishing all your thoughts will have returned");
                int amountOfThoughts = takenThoughts.Count;
                LByourheadspace.Items.Add("0");
                Task.Delay(secondsBetweenCounting).Wait();
                for (int i = 1; i < amountOfThoughts; i++)
                {
                    LByourheadspace.Items.Add(i);
                    returnedThought = takenThoughts.Pop();
                    LByourheadspace.Items.Add(returnedThought + " Has been returned");
                    returnedThoughts.Push(returnedThought);
                    Task.Delay(secondsBetweenCounting).Wait();
                }
                LByourheadspace.Items.Add(amountOfThoughts++);
                LByourheadspace.Items.Add("And all thoughts have been returned back to you");
                return returnedThoughts;
            }
            else if(RBcount10.Checked)
            {
                //TODO Create better Awakener
                LByourheadspace.Items.Add("Your thoughts now returning as I count up to 10, upon when all your thoughts will have returned");
                for (int i = 0; i < 10; i++)
                {
                    LByourheadspace.Items.Add(i);
                    Task.Delay(secondsBetweenCounting).Wait();
                }
                returnedThoughts = takenThoughts;
                return returnedThoughts;
            }
            else
            {
                LByourheadspace.Items.Add("Your thoughts now returning as I count them down, upon finishing all your thoughts will have returned");
                while (takenThoughts.Count > 0)
                {
                    LByourheadspace.Items.Add(takenThoughts.Count);
                    returnedThought = takenThoughts.Pop();
                    LByourheadspace.Items.Add(returnedThought + " Has been Returned");
                    takenThoughts.Push(returnedThought);
                    Task.Delay(secondsBetweenCounting).Wait();
                };
                LByourheadspace.Items.Add("And all thoughts have been returned back to you");
                LByourheadspace.Items.Add(takenThoughts.Count);
                return returnedThoughts;
            }
        }

        private void BTStart_Click(object sender, EventArgs e)
        {
            LByourheadspace.Items.Clear();
            Stack<string> inputThoughts = new Stack<string>();
            int secondsBeforeAwakening = Convert.ToInt32(NumSecondsAwake.Value * 1000);
            foreach (string thought in TBthoughts.Lines)
            {
                inputThoughts.Push(thought);
            }
            Stack<string> takenThoughts = CountAwayThoughts(inputThoughts);
            //TODO Implement Drop with preset "sessions" E.G Relaxation, Lewd, Happy
            Task.Delay(secondsBeforeAwakening).Wait();
            ReturnThoughts(takenThoughts);
        }
    }
}
