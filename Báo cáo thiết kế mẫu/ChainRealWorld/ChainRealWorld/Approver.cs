using System;
using System.Collections.Generic;
using System.Text;

namespace ChainRealWorld
{
    abstract class Approver
    {
        protected Approver successor;

        public void SetSucessor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
