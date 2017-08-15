/*
Binary search implementaion using C#
*/

using System;

namespace BinarySearchCS
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Sample array for testing.
			int[] nums = {2,8,17,23,46,58,67,74,88,95};

			//Prompts user to enter a target value to search for.
			Console.WriteLine("Enter a number to search for: ");
			int target = Convert.ToInt32(Console.ReadLine());

			bool isPresent = binarySearch(nums,target); //Calls iterative version.
			//bool isPresent = recursiveBinarySearch(nums,target); //Calls recursive version.

			//Lets the user know if the target value is or is not in the given array.
			if (isPresent){
				Console.WriteLine("The number {0} is present in the given array.", target);

			}
			else{ 
				Console.WriteLine("The number {0} is not present in the given array.", target);
			}

			//Prints the array values for testing.
			foreach (int n in nums){
				Console.Write("{0},", n);
			}
		}

		//Performs a recursive binary search.
		public static bool recursiveBinarySearch(int[] arr, int target){

			//Calls helper method.
			return recursiveBinarySearch(arr, target, arr.Length - 1, 0);
		}

		//Helper method so only an array and a target value are required as parameters.
		public static bool recursiveBinarySearch(int[] arr, int target, int hi, int lo){
			
			//Case if target value is not in the given array.
			if (hi < lo){
				return false;
			}

			int mid = (hi + lo) / 2;

			//Case if target value is in the given array.
			if (target == arr[mid]){
				return true;
			}
			else if (target < arr[mid]) {
				//Searches the lower portion of the array.
				return recursiveBinarySearch(arr, target, mid-1, lo); 
			}
			else{
				//Searches the higher portion of the array.
				return recursiveBinarySearch(arr, target, hi, mid+1);
			}

		}

		//Performs an interative binary search.
		public static bool binarySearch(int[] arr, int target){

			int hi = arr.Length-1;
			int lo = 0;
			int mid = hi / 2;

			while(hi >= lo){

				mid = (hi + lo) / 2;

				//Target is in the given array.
				if (target == arr[mid]){
					return true;
				}
				else if (target < arr[mid]){
					hi = mid-1; //Searches the lower portion of the array.
				}
				else if (target > arr[mid]){
					lo = mid+1; //Searches the higher portion of the array.
				}
			}

			return false;
		}
	}
}
