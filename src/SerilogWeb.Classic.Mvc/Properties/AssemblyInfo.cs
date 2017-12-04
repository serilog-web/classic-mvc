using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;
using SerilogWeb.Classic.Mvc;

[assembly: AssemblyTitle("SerilogWeb.Classic.Mvc")]
[assembly: PreApplicationStartMethod(typeof(PreApplicationStartModule), "Register")]
