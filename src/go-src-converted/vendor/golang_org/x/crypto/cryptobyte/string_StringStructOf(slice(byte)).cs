//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace crypto
{
    public static partial class cryptobyte_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct String
        {
            // Value of the String struct
            private readonly slice<byte> m_value;

            public String(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and String struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator String(slice<byte> value) => new String(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(String value) => value.m_value;
            
            // Enable comparisons between nil and String struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(String value, NilType nil) => value.Equals(default(String));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(String value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, String value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, String value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator String(NilType nil) => default(String);
        }
    }
}}}}}