//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:29:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace encoding
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byteEncoder
        {
            // Value of the byteEncoder struct
            private readonly byte m_value;

            public byteEncoder(byte value) => m_value = value;

            // Enable implicit conversions between byte and byteEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byteEncoder(byte value) => new byteEncoder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(byteEncoder value) => value.m_value;
            
            // Enable comparisons between nil and byteEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byteEncoder value, NilType nil) => value.Equals(default(byteEncoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byteEncoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byteEncoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byteEncoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byteEncoder(NilType nil) => default(byteEncoder);
        }
    }
}}