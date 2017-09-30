/*
 * 
 */
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MutableTupleTests")]
namespace Ekstrand
{
    /// <summary>
    /// Helper so we can call some MTuple methods recursively without knowing the underlying types.
    /// </summary>
    internal interface ITuple
    {
        /// <summary>
        /// Returns a string that represents the value of this Mutable Tuple instance. 
        /// </summary>
        /// <param name="sb">StringBuilder object</param>
        /// <returns>The string representation of this Mutable Tuple object.</returns>
        string ToString(StringBuilder sb);
        /// <summary>
        /// Calculates the hash code for the current Mutable Tuple from its elements hash code value.
        /// </summary>
        /// <param name="comparer">An object whose GetHashCode method calculates the hash code of the current Mutable Tuple object.</param>
        /// <returns>A 32-bit signed integer hash code.</returns>
        int GetHashCode(IEqualityComparer comparer);
        /// <summary>
        /// Return Mutable Tuple number of elements. 
        /// </summary>
        int Size { get; }

    }

    /// <summary>
    /// Provides static methods for creating mutable tuple objects. 
    /// </summary>
    public static class MTuple
    {
        /// <summary>
        /// Creates a new 1-mutable tuple, or singleton.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1).</returns>
        public static MTuple<T1> Create<T1>(T1 item1)
        {
            return new MTuple<T1>(item1);
        }

        /// <summary>
        /// Creates a new 2-mutable tuple, or pair.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2).</returns>
        public static MTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
        {
            return new MTuple<T1, T2>(item1, item2);
        }

        /// <summary>
        /// Creates a new 3-mutable tuple, or triple.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T3">T3: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <param name="item3">Type T3: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2, item3).</returns>
        public static MTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new MTuple<T1, T2, T3>(item1, item2, item3);
        }

