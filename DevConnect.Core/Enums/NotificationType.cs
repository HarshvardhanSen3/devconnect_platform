using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConnect.Core.Enums
{
    public enum NotificationType
    {
        CodeReviewReceived  = 1,
        CommentReceived     = 2,
        ReviewAccepted      = 3,
        BadgeEarned         = 4,
        ProjectInvite       = 5,
        PairRequestReceived = 6,
        SystemMessage       = 7
    }
}
