// FrogRiverOne solution. For problem description, see https://codility.com/programmers/lessons/2
// Code written in C# 5.0 with .NET 4.5 (Mono)

using System;

class Solution {
    public int solution(int X, int[] A) {
        int N = A.Length;
        if (X > N) {
            return -1;
        }
        int[] z = new int[X];
        for (int i=0; i<X; ++i) {
            z[i] = 0;
        }
        int sum_z = 0;
        for (int i = 0; i < N; ++i) {
            if (A[i] <= X && z[A[i]-1] == 0) {
                z[A[i]-1] = 1;
                sum_z += 1;
            }
            if (sum_z == X) {
                return i;
            }
        }
        return -1;
    }
}
