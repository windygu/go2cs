//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using types = go.go.types_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using go;

namespace go {
namespace go {
namespace @internal
{
    public static partial class gccgoimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct GccgoInstallation
        {
            // Constructors
            public GccgoInstallation(NilType _)
            {
                this.GccVersion = default;
                this.TargetTriple = default;
                this.LibPaths = default;
            }

            public GccgoInstallation(@string GccVersion = default, @string TargetTriple = default, slice<@string> LibPaths = default)
            {
                this.GccVersion = GccVersion;
                this.TargetTriple = TargetTriple;
                this.LibPaths = LibPaths;
            }

            // Enable comparisons between nil and GccgoInstallation struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(GccgoInstallation value, NilType nil) => value.Equals(default(GccgoInstallation));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(GccgoInstallation value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, GccgoInstallation value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, GccgoInstallation value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator GccgoInstallation(NilType nil) => default(GccgoInstallation);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static GccgoInstallation GccgoInstallation_cast(dynamic value)
        {
            return new GccgoInstallation(value.GccVersion, value.TargetTriple, value.LibPaths);
        }
    }
}}}