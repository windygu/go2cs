//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using strconv = go.strconv_package;
using go;

namespace go {
namespace os
{
    public static partial class user_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Group
        {
            // Constructors
            public Group(NilType _)
            {
                this.Gid = default;
                this.Name = default;
            }

            public Group(@string Gid = default, @string Name = default)
            {
                this.Gid = Gid;
                this.Name = Name;
            }

            // Enable comparisons between nil and Group struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Group value, NilType nil) => value.Equals(default(Group));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Group value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Group value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Group value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Group(NilType nil) => default(Group);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Group Group_cast(dynamic value)
        {
            return new Group(value.Gid, value.Name);
        }
    }
}}