using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumbers
{
    public interface IGenericGenerator
    {
        int passwordLength { get; }

        string GeneratePassword();
    }
}
