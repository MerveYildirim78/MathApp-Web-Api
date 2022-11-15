using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class FriendStatus
    {
        public FriendStatus()
        {
            Friends = new HashSet<Friend>();
        }

        public byte FriendStatusId { get; set; }
        public string StatusDescription { get; set; }

        public virtual ICollection<Friend> Friends { get; set; }
    }
}
