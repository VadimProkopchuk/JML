﻿using System;
using System.Collections.Generic;

namespace JML.ApiModels
{
    public class UserProfileModel
    {
        public string FullName { get; set; }
        public string GroupName { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Tests { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ActiveAt { get; set; }
        public bool IsLocked { get; set; }
        public bool HasStudentRole { get; set; }
        public bool HasTeacherRole { get; set; }
    }
}
