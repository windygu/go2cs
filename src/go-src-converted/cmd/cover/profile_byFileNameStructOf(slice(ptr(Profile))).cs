//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:32:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byFileName
        {
            // Value of the byFileName struct
            private readonly slice<ptr<Profile>> m_value;

            public byFileName(slice<ptr<Profile>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<Profile>> and byFileName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byFileName(slice<ptr<Profile>> value) => new byFileName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<Profile>>(byFileName value) => value.m_value;
            
            // Enable comparisons between nil and byFileName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byFileName value, NilType nil) => value.Equals(default(byFileName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byFileName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byFileName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byFileName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byFileName(NilType nil) => default(byFileName);
        }
    }
}