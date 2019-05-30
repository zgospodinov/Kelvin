using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Kelvin
{
    public partial class Form1 : Form
    {
        private enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);

        [DllImport("gdi32.dll")]
        private static extern bool GetDeviceGammaRamp(IntPtr hDC, [Out] short[] lpRamp);

        private static bool initialized = false;
        private static Int32 hdc;
        private static int a;
        private GlobalHotkey ghkAdd;
        private GlobalHotkey ghkSubtract;
        private GlobalHotkey ghkRedAdd;
        private GlobalHotkey ghkRedSubtract;

        public int curBrightness { get; set; } = 200;
        private static int _maxLimit = 350;
        private static int _lowerLimit = 5;
        private static double[] _gammas = { 1, 1, 1 };
        //private static double[] _gammas = { 255, 51, 0 };
        private static int _step = 5;
        private static int _stepRed = 35;

        private static int _kelvinTemperature = 4500;
        private static int _kelvinMinimum = 1000;
        private static int _kelvinMaximum = 6500;

        public Form1()
        {
            InitializeComponent();

            trackBarBrightness.Minimum = _lowerLimit;
            trackBarBrightness.Maximum = _maxLimit;
            trackBarBrightness.Value = curBrightness;

            trackBar1.Value = _kelvinTemperature;

            ghkAdd = new GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.Add, this);
            ghkSubtract = new GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.Subtract, this);

            ghkRedAdd = new GlobalHotkey(Constants.CTRL + Constants.ALT, Keys.Add, this);
            ghkRedSubtract = new GlobalHotkey(Constants.CTRL + Constants.ALT, Keys.Subtract, this);

        }
        private static void InitializeClass()
        {
            if (initialized)
            {
                return;
            }

            var hdcTest = Graphics.FromHwnd(IntPtr.Zero);
            hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();
            initialized = true;
        }
        public static unsafe bool SetBrightness(int brightness)
        {
            InitializeClass();
            if (brightness > _maxLimit)
            {
                brightness = _maxLimit;
            }

            if (brightness < _lowerLimit)
            {
                brightness = _lowerLimit;
            }

            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;

            if (brightness < _lowerLimit)
            {
                brightness = _lowerLimit;
            }

            double brightness2 = (double)brightness / _maxLimit;

            {

            }
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    //int arrayVal = i * (brightness + 128);
                    double arrayVal = (Math.Pow(i / 256.0, 1.0 / _gammas[j]) * 65535) + 0.5;
                    arrayVal *= brightness2;
                    if (arrayVal > 65535)
                    {
                        arrayVal = 65535;
                    }

                    if (arrayVal < 0)
                    {
                        arrayVal = 0;
                    }

                    *idx = (short)arrayVal;
                    idx++;
                }
            }
            bool retVal = SetDeviceGammaRamp(hdc, gArray);
            return retVal;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //a = trackBar1.Value;
            //SetBrightness(a);
        }

        private void HandleHotkey(Message m)
        {
            Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
            int modifier = ((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
            int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.

            //MessageBox.Show(modifier.ToString());

            if (modifier == (Constants.ALT + Constants.SHIFT) && key == Keys.Add)
            {
                curBrightness += _step;
                if (curBrightness > _maxLimit)
                {
                    curBrightness = _maxLimit;
                }
            }

            if (modifier == (Constants.ALT + Constants.SHIFT) && key == Keys.Subtract)
            {
                curBrightness -= _step;
                if (curBrightness < _lowerLimit)
                {
                    curBrightness = _lowerLimit;
                }
            }

            if (modifier == (Constants.CTRL + Constants.ALT) && key == Keys.Add)
            {
                AdjustBlue(_stepRed, AdjustOperation.Add, InvokeType.Hotkey);
            }

            if (modifier == (Constants.CTRL + Constants.ALT) && key == Keys.Subtract)
            {
                AdjustBlue(_stepRed, AdjustOperation.Subtract, InvokeType.Hotkey);
            }

            trackBarBrightness.Value = curBrightness;

            //trackBar1.Value = _kelvinTemperature;

            SetBrightness(curBrightness);
        }

        private void AdjustBlue(int step, AdjustOperation operation, InvokeType invoke)
        {
            RGB rgb = new RGB();
            switch (invoke)
            {
                case InvokeType.Slider:
                    break;
                case InvokeType.Hotkey:
                    {
                        switch (operation)
                        {
                            case AdjustOperation.Add:
                                {
                                    _kelvinTemperature += _stepRed;
                                    if (_kelvinTemperature > _kelvinMaximum)
                                    {
                                        _kelvinTemperature = _kelvinMaximum;
                                        //MessageBox.Show(trackBar1.Value.ToString());
                                    }
                                }
                                break;
                            case AdjustOperation.Subtract:
                                {
                                    _kelvinTemperature -= _stepRed;
                                    if (_kelvinTemperature < _kelvinMinimum)
                                    {
                                        _kelvinTemperature = _kelvinMinimum;
                                        //MessageBox.Show(trackBar1.Value.ToString());
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        lblCurrentKelvin.Text = $"{_kelvinTemperature}K";
                        trackBar1.Value = _kelvinTemperature;
                    }
                    break;
                default:
                    break;
            }

            rgb = KelvinTemperature.KelvinToRGB(_kelvinTemperature);
            _gammas[0] = rgb.Red / 255;
            _gammas[1] = rgb.Green / 255;
            _gammas[2] = rgb.Blue / 255;
        }

        private enum AdjustOperation
        {
            Add,
            Subtract
        }

        private enum InvokeType
        {
            Slider,
            Hotkey
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                HandleHotkey(m);
            }

            base.WndProc(ref m);
        }

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            //WriteLine("Trying to register SHIFT+ALT+ +");

            ghkAdd.Register();
            ghkSubtract.Register();
            ghkRedAdd.Register();
            ghkRedSubtract.Register();

            SetFormLocation();

            //if (ghkAdd.Register())
            //    WriteLine("Hotkey registered.");
            //else
            //    WriteLine("Hotkey failed to register");

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AdjustBlue(_stepRed, AdjustOperation.Add, InvokeType.Slider);
            SetBrightness(curBrightness);

            //presetsToolStripMenuItem.DropDown.Items gkkhlk
            presetsToolStripMenuItem.Click += PresetsToolStripMenuItem_Click;

        }

        private void PresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.DropDown.Items.OfType<ToolStripMenuItem>().Cast<ToolStripMenuItem>().ToList().ForEach(toolStripMenuItem => toolStripMenuItem.Click += ToolStripMenuItem_Click);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem dropDownItem = (ToolStripMenuItem)sender;
            _kelvinTemperature = int.Parse((string)dropDownItem.Tag);
            AdjustBlue(_stepRed, AdjustOperation.Add, InvokeType.Slider);
            SyncTrackBars();
            SetBrightness(curBrightness);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void SetFormLocation()
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            // use 'Screen.AllScreens[1].WorkingArea' for secondary screen
            Left = workingArea.Left + workingArea.Width - Size.Width * 2;
            Top = workingArea.Top + workingArea.Height - Size.Height * 7;

            WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKeys(new List<GlobalHotkey>() { ghkAdd, ghkSubtract, ghkRedAdd, ghkRedSubtract });
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnregisterHotKeys(new List<GlobalHotkey>() { ghkAdd, ghkSubtract, ghkRedAdd, ghkRedSubtract });

            Close();
        }
        #endregion

        private void WriteLine(string text)
        {
            //textBox1.Text += text + Environment.NewLine;
            textBox1.Text = $"Brightness: {text}";
        }

        private void GetCurrentBirghtness()
        {
            ManagementScope scope;
            SelectQuery query;

            scope = new ManagementScope("root\\WMI");
            query = new SelectQuery("SELECT * FROM WmiMonitorBrightness");

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        //Console.WriteLine(mObj.ClassPath);
                        foreach (var item in mObj.Properties)
                        {
                            //Console.WriteLine(item.Name + " " + item.Value.ToString());
                            if (item.Name == "CurrentBrightness")
                            {

                                //MessageBox.Show(item.Value.GetType().ToString());
                                curBrightness = int.Parse(item.Value.ToString());
                                //Do something with CurrentBrightness
                                //MessageBox.Show("Test");
                            }

                            if (item.Name == "CurrentContrast")
                            {
                                //MessageBox.Show("Test");
                            }
                        }
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblCurrentKelvin.Text = $"{trackBar1.Value}K";

            _kelvinTemperature = trackBar1.Value;
            AdjustBlue(_stepRed, AdjustOperation.Add, InvokeType.Slider);
            SetBrightness(curBrightness);
        }

        private void UnregisterHotKeys(List<GlobalHotkey> hotkeys)
        {
            hotkeys.ForEach(k => k.Unregiser());
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            curBrightness = trackBarBrightness.Value;
            SetBrightness(curBrightness);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvents = (MouseEventArgs)e;

            switch (mouseEvents.Button)
            {
                case MouseButtons.Left:
                    {
                        if (WindowState == FormWindowState.Normal)
                        {
                            Hide();
                            WindowState = FormWindowState.Minimized;
                        }
                        else
                        {
                            Show();
                            Activate();
                            WindowState = FormWindowState.Normal;
                        }
                    }
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    {
                        contextMenuStrip1.Show();
                    }
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"1. {Keys.Alt}+{Keys.Shift}/+  - Increase Brightness");
            info.AppendLine($"2. {Keys.Alt}+{Keys.Shift}/-  - Decrease Brightness");
            info.AppendLine($"3. {Keys.Control}+{Keys.Alt}/+  - Increase blue light");
            info.AppendLine($"4. {Keys.Control}+{Keys.Alt}/-  - Reduce blue light");

            MessageBox.Show(info.ToString(), "Global hotkeys");
        }

        private void overcastSkype6500KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPresetTemperature(sender);
        }

        private void SyncTrackBars()
        {
            trackBar1.Value = _kelvinTemperature;
            lblCurrentKelvin.Text = $"{_kelvinTemperature}K";
            trackBarBrightness.Value = curBrightness;
        }

        private void SetPresetTemperature(object sender)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            _kelvinTemperature = int.Parse(item.Tag.ToString());
            SyncTrackBars();
            AdjustBlue(_stepRed, AdjustOperation.Add, InvokeType.Slider);
            SetBrightness(curBrightness);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Kelvin - a free screen brightness and blue light adjustment tool");
            info.AppendLine($"Version: {ProductVersion}");

            info.AppendLine();
            info.AppendLine($"Resources and know-how:");
            info.AppendLine($"Screen brightness: http://www.florisdriessen.nl/programming/c-sharp-how-to-change-the-color-gamma-and-brightness/");
            info.AppendLine($"Set global hotkeys: https://www.daniweb.com/programming/software-development/threads/330813/how-to-implement-global-hotkeys-in-c");
            info.AppendLine($"Convert Kelvin to RGB: http://www.tannerhelland.com/4435/convert-temperature-rgb-algorithm-code/");
            info.AppendLine($"What is the best Color temperature: https://iristech.co/what-is-the-best-color-temperature/");

            //https://csharp.hotexamples.com/de/examples/-/GammaRamp/-/php-gammaramp-class-examples.html

            info.AppendLine();
            info.AppendLine();
            info.AppendLine($"Developed by ZGROUND");
            info.AppendLine($"License: MIT");

            var dialog = MessageBox.Show(info.ToString(), "About");

        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            infoToolStripMenuItem_Click(sender, e);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }
    }
}
