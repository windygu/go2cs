//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fpregset
        {
            // Constructors
            public fpregset(NilType _)
            {
                this.fp_reg_set = default;
            }

            public fpregset(array<byte> fp_reg_set = default)
            {
                this.fp_reg_set = fp_reg_set;
            }

            // Enable comparisons between nil and fpregset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fpregset value, NilType nil) => value.Equals(default(fpregset));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fpregset value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fpregset value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fpregset value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fpregset(NilType nil) => default(fpregset);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fpregset fpregset_cast(dynamic value)
        {
            return new fpregset(value.fp_reg_set);
        }
    }
}