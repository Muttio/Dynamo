﻿using Dynamo.Models;
using Migrations;

namespace Dynamo.Nodes
{

    public class DividedPathSpacingRuleLayout : MigrationNode
    {
    }

    public class DividedPath : MigrationNode
    {
        [NodeMigration(from: "0.6.3.0", to: "0.7.0.0")]
        public static NodeMigrationData Migrate_0630_to_0700(NodeMigrationData data)
        {
            return MigrateToDsFunction(data, "RevitNodes.dll",
                "DividedPath.ByCurveAndDivisions", 
                "DividedPath.ByCurveAndDivisions@CurveReference,int");
        }
    }

    public class PointsOnDividedPath : MigrationNode
    {
    }

}