using System;
using System.Collections.Generic;

#nullable disable

namespace MathApp1.Api.DataLayer
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
    }
}
