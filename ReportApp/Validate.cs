using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportApp;
internal class Validate
{
    public bool RecordNumber_IsValid(string record)
    {
        if (record.Length != 4)
        {
            return false;
        }

        throw new NotImplementedException();

    }
}
