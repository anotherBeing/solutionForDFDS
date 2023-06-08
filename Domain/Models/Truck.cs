using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Truck
{
    public string LicensePlate { get; set; }
    public Location CurrentLocation { get; set; }
    public IOrderedEnumerable<LocationTime> LocationHistory { get; set; }
}
