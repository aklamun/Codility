// MissingInteger solution. For problem description, see https://codility.com/programmers/lessons/2
// Code written in C# 5.0 with .NET 4.5 (Mono)

using System;

class Solution {
    public int solution(int[] A) {
        int n = 0;
        foreach (int elem in A) {
            if (elem > n) {
                n = elem;
            }
        }
        if (n < 1) {
            return 1;
        }
        int N = A.Length;
        int[] z = new int[N];
        for (int i=0; i<N; ++i) {
            z[i] = 0;
        }
        foreach (int elem in A) {
            if (elem > 0 && elem <= N) {
                z[elem-1] = 1;
            }
        }
        for (int i=0; i<n; ++i) {
            if (z[i] == 0) {
                return i+1;
            }
        }
        return n+1;
    }
}
