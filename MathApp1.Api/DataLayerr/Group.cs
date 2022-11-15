using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class Group
    {
        public Group()
        {
            GroupMembers = new HashSet<GroupMember>();
            Messages = new HashSet<Message>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupProfilePhoto { get; set; }
        public int CreaterUserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual User CreaterUser { get; set; }
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
