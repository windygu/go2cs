//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using mime = go.mime_package;
using multipart = go.mime.multipart_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#pragma warning disable CS0660, CS0661

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface File
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static File As<T>(in T target) => (File<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static File As<T>(ptr<T> target_ptr) => (File<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static File? As(object target) =>
                typeof(File<>).CreateInterfaceHandler<File>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class File<T> : File
        {
            private T m_target;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.Value;

                    return ref m_target;
                }
            }

            public File(in T target) => m_target = target;

            public File(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate (os.FileInfo, error) ReaddirByRef(ref T value, long count);
            private delegate (os.FileInfo, error) ReaddirByVal(T value, long count);

            private static readonly ReaddirByRef s_ReaddirByRef;
            private static readonly ReaddirByVal s_ReaddirByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (os.FileInfo, error) Readdir(long count)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReaddirByRef is null)
                    return s_ReaddirByVal!(target, count);

                return s_ReaddirByRef(ref target, count);
            }

            private delegate (os.FileInfo, error) StatByRef(ref T value);
            private delegate (os.FileInfo, error) StatByVal(T value);

            private static readonly StatByRef s_StatByRef;
            private static readonly StatByVal s_StatByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (os.FileInfo, error) Stat()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_StatByRef is null)
                    return s_StatByVal!(target);

                return s_StatByRef(ref target);
            }

            private delegate error CloseByRef(ref T value);
            private delegate error CloseByVal(T value);

            private static readonly CloseByRef s_CloseByRef;
            private static readonly CloseByVal s_CloseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public error Close()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_CloseByRef is null)
                    return s_CloseByVal!(target);

                return s_CloseByRef(ref target);
            }

            private delegate (long, error) ReadByRef(ref T value, slice<byte> p);
            private delegate (long, error) ReadByVal(T value, slice<byte> p);

            private static readonly ReadByRef s_ReadByRef;
            private static readonly ReadByVal s_ReadByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Read(slice<byte> p)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_ReadByRef is null)
                    return s_ReadByVal!(target, p);

                return s_ReadByRef(ref target, p);
            }

            private delegate (long, error) SeekByRef(ref T value, long offset, long whence);
            private delegate (long, error) SeekByVal(T value, long offset, long whence);

            private static readonly SeekByRef s_SeekByRef;
            private static readonly SeekByVal s_SeekByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public (long, error) Seek(long offset, long whence)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_SeekByRef is null)
                    return s_SeekByVal!(target, offset, whence);

                return s_SeekByRef(ref target, offset, whence);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static File()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("Readdir");

                if (!(extensionMethod is null))
                    s_ReaddirByRef = extensionMethod.CreateStaticDelegate(typeof(ReaddirByRef)) as ReaddirByRef;

                if (s_ReaddirByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Readdir");

                    if (!(extensionMethod is null))
                        s_ReaddirByVal = extensionMethod.CreateStaticDelegate(typeof(ReaddirByVal)) as ReaddirByVal;
                }

                if (s_ReaddirByRef is null && s_ReaddirByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Readdir method", new Exception("Readdir"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Stat");

                if (!(extensionMethod is null))
                    s_StatByRef = extensionMethod.CreateStaticDelegate(typeof(StatByRef)) as StatByRef;

                if (s_StatByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Stat");

                    if (!(extensionMethod is null))
                        s_StatByVal = extensionMethod.CreateStaticDelegate(typeof(StatByVal)) as StatByVal;
                }

                if (s_StatByRef is null && s_StatByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Stat method", new Exception("Stat"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Close");

                if (!(extensionMethod is null))
                    s_CloseByRef = extensionMethod.CreateStaticDelegate(typeof(CloseByRef)) as CloseByRef;

                if (s_CloseByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Close");

                    if (!(extensionMethod is null))
                        s_CloseByVal = extensionMethod.CreateStaticDelegate(typeof(CloseByVal)) as CloseByVal;
                }

                if (s_CloseByRef is null && s_CloseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Close method", new Exception("Close"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Read");

                if (!(extensionMethod is null))
                    s_ReadByRef = extensionMethod.CreateStaticDelegate(typeof(ReadByRef)) as ReadByRef;

                if (s_ReadByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Read");

                    if (!(extensionMethod is null))
                        s_ReadByVal = extensionMethod.CreateStaticDelegate(typeof(ReadByVal)) as ReadByVal;
                }

                if (s_ReadByRef is null && s_ReadByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Read method", new Exception("Read"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("Seek");

                if (!(extensionMethod is null))
                    s_SeekByRef = extensionMethod.CreateStaticDelegate(typeof(SeekByRef)) as SeekByRef;

                if (s_SeekByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("Seek");

                    if (!(extensionMethod is null))
                        s_SeekByVal = extensionMethod.CreateStaticDelegate(typeof(SeekByVal)) as SeekByVal;
                }

                if (s_SeekByRef is null && s_SeekByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement File.Seek method", new Exception("Seek"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator File<T>(in ptr<T> target_ptr) => new File<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator File<T>(in T target) => new File<T>(target);

            // Enable comparisons between nil and File<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File<T> value, NilType nil) => Activator.CreateInstance<File<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File<T> value) => value != nil;
        }
    }
}}

namespace go
{
    public static class http_FileExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.net.http_package.File target)
        {
            try
            {
                return ((go.net.http_package.File<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.net.http_package.File target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.net.http_package.File target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.net.http_package.File<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.net.http_package.File target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}