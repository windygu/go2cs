//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:29:45 UTC
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
        public partial struct ObjectIdentifier
        {
            // Value of the ObjectIdentifier struct
            private readonly slice<long> m_value;

            public ObjectIdentifier(slice<long> value) => m_value = value;

            // Enable implicit conversions between slice<long> and ObjectIdentifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ObjectIdentifier(slice<long> value) => new ObjectIdentifier(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<long>(ObjectIdentifier value) => value.m_value;
            
            // Enable comparisons between nil and ObjectIdentifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ObjectIdentifier value, NilType nil) => value.Equals(default(ObjectIdentifier));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ObjectIdentifier value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ObjectIdentifier value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ObjectIdentifier value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ObjectIdentifier(NilType nil) => default(ObjectIdentifier);
        }
    }
}}