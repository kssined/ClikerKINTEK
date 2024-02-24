using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {

        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var khs = (KeyboardHookStruct)
                          Marshal.PtrToStructure(lParam,
                          typeof(KeyboardHookStruct));
                if (Convert.ToInt32("" + wParam) == 256)
                {
                    if ((int)khs.VirtualKeyCode == 123)//F12
                    {
                        ButtonStop.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 113)//F2
                    {
                        ButtonStart.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 114)//F3
                    {
                        ButtonPickLoc.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                }
            }
            return CallNextHookEx(m_hHook, nCode, wParam, lParam);
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }
        private delegate IntPtr LowLevelKeyboardProcDelegate(
            int nCode, IntPtr wParam, IntPtr lParam);

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                m_callback,
                GetModuleHandle(IntPtr.Zero), 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }

        //хуки для мышки
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //Нормированные абсолютные координаты
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //Нажатие на левую кнопку мыши
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //Поднятие левой кнопки мыши
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        //Нажатие на правой кнопку мыши
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //Поднятие правой кнопки мыши
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //перемещение указателя мыши
        private const int MOUSEEVENTF_MOVE = 0x0001;
        //Для определение курсора 
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        static protected long totalPixels = 0;
        static protected int diffx;
        static protected int diffy;

        static public bool _isStart = false;


        public AutoClicker()
        {
            InitializeComponent();
            SetHook();
            this.Focus();
        }

        //Функция для определения курсора
        private void button1_Click(object sender, EventArgs e)
        {


            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            TextBoxForX.Text = defPnt.X.ToString();
            TextBoxForY.Text = defPnt.Y.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxForMins_TextChanged(object sender, EventArgs e)
        {

        }

        //закрыть окно
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Свернуть окно
        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            _isStart = false;
            TextBoxForMins.Text = "0";
            TextBoxForSecs.Text = "0";
            TextBoxForX.Text = "0";
            TextBoxForY.Text = "0";
        }

        private void TextBoxForMins_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

       async private void ButtonStart_Click(object sender, EventArgs e)
        {
            _isStart = true;
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int x = 65535/ resolution.Width * Convert.ToInt32(TextBoxForX.Text);
            int Y = 65535 / resolution.Height * Convert.ToInt32(TextBoxForY.Text);

            while(_isStart)
            {
                if(ButtonLeft.Checked == true && ButtonOne.Checked == true)
                {
                    //Перемещаем мышку на заданные координаты
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, Y, 0, 0);
                    //Нажимае на левую кнопку мышки 2 раза
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN |MOUSEEVENTF_LEFTUP, x, Y, 0, 0);
                    
                }
                 if (ButtonLeft.Checked == true && ButtonDouble.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, Y, 0, 0);
                }
                if (ButtonRight.Checked == true && ButtonOne.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, Y, 0, 0);
                }
                if (ButtonRight.Checked == true && ButtonDouble.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x,Y,0, 0);
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, Y, 0, 0);
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, Y, 0, 0);
                }
                await Task.Delay(60000 * Convert.ToInt32(TextBoxForMins.Text)+ 1000*Convert.ToInt32(TextBoxForSecs.Text));
                
            }
        }
    }
}
