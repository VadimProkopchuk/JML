﻿using System;
using System.Collections.Generic;
using VPX.Domain.Core.Contracts;

namespace VPX.Domain
{
    public class Lecture : IAppEntity<Guid>, IAuditableEntity
    {
        public Guid Id { get; protected set; }

        public string Name { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public string Preview { get; set; }
        public string Section { get; set; }
        public TimeSpan TimeToRead { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public virtual ICollection<LectureTag> LectureTags { get; set; }
    }
}
