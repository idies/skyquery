﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jhu.SkyQuery.Jobs.Query {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class XMatchScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal XMatchScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jhu.SkyQuery.Jobs.Query.XMatchScripts", typeof(XMatchScripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- *** XMatchResources/CreateLinkTable.sql *** ---
        ///
        ///CREATE TABLE [$tablename]
        ///(
        ///	[ZoneID1] [bigint] NOT NULL,
        ///	[ZoneID2] [int] NOT NULL,
        ///	[Alpha1] [float] NOT NULL,
        ///	[Alpha2] [float] NOT NULL
        ///)
        ///
        ///ALTER TABLE [$tablename] ADD CONSTRAINT [$indexname] PRIMARY KEY ( [ZoneID1], [ZoneID2] ).
        /// </summary>
        internal static string CreateLinkTable {
            get {
                return ResourceManager.GetString("CreateLinkTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- *** XMatchResources/CreatePairTable.sql *** ---
        ///
        ///CREATE TABLE [$tablename]
        ///(
        ///	[$createcolumnlist1],
        ///	[$createcolumnlist2],
        ///	[Dx] float NOT NULL,
        ///	[Dy] float NOT NULL,
        ///	[Dz] float NOT NULL
        ///).
        /// </summary>
        internal static string CreatePairTable {
            get {
                return ResourceManager.GetString("CreatePairTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- *** XMatchResources/CreateZoneDefTable.sql *** ---
        ///
        ///CREATE TABLE [$tablename]
        ///(
        ///	ZoneID int NOT NULL,
        ///	DecMin float NOT NULL,
        ///	DecMax float NOT NULL,
        ///	Alpha float NOT NULL
        ///) 
        ///
        ///ALTER TABLE [$tablename] ADD CONSTRAINT [$indexname] PRIMARY KEY (ZoneID)
        ///.
        /// </summary>
        internal static string CreateZoneDefTable {
            get {
                return ResourceManager.GetString("CreateZoneDefTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- *** XMatchResources/PopulateZoneDefTable.sql *** ---
        ///
        ///INSERT [$tablename] WITH (TABLOCKX)
        ///SELECT [zd].* FROM [SkyQuery_Code].[dbo].[CalculateZones](@ZoneHeight, @Theta, @PartitionMin, @PartitionMax) AS [zd].
        /// </summary>
        internal static string PopulateZoneDefTable {
            get {
                return ResourceManager.GetString("PopulateZoneDefTable", resourceCulture);
            }
        }
    }
}
