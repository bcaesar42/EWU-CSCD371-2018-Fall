namespace Assignment6
{
    public struct Time
    {
        public byte Hour { get; }
        public byte Minute { get; }
        public byte Second { get; }

        public Time(byte hour, byte minute, byte second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
    }
}
