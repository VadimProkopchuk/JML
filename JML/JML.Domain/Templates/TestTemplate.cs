﻿using System;
using System.Collections.Generic;
using JML.Domain.Core.Contracts;

namespace JML.Domain.Templates
{
    public class TestTemplate : IAppEntity<Guid>, IAuditableEntity
    {
        public Guid Id { get; protected set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int CountOfQuestions { get; set; }
        public TimeSpan ExecuteTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public virtual ICollection<TestTemplateTag> TestTemplateTags { get; set; }
        public virtual ICollection<QuestionTemplate> Questions { get; set; }
    }
}
