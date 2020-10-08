//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct heldLockInfo
        {
            // Constructors
            public heldLockInfo(NilType _)
            {
                this.lockAddr = default;
                this.rank = default;
            }

            public heldLockInfo(System.UIntPtr lockAddr = default, lockRank rank = default)
            {
                this.lockAddr = lockAddr;
                this.rank = rank;
            }

            // Enable comparisons between nil and heldLockInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(heldLockInfo value, NilType nil) => value.Equals(default(heldLockInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(heldLockInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, heldLockInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, heldLockInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator heldLockInfo(NilType nil) => default(heldLockInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static heldLockInfo heldLockInfo_cast(dynamic value)
        {
            return new heldLockInfo(value.lockAddr, value.rank);
        }
    }
}