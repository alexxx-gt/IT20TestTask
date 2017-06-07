using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT20TestTask.Models
{
    public class Passing
    {
        public int PassingId { get; set; }
        public int FormId { get; set; }
        public bool Callback { get; set; }
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Interviewee { get; set; }
        public string EquipmentTitle { get; set; }
    }
}