using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailWire.Models
{
    public class TrainES
    {
        public string TrainId { get; set; }
        public string TrainName { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public string Time { get; set; }
    }
}