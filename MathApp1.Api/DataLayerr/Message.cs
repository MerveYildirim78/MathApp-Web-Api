using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class Message
    {
        public Message()
        {
            Complains = new HashSet<Complain>();
        }

        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public int? GroupId { get; set; }
        public string MessageContent { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime ReadDate { get; set; }

        public virtual Group Group { get; set; }
        public virtual User Receiver { get; set; }
        public virtual User Sender { get; set; }
        public virtual ICollection<Complain> Complains { get; set; }
    }
}
