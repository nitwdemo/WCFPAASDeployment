using System;
using System.Threading;

namespace WCFServiceWebRole1
{
    internal class CompletedAsyncResult : IAsyncResult
    {
        private int num1;
        private int num2;
        private int data;

        public CompletedAsyncResult(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.Data = num1 + num2;
        }

        public object AsyncState
        {
            get
            {
                return null;
            }
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool CompletedSynchronously
        {
            get
            {
                return true;
            }
        }

        public bool IsCompleted
        {
            get
            {
                return true;
            }
        }
    }
}