using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class GroupMember
    {
        public int GroupMemberId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int AddedUserId { get; set; }
        public DateTime AddedDate { get; set; }
        public bool IsAdmin { get; set; }

        public virtual User AddedUser { get; set; }
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
