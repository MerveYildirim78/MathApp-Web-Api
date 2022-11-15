using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class Complain
    {
        public int ComplainId { get; set; }
        public int ComplainantUserId { get; set; }
        public int ComplainedOfUserId { get; set; }
        public byte ComplainStatusId { get; set; }
        public DateTime ComplainDate { get; set; }
        public int MessageReferenceId { get; set; }

        public virtual ComplainStatus ComplainStatus { get; set; }
        public virtual User ComplainantUser { get; set; }
        public virtual User ComplainedOfUser { get; set; }
        public virtual Message MessageReference { get; set; }
    }
}
