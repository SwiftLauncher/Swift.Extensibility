using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.Services
{
    public interface IExtensionRegistry
    {
        void RegisterExtension<T>(T extension);

        IEnumerable<Type> GetExtensionPoints();
    }
}
