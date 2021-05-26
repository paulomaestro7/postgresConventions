using System;

namespace postgresConventions.Model
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
