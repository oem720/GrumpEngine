namespace GrumpEngine
{
    public class ResizeableMatrix<T>
    {
        /// <summary>
        /// Creates a new ResizeableMatrix with the starting size of rows and columns as row and col.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public ResizeableMatrix(int row, int col)
        {
            Matrix = new T[row, col];
        }

        /// <summary>
        /// Returns the matrix stored within the class.
        /// </summary>
        public T[,] Matrix { get; private set; }

        /// <summary>
        /// Fills the matrix with the value passed to it.
        /// Will require point specific editing to change individual values.
        /// </summary>
        /// <param name="value"></param>
        public void Fill(T value)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = value;
        }

        /// <summary>
        /// Finds an empty slot on the matrix and slides the value into it.
        /// If the array has no empty slots, the matrix is resized, and the value is added to the first empty slot on the new row.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            for(int i = 0; i < Matrix.GetLength(0); i++)
            {
                for(int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == null)
                    {                        
                        Matrix[i, j] = value;
                        return;
                    }                    
                }

                if (i == Matrix.GetLength(0) - 1)
                    AddRow(); 
            }
        }

        /// <summary>
        /// Inserts the given EncounterType at the slot given in [row, col]
        /// Every value to the left is shifted left by 1 value to ensure all values are preserved.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void Insert(T value, int row, int col)
        {
            T[,] temp = Count + 1 > Matrix.Length ? new T[Matrix.GetLength(0) + 1, Matrix.GetLength(1)] : new T[Matrix.GetLength(0), Matrix.GetLength(1)];

            for (int i = 0; i <= row; i++)
                for(int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (i == row && j == col)
                    {
                        temp[i, j] = value;
                        break;
                    }
                    temp[i, j] = Matrix[i, j];
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
                        temp[i, j] = Matrix[i - 1, Matrix.GetLength(1) - 1];

                    else if(i < Matrix.GetLength(0))
                        temp[i, j] = Matrix[i, j - 1];
                }
                if(col == Matrix.GetLength(1) - 1)
                    col--;

                isAtStartOfRow = true;
                hasFinishedFirstRowManipulation = true;
            }

            Matrix = temp;
        }

        /// <summary>
        /// Compares the lengths of another Matrix to this array. Return the value from that subtraction.
        /// If it is 0, they are the same length. If it is 1 or greater, this matrix is greater in size.
        /// If it is -1 or less, the other matrix is greater in size.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(ResizeableMatrix<T> other)
        {
            return Matrix.Length - other.Matrix.Length;
        }

        /// <summary>
        /// Resizes the array on the column. Adds an extra column to the array and copies the old data to the new array.
        /// </summary>
        public bool AddCol()
        {
            T[,] temp = new T[Matrix.GetLength(0), Matrix.GetLength(1) + 1];

            for(int i = 0; i < Matrix.GetLength(0); i++)
                for(int j = 0; j < Matrix.GetLength(1); j++)
                    temp[i, j] = Matrix[i, j];

            Matrix = temp;

            return true;
        }

        /// <summary>
        /// Resizes the array on the rows. Adds an extra row to the array and copies the old data to the new array.
        /// </summary>
        public bool AddRow()
        {
            T[,] temp = new T[Matrix.GetLength(0) + 1, Matrix.GetLength(1)];

            for(int i = 0; i < Matrix.GetLength(0); i++)
                for(int j = 0; j < Matrix.GetLength(1); j++)
                    temp[i, j] = Matrix[i, j];

            Matrix = temp;

            return true;
        }

        /// <summary>
        /// Removes a column from the end of the matrix (data will be lost)
        /// </summary>
        /// <returns></returns>
        public bool RemoveCol()
        {
            if (Matrix.GetLength(1) - 1 < 1)
                return false;

            T[,] temp = new T[Matrix.GetLength(0), Matrix.GetLength(1) - 1];

            for(int i = 0; i < temp.GetLength(0); i++)
                for(int j = 0; j < temp.GetLength(1); j++)
                    temp[i, j] = Matrix[i, j];

            Matrix = temp;
            return true;
        }

        /// <summary>
        /// Removes a row from the end of the matrix (data will be lost)
        /// </summary>
        /// <returns></returns>
        public bool RemoveRow()
        {
            if (Matrix.GetLength(0) - 1 < 1)
                return false;

            T[,] temp = new T[Matrix.GetLength(0) - 1, Matrix.GetLength(1)];

            for(int i = 0; i < temp.GetLength(0); i++)
                for(int j = 0; j < temp.GetLength(1); j++)
                    temp[i, j] = Matrix[i, j];

            Matrix = temp;

            return true;
        }

        /// <summary>
        /// Returns the amount of elements currently stored on the array.
        /// </summary>
        public int Count
        {
            get
            {
                int numElements = 0;

                for (int i = 0; i < Matrix.GetLength(0); i++)
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                        if (Matrix[i, j] != null)
                            numElements++;

                return numElements;
            }
        }

        /// <summary>
        /// Returns the amount of slots currently available to be stored.
        /// </summary>
        public int Length
        {
            get { return Matrix.Length; }
        }

        /// <summary>
        /// Returns the length at the dimension. 0 returns the number of rows, 1 returns the number of columns.
        /// </summary>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public int GetLength(int dimension)
        {
            return Matrix.GetLength(dimension);
        }

        public T this[int i, int j]
        {
            get => this[i, j];
            set => this[i, j] = value;
        }
    }
}
