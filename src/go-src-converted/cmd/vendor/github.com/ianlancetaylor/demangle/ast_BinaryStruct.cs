//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:50 UTC
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
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Binary
        {
            // Constructors
            public Binary(NilType _)
            {
                this.Op = default;
                this.Left = default;
                this.Right = default;
            }

            public Binary(AST Op = default, AST Left = default, AST Right = default)
            {
                this.Op = Op;
                this.Left = Left;
                this.Right = Right;
            }

            // Enable comparisons between nil and Binary struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Binary value, NilType nil) => value.Equals(default(Binary));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Binary value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Binary value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Binary value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Binary(NilType nil) => default(Binary);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Binary Binary_cast(dynamic value)
        {
            return new Binary(value.Op, value.Left, value.Right);
        }
    }
}}}}}