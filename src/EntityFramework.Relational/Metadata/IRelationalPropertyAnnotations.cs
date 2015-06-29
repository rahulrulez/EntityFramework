// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.Relational.Metadata
{
    public interface IRelationalPropertyAnnotations
    {
        string Column { get; }
        int? ColumnOrder { get; }
        string ColumnType { get; }
        string DefaultValueSql { get; }
        object DefaultValue { get; }
    }
}
