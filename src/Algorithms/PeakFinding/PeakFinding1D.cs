using System;
namespace Algorithms.PeakFinding
{
    public static class PeakFinding1D
    {
        public static int LinearPeakFinding(int[] unSortedArray)
        {
            if (unSortedArray[0] > unSortedArray[1])
            {
                return 0;
            }
            else if (unSortedArray[^1] > unSortedArray[^2])
            {
                return unSortedArray.Length - 1;
            }
            else
            {
                for (int i = 1; i < unSortedArray.Length - 2; i++)
                {
                    if (unSortedArray[i] > unSortedArray[i - 1] && unSortedArray[i] > unSortedArray[i + 1])
                    {
                        return i;
                    }
                }
                return -1;
            }

        }

        public static int RecursiveLinearPeakFinding(int[] unSortedArray, int index)
        {
            if (index == 0 && unSortedArray[index] > unSortedArray[1])
            {
                return index;
            }
            else if (index == unSortedArray.Length - 1 && unSortedArray[index] > unSortedArray[^2])
            {
                return index;
            }
            else if (unSortedArray[index] > unSortedArray[index - 1] && unSortedArray[index] > unSortedArray[index + 1])
            {
                return index;
            }
            else
            {
                return RecursiveLinearPeakFinding(unSortedArray, index++);
            }
        }

        public static int BinaryPeakFinding(int[] unSortedArray, int startIndex, int endIndex)
        {
            int mid;
            while (true)
            {
                mid = (int)Math.Ceiling((startIndex + endIndex) / 2F);

                if (mid > 0 && unSortedArray[mid] < unSortedArray[mid - 1])
                {
                    endIndex = mid - 1;
                }
                else if (mid < unSortedArray.Length - 1 && unSortedArray[mid] < unSortedArray[mid + 1])
                {
                    startIndex = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
        }

        public static int RecursiveBinaryPeakFinding(int[] unSortedArray, int startIndex, int endIndex)
        {
            int mid = (int)Math.Ceiling((startIndex + endIndex) / 2F);
            if (mid > 0 && unSortedArray[mid] < unSortedArray[mid - 1])
            {
                return RecursiveBinaryPeakFinding(unSortedArray, startIndex, mid - 1);
            }
            else if (mid < unSortedArray.Length - 1 && unSortedArray[mid] < unSortedArray[mid + 1])
            {
                return RecursiveBinaryPeakFinding(unSortedArray, mid + 1, endIndex);
            }
            else
            {
                return mid;
            }
        }
    }
}