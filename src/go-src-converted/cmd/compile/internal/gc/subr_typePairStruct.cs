//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:29:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using md5 = go.crypto.md5_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using os = go.os_package;
using debug = go.runtime.debug_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typePair
        {
            // Constructors
            public typePair(NilType _)
            {
                this.t1 = default;
                this.t2 = default;
            }

            public typePair(ref ptr<types.Type> t1 = default, ref ptr<types.Type> t2 = default)
            {
                this.t1 = t1;
                this.t2 = t2;
            }

            // Enable comparisons between nil and typePair struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typePair value, NilType nil) => value.Equals(default(typePair));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typePair value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typePair value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typePair value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typePair(NilType nil) => default(typePair);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typePair typePair_cast(dynamic value)
        {
            return new typePair(ref value.t1, ref value.t2);
        }
    }
}}}}