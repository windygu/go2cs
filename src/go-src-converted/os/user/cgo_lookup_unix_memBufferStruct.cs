//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using C = go.C_package;
using go;

namespace go {
namespace os
{
    public static partial class user_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct memBuffer
        {
            // Constructors
            public memBuffer(NilType _)
            {
                this.ptr = default;
                this.size = default;
            }

            public memBuffer(unsafe.Pointer ptr = default, C.size_t size = default)
            {
                this.ptr = ptr;
                this.size = size;
            }

            // Enable comparisons between nil and memBuffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(memBuffer value, NilType nil) => value.Equals(default(memBuffer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(memBuffer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, memBuffer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, memBuffer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator memBuffer(NilType nil) => default(memBuffer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static memBuffer memBuffer_cast(dynamic value)
        {
            return new memBuffer(value.ptr, value.size);
        }
    }
}}