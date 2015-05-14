// PermMissingElem solution. For problem description, see https://codility.com/programmers/lessons/
// Code written in C# 5.0 with .NET 4.5 (Mono)

using System;

class Solution {
    public int solution(int[] A) {
        int N = A.Length;
        if (N == 0) {
            return 1;
        }
        Array.Sort(A);
        if (A[0] != 1) {
            return 1;
        }
        else if (A[N-1] != N+1) {
            return N+1;
        }
        else {
            int missing = 0;
            for (int i=0; i< N-1; i++ ) {
                if ( A[i+1] - A[i] != 1 ) {
                    missing = A[i]+1;
                    break;
                }
            }
            return missing;
        }
    }
}
