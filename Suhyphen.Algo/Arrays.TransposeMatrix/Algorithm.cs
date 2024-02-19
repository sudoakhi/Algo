﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Arrays.TransposeMatrix
{
    public sealed class Algorithm
    {
        public static int[][] TransposeMatrix(int[][] matrix)
        {
            if(matrix != null)
            {
                var result = new int[matrix.GetLength(1)][];

                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        result[j][i] = matrix[i][j];
                    }
                }

                return result;
            }

            return null;
        }
    }
}
