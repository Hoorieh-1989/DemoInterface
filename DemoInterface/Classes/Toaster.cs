using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    //how to put implemnation is to put the mouse on the IPowerplug and click on implemation interface
    public class Toaster : IPowerPlug
    {
        public void Connect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(int voltage, int ampere)
        {
            throw new NotImplementedException();
        }
    }

}