//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 June 21 12:35:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct T2
        {
            public T2(NilType _)
            {
                // Field instance values
                //public DateTime When;
                //public string What = ""; <- string initialized to empty
                // Inherited interface initializations (set to null / default)
                // Inherited structure initializations
            }

            // Only include constructor if struct contains fields
            //public T2(params)
            //{
            //    this.Field = Field,
            //    // Inherited interface initializations
            //    // Inherited structure initializations
            //}

            // Enable comparisons between nil and T2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T2 value, NilType nil) => value.Equals(default(T2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T2(NilType nil) => default(T2);
        }
    }
}