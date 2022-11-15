using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class Friend
    {
        public int FriendId { get; set; }
        public int RequesterUserId { get; set; }
        public int RequestedUserId { get; set; }
        public byte FriendStatusId { get; set; }
        public DateTime RequestedDate { get; set; }

        public virtual FriendStatus FriendStatus { get; set; }
        public virtual User RequestedUser { get; set; }
        public virtual User RequesterUser { get; set; }
    }
}
