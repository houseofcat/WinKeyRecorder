using static WinKeyRecorder.InputStructs;

namespace WinKeyRecorder
{
    public class KeyInputSequence
    {
        public long FrameTimestamp { get; set; }
        public INPUT[] InputSequence { get; set; }
        public string KeySequence { get; set; }
    }
}
