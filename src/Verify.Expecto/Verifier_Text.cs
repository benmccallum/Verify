using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Expecto;

namespace Verify.Expecto
{
    public static partial class Verifier
    {
        public static Task Verify(
            string target,
            VerifySettings? settings = null,
            [CallerFilePath] string sourceFile = "",
            [CallerMemberName] string member = "")
        {
            var memberInfos = typeof(SourceLocation).GetMembers(BindingFlags.Static|BindingFlags.NonPublic);
            Debugger.Launch();
            return Task.CompletedTask;
        }
    }
}