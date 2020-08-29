//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using rsa = go.crypto.rsa_package;
using asn1 = go.encoding.asn1_package;
using errors = go.errors_package;
using big = go.math.big_package;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pkcs1PublicKey
        {
            // Constructors
            public pkcs1PublicKey(NilType _)
            {
                this.N = default;
                this.E = default;
            }

            public pkcs1PublicKey(ref ptr<big.Int> N = default, long E = default)
            {
                this.N = N;
                this.E = E;
            }

            // Enable comparisons between nil and pkcs1PublicKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pkcs1PublicKey value, NilType nil) => value.Equals(default(pkcs1PublicKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pkcs1PublicKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pkcs1PublicKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pkcs1PublicKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pkcs1PublicKey(NilType nil) => default(pkcs1PublicKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pkcs1PublicKey pkcs1PublicKey_cast(dynamic value)
        {
            return new pkcs1PublicKey(ref value.N, value.E);
        }
    }
}}