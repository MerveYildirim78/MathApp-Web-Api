using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayerr
{
    public partial class ComplainStatus
    {
        public ComplainStatus()
        {
            Complains = new HashSet<Complain>();
        }

        public byte ComplainStatusId { get; set; }
        public string ComplainDescription { get; set; }

        public virtual ICollection<Complain> Complains { get; set; }
    }
}
