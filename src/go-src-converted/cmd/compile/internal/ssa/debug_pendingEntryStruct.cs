//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.cmd.@internal.dwarf_package;
using obj = go.cmd.@internal.obj_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using bits = go.math.bits_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pendingEntry
        {
            // Constructors
            public pendingEntry(NilType _)
            {
                this.present = default;
                this.startBlock = default;
                this.startValue = default;
                this.pieces = default;
            }

            public pendingEntry(bool present = default, ID startBlock = default, ID startValue = default, slice<VarLoc> pieces = default)
            {
                this.present = present;
                this.startBlock = startBlock;
                this.startValue = startValue;
                this.pieces = pieces;
            }

            // Enable comparisons between nil and pendingEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pendingEntry value, NilType nil) => value.Equals(default(pendingEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pendingEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pendingEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pendingEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pendingEntry(NilType nil) => default(pendingEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pendingEntry pendingEntry_cast(dynamic value)
        {
            return new pendingEntry(value.present, value.startBlock, value.startValue, value.pieces);
        }
    }
}}}}