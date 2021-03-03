﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

//[assembly: InternalsVisibleTo("ooxml.Testcases")]

[assembly: InternalsVisibleTo("NPOI.OOXML.TestCases, PublicKey=002400000480000094000000060200000024000052534131000400000100010095ccd95af3b39d8bc20544d3f47fd24b53ebc5ccb693eaed116290629f8cd882c827ebd511ad59449224f0718d3f9d03b64945a6c8b6644266001b8c8426185330e3d96da70ae16d4acc21b8d4d480f1385c7e924273179375aa88f81380a72fb115712a313379d16aed4aa36208ee3b4a5dd785b06a07b2d868e3227f4495b5", AllInternalsVisible = true)]
#if NETSTANDARD2_1 || NETSTANDARD2_0 || NET40
[assembly: AllowPartiallyTrustedCallers]
#endif
#if NETSTANDARD2_1 || NETSTANDARD2_0 || NET40 || NET45
[assembly: SecurityRules(SecurityRuleSet.Level1)]
#endif
