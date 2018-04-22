﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jhu.Graywulf.Registry;

namespace Jhu.SkyQuery.Jobs.Query
{
    [TestClass]
    public class SqlScriptTest : SkyQueryTestBase
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            StartLogger();
            InitializeJobTests();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            CleanupJobTests();
            StopLogger();
        }

        [TestMethod]
        public void AggregateRegionsTest()
        {
            var sql = @"
DECLARE @r varbinary(max)
DECLARE @a float = 0

SELECT @r = region.UnionEvery(region.CircleEq(ra, dec, 0.5)),
       @a = SUM(region.Area(region.CircleEq(ra, dec, 0.5)))
FROM MYDB:MyCatalog

SELECT region.Area(@r), @a
";

            RunQuery(sql);
        }
    }
}
