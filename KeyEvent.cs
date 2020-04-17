using System;
using System.Windows.Forms;

namespace WinKeyRecorder
{
    public class KeyEvent
    {
        public int Action { get; set; }
        public string ActionString { get; set; }
        public long Timestamp { get; set; }
        public Keys Key { get; set; }
        public uint Flag { get; set; }
        public IntPtr KeyIntPtr { get; set; }
    }
}
