//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:56:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using big = go.math.big_package;
using os = go.os_package;
using sort = go.sort_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ltState
        {
            // Constructors
            public ltState(NilType _)
            {
                this.sdom = default;
                this.parent = default;
                this.ancestor = default;
            }

            public ltState(slice<ptr<BasicBlock>> sdom = default, slice<ptr<BasicBlock>> parent = default, slice<ptr<BasicBlock>> ancestor = default)
            {
                this.sdom = sdom;
                this.parent = parent;
                this.ancestor = ancestor;
            }

            // Enable comparisons between nil and ltState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ltState value, NilType nil) => value.Equals(default(ltState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ltState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ltState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ltState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ltState(NilType nil) => default(ltState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ltState ltState_cast(dynamic value)
        {
            return new ltState(value.sdom, value.parent, value.ancestor);
        }
    }
}}}}}