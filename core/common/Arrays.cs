using System;

namespace Jauch.Tools.Common
{
	public static class Arrays
    {
        #region INITIALIZATION
        public static void InitializeArray (ref double[] array, double value = 0.0d)
		{
			for (int i = 0; i < array.Length; i++)
				array [i] = value;
		}

		public static void InitializeArray (ref float[] array, float value = 0.0f)
		{
			for (int i = 0; i < array.Length; i++)
				array [i] = value;
		}

		public static void InitializeArray (ref int[] array, int value = 0)
		{
			for (int i = 0; i < array.Length; i++)
				array [i] = value;
		}

		public static void InitializeArray (ref double[,] array, double value = 0.0d)
		{
			for (int i = 0; i < array.GetLength (0); i++)
				for (int j = 0; j < array.GetLength (1); j++)
					array [i, j] = value;
		}

		public static void InitializeArray (ref float[,] array, float value = 0.0f)
		{
			for (int i = 0; i < array.GetLength (0); i++)
				for (int j = 0; j < array.GetLength (1); j++)
					array [i, j] = value;
		}

		public static void InitializeArray (ref int[,] array, int value = 0)
		{
			for (int i = 0; i < array.GetLength (0); i++)
				for (int j = 0; j < array.GetLength (1); j++)
					array [i, j] = value;
		}

		public static void InitializeArray (ref double[,,] array, double value = 0.0d)
		{
			for (int i = 0; i < array.GetLength (0); i++)
				for (int j = 0; j < array.GetLength (1); j++)
					for (int k = 0; k < array.GetLength (2); k++)
						array [i, j, k] = value;
		}

		public static void InitializeArray (ref float[,,] array, float value = 0.0f)
		{
			for (int i = 0; i < array.GetLength (0); i++)
				for (int j = 0; j < array.GetLength (1); j++)
					for (int k = 0; k < array.GetLength (2); k++)
						array [i, j, k] = value;
		}

		public static void InitializeArray (ref int[,,] array, int value = 0)
		{
			for (int i = 0; i < array.GetLength (0); i++)
				for (int j = 0; j < array.GetLength (1); j++)
					for (int k = 0; k < array.GetLength (2); k++)
						array [i, j, k] = value;
		}

//----

        public static void InitializeArray(ref double[] array,  int[] mapping, double value = 0.0d, double fillValue = -99.0)
        {
            for (int i = 0; i < array.Length; i++)
                if (mapping == null || mapping[i] == 1)
                    array[i] = value;
                else
                    array[i] = fillValue;
        }

        public static void InitializeArray(ref float[] array, int[] mapping, float value = 0.0f, float fillValue = -99.0f)
        {
            for (int i = 0; i < array.Length; i++)
                if (mapping == null || mapping[i] == 1)
                    array[i] = value;
                else
                    array[i] = fillValue;
        }

        public static void InitializeArray(ref int[] array, int[] mapping, int value = 0, int fillValue = -99)
        {
            for (int i = 0; i < array.Length; i++)
                if (mapping == null || mapping[i] == 1)
                    array[i] = value;
                else
                    array[i] = fillValue;
        }

        public static void InitializeArray(ref double[,] array, int[,] mapping, double value = 0.0d, double fillValue = -99.0)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (mapping == null || mapping[i, j] == 1)
                        array[i, j] = value;
                    else
                        array[i, j] = fillValue;
        }

