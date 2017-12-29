using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class Driver
    {
        public Guid Id { get; protected set; }
        public string UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }
    }
}