        /// <summary>
        /// Creates a new 4-mutable tuple, or quadruple.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T3">T3: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T4">T4: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <param name="item3">Type T3: The value of the only component of the mutable tuple.</param>
        /// <param name="item4">Type T4: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2, item3, item4).</returns>
        public static MTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            return new MTuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// Creates a new 5-mutable tuple, or quintuple.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T3">T3: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T4">T4: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T5">T5: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <param name="item3">Type T3: The value of the only component of the mutable tuple.</param>
        /// <param name="item4">Type T4: The value of the only component of the mutable tuple.</param>
        /// <param name="item5">Type T5: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2, item3, item4, item5).</returns>
        public static MTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new MTuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// Creates a new 6-mutable tuple, or sextuple.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T3">T3: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T4">T4: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T5">T5: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T6">T6: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <param name="item3">Type T3: The value of the only component of the mutable tuple.</param>
        /// <param name="item4">Type T4: The value of the only component of the mutable tuple.</param>
        /// <param name="item5">Type T5: The value of the only component of the mutable tuple.</param>
        /// <param name="item6">Type T6: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2, item3, item4, item5, item6).</returns>
        public static MTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new MTuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// Creates a new 7-mutable tuple, or septuple.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T3">T3: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T4">T4: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T5">T5: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T6">T6: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T7">T7: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <param name="item3">Type T3: The value of the only component of the mutable tuple.</param>
        /// <param name="item4">Type T4: The value of the only component of the mutable tuple.</param>
        /// <param name="item5">Type T5: The value of the only component of the mutable tuple.</param>
        /// <param name="item6">Type T6: The value of the only component of the mutable tuple.</param>
        /// <param name="item7">Type T7: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2, item3, item4, item5, item6, item7).</returns>
        public static MTuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new MTuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// Creates a new 8-mutable tuple, or octuple.
        /// </summary>
        /// <typeparam name="T1">T1: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T2">T2: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T3">T3: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T4">T4: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T5">T5: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T6">T6: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T7">T7: The type of the only component of the mutable tuple.</typeparam>
        /// <typeparam name="T8">T8: The type of the only component of the mutable tuple.</typeparam>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        /// <param name="item2">Type T2: The value of the only component of the mutable tuple.</param>
        /// <param name="item3">Type T3: The value of the only component of the mutable tuple.</param>
        /// <param name="item4">Type T4: The value of the only component of the mutable tuple.</param>
        /// <param name="item5">Type T5: The value of the only component of the mutable tuple.</param>
        /// <param name="item6">Type T6: The value of the only component of the mutable tuple.</param>
        /// <param name="item7">Type T7: The value of the only component of the mutable tuple.</param>
        /// <param name="item8">Type T8: The value of the only component of the mutable tuple.</param>
        /// <returns>A tuple whose value is (item1, item2, item3, item4, item5, item6, item7, item8).</returns>
        public static MTuple<T1, T2, T3, T4, T5, T6, T7, MTuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
        {
            return new MTuple<T1, T2, T3, T4, T5, T6, T7, MTuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new MTuple<T8>(item8));
        }

        #region Combine Hash Codes

        // From System.Web.Util.HashCodeCombiner
        /// <summary>
        /// HashCodeCombiner
        /// </summary>
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2)
        {
            return (((h1 << 5) + h1) ^ h2);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/HashCodeCombiner[@id="summary"]/*' />
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h3"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2, int h3)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2), h3);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/HashCodeCombiner[@id="summary"]/*' />
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h3"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h4"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2), CombineHashCodes(h3, h4));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/HashCodeCombiner[@id="summary"]/*' />
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h3"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h4"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h5"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), h5);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/HashCodeCombiner[@id="summary"]/*' />
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h3"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h4"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h5"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h6"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/HashCodeCombiner[@id="summary"]/*' />
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h3"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h4"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h5"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h6"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h7"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/HashCodeCombiner[@id="summary"]/*' />
        /// <param name="h1"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h2"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h3"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h4"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h5"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h6"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h7"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <param name="h8"><include file="..\Comments\commoncontent.xml" path='Comments/HashPramName/*' /></param>
        /// <returns><include file="..\Comments\commoncontent.xml" path='Comments/HashReturn/*' /></returns>
        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7, h8));
        }

        #endregion
    }

    /// <summary>
    /// Creates a new 1-mutable tuple, or singleton.
    /// </summary>
    /// <typeparam name="T1">The value of the only component of the mutable tuple.</typeparam>
    [Serializable]
    public class MTuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1>>, ITuple
    {

        private  T1 m_Item1;

        /// <summary>
        /// Gets/Sets the value of the Mutable Tuple object's single component.
        /// </summary>
        public T1 Item1
        {
            get { return m_Item1; }
            set { m_Item1 = value; }
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
        }

        /// <summary>
        /// Initializes a new instance of the Mutable Tuple&lt;T1&gt; class.
        /// </summary>
        /// <param name="item1">Type T1: The value of the only component of the mutable tuple.</param>
        public MTuple(T1 item1)
        {
            m_Item1 = item1;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1> objTuple = other as MTuple<T1>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc3/*" />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        int IComparable<MTuple<T1>>.CompareTo(MTuple<T1> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1> objTuple = other as MTuple<T1>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            return comparer.Compare(m_Item1, objTuple.m_Item1);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return comparer.GetHashCode(m_Item1);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(")");
            return sb.ToString();
        }


        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 1;
            }
        }
    }

    /// <summary>
    /// Creates a new 2-mutable tuple, or pair.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1,T2>>, ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;

 
        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }
        
        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        public MTuple(T1 item1, T2 item2)
        {
            m_Item1 = item1;
            m_Item2 = item2;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2> objTuple = other as MTuple<T1, T2>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2>>.CompareTo(MTuple<T1, T2> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2> objTuple = other as MTuple<T1, T2>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            return comparer.Compare(m_Item2, objTuple.m_Item2);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(")");
            return sb.ToString();
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 2;
            }
        }
    }

    /// <summary>
    /// Creates a new 3-mutable tuple, or triple.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    /// <typeparam name="T3"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT3/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1, T2, T3>>, ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;
        private  T3 m_Item3;

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT3/*' />
        public T3 Item3 { get { return m_Item3; } set { m_Item3 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2); 
            m_Item3 = default(T3); 
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        /// <param name="item3"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter3/*' /></param>
        public MTuple(T1 item1, T2 item2, T3 item3)
        {
            m_Item1 = item1;
            m_Item2 = item2;
            m_Item3 = item3;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2, T3> objTuple = other as MTuple<T1, T2, T3>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2) && comparer.Equals(m_Item3, objTuple.m_Item3);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2, T3>>.CompareTo(MTuple<T1, T2, T3> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2, T3> objTuple = other as MTuple<T1, T2, T3>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            c = comparer.Compare(m_Item2, objTuple.m_Item2);

            if (c != 0) return c;

            return comparer.Compare(m_Item3, objTuple.m_Item3);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(", ");
            sb.Append(m_Item3);
            sb.Append(")");
            return sb.ToString();
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 3;
            }
        }
    }

    /// <summary>
    /// Creates a new 4-mutable tuple, or quadruple.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    /// <typeparam name="T3"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT3/*' /></typeparam>
    /// <typeparam name="T4"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT4/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1, T2, T3, T4>> ,ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;
        private  T3 m_Item3;
        private  T4 m_Item4;

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT3/*' />
        public T3 Item3 { get { return m_Item3; } set { m_Item3 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT4/*' />
        public T4 Item4 { get { return m_Item4; } set { m_Item4 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2);
            m_Item3 = default(T3);
            m_Item4 = default(T4);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        /// <param name="item3"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter3/*' /></param>
        /// <param name="item4"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter4/*' /></param>
        public MTuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            m_Item1 = item1;
            m_Item2 = item2;
            m_Item3 = item3;
            m_Item4 = item4;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2, T3, T4> objTuple = other as MTuple<T1, T2, T3, T4>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2) && comparer.Equals(m_Item3, objTuple.m_Item3) && comparer.Equals(m_Item4, objTuple.m_Item4);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2, T3, T4>>.CompareTo(MTuple<T1, T2, T3, T4> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2, T3, T4> objTuple = other as MTuple<T1, T2, T3, T4>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            c = comparer.Compare(m_Item2, objTuple.m_Item2);

            if (c != 0) return c;

            c = comparer.Compare(m_Item3, objTuple.m_Item3);

            if (c != 0) return c;

            return comparer.Compare(m_Item4, objTuple.m_Item4);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(", ");
            sb.Append(m_Item3);
            sb.Append(", ");
            sb.Append(m_Item4);
            sb.Append(")");
            return sb.ToString();
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 4;
            }
        }
    }

    /// <summary>
    /// Creates a new 5-mutable tuple, or quintuple.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    /// <typeparam name="T3"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT3/*' /></typeparam>
    /// <typeparam name="T4"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT4/*' /></typeparam>
    /// <typeparam name="T5"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT5/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1, T2, T3, T4, T5>> ,ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;
        private  T3 m_Item3;
        private  T4 m_Item4;
        private  T5 m_Item5;

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT3/*' />
        public T3 Item3 { get { return m_Item3; } set { m_Item3 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT4/*' />
        public T4 Item4 { get { return m_Item4; } set { m_Item4 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT5/*' />
        public T5 Item5 { get { return m_Item5; } set { m_Item5 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2);
            m_Item3 = default(T3);
            m_Item4 = default(T4);
            m_Item5 = default(T5);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        /// <param name="item3"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter3/*' /></param>
        /// <param name="item4"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter4/*' /></param>
        /// <param name="item5"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter5/*' /></param>
        public MTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            m_Item1 = item1;
            m_Item2 = item2;
            m_Item3 = item3;
            m_Item4 = item4;
            m_Item5 = item5;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2, T3, T4, T5> objTuple = other as MTuple<T1, T2, T3, T4, T5>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2) && comparer.Equals(m_Item3, objTuple.m_Item3) && comparer.Equals(m_Item4, objTuple.m_Item4) && comparer.Equals(m_Item5, objTuple.m_Item5);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2, T3, T4, T5>>.CompareTo(MTuple<T1, T2, T3, T4, T5> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2, T3, T4, T5> objTuple = other as MTuple<T1, T2, T3, T4, T5>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            c = comparer.Compare(m_Item2, objTuple.m_Item2);

            if (c != 0) return c;

            c = comparer.Compare(m_Item3, objTuple.m_Item3);

            if (c != 0) return c;

            c = comparer.Compare(m_Item4, objTuple.m_Item4);

            if (c != 0) return c;

            return comparer.Compare(m_Item5, objTuple.m_Item5);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(", ");
            sb.Append(m_Item3);
            sb.Append(", ");
            sb.Append(m_Item4);
            sb.Append(", ");
            sb.Append(m_Item5);
            sb.Append(")");
            return sb.ToString();
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 5;
            }
        }
    }

    /// <summary>
    /// Creates a new 6-mutable tuple, or sextuple.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    /// <typeparam name="T3"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT3/*' /></typeparam>
    /// <typeparam name="T4"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT4/*' /></typeparam>
    /// <typeparam name="T5"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT5/*' /></typeparam>
    /// <typeparam name="T6"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT6/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1, T2, T3, T4, T5, T6>> ,ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;
        private  T3 m_Item3;
        private  T4 m_Item4;
        private  T5 m_Item5;
        private  T6 m_Item6;

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT3/*' />
        public T3 Item3 { get { return m_Item3; } set { m_Item3 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT4/*' />
        public T4 Item4 { get { return m_Item4; } set { m_Item4 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT5/*' />
        public T5 Item5 { get { return m_Item5; } set { m_Item5 = value; } }
        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT6/*' />
        public T6 Item6 { get { return m_Item6; } set { m_Item6 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2);
            m_Item3 = default(T3);
            m_Item4 = default(T4);
            m_Item5 = default(T5);
            m_Item6 = default(T6);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        /// <param name="item3"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter3/*' /></param>
        /// <param name="item4"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter4/*' /></param>
        /// <param name="item5"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter5/*' /></param>
        /// <param name="item6"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter6/*' /></param>
        public MTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            m_Item1 = item1;
            m_Item2 = item2;
            m_Item3 = item3;
            m_Item4 = item4;
            m_Item5 = item5;
            m_Item6 = item6;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2, T3, T4, T5, T6> objTuple = other as MTuple<T1, T2, T3, T4, T5, T6>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2) && comparer.Equals(m_Item3, objTuple.m_Item3) && comparer.Equals(m_Item4, objTuple.m_Item4) && comparer.Equals(m_Item5, objTuple.m_Item5) && comparer.Equals(m_Item6, objTuple.m_Item6);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2, T3, T4, T5, T6>>.CompareTo(MTuple<T1, T2, T3, T4, T5, T6> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2, T3, T4, T5, T6> objTuple = other as MTuple<T1, T2, T3, T4, T5, T6>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            c = comparer.Compare(m_Item2, objTuple.m_Item2);

            if (c != 0) return c;

            c = comparer.Compare(m_Item3, objTuple.m_Item3);

            if (c != 0) return c;

            c = comparer.Compare(m_Item4, objTuple.m_Item4);

            if (c != 0) return c;

            c = comparer.Compare(m_Item5, objTuple.m_Item5);

            if (c != 0) return c;

            return comparer.Compare(m_Item6, objTuple.m_Item6);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(", ");
            sb.Append(m_Item3);
            sb.Append(", ");
            sb.Append(m_Item4);
            sb.Append(", ");
            sb.Append(m_Item5);
            sb.Append(", ");
            sb.Append(m_Item6);
            sb.Append(")");
            return sb.ToString();
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 6;
            }
        }
    }

    /// <summary>
    /// Creates a new 7-mutable tuple, or septuple.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    /// <typeparam name="T3"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT3/*' /></typeparam>
    /// <typeparam name="T4"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT4/*' /></typeparam>
    /// <typeparam name="T5"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT5/*' /></typeparam>
    /// <typeparam name="T6"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT6/*' /></typeparam>
    /// <typeparam name="T7"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT7/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1, T2, T3, T4, T5, T6, T7>> ,ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;
        private  T3 m_Item3;
        private  T4 m_Item4;
        private  T5 m_Item5;
        private  T6 m_Item6;
        private  T7 m_Item7;

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT3/*' />
        public T3 Item3 { get { return m_Item3; } set { m_Item3 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT4/*' />
        public T4 Item4 { get { return m_Item4; } set { m_Item4 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT5/*' />
        public T5 Item5 { get { return m_Item5; } set { m_Item5 = value; } }
        
        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT6/*' />
        public T6 Item6 { get { return m_Item6; } set { m_Item6 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT7/*' />
        public T7 Item7 { get { return m_Item7; } set { m_Item7 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2);
            m_Item3 = default(T3);
            m_Item4 = default(T4);
            m_Item5 = default(T5);
            m_Item6 = default(T6);
            m_Item7 = default(T7);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        /// <param name="item3"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter3/*' /></param>
        /// <param name="item4"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter4/*' /></param>
        /// <param name="item5"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter5/*' /></param>
        /// <param name="item6"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter6/*' /></param>
        /// <param name="item7"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter7/*' /></param>
        public MTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            m_Item1 = item1;
            m_Item2 = item2;
            m_Item3 = item3;
            m_Item4 = item4;
            m_Item5 = item5;
            m_Item6 = item6;
            m_Item7 = item7;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2, T3, T4, T5, T6, T7> objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2) && comparer.Equals(m_Item3, objTuple.m_Item3) && comparer.Equals(m_Item4, objTuple.m_Item4) && comparer.Equals(m_Item5, objTuple.m_Item5) && comparer.Equals(m_Item6, objTuple.m_Item6) && comparer.Equals(m_Item7, objTuple.m_Item7);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2, T3, T4, T5, T6, T7>>.CompareTo(MTuple<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2, T3, T4, T5, T6, T7> objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            c = comparer.Compare(m_Item2, objTuple.m_Item2);

            if (c != 0) return c;

            c = comparer.Compare(m_Item3, objTuple.m_Item3);

            if (c != 0) return c;

            c = comparer.Compare(m_Item4, objTuple.m_Item4);

            if (c != 0) return c;

            c = comparer.Compare(m_Item5, objTuple.m_Item5);

            if (c != 0) return c;

            c = comparer.Compare(m_Item6, objTuple.m_Item6);

            if (c != 0) return c;

            return comparer.Compare(m_Item7, objTuple.m_Item7);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7));
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(", ");
            sb.Append(m_Item3);
            sb.Append(", ");
            sb.Append(m_Item4);
            sb.Append(", ");
            sb.Append(m_Item5);
            sb.Append(", ");
            sb.Append(m_Item6);
            sb.Append(", ");
            sb.Append(m_Item7);
            sb.Append(")");
            return sb.ToString();
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {
                return 7;
            }
        }
    }

    /// <summary>
    /// Creates a new 8-mutable tuple, or octuple.
    /// </summary>
    /// <typeparam name="T1"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT1/*' /></typeparam>
    /// <typeparam name="T2"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT2/*' /></typeparam>
    /// <typeparam name="T3"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT3/*' /></typeparam>
    /// <typeparam name="T4"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT4/*' /></typeparam>
    /// <typeparam name="T5"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT5/*' /></typeparam>
    /// <typeparam name="T6"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT6/*' /></typeparam>
    /// <typeparam name="T7"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT7/*' /></typeparam>
    /// <typeparam name="TRest"><include file="..\Comments\commoncontent.xml" path='Comments/typeparamT8/*' /></typeparam>
    [Serializable]
    public class MTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, IComparable<MTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> ,ITuple
    {

        private  T1 m_Item1;
        private  T2 m_Item2;
        private  T3 m_Item3;
        private  T4 m_Item4;
        private  T5 m_Item5;
        private  T6 m_Item6;
        private  T7 m_Item7;
        private  TRest m_Rest;

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT1/*' />
        public T1 Item1 { get { return m_Item1; } set { m_Item1 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT2/*' />
        public T2 Item2 { get { return m_Item2; } set { m_Item2 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT3/*' />
        public T3 Item3 { get { return m_Item3; } set { m_Item3 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT4/*' />
        public T4 Item4 { get { return m_Item4; } set { m_Item4 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT5/*' />
        public T5 Item5 { get { return m_Item5; } set { m_Item5 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT6/*' />
        public T6 Item6 { get { return m_Item6; } set { m_Item6 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT7/*' />
        public T7 Item7 { get { return m_Item7; } set { m_Item7 = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetSetT8/*' />
        public TRest Rest { get { return m_Rest; } set { m_Rest = value; } }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/BaseConstructor/*' />
        public MTuple()
        {
            m_Item1 = default(T1);
            m_Item2 = default(T2);
            m_Item3 = default(T3);
            m_Item4 = default(T4);
            m_Item5 = default(T5);
            m_Item6 = default(T6);
            m_Item7 = default(T7);
            m_Rest = default(TRest);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ConstructorWithParametrs/*' />
        /// <param name="item1"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter1/*' /></param>
        /// <param name="item2"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter2/*' /></param>
        /// <param name="item3"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter3/*' /></param>
        /// <param name="item4"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter4/*' /></param>
        /// <param name="item5"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter5/*' /></param>
        /// <param name="item6"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter6/*' /></param>
        /// <param name="item7"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter7/*' /></param>
        /// <param name="rest"><include file="..\Comments\commoncontent.xml" path='Comments/ConParameter8/*' /></param>
        public MTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
        {
            if (!(rest is ITuple))
            {
                throw new ArgumentException("ArgumentException Tuple Last Argument Not A Tuple");
            }

            m_Item1 = item1;
            m_Item2 = item2;
            m_Item3 = item3;
            m_Item4 = item4;
            m_Item5 = item5;
            m_Item6 = item6;
            m_Item7 = item7;
            m_Rest = rest;
        }

        ///<include file = "..\Comments\commoncontent.xml" path='Comments/Equals/*' />
        public override Boolean Equals(Object obj)
        {
            return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<Object>.Default); ;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatable/*' />
        Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
        {
            if (other == null) return false;

            MTuple<T1, T2, T3, T4, T5, T6, T7, TRest> objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7, TRest>;

            if (objTuple == null)
            {
                return false;
            }

            return comparer.Equals(m_Item1, objTuple.m_Item1) && comparer.Equals(m_Item2, objTuple.m_Item2) && comparer.Equals(m_Item3, objTuple.m_Item3) && comparer.Equals(m_Item4, objTuple.m_Item4) && comparer.Equals(m_Item5, objTuple.m_Item5) && comparer.Equals(m_Item6, objTuple.m_Item6) && comparer.Equals(m_Item7, objTuple.m_Item7) && comparer.Equals(m_Rest, objTuple.m_Rest);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path='Comments/CompleteDoc3/*' />
        Int32 IComparable.CompareTo(Object obj)
        {
            return ((IStructuralComparable)this).CompareTo(obj, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompairTo4/*" />
        Int32 IComparable<MTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.CompareTo(MTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
        {
            return ((IStructuralComparable)this).CompareTo(other, Comparer<Object>.Default);
        }

        /// <include file="..\Comments\CompareToMethod.xml" path="Comments/CompleteDoc2/*" />
        Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
        {
            if (other == null) return 1;

            MTuple<T1, T2, T3, T4, T5, T6, T7, TRest> objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7, TRest>;

            if (objTuple == null)
            {
                throw new ArgumentException("ArgumentException_TupleIncorrectType", this.GetType().ToString());
            }

            int c = 0;

            c = comparer.Compare(m_Item1, objTuple.m_Item1);

            if (c != 0) return c;

            c = comparer.Compare(m_Item2, objTuple.m_Item2);

            if (c != 0) return c;

            c = comparer.Compare(m_Item3, objTuple.m_Item3);

            if (c != 0) return c;

            c = comparer.Compare(m_Item4, objTuple.m_Item4);

            if (c != 0) return c;

            c = comparer.Compare(m_Item5, objTuple.m_Item5);

            if (c != 0) return c;

            c = comparer.Compare(m_Item6, objTuple.m_Item6);

            if (c != 0) return c;

            c = comparer.Compare(m_Item7, objTuple.m_Item7);

            if (c != 0) return c;

            return comparer.Compare(m_Rest, objTuple.m_Rest);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/GetHashCode/*' />
        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<Object>.Default);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/IStructuralEquatableGetHashCode/*' />
        Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            // We want to have a limited hash in this case.  We'll use the last 8 elements of the MTuple
            ITuple t = (ITuple)m_Rest;
            if (t.Size >= 8) { return t.GetHashCode(comparer); }

            // In this case, the rest member has less than 8 elements so we need to combine some our elements with the elements in rest
            int k = 8 - t.Size;
            switch (k)
            {
                case 1:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
                case 2:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
                case 3:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
                case 4:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
                case 5:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
                case 6:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
                case 7:
                    return MTuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), t.GetHashCode(comparer));
            }
            Contract.Assert(false, "Missed all cases for computing MTuple hash code");
            return -1;
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleGetHashCode/*' />
        Int32 ITuple.GetHashCode(IEqualityComparer comparer)
        {
            return ((IStructuralEquatable)this).GetHashCode(comparer);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ToString/*' />
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            return ((ITuple)this).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleToString/*' />
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(m_Item1);
            sb.Append(", ");
            sb.Append(m_Item2);
            sb.Append(", ");
            sb.Append(m_Item3);
            sb.Append(", ");
            sb.Append(m_Item4);
            sb.Append(", ");
            sb.Append(m_Item5);
            sb.Append(", ");
            sb.Append(m_Item6);
            sb.Append(", ");
            sb.Append(m_Item7);
            sb.Append(", ");
            return ((ITuple)m_Rest).ToString(sb);
        }

        /// <include file="..\Comments\commoncontent.xml" path='Comments/ITupleSize/*' />
        int ITuple.Size
        {
            get
            {               
                return 7 + ((ITuple)m_Rest).Size;
            }
        }
    }
}
