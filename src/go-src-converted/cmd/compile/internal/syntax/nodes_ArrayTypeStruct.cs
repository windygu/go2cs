//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct ArrayType
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public ArrayType(NilType _)
            {
                this.Len = default;
                this.Elem = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public ArrayType(Expr Len = default, Expr Elem = default, expr expr = default)
            {
                this.Len = Len;
                this.Elem = Elem;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and ArrayType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ArrayType value, NilType nil) => value.Equals(default(ArrayType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ArrayType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ArrayType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ArrayType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ArrayType(NilType nil) => default(ArrayType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ArrayType ArrayType_cast(dynamic value)
        {
            return new ArrayType(value.Len, value.Elem, value.expr);
        }
    }
}}}}