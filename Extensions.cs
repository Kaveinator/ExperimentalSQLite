﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalSQLite {
    public static class Extensions {
        public static string GetDbTypeAsString(this DbType dbType) {
            switch (dbType) {
                case DbType.Byte:
                case DbType.Boolean:
                case DbType.Int16:
                case DbType.Int32:
                case DbType.Int64:
                case DbType.UInt16:
                case DbType.UInt32:
                case DbType.UInt64:
                    return "INTEGER";
                case DbType.Decimal:
                    return "NUMERIC";
                case DbType.String:
                case DbType.Date:
                case DbType.DateTime:
                    return "TEXT";
                case DbType.Binary:
                    return "BLOB";
                default:
                    throw new NotSupportedException($"Unsupported DbType: {dbType}");
            }
        }

        public static bool HasAnyFlags<T>(this T obj, params T[] array) where T : Enum
            => array.Any(flag => obj.HasFlag(flag));
    }
}
