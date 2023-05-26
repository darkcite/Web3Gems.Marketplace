﻿using System;
namespace Marketplace.Shared
{
    public class TokenMetadata
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ExternalUrl { get; set; }
        public string BackgroundColor { get; set; }
        public List<Trait> Traits { get; set; }
    }

    public class Trait
    {
        public string TraitType { get; set; }
        public string Value { get; set; }
    }
}

