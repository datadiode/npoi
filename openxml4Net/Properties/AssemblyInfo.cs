using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

#if NETSTANDARD2_1 || NETSTANDARD2_0 || NET40
[assembly: AllowPartiallyTrustedCallers]
#endif
#if NETSTANDARD2_1 || NETSTANDARD2_0 || NET40 || NET45
[assembly: SecurityRules(SecurityRuleSet.Level1)]
#endif
