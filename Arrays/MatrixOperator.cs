﻿using System;

namespace Parcial3_Base
{
    public static class MatrixExtensions
    {
        public static void PrintMatrixValues(this int[,] matrix)
        {
            //Cómo se usa? matrix.PrintMatrixValues();
            //Siendo 'matrix' el nombre de la matriz

            matrix = null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix = null;
                }
            }
            else Console.WriteLine("matrix es valida");

            if (matrix != null)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.WriteLine(string.Format("[{0},{1}] = {2}", i, j, matrix[i, j]));
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrix is null");
            }
        }

        public static void PrintDimensions(this int[,] inputMatrix)
        {
            Console.WriteLine(string.Format("Matrix has dimension {0}x{1}", inputMatrix.GetLength(0), inputMatrix.GetLength(1)));
        }
    }

    internal class MatrixOperator
    {
        /// <summary>
        /// Suma las matrices parámetro.
        /// Valor del punto: 1.0 / 5.0
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns>La matriz suma</returns>
        public int[,] AddMatrix(int[,] matrixA, int[,] matrixB)
        {
            int[,] result = null;
            int[,] result = new int [,];
            if (matrixA.GetLength(0) == matrixB.GetLength(0) && matrixA.GetLenght(1) == matrixB.GetLenght(1))
            {
                for (int i = 0; int i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; int j < matrixB.GetLength(1); j++)
                    int[] result = int i + int j;
                }
            }
            else result = null;

            if (result != null)
            {
                result.PrintMatrixValues();
            }

            return result;
        }

        /// <summary>
        /// Multiplica una matriz por un escalar
        /// Valor del punto: 1.0/ 5.0
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="scalar"></param>
        /// <returns>La matriz producto por escalar</returns>
        public int[,] MultiplyMatrixByScalar(int[,] matrix, int scalar)
        {
            int[,] result = null;
            scalar = x;
            if (i = 0)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int[,] = 0;
                        result = null;
                    }
                }
            }
            else result != null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int[,] result = int [,] * scalar;
                }
            }
                    if (result != null)
            {
                result.PrintMatrixValues();
            }

            return result;
        }

        /// <summary>
        /// Multiplica dos matrices parámetro
        /// Valor del punto: 2.0 / 5.0
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns>La matriz producto</returns>
        public int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int[,] result = null;

            if (result != null)
            {
                result.PrintMatrixValues();
            }

            return result;
        }

        /// <summary>
        /// Mezcla los elementos de dos matrices parámetro
        /// Valor del punto: 1.0 / 5.0
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns>La matriz mezcla</returns>
        public int[,] MixMatrix(int[,] matrixA, int[,] matrixB)
        {
            /*
             * La operación ficticia 'mezcla' será definida así.
             * Sean dos matrices 'matrixA' y 'matrixB' de igual dimensión
             * La mezcla de esas matrices dará como resultado una matriz 'result'
             * Los elementos de 'result' seguirán la siguiente regla:
             * a. Un elemento de la diagonal será el producto de los elementos de 'matrixA' y 'matrixB' en esa posición
             * b. Cualquier elemento debajo de la diagonal será el elemento de 'matrixA' en esa posición
             * c. Cualquier elemento encima de la diagonal será el elemento de 'matrixB' en esa posición
             */

            int[,] result = null;
            int[;] result = new int[,];
            if (matrixA.GetLength(0) == matrixB.GetLength(0) && matrixA.GetLenght(1) == matrixB.GetLenght(1)) {
                if (int i = int j)
            {
                    for (int i = 0; i < matrixA.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrixB.GetLength(1); j++)
                        {
                            int[,] result = i * j;
                        }
                    }
                }
            else if (int i < int j) 
            {
                    for (int i = 0; i < matrixA.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrixB.GetLength(1); j++)
                        {
                            int[,] result = j;
                        }
                    }
                }
            else if (int i > int j)
            {
                    for (int i = 0; i < matrixA.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrixB.GetLength(1); j++)
                        {
                            int[,] result = i;
                        }
                    }
                }
            }
            if (result != null)
            {
                result.PrintMatrixValues();
            }

            return result;
        }
    }
}