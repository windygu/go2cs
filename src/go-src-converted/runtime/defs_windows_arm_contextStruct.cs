//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:38 UTC
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
        private partial struct context
        {
            // Constructors
            public context(NilType _)
            {
                this.contextflags = default;
                this.r0 = default;
                this.r1 = default;
                this.r2 = default;
                this.r3 = default;
                this.r4 = default;
                this.r5 = default;
                this.r6 = default;
                this.r7 = default;
                this.r8 = default;
                this.r9 = default;
                this.r10 = default;
                this.r11 = default;
                this.r12 = default;
                this.spr = default;
                this.lrr = default;
                this.pc = default;
                this.cpsr = default;
                this.fpscr = default;
                this.padding = default;
                this.floatNeon = default;
                this.bvr = default;
                this.bcr = default;
                this.wvr = default;
                this.wcr = default;
                this.padding2 = default;
            }

            public context(uint contextflags = default, uint r0 = default, uint r1 = default, uint r2 = default, uint r3 = default, uint r4 = default, uint r5 = default, uint r6 = default, uint r7 = default, uint r8 = default, uint r9 = default, uint r10 = default, uint r11 = default, uint r12 = default, uint spr = default, uint lrr = default, uint pc = default, uint cpsr = default, uint fpscr = default, uint padding = default, array<neon128> floatNeon = default, array<uint> bvr = default, array<uint> bcr = default, array<uint> wvr = default, array<uint> wcr = default, array<uint> padding2 = default)
            {
                this.contextflags = contextflags;
                this.r0 = r0;
                this.r1 = r1;
                this.r2 = r2;
                this.r3 = r3;
                this.r4 = r4;
                this.r5 = r5;
                this.r6 = r6;
                this.r7 = r7;
                this.r8 = r8;
                this.r9 = r9;
                this.r10 = r10;
                this.r11 = r11;
                this.r12 = r12;
                this.spr = spr;
                this.lrr = lrr;
                this.pc = pc;
                this.cpsr = cpsr;
                this.fpscr = fpscr;
                this.padding = padding;
                this.floatNeon = floatNeon;
                this.bvr = bvr;
                this.bcr = bcr;
                this.wvr = wvr;
                this.wcr = wcr;
                this.padding2 = padding2;
            }

            // Enable comparisons between nil and context struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(context value, NilType nil) => value.Equals(default(context));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(context value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, context value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, context value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator context(NilType nil) => default(context);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static context context_cast(dynamic value)
        {
            return new context(value.contextflags, value.r0, value.r1, value.r2, value.r3, value.r4, value.r5, value.r6, value.r7, value.r8, value.r9, value.r10, value.r11, value.r12, value.spr, value.lrr, value.pc, value.cpsr, value.fpscr, value.padding, value.floatNeon, value.bvr, value.bcr, value.wvr, value.wcr, value.padding2);
        }
    }
}