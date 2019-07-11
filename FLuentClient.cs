using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaces
{
    public class FluentClient
    {
        public readonly IFluentINterface fluent;
        public FluentClient(IFluentINterface fluent)
        {
            this.fluent = fluent;
        }

        public void Run()
        {
            fluent.DoSomething().DoSomethingElse().DoSomethingElse().ThisMethodIsNotFlunent();
        }

        
    }
}
