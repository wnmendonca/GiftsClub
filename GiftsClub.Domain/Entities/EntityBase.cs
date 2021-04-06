using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftsClub.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase()
        {
            if (string.IsNullOrEmpty(Id))
                Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtChange { get; set; }
    }
}
