// FrogJmp solution. For problem description, see https://codility.com/programmers/lessons/
// Code written in C# 5.0 with .NET 4.5 (Mono)

using System;

class Solution {
    public int solution(int X, int Y, int D) {
        int z = (int) (Y-X)/D;
        if ( z < (double) (Y-X)/D ) {
            z += 1;
        }
        return z;
    }
}
