using System;

//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding,
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

namespace _06.Matrix_class
{
    class Matrix
    {
        private int[,] matrix;
        public Matrix(int height, int width)
        {
            this.matrix = new int[height, width];
        }

        public int GetHeight()
        {
            return matrix.GetLength(0);
        }

        public int GetWidth()
        {
            return matrix.GetLength(1);
        }

        public int this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if ((m1.GetHeight() != m2.GetHeight()) || (m1.GetWidth() != m2.GetWidth()))
            {
                throw new ArgumentException("Matrices not the same size!");
            }

            Matrix result = new Matrix(m1.GetHeight(), m1.GetWidth());

            for (int i = 0; i < result.GetHeight(); i++)
            {
                for (int j = 0; j < result.GetWidth(); j++)
                {
                    result[i, j] = m1[i,j] + m2[i,j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if ((m1.GetHeight() != m2.GetHeight()) || (m1.GetWidth() != m2.GetWidth()))
            {
                throw new ArgumentException("Matrices not the same size!");
            }

            Matrix result = new Matrix(m1.GetHeight(), m1.GetWidth());

            for (int i = 0; i < result.GetHeight(); i++)
            {
                for (int j = 0; j < result.GetWidth(); j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.GetWidth() != m2.GetHeight())
            {
                throw new ArgumentException("Matrices not the correct size!");
            }

            Matrix result = new Matrix(m1.GetHeight(), m2.GetWidth());

            int res = 0;

            for (int i = 0; i < result.GetHeight(); i++)
            {
                for (int j = 0; j < result.GetWidth(); j++)
                {
                    for (int k = 0; k < result.GetWidth(); k++)
                    {
                        res = res + m1[i,k] * m2[k,j];
                    }
                    result[i, j] = res;
                    res = 0;
                }
            }

            return result;
        }
        public void ToString()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}   ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
    class MatrixClass
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the height of the first matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the width of the first matrix: ");
            int m = int.Parse(Console.ReadLine());

            Matrix matrix1 = new Matrix(n, m);

            Console.WriteLine("Incert the matrix row by row: ");
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] row = line.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = int.Parse(row[j]);
                }
            }

            Console.WriteLine("Insert the height of the second matrix: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the width of the second matrix: ");
            int m1 = int.Parse(Console.ReadLine());

            Matrix matrix2 = new Matrix(n1, m1);

            Console.WriteLine("Incert the array row by row: ");
            for (int i = 0; i < n1; i++)
            {
                string line = Console.ReadLine();
                string[] row = line.Split(' ');
                for (int j = 0; j < m1; j++)
                {
                    matrix2[i, j] = int.Parse(row[j]);
                }
            }

            Console.WriteLine("Addition");
            Matrix matrix3 = matrix1 + matrix2;
            matrix3.ToString();
            Console.WriteLine("Substraction");
            Matrix matrix4 = matrix1 - matrix2;
            matrix4.ToString();
            Console.WriteLine("Multiplication");
            Matrix matrix5 = matrix1 * matrix2;
            matrix5.ToString();
        }
    }
}
