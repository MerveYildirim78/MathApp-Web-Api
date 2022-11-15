using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class User
    {
        public User()
        {
            ComplainComplainantUsers = new HashSet<Complain>();
            ComplainComplainedOfUsers = new HashSet<Complain>();
            GroupMemberAddedUsers = new HashSet<GroupMember>();
            GroupMemberUsers = new HashSet<GroupMember>();
            Groups = new HashSet<Group>();
            MessageReceivers = new HashSet<Message>();
            MessageSenders = new HashSet<Message>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePhoto { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Friend FriendRequestedUser { get; set; }
        public virtual Friend FriendRequesterUser { get; set; }
        public virtual ICollection<Complain> ComplainComplainantUsers { get; set; }
        public virtual ICollection<Complain> ComplainComplainedOfUsers { get; set; }
        public virtual ICollection<GroupMember> GroupMemberAddedUsers { get; set; }
        public virtual ICollection<GroupMember> GroupMemberUsers { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Message> MessageReceivers { get; set; }
        public virtual ICollection<Message> MessageSenders { get; set; }
    }
}
