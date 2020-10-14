using System;
using System.Collections.Generic;
using System.Text;

namespace personalKPI.Core.Model
{
  public   class Kpi
    {
        public int Id { get; set; }
        public int KpiId { get; set; }
        public int UserId { get; set; }
        public KpiTemplate KpiTemplate { get; set; }
        public User User { get; set; }


    }
}
