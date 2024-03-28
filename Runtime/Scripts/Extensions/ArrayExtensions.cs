using UnityEngine;

namespace HHG.Common.Runtime
{
    public static class ArrayExtensions
    {
        public static T GetRandom<T>(this T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }

        public static T[] RotatedClockwise<T>(this T[] array, int rows, int cols, int rotation = 1)
        {
            T[] source = new T[array.Length];
            T[] destination = new T[array.Length];

            System.Array.Copy(array, source, rows * cols);
            System.Array.Copy(array, destination, rows * cols);

            for (int interation = 0; interation < rotation; interation++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        destination[j * rows + (rows - 1 - i)] = source[i * cols + j];
                    }
                }
                System.Array.Copy(destination, source, rows * cols);
            }

            return destination;
        }

        public static T[] RotatedCounterclockwise<T>(this T[] array, int rows, int cols, int rotation = 1)
        {
            T[] source = new T[array.Length];
            T[] destination = new T[array.Length];

            System.Array.Copy(array, source, rows * cols);
            System.Array.Copy(array, destination, rows * cols);

            for (int interation = 0; interation < rotation; interation++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        destination[(cols - 1 - j) * rows + i] = source[i * cols + j];
                    }
                }
                System.Array.Copy(destination, source, rows * cols);
            }

            return destination;
        }
    }
}