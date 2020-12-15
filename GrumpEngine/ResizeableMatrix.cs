namespace GrumpEngine
{
    class ResizeableMatrix
    {
        private EncounterType[,] matrix;

        public ResizeableMatrix(int row, int col)
        {
            matrix = new EncounterType[row, col];
        }

        public EncounterType[,] Matrix
        {
            get { return matrix; }
        }

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

        public void Replace(EncounterType value, int row, int col)
        {
            matrix[row, col] = value;
        }

        public int CompareTo(ResizeableMatrix other)
        {
            return matrix.Length - other.Matrix.Length;
        }

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

        public int Length
        {
            get { return matrix.Length; }
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
