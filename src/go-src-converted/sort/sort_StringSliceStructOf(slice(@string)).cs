//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class sort_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct StringSlice
        {
            // Value of the StringSlice struct
            private readonly slice<@string> m_value;

            public StringSlice(slice<@string> value) => m_value = value;

            // Enable implicit conversions between slice<@string> and StringSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StringSlice(slice<@string> value) => new StringSlice(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<@string>(StringSlice value) => value.m_value;
            
            // Enable comparisons between nil and StringSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StringSlice value, NilType nil) => value.Equals(default(StringSlice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StringSlice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StringSlice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StringSlice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StringSlice(NilType nil) => default(StringSlice);
        }
    }
}