//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SameSite
        {
            // Value of the SameSite struct
            private readonly long m_value;

            public SameSite(long value) => m_value = value;

            // Enable implicit conversions between long and SameSite struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SameSite(long value) => new SameSite(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(SameSite value) => value.m_value;
            
            // Enable comparisons between nil and SameSite struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SameSite value, NilType nil) => value.Equals(default(SameSite));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SameSite value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SameSite value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SameSite value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SameSite(NilType nil) => default(SameSite);
        }
    }
}}