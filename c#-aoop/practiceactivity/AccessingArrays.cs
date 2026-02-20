using System;

public class Program {
    public static void Values(int[] arr) {
        // Write code here
        for (int i = 0; i < arr.Length; i++){
            Console.WriteLine(arr[i]);
        }
    }

    public static void Main(string[] args) {
        int[] numbers = {10, 20, 30, 40, 50};
        Values(numbers);
    }
}