using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevConnect.Core.Enums;using DevConnect.Core.Models;
using DevConnect.Core.Enums;
using DevConnect.Core.Enums;

namespace DevConnect.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        // ── Basic Info ────────────────────────────────────
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public string? Bio { get; set; }
        public string? Location { get; set; }
        public string? GitHubUrl { get; set; }
        public string? PortfolioUrl { get; set; }

        // ── Role & Status ─────────────────────────────────\

        public User_Role Role { get; set; } = User_Role.Developer;
        //public UserRole Role { get; set; } = UserRole.Developer;
        public UserStatus Status { get; set; } = UserStatus.Active;
        public ExperienceLevel ExperienceLevel { get; set; }
                               = ExperienceLevel.Junior;

        // ── Reputation ────────────────────────────────────
        public int ReputationPoints { get; set; } = 0;
        public int TotalReviews { get; set; } = 0;
        public int TotalReviewsGiven { get; set; } = 0;
        public int AcceptedReviews { get; set; } = 0;

        // ── Auth ──────────────────────────────────────────
        public string? GitHubId { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public bool IsEmailVerified { get; set; } = false;
        public string? EmailVerificationToken { get; set; }

        // ── Timestamps ────────────────────────────────────
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public bool IsActive { get; set; } = true;

        // ── Navigation Properties (EF Core) ───────────────
        public ICollection<UserSkill> Skills { get; set; }
            = new List<UserSkill>();
    }
}