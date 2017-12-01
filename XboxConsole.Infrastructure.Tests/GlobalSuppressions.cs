// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Internal.GamesTest.Xbox.Tests.XboxPathTests.#RunDataDrivenTest`2(System.Collections.Generic.IEnumerable`1<Microsoft.Internal.GamesTest.Xbox.Tests.XboxPathTests+TestInputData`2<!!0,!!1>>,System.Func`2<!!0,!!1>,System.Func`3<!!1,!!1,System.Boolean>)", Justification = "Need to catch all exception types and compare them to the expected exception.")]
