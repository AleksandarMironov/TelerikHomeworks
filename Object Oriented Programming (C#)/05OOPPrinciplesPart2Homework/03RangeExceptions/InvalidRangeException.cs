using System;

namespace _03RangeExceptions
{
    public class InvalidRangeException<T> : ArgumentException where T : IComparable<T>
    {
        private T start;
        private T end;
        private string msg;


        public InvalidRangeException(string msg, T start, T end) : base("Invalid range exception! : " + msg + $" Range: {start} - {end}")
        {
            this.Start = start;
            this.End = end;
            this.Msg = msg;
        }

        public InvalidRangeException(string msg, T start, T end, Exception innerEx) : base("Invalid range exception! : " + msg + $" Range: {start} - {end}", innerEx)
        {
            this.Start = start;
            this.End = end;
            this.Msg = msg;

        }

        public T Start
        {
            get
            {
                return this.start;
                
            }
            set
            {
                this.start = value;
                
            }
        }

        public T End
        {
            get
            {
                return this.end;

            }
            set
            {
                this.end = value;

            }
        }

        public string Msg
        {
            get
            {
                return this.msg;

            }
            set
            {
                this.msg = value;

            }
        }
    }
}
