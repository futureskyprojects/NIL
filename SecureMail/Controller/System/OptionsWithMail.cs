using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail.Operations
{
    public static class Options
    {
        public static void MODIFY(IList<String> LabelsToAdd, IList<String> LabelsToRemove, String MessageId)
        {
            ModifyMessageRequest modify = new ModifyMessageRequest();
            modify.AddLabelIds = LabelsToAdd;
            modify.RemoveLabelIds = LabelsToRemove;
            Message message = Gmail.Connect.service.Users.Messages.Modify(modify, "me", MessageId).Execute();
        }
    }
}
