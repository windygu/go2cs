//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace packages
{
    public static partial class packagestest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Range
        {
            // Value of the Range struct
            private readonly span.Range m_value;

            public Range(span.Range value) => m_value = value;

            // Enable implicit conversions between span.Range and Range struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Range(span.Range value) => new Range(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator span.Range(Range value) => value.m_value;
            
            // Enable comparisons between nil and Range struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Range value, NilType nil) => value.Equals(default(Range));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Range value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Range value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Range value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Range(NilType nil) => default(Range);
        }
    }
}}}}}}