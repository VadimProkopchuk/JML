﻿using JML.Domain.Core.Contracts;
using JML.Domain.Templates;
using System;

namespace JML.Domain
{
    public class TestTemplateTag : IAppEntity<Guid>, IAuditableEntity
    {
        public Guid Id { get; protected set; }
        public Guid TestTemplateId { get; set; }
        public Guid TagId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public virtual TestTemplate TestTemplate { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
