using System.Diagnostics;

namespace AutoClicker
{
    class UserStartAutoClilker
    {
        private ProgramAutoClikers programAutoClikers = new ProgramAutoClikers();
        private bool isClickerRunning = true;
        private MainForm form;

        public UserStartAutoClilker(MainForm mainForm)
        {
            form = mainForm;
            programAutoClikers.OnAutoClickerStopped += () =>
            {
                if (form.InvokeRequired)
                {
                    form.Invoke(new Action(BlockStopButton));
                    isClickerRunning = true;
                }
                else
                {
                    isClickerRunning = true;
                    BlockStopButton();
                }
            };
        }

        private void ProgramAutoClikers_OnUserClickStop() => BlockStopButton();

        public void ToggleAutoClicker()
        {
            if (isClickerRunning)
            {
                StartClicker();
            }
            else
            {
                StopClicker();
            }
        }

        public void StartClicker()
        {
            long sleep = HanlderSleep();
            bool isRepeatNotStopper = form.isRepeatUnitStopper.Checked;
            bool isRepeatTimer = form.isRepeat.Checked;
            string typeClicker = form.typeClickerBox.Text;
            int boxSleep = Convert.ToInt32(form.doubleClickDelay.Text);

            if (sleep != 0)
            {
                int mouseButtonIndex = form.mouseButton.SelectedIndex;

                if (isRepeatNotStopper)
                {
                    if (boxSleep == 0 && typeClicker == "Double")
                    {
                        MessageBox.Show("Enter a double click delay of the recommender of at least 10");
                        return;
                    }
                    programAutoClikers.Start(sleep, mouseButtonIndex, typeClicker, boxSleep);
                    BlockStartButton();
                }
                else if (isRepeatTimer)
                {
                    int value = Convert.ToInt32(form.valueClickers.Text);

                    if (value == 0)
                    {
                        MessageBox.Show("Enter the number of clicks");
                        return;
                    }
                    if (boxSleep == 0 && typeClicker == "Double")
                    {
                        MessageBox.Show("Enter a double click delay of the recommender of at least 10");
                        return;
                    }

                    programAutoClikers.Start(sleep, mouseButtonIndex, typeClicker, boxSleep, value);
                    BlockStartButton();
                }
                isClickerRunning = false;
            }
            else
            {
                MessageBox.Show("You have not specified the AutoClicker time");
            }
        }

        public void StopClicker()
        {
            programAutoClikers.Stop();
            isClickerRunning = true;
            BlockStopButton();
        }

        private long HanlderSleep()
        {
            return (Convert.ToInt32(form.hoursTextBox.Text) * 3600000L) +
                   (Convert.ToInt32(form.minsTextBox.Text) * 60000L) +
                   (Convert.ToInt32(form.secondsTextBox.Text) * 1000L) +
                   Convert.ToInt32(form.millisecendsTextBox.Text);
        }

        private void BlockStartButton()
        {
            form.startButton.Enabled = false;
            form.stopButton.Enabled = true;
        }

        private void BlockStopButton()
        {
            form.startButton.Enabled = true;
            form.stopButton.Enabled = false;
        }
    }
}
