using System;

namespace personalKPI.Core.Model
{
    public class KpiTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int  MetricId{ get; set; }
        public Metric Metric { get; set; }

        
    }
}
