// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Utilities;
using Remotion.Linq.Clauses;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class IncludeSpecification
    {
        public IncludeSpecification(
            [NotNull] IQuerySource querySource,
            [NotNull] IReadOnlyList<INavigation> navigationPath)
        {
            Check.NotNull(querySource, nameof(querySource));
            Check.NotNull(navigationPath, nameof(navigationPath));

            QuerySource = querySource;
            NavigationPath = navigationPath;
        }

        public virtual IQuerySource QuerySource { get; }
        public virtual IReadOnlyList<INavigation> NavigationPath { get; }

        public virtual bool IsEnumerableTarget { get; set; }

        public override string ToString()
        {
            return $"{QuerySource.ItemName}.{NavigationPath.Select(n => n.Name).Join(".")}";
        }
    }
}
