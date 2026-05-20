using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConnect.Core.Models
{
    public class AdminLog
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string Action { get; set; } = string.Empty;
        public string TargetType { get; set; } = string.Empty;
        public int? TargetId { get; set; }
        public string? Details { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public User Admin { get; set; } = null!;
    }
}
