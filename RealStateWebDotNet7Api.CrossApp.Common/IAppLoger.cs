using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.CrossApp.Common
{
    public interface IAppLoger<T>
    {
        void LogInformation(string type ,string message , params object[] args);
    }
}
