//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using src = go.cmd.@internal.src_package;
using list = go.container.list_package;
using gosym = go.debug.gosym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using armasm = go.golang.org.x.arch.arm.armasm_package;
using arm64asm = go.golang.org.x.arch.arm64.arm64asm_package;
using ppc64asm = go.golang.org.x.arch.ppc64.ppc64asm_package;
using x86asm = go.golang.org.x.arch.x86.x86asm_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Disasm
        {
            // Constructors
            public Disasm(NilType _)
            {
                this.syms = default;
                this.pcln = default;
                this.text = default;
                this.textStart = default;
                this.textEnd = default;
                this.goarch = default;
                this.disasm = default;
                this.byteOrder = default;
            }

            public Disasm(slice<Sym> syms = default, Liner pcln = default, slice<byte> text = default, ulong textStart = default, ulong textEnd = default, @string goarch = default, disasmFunc disasm = default, binary.ByteOrder byteOrder = default)
            {
                this.syms = syms;
                this.pcln = pcln;
                this.text = text;
                this.textStart = textStart;
                this.textEnd = textEnd;
                this.goarch = goarch;
                this.disasm = disasm;
                this.byteOrder = byteOrder;
            }

            // Enable comparisons between nil and Disasm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Disasm value, NilType nil) => value.Equals(default(Disasm));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Disasm value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Disasm value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Disasm value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Disasm(NilType nil) => default(Disasm);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Disasm Disasm_cast(dynamic value)
        {
            return new Disasm(value.syms, value.pcln, value.text, value.textStart, value.textEnd, value.goarch, value.disasm, value.byteOrder);
        }
    }
}}}