//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct File
        {
            // Constructors
            public File(NilType _)
            {
                this.Doc = default;
                this.Package = default;
                this.Name = default;
                this.Decls = default;
                this.Scope = default;
                this.Imports = default;
                this.Unresolved = default;
                this.Comments = default;
            }

            public File(ref ptr<CommentGroup> Doc = default, token.Pos Package = default, ref ptr<Ident> Name = default, slice<Decl> Decls = default, ref ptr<Scope> Scope = default, slice<ref ImportSpec> Imports = default, slice<ref Ident> Unresolved = default, slice<ref CommentGroup> Comments = default)
            {
                this.Doc = Doc;
                this.Package = Package;
                this.Name = Name;
                this.Decls = Decls;
                this.Scope = Scope;
                this.Imports = Imports;
                this.Unresolved = Unresolved;
                this.Comments = Comments;
            }

            // Enable comparisons between nil and File struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File value, NilType nil) => value.Equals(default(File));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator File(NilType nil) => default(File);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static File File_cast(dynamic value)
        {
            return new File(ref value.Doc, value.Package, ref value.Name, value.Decls, ref value.Scope, value.Imports, value.Unresolved, value.Comments);
        }
    }
}}