//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface Sockaddr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sockaddr As<T>(in T target) => (Sockaddr<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sockaddr As<T>(ptr<T> target_ptr) => (Sockaddr<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static Sockaddr? As(object target) =>
                typeof(Sockaddr<>).CreateInterfaceHandler<Sockaddr>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class Sockaddr<T> : Sockaddr
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

            public Sockaddr(in T target) => m_target = target;

            public Sockaddr(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void copyByRef(ref T value);
            private delegate void copyByVal(T value);

            private static readonly copyByRef s_copyByRef;
            private static readonly copyByVal s_copyByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void copy()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_copyByRef is null)
                {
                    s_copyByVal!(target);
                    return;
                }

                s_copyByRef(ref target);
                return;
                
            }

            private delegate void keyByRef(ref T value);
            private delegate void keyByVal(T value);

            private static readonly keyByRef s_keyByRef;
            private static readonly keyByVal s_keyByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void key()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.Value;
                if (s_keyByRef is null)
                {
                    s_keyByVal!(target);
                    return;
                }

                s_keyByRef(ref target);
                return;
                
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static Sockaddr()
            {
                Type targetType = typeof(T);
                Type targetTypeByRef = targetType.MakeByRefType();
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByRef.GetExtensionMethod("copy");

                if (!(extensionMethod is null))
                    s_copyByRef = extensionMethod.CreateStaticDelegate(typeof(copyByRef)) as copyByRef;

                if (s_copyByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("copy");

                    if (!(extensionMethod is null))
                        s_copyByVal = extensionMethod.CreateStaticDelegate(typeof(copyByVal)) as copyByVal;
                }

                if (s_copyByRef is null && s_copyByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sockaddr.copy method", new Exception("copy"));

               extensionMethod = targetTypeByRef.GetExtensionMethod("key");

                if (!(extensionMethod is null))
                    s_keyByRef = extensionMethod.CreateStaticDelegate(typeof(keyByRef)) as keyByRef;

                if (s_keyByRef is null)
                {
                    extensionMethod = targetType.GetExtensionMethod("key");

                    if (!(extensionMethod is null))
                        s_keyByVal = extensionMethod.CreateStaticDelegate(typeof(keyByVal)) as keyByVal;
                }

                if (s_keyByRef is null && s_keyByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement Sockaddr.key method", new Exception("key"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sockaddr<T>(in ptr<T> target_ptr) => new Sockaddr<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator Sockaddr<T>(in T target) => new Sockaddr<T>(target);

            // Enable comparisons between nil and Sockaddr<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sockaddr<T> value, NilType nil) => Activator.CreateInstance<Sockaddr<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sockaddr<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sockaddr<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sockaddr<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class syscall_SockaddrExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.syscall_package.Sockaddr target)
        {
            try
            {
                return ((go.syscall_package.Sockaddr<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.syscall_package.Sockaddr target, out T result)
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
        public static object? _(this go.syscall_package.Sockaddr target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.syscall_package.Sockaddr<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.syscall_package.Sockaddr target, Type type, out object? result)
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