﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jhu.Graywulf.Schema;
using Jhu.Graywulf.SqlParser;
using Jhu.Graywulf.SqlCodeGen;
using Jhu.Graywulf.SqlCodeGen.SqlServer;

namespace Jhu.SkyQuery.CodeGen
{
    public class SkyQueryColumnListGenerator : SqlServerColumnListGenerator
    {
        public SkyQueryColumnListGenerator()
            : base()
        {
        }

        public SkyQueryColumnListGenerator(IEnumerable<ColumnReference> columns)
            : base(columns)
        {
        }

        public SkyQueryColumnListGenerator(TableReference tr, ColumnContext context, ColumnListType listType)
            : base(tr, context, listType)
        {
        }
    }
}
