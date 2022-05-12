using System;
using System.Collections.Generic;
using System.Text;

namespace NPuzzle
{
    class Solvable
    {
        public static int mergeSort(int[] arr, int array_size)
        {
            int right = array_size - 1;
            int left = 0;
            int[] temp_array = new int[array_size];

            return mergeSort(arr, temp_array, left, right);
        }

        public static int mergeSort(int[] arr, int[] temp, int left, int right)
        {
            int num_of_inversions = 0;
            int mid;
            if (right > left)
            {
                //Divide the array into two parts and call mergesort on each part
                mid = (right + left) / 2;


                num_of_inversions += mergeSort(arr, temp, mid + 1, right); //right sub-array
                num_of_inversions += mergeSort(arr, temp, left, mid); // left sub-array

                //the number of inversion in the merge step
                num_of_inversions += merge(arr, temp, left, mid + 1, right);
            }
            return num_of_inversions;
        }

        // This method merges two sorted arrays and returns inversion count in the arrays.
        // note: the two arrays(firt-mid : mid-last) are already sorted in this step
        public static int merge(int[] arr, int[] temp, int left, int mid, int right)
        {

            int i, j, k;
            i = left; // i is index for left subarray
            j = mid;  //j is index for right subarray

            k = left; // k is index for temp array

            int inv_count = 0;
            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];


                    inv_count = inv_count + (mid - i);
                }
            }

            // Copy the remaining elements of left subarray to temp
            while (i <= mid - 1)
                temp[k++] = arr[i++];

            // Copy the remaining elements of right subarray to temp

            while (j <= right)
                temp[k++] = arr[j++];

            // Copy the merged elements to original array 
            for (i = left; i <= right; i++)
                arr[i] = temp[i];

            return inv_count;
        }


        public static bool isSolvable(Node node)
        {
            int[] arr = new int[node.perimeter * node.perimeter];
            Helpers.copypuzzle(arr, node.puzzle, node.perimeter * node.perimeter);
            int num_of_inversions = Solvable.mergeSort(arr, node.perimeter * node.perimeter);

            Console.Write("Number of inversions are " + num_of_inversions);


            if (node.perimeter % 2 == 0)
            {
                int zeroRow = node.zeroIndx / node.perimeter;
                if ((node.perimeter - zeroRow) % 2 == 0 && num_of_inversions % 2 != 0)
                {
                    Console.Write("the puzzle is solvable");
                    return true;

                }
                else if ((node.perimeter - zeroRow) % 2 != 0 && num_of_inversions % 2 == 0)
                {
                    Console.Write("the puzzle is solvable");
                    return true;

                }

            }
            if (node.perimeter % 2 != 0 && num_of_inversions % 2 == 0)
            {
                Console.Write("the puzzle is solvable");
                return true;

            }
            else
            {
                Console.Write("the puzzle is un-solvable !!");
                return false;

            }
        }
    }
}