using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private UserStartAutoClilker autoClicker;
        private int selectedHotkeyClicker;

        private const int HOTKEY_ID = 1;
        private const int MOD_NOREPEAT = 0x4000;
        private const int VK_F6 = 0x75;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();
            TextBox[] arrayTextBox = new TextBox[] { hoursTextBox, minsTextBox, secondsTextBox, millisecendsTextBox, valueClickers, doubleClickDelay } ;
            foreach (TextBox? textBox in arrayTextBox)
            {
                textBox.KeyPress += TextBox_KeyPress;
                textBox.TextChanged += TextBox_TextChanged;

            }

            autoClicker = new UserStartAutoClilker(this);
            selectedHotkeyClicker = VK_F6;
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NOREPEAT, selectedHotkeyClicker);
            startClilkerButton.Text = ((Keys)selectedHotkeyClicker).ToString();
            stopButton.Enabled = false;
            isRepeatUnitStopper.Checked = true;
        }
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x0312 && message.WParam.ToInt32() == HOTKEY_ID)
            {
                autoClicker.ToggleAutoClicker();
            }
            base.WndProc(ref message);
        }

        private void StartButton_Click(object sender, EventArgs e) => autoClicker.StartClicker();
        private void StopButton_Click(object sender, EventArgs e) => autoClicker.StopClicker();

        private void RegisterHotkeyUser(int key)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NOREPEAT, key);
        }
        private void startClilkerButton_KeyDown(object sender, KeyEventArgs eventArgs)
        {
            selectedHotkeyClicker = eventArgs.KeyValue;
            startClilkerButton.Text = eventArgs.KeyCode.ToString();
            RegisterHotkeyUser(selectedHotkeyClicker);
            eventArgs.SuppressKeyPress = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs eventArgsParametr)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(eventArgsParametr);
        }

        private void typeClickerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeClickerBox.SelectedIndex == 1)
            {
                doubleClickDelayText.Visible = true;
                doubleClickDelay.Visible = true;
            }
            else if (typeClickerBox.SelectedIndex == 0)
            {
                doubleClickDelayText.Visible = false;
                doubleClickDelay.Visible = false;
            }
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "0";
                }
                else if (int.TryParse(textBox.Text, out int value))
                {
                    if (value < 0) textBox.Text = "0";
                }
            }
        }
    }
}
