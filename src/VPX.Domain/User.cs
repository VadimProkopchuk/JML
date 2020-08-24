﻿using System;
using System.Collections.Generic;
using VPX.Domain.Core.Contracts;

namespace VPX.Domain
{
    public class User : IAppEntity<Guid>, IAuditableEntity
    {
        public Guid Id { get; set; }
        public Guid? GroupId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int CountOfInvalidAttempts { get; set; }
        public bool IsLocked { get; set; }
        public string Email { get; set; }
        public string AvatarBase64 { get; set; }
        
        public DateTime? ActiveAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public virtual StudyGroup Group { get; set; }
        public virtual ICollection<KnowledgeTest> Tests { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
