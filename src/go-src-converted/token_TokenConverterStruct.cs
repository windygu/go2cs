//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:54:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal
{
    public static partial class span_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TokenConverter
        {
            // Constructors
            public TokenConverter(NilType _)
            {
                this.fset = default;
                this.file = default;
            }

            public TokenConverter(ref ptr<token.FileSet> fset = default, ref ptr<token.File> file = default)
            {
                this.fset = fset;
                this.file = file;
            }

            // Enable comparisons between nil and TokenConverter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TokenConverter value, NilType nil) => value.Equals(default(TokenConverter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TokenConverter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TokenConverter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TokenConverter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TokenConverter(NilType nil) => default(TokenConverter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TokenConverter TokenConverter_cast(dynamic value)
        {
            return new TokenConverter(ref value.fset, ref value.file);
        }
    }
}}}}}