        public static void InitializeArray(ref float[,] array, int[,] mapping, float value = 0.0f, float fillValue = -99.0f)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (mapping == null || mapping[i, j] == 1)
                        array[i, j] = value;
                    else
                        array[i, j] = fillValue;
        }

        public static void InitializeArray(ref int[,] array, int[,] mapping, int value = 0, int fillValue = -99)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (mapping == null || mapping[i, j] == 1)
                        array[i, j] = value;
                    else
                        array[i, j] = fillValue;
        }

        public static void InitializeArray(ref double[, ,] array, int[,,] mapping, double value = 0.0d, double fillValue = -99.0)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        if (mapping == null || mapping[i, j, k] == 1)
                            array[i, j, k] = value;
                        else
                            array[i, j, k] = fillValue;
        }

        public static void InitializeArray(ref float[, ,] array, int[,,] mapping, float value = 0.0f, float fillValue = -99.0f)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        if (mapping == null || mapping[i, j, k] == 1)
                            array[i, j, k] = value;
                        else
                            array[i, j, k] = fillValue;
        }

        public static void InitializeArray(ref int[, ,] array, int[,,] mapping, int value = 0, int fillValue = -99)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        if (mapping == null || mapping[i, j, k] == 1)
                            array[i, j, k] = value;
                        else
                            array[i, j, k] = fillValue;
        }

        #endregion INITIALIZATION

        #region CONVERSION        

        public static float[] ToFloat(int[] toConvert)
        {
            float[] newArray = new float[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (float)(toConvert[i]);
            return newArray;
        }

        public static float[] ToFloat(float[] toConvert)
        {
            float[] newArray = new float[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (float)(toConvert[i]);
            return newArray;
        }

        public static float[] ToFloat(double[] toConvert)
        {
            float[] newArray = new float[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (float)(toConvert[i]);
            return newArray;
        }

        public static float[,] ToFloat(int[,] toConvert)
        {
            float[,] newArray = new float[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                newArray[i, j] = (float)(toConvert[i, j]);
            return newArray;
        }

        public static float[,] ToFloat(float[,] toConvert)
        {
            float[,] newArray = new float[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                newArray[i, j] = (float)(toConvert[i, j]);
            return newArray;
        }

        public static float[,] ToFloat(double[,] toConvert)
        {
            float[,] newArray = new float[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                newArray[i, j] = (float)(toConvert[i, j]);
            return newArray;
        }

        public static float[, ,] ToFloat(int[, ,] toConvert)
        {
            float[,,] newArray = new float[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (float)(toConvert[i, j, k]);
            return newArray;
        }

        public static float[, ,] ToFloat(float[, ,] toConvert)
        {
            float[, ,] newArray = new float[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (float)(toConvert[i, j, k]);
            return newArray;
        }

        public static float[, ,] ToFloat(double[, ,] toConvert)
        {
            float[, ,] newArray = new float[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (float)(toConvert[i, j, k]);
            return newArray;
        }

        //=========

        public static double[] ToDouble(int[] toConvert)
        {
            double[] newArray = new double[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (double)(toConvert[i]);
            return newArray;
        }

        public static double[] ToDouble(float[] toConvert)
        {
            double[] newArray = new double[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (double)(toConvert[i]);
            return newArray;
        }

        public static double[] ToDouble(double[] toConvert)
        {
            double[] newArray = new double[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (double)(toConvert[i]);
            return newArray;
        }

        public static double[,] ToDouble(int[,] toConvert)
        {
            double[,] newArray = new double[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    newArray[i, j] = (double)(toConvert[i, j]);
            return newArray;
        }

        public static double[,] ToDouble(float[,] toConvert)
        {
            double[,] newArray = new double[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    newArray[i, j] = (double)(toConvert[i, j]);
            return newArray;
        }

        public static double[,] ToDouble(double[,] toConvert)
        {
            double[,] newArray = new double[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    newArray[i, j] = (double)(toConvert[i, j]);
            return newArray;
        }

        public static double[, ,] ToDouble(int[, ,] toConvert)
        {
            double[, ,] newArray = new double[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (double)(toConvert[i, j, k]);
            return newArray;
        }

        public static double[, ,] ToDouble(float[, ,] toConvert)
        {
            double[, ,] newArray = new double[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (double)(toConvert[i, j, k]);
            return newArray;
        }

        public static double[, ,] ToDouble(double[, ,] toConvert)
        {
            double[, ,] newArray = new double[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (double)(toConvert[i, j, k]);
            return newArray;
        }


        //=========

        public static int[] ToInt(int[] toConvert)
        {
            int[] newArray = new int[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (int)(toConvert[i]);
            return newArray;
        }

        public static int[] ToInt(float[] toConvert)
        {
            int[] newArray = new int[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (int)(toConvert[i]);
            return newArray;
        }

        public static int[] ToInt(double[] toConvert)
        {
            int[] newArray = new int[toConvert.GetLength(0)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                newArray[i] = (int)(toConvert[i]);
            return newArray;
        }

        public static int[,] ToInt(int[,] toConvert)
        {
            int[,] newArray = new int[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    newArray[i, j] = (int)(toConvert[i, j]);
            return newArray;
        }

        public static int[,] ToInt(float[,] toConvert)
        {
            int[,] newArray = new int[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    newArray[i, j] = (int)(toConvert[i, j]);
            return newArray;
        }

        public static int[,] ToInt(double[,] toConvert)
        {
            int[,] newArray = new int[toConvert.GetLength(0), toConvert.GetLength(1)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    newArray[i, j] = (int)(toConvert[i, j]);
            return newArray;
        }

        public static int[, ,] ToInt(int[, ,] toConvert)
        {
            int[, ,] newArray = new int[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (int)(toConvert[i, j, k]);
            return newArray;
        }

        public static int[, ,] ToInt(float[, ,] toConvert)
        {
            int[, ,] newArray = new int[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (int)(toConvert[i, j, k]);
            return newArray;
        }

        public static int[, ,] ToInt(double[, ,] toConvert)
        {
            int[, ,] newArray = new int[toConvert.GetLength(0), toConvert.GetLength(1), toConvert.GetLength(2)];
            for (int i = 0; i < toConvert.GetLength(0); i++)
                for (int j = 0; j < toConvert.GetLength(1); j++)
                    for (int k = 0; k < toConvert.GetLength(2); k++)
                        newArray[i, j, k] = (int)(toConvert[i, j, k]);
            return newArray;
        }
        #endregion CONVERSION
    }
}

