// Code generated by go tool dist; DO NOT EDIT.

// package objabi -- go2cs converted at 2020 August 29 08:46:21 UTC
// import "cmd/internal/objabi" ==> using objabi = go.cmd.@internal.objabi_package
// Original source: C:\Go\src\cmd\internal\objabi\zbootstrap.go
using runtime = go.runtime_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objabi_package
    {
        private static readonly @string defaultGO386 = "sse2";

        private static readonly @string defaultGOARM = "5";

        private static readonly @string defaultGOMIPS = "hardfloat";

        private static readonly var defaultGOOS = runtime.GOOS;

        private static readonly var defaultGOARCH = runtime.GOARCH;

        private static readonly @string defaultGO_EXTLINK_ENABLED = "";

        private static readonly @string version = "go1.10.1";

        private static readonly long stackGuardMultiplier = 1L;

        private static readonly @string goexperiment = "";

    }
}}}