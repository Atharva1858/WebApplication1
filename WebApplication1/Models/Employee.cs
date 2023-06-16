using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key] public int nodeId { get; set; }

        public string nodeName { get; set; }

        public int ParentNodeId { get; set; }

        public bool IsActive { get; set; }

        public DateTime StartDate { get; set; }


    }
}
