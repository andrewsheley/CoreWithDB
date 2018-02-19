using System;
using System.Collections.Generic;

namespace CoreWithDB.Models
{
    public partial class ParkingLot
    {
        public ParkingLot()
        {
            Employee = new HashSet<Employee>();
        }

        public int ParkingLotId { get; set; }
        public string LotName { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
