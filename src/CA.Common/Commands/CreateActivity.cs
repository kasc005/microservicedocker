﻿using System;
namespace CA.Common.Commands
{
    public class CreateActivity : ICommand
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Category { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
