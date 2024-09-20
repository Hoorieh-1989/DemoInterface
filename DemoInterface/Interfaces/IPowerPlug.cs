using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Interfaces
{
    // detta är ett kontrakt som en klass kan fälja .Det säger
    //att alla metoder som finns här måste implementeras av klassen med 
    // dessa namn och inparametrar.Men säger inget om hur klassen gör 
    //gör detta 
public interface IPowerPlug
    {
        public void Connect(int voltage, int ampere);

        public void Disconnect(int voltage, int ampere);    
    }
}
