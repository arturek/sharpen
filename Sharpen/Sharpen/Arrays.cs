namespace Sharpen
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	internal class Arrays
	{
		public static List<T> AsList<T> (params T[] array)
		{
			return array.ToList<T> ();
		}

		public static bool Equals<T> (T[] a1, T[] a2)
		{
			if (a1.Length != a2.Length) {
				return false;
			}
			for (int i = 0; i < a1.Length; i++) {
				if (!a1[i].Equals (a2[i])) {
					return false;
				}
			}
			return true;
		}

		public static void Fill<T> (T[] array, T val)
		{
			Fill<T> (array, 0, array.Length, val);
		}

		public static void Fill<T> (T[] array, int start, int end, T val)
		{
			for (int i = start; i < end; i++) {
				array[i] = val;
			}
		}

		public static void Sort (string[] array)
		{
			Array.Sort (array, (s1,s2) => string.CompareOrdinal (s1,s2));
		}

		public static void Sort<T> (T[] array)
		{
			Array.Sort<T> (array);
		}

		public static void Sort<T> (T[] array, IComparer<T> c)
		{
			Array.Sort<T> (array, c);
		}

		public static void Sort<T> (T[] array, int start, int count)
		{
			Array.Sort<T> (array, start, count);
		}

		public static void Sort<T> (T[] array, int start, int count, IComparer<T> c)
		{
			Array.Sort<T> (array, start, count, c);
		}

        public static T[][] Create<T>(int dim0, int dim1)
        {
            var array = new T[dim0][];
            for (var k0 = 0; k0 < dim0; ++k0) array[k0] = new T[dim1];
            return array;
        }

        public static T[][][] Create<T>(int dim0, int dim1, int dim2)
        {
            var array = new T[dim0][][];
            for (var k0 = 0; k0 < dim0; ++k0)
            {
                array[k0] = new T[dim1][];
                for (var k1 = 0; k1 < dim1; ++k1) array[k0][k1] = new T[dim2];
            }
            return array;
        }

        public static T[][][][] Create<T>(int dim0, int dim1, int dim2, int dim3)
        {
            var array = new T[dim0][][][];
            for (var k0 = 0; k0 < dim0; ++k0)
            {
                array[k0] = new T[dim1][][];
                for (var k1 = 0; k1 < dim1; ++k1)
                {
                    array[k0][k1] = new T[dim2][];
                    for (var k2 = 0; k2 < dim2; ++k2) array[k0][k1][k2] = new T[dim3];
                }
            }
            return array;
        }
    }
}
