using System;
using System.Collections.Generic;
using System.Text;

namespace personalKPI.Core.Model
{
    public class Metric
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MetricTypeId { get; set; }
        public MetricType MetricType { get; set; }
    }
}
