﻿using Microsoft.CodeAnalysis;

namespace Stryker.Core.Mutants
{
    /// <summary>
    /// Represents a single mutation on code level
    /// </summary>
    public class Mutation
    {
        public SyntaxNode OriginalNode { get; set; }
        public SyntaxNode ReplacementNode { get; set; }
        public string DisplayName { get; set; }
        public string Type { get; set; }
    }
}
