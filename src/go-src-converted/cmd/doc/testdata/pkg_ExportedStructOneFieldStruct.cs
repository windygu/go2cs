//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd
{
    public static partial class pkg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ExportedStructOneField
        {
            // Constructors
            public ExportedStructOneField(NilType _)
            {
                this.OnlyField = default;
            }

            public ExportedStructOneField(long OnlyField = default)
            {
                this.OnlyField = OnlyField;
            }

            // Enable comparisons between nil and ExportedStructOneField struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ExportedStructOneField value, NilType nil) => value.Equals(default(ExportedStructOneField));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ExportedStructOneField value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ExportedStructOneField value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ExportedStructOneField value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ExportedStructOneField(NilType nil) => default(ExportedStructOneField);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ExportedStructOneField ExportedStructOneField_cast(dynamic value)
        {
            return new ExportedStructOneField(value.OnlyField);
        }
    }
}}