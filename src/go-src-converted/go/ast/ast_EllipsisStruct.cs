//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Ellipsis
        {
            // Constructors
            public Ellipsis(NilType _)
            {
                this.Ellipsis = default;
                this.Elt = default;
            }

            public Ellipsis(token.Pos Ellipsis = default, Expr Elt = default)
            {
                this.Ellipsis = Ellipsis;
                this.Elt = Elt;
            }

            // Enable comparisons between nil and Ellipsis struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Ellipsis value, NilType nil) => value.Equals(default(Ellipsis));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Ellipsis value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Ellipsis value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Ellipsis value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Ellipsis(NilType nil) => default(Ellipsis);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Ellipsis Ellipsis_cast(dynamic value)
        {
            return new Ellipsis(value.Ellipsis, value.Elt);
        }
    }
}}