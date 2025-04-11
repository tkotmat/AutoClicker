using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    class ProgramAutoClikers
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x40;

        private bool isClicking = false;
        private long sleep;
        private uint mouseDown;
        private uint mouseUp;

        public event Action OnAutoClickerStopped;

        public void Start(long sleepTime, int mouseButtonIndex, string typeClicker, int sleepDoubleTime,int valueClikers = 0)
        {
            if (isClicking) return;

            sleep = sleepTime;
            GetMouseEventCodes(mouseButtonIndex, out mouseDown, out mouseUp);

            if (sleep > 0 && mouseDown != 0 && mouseUp != 0)
            {
                isClicking = true;

                Task.Run(() =>
                {
                    if (valueClikers > 0)
                    {
                        while (isClicking)
                        {
                            if (typeClicker == "Double")
                            {
                                mouse_event(mouseDown | mouseUp, 0, 0, 0, IntPtr.Zero);
                                Thread.Sleep(sleepDoubleTime);
                                mouse_event(mouseDown | mouseUp, 0, 0, 0, IntPtr.Zero);

                                Thread.Sleep((int)sleep + sleepDoubleTime);
                                valueClikers -= 2;

                                if (valueClikers <= 0)
                                {
                                    Stop();
                                    OnAutoClickerStopped?.Invoke();
                                }
                            }
                            else
                            {
                                mouse_event(mouseDown | mouseUp, 0, 0, 0, IntPtr.Zero);
                                Thread.Sleep((int)sleep);
                                valueClikers--;

                                if (valueClikers <= 0)
                                {
                                    Stop();
                                    OnAutoClickerStopped?.Invoke();
                                }
                            }
                        }
                    }
                    else
                    {
                        while (isClicking)
                        {
                            if (typeClicker == "Double")
                            {
                                mouse_event(mouseDown | mouseUp, 0, 0, 0, IntPtr.Zero);
                                Thread.Sleep(sleepDoubleTime);
                                mouse_event(mouseDown | mouseUp, 0, 0, 0, IntPtr.Zero);

                                Thread.Sleep((int)sleep + sleepDoubleTime);
                            }
                            else
                            {
                                mouse_event(mouseDown | mouseUp, 0, 0, 0, IntPtr.Zero);
                                Thread.Sleep((int)sleep);
                            }
                        }
                        valueClikers = 0;
                    }
                });
            }
            else
            {
                Debug.WriteLine("Incorrect autoclicker parameters.");
            }
        }

        public void Stop()
        {
            isClicking = false;
        }

        private void GetMouseEventCodes(int index, out uint down, out uint up)
        {
            down = 0;
            up = 0;

            switch (index)
            {
                case 0:
                    down = MOUSEEVENTF_LEFTDOWN;
                    up = MOUSEEVENTF_LEFTUP;
                    break;
                case 1: 
                    down = MOUSEEVENTF_RIGHTDOWN;
                    up = MOUSEEVENTF_RIGHTUP;
                    break;
                case 2: 
                    down = MOUSEEVENTF_MIDDLEDOWN;
                    up = MOUSEEVENTF_MIDDLEUP;
                    break;
            }
        }
    }
}
