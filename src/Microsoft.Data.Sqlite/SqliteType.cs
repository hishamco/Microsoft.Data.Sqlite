// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Sqlite.Interop;

namespace Microsoft.Data.Sqlite
{
    public enum SqliteType
    {
        Integer = Sqlite3Constants.SQLITE_INTEGER,
        Real = Sqlite3Constants.SQLITE_FLOAT,
        Text = Sqlite3Constants.SQLITE_TEXT,
        Blob = Sqlite3Constants.SQLITE_BLOB
    }
}
