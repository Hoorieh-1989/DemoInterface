using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    public class WashingMashin : IPowerPlug, IDisposable
    {
        public void Connect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}