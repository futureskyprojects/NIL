using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecureMail;
using SecureMail.Operations;
using System.IO;

namespace Background
{
    public class CheckNewMail
    {
        void GetNewMail()
        {
            // If not enough user infor
            if (!Directory.Exists(GlobalVarriable.UserCombine) || !Directory.Exists(GlobalVarriable.UserToken))
                return;
            // If OK, get per user and get mail info

        }
    }
}
