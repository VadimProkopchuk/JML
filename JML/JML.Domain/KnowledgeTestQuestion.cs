﻿using JML.Domain.Core.Contracts;
using JML.Domain.Templates;
using System;

namespace JML.Domain
{
    public class KnowledgeTestQuestion : IAppEntity<Guid>, IAuditableEntity
    {
        public Guid Id { get; protected set; }
        public Guid QuestionTemplateId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsProvidedCorrectAnswer { get; set; }

        public virtual QuestionTemplate QuestionTemplate { get; set; }
    }
}
