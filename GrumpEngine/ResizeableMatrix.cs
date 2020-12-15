namespace GrumpEngine
{
    class ResizeableMatrix
    {
        private EncounterType[,] matrix;

        /// <summary>
        /// Creates a new ResizeableMatrix with the starting size of rows and columns as row and col.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public ResizeableMatrix(int row, int col)
        {
            matrix = new EncounterType[row, col];
        }

        /// <summary>
        /// Returns the matrix stored within the class.
        /// </summary>
        public EncounterType[,] Matrix
        {
            get { return matrix; }
        }

        /// <summary>
        /// Fills the matrix with the value passed to it.
        /// Will require point specific editing to change individual values.
        /// </summary>
        /// <param name="value"></param>
        public void Fill(int value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new EncounterType(value);
                }
            }
        }

        /// <summary>
        /// Finds an empty slot on the matrix and slides the value into it.
        /// If the array has no empty slots, the matrix is resized, and the value is added to the first empty slot on the new row.
        /// </summary>
        /// <param name="value"></param>
        public void Add(EncounterType value)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == null)
                    {                        
                        matrix[i, j] = value;
                        return;
                    }                    
                }
                if (i == matrix.GetLength(0) - 1)
                {
                    ResizeRowSize();
                } 
            }
        }

        /// <summary>
        /// Inserts the given EncounterType at the slot given in [row, col]
        /// Every value to the left is shifted left by 1 value to ensure all values are preserved.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void Insert(EncounterType value, int row, int col)
        {
            EncounterType[,] temp;

            if(Count + 1 > matrix.Length)
            {
                temp = new EncounterType[matrix.GetLength(0) + 1, matrix.GetLength(1)];
            }
            else
            {
                temp = new EncounterType[matrix.GetLength(0), matrix.GetLength(1)];
            }

            for(int i = 0; i <= row; i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == row && j == col)
                    {
                        temp[i, j] = value;
                        break;
                    }
                    temp[i, j] = matrix[i, j];
                }
            }

            bool hasFinishedFirstRowManipulation = false;
            bool isAtStartOfRow = true;

            for(int i = row; i < temp.GetLength(0); i++)
            {
                for(int j = col + 1; j < temp.GetLength(1); j++)
                {
                    if(i > row && j == col + 1 && hasFinishedFirstRowManipulation && isAtStartOfRow)
                    {
                        j = 0;
                        isAtStartOfRow = false;
                    }

                    if (j == 0)
                    {
                        temp[i, j] = matrix[i - 1, matrix.GetLength(1) - 1];
                    }
                    else if(i < matrix.GetLength(0))
                    {
                        temp[i, j] = matrix[i, j - 1];
                    }
                }

                if(col == matrix.GetLength(1) - 1)
                {
                    col--;
                }

                isAtStartOfRow = true;
                hasFinishedFirstRowManipulation = true;
            }

            matrix = temp;
        }

        /// <summary>
        /// Replaces the value at space [row, col] with EncounterType value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void Replace(EncounterType value, int row, int col)
        {
            matrix[row, col] = value;
        }

        /// <summary>
        /// Compares the lengths of another Matrix to this array. Return the value from that subtraction.
        /// If it is 0, they are the same length. If it is 1 or greater, this matrix is greater in size.
        /// If it is -1 or less, the other matrix is greater in size.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(ResizeableMatrix other)
        {
            return matrix.Length - other.Matrix.Length;
        }

        /// <summary>
        /// Resizes the array on the column. Adds an extra column to the array and copies the old data to the new array.
        /// </summary>
        public void ResizeColSize()
        {
            EncounterType[,] temp = new EncounterType[matrix.GetLength(0), matrix.GetLength(1) + 1];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp[i, j] = matrix[i, j];
                }
            }

            matrix = temp;
        }

        /// <summary>
        /// Resizes the array on the rows. Adds an extra row to the array and copies the old data to the new array.
        /// </summary>
        public void ResizeRowSize()
        {
            EncounterType[,] temp = new EncounterType[matrix.GetLength(0) + 1, matrix.GetLength(1)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp[i, j] = matrix[i, j];
                }
            }

            matrix = temp;
        }

        /// <summary>
        /// Returns the amount of elements currently stored on the array.
        /// </summary>
        public int Count
        {
            get
            {
                int numElements = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != null)
                        {
                            numElements++;
                        }
                    }
                }

                return numElements;
            }
        }

        /// <summary>
        /// Returns the amount of slots currently available to be stored.
        /// </summary>
        public int Length
        {
            get { return matrix.Length; }
        }

        /// <summary>
        /// Returns the length at the dimension. 0 returns the number of rows, 1 returns the number of columns.
        /// </summary>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public int GetLength(int dimension)
        {
            return matrix.GetLength(dimension);
        }

        /// <summary>
        /// Returns the encounter tile at the specified coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public EncounterType GetEncounter(int x, int y)
        {
            return matrix[x, y];
        }

        public override string ToString()
        {
            string matrixAsString = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrixAsString += "[";
                    }
                    else if (j == matrix.GetLength(1) - 1)
                    {
                        matrixAsString += $"{matrix[i, j]}]\n";
                        continue;
                    }
                    matrixAsString += $"{matrix[i, j]}, ";
                }
            }

            return matrixAsString;
        }
    }
}
