﻿using System;

namespace JML.ApiModels
{
    public class UpdateGroupModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid[] Users { get; set; }
    }
}
