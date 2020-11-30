#pragma warning disable CA1815

namespace TimeStruct
{
    public struct Time
    {
        public readonly int Hours
        {
            get => Hours;
            set => Hours = value;
        }

        public readonly int Minutes
        {
            get => Minutes;
            set => Minutes = value;
        }

        public Time(int minutes)
            : this(0, minutes)
        {
        }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public string ToString()
        {
            var h = Hours.ToString("00");
            var m = Minutes.ToString("00");

            return $"{h}:{m}";
        }

        public void Deconstruct(out int hours, out int minutes)
        {
            hours = Hours;
            minutes = Minutes;
        }
    }
}
