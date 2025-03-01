﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

#nullable disable

namespace Microsoft.Build.Evaluation
{
    /// <summary>
    /// Compares for inequality
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    internal sealed class NotEqualExpressionNode : MultipleComparisonNode
    {
        /// <summary>
        /// Compare numbers
        /// </summary>
        protected override bool Compare(double left, double right)
        {
            return left != right;
        }

        /// <summary>
        /// Compare booleans
        /// </summary>
        protected override bool Compare(bool left, bool right)
        {
            return left != right;
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        protected override bool Compare(string left, string right)
        {
            return !String.Equals(left, right, StringComparison.OrdinalIgnoreCase);
        }

        internal override string DebuggerDisplay => $"(!= {LeftChild.DebuggerDisplay} {RightChild.DebuggerDisplay})";
    }
}
