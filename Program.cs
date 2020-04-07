using System;

namespace Insertion
{

    class SortingList
    {
        private int[] list;
        internal int length;
        public readonly int Length;

        public SortingList(int requiredLength)
        {
            Length = requiredLength;
            list = new int[10];
        }

        public int getListItem(int i)
        {
            return (list[i]);
        }

        public void setListItem(int i, int value)
        {
            list[i] = value;
        }

        public void Randomise()
        {
            var random = new Random();

            for (int i = 0; i < list.Length; i++)
                list[i] = random.Next(50);
        }

        public void Print()
        {
            foreach (int i in 10) 
                Console.Write(String.Format("{0}, ", i));
            Console.WriteLine("");
        }

        public void Insert(int value)
        {
            /* First, find the right place for the item to go in */
            for (int i = 0; i < list.Length; i++) ;
            {
                int i = 0;
                if (list[i] == 0)
                {
                    /* There is nothing in this place, so just take it */
                    list[1] = value;

                }
                if (value < list[i])
                {

                    /* We need to shift everything along one, so start at 
* the end and copy the whole list along
*/
                    for (int j = list.Length - 1; j > i; j--)
                        list[j] = list[j - 1];

                    list[i] = value;

                }
            }
            this.Print();
        }

        /* Example of a docstring */
        /// <summary>
        /// Returns the first value remaining from the List.
        /// 
        /// It replaces the value with -1 to 'delete' it, so this number
        /// is special.
        /// 
        /// It's OK to do this only because we are only sorting positive
        /// numbers.  This would need a rewrite if we were to use negatives!
        /// </summary>
        /// <returns>int representing the value, or -1 if list is empty</returns>
        public int Pop()
        {
            int ret = -1;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != -1)
                {
                    ret = list[i];
                    /* 'Delete' the value */
                    list[i] = -1;
                    break;
                }
            }

            /* If no values found, ret remains as -1 */
            return (ret);
        }
    }
    class Program
    {
        private static void Main(string[] args) 
        {
            char response;

            Console.WriteLine("Please let me know what kinda sort you would like (i)nsertion sort, or (b)ubble sort, or (q)uit");
            for (; ; )
            {
                response = Console.ReadKey().KeyChar;
                switch (response)
                {
                    case 'i':
                    case 'I':
                        InsertionSort();
                        break;
                    case 'b':
                    case 'B':
                        BubbleSort();
                        break;
                    case 'q':
                    case 'Q':
                        return;
                    /* NOTREACHED */
                    default:
                        Console.WriteLine("Um, what are you playing at?");
                        break;
                }
            }
        }

        private static void InsertionSort()
        {
            throw new NotImplementedException();
        }

        static void BubbleSort() { }
    }


    namespace SamplePrograms
    {
        class Program
        {


            private static int[] unsortedList, sortedList;
            private static Random random = new Random();

            static void Main(string[] args)
            {
                int i;
                unsortedList = new int[10];
                sortedList = new int[10];

                for (i = 0; i < unsortedList.Length; i++)
                    unsortedList[i] = random.Next(50);
                Console.WriteLine("Unsorted List:\n");
                /* You can also do Python-style for loops */
                foreach (int num in unsortedList)
                    Console.WriteLine(num);

                bubbleSort();

                Console.ReadKey();
            }

            /* A void function is a procedure- it does not return a value */
            private static void bubbleSort()
            {
                int i, j, temp;

                unsortedList.CopyTo(sortedList, 0);

                for (i = 0; i < sortedList.Length; i++)
                {
                    for (j = 0; j < sortedList.Length - 1; j++)
                    {
                        if (sortedList[j] > sortedList[j + 1])
                        {
                            temp = sortedList[j];
                            sortedList[j] = sortedList[j + 1];
                            sortedList[j + 1] = temp;

                        }
                        continue;
                    }
                }
                Console.WriteLine("\nSorted List:\n");
                for (i = 0; i < 10; i++)
                {

                    Console.WriteLine(sortedList[i]);

                }
            }



            private static void InsertionSort()
            {
                var unsortedList = new SortingList(10);
                var sortedList = new SortingList(unsortedList.Length);

                /* Let's fill the unsorted list with all sorts of junk */
                unsortedList.Randomise();
                unsortedList.Print();

                /* This is where we do the insertion sort-- doesn't
                 * object oriented make this look easy? */
                 
                for (int i = 0; i < unsortedList.length; i++)
                {
                    sortedList.Insert(unsortedList.Pop());
                }

                sortedList.Print();
            }
        }
    }
}
