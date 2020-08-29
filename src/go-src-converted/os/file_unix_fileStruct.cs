//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:44:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using poll = go.@internal.poll_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct file
        {
            // Constructors
            public file(NilType _)
            {
                this.pfd = default;
                this.name = default;
                this.dirinfo = default;
                this.nonblock = default;
                this.stdoutOrErr = default;
            }

            public file(poll.FD pfd = default, @string name = default, ref ptr<dirInfo> dirinfo = default, bool nonblock = default, bool stdoutOrErr = default)
            {
                this.pfd = pfd;
                this.name = name;
                this.dirinfo = dirinfo;
                this.nonblock = nonblock;
                this.stdoutOrErr = stdoutOrErr;
            }

            // Enable comparisons between nil and file struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(file value, NilType nil) => value.Equals(default(file));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(file value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, file value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, file value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator file(NilType nil) => default(file);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static file file_cast(dynamic value)
        {
            return new file(value.pfd, value.name, ref value.dirinfo, value.nonblock, value.stdoutOrErr);
        }
    }
}