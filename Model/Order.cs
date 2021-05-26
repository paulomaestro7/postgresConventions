using System.Collections.Generic;

namespace postgresConventions.Model
{
    public class Order : Base
    {
        public Order()
        {
            Client = new HashSet<Client>();
        }
        public decimal Total { get; set; }
        public int ClientId { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
