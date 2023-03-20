namespace _012_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var ip = new IP(112, 114, 15, 33);

            //var FirstSegment = ip[1];

            //Console.WriteLine($"First Segment: {FirstSegment}");
            //Console.WriteLine($"Address: {ip.Address}");
            int[,] inputs = new int[,]
            {
                {1, 2, 3, 5, 6},
                {1, 2, 3, 5, 6},
                {1, 2, 3, 5, 6},
                {1, 2, 3, 5, 6},
                {1, 2, 3, 5, 6},
                {1, 2, 3, 5, 6}
            };

            var suduko = new Suduko(inputs);
            Console.WriteLine(suduko[2,2]);  //3

            suduko[2, 2] = 10;

            Console.WriteLine(suduko[2, 2]);
            Console.ReadKey();
        }
    }
    //public class IP
    //{
    //    private int[] segments = new int[4];

    //    public IP(int segment1, int segment2, int segment3, int segment4) 
    //    {
    //        segments[0] = segment1;
    //        segments[1] = segment2;
    //        segments[2] = segment3;
    //        segments[3] = segment4;
    //    }
    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return segments[index];
    //        }
    //        set
    //        {
    //            segments[index]=value;
    //        }
    //    }
    //    public string Address => string.Join(".", segments);
    //}

    public class Suduko
    {
        private int[,] _matrix;

        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || row>_matrix.GetLength(0)-1)
                    return -1;
                if(col<0 || col>_matrix.GetLength(1)-1)
                    return -1;

                return _matrix[row, col];
            }
            set
            {
                if (value < 1 || value > _matrix.GetLength(0))
                    return;
                _matrix[row, col] = value;
            }
        }

        public Suduko(int[,] matrix)
        {
            _matrix = matrix;
        }
    }
}