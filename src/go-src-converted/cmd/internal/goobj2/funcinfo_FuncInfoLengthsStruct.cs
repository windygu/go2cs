//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:50:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncInfoLengths
        {
            // Constructors
            public FuncInfoLengths(NilType _)
            {
                this.NumPcdata = default;
                this.PcdataOff = default;
                this.NumFuncdataoff = default;
                this.FuncdataoffOff = default;
                this.NumFile = default;
                this.FileOff = default;
                this.NumInlTree = default;
                this.InlTreeOff = default;
                this.Initialized = default;
            }

            public FuncInfoLengths(uint NumPcdata = default, uint PcdataOff = default, uint NumFuncdataoff = default, uint FuncdataoffOff = default, uint NumFile = default, uint FileOff = default, uint NumInlTree = default, uint InlTreeOff = default, bool Initialized = default)
            {
                this.NumPcdata = NumPcdata;
                this.PcdataOff = PcdataOff;
                this.NumFuncdataoff = NumFuncdataoff;
                this.FuncdataoffOff = FuncdataoffOff;
                this.NumFile = NumFile;
                this.FileOff = FileOff;
                this.NumInlTree = NumInlTree;
                this.InlTreeOff = InlTreeOff;
                this.Initialized = Initialized;
            }

            // Enable comparisons between nil and FuncInfoLengths struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncInfoLengths value, NilType nil) => value.Equals(default(FuncInfoLengths));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncInfoLengths value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncInfoLengths value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncInfoLengths value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncInfoLengths(NilType nil) => default(FuncInfoLengths);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FuncInfoLengths FuncInfoLengths_cast(dynamic value)
        {
            return new FuncInfoLengths(value.NumPcdata, value.PcdataOff, value.NumFuncdataoff, value.FuncdataoffOff, value.NumFile, value.FileOff, value.NumInlTree, value.InlTreeOff, value.Initialized);
        }
    }
}}}