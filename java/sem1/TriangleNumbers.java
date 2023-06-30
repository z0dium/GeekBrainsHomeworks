package org.example;

public class TriangleNumbers {
    public static long calculateTriangularNumber(int n){
        long result = 0L;
        for (int i = 1; i<=n;i++){
            result = result + i;
        }
        return result;
    }
    public static void main(String[] args) {
        System.out.println(calculateTriangularNumber(10));
        System.out.println(calculateTriangularNumber(100));
        System.out.println(calculateTriangularNumber(1000));
        System.out.println(calculateTriangularNumber(10000));
        System.out.println(calculateTriangularNumber(100000));
        System.out.println(calculateTriangularNumber(1000000));
        System.out.println(calculateTriangularNumber(10000000));
        System.out.println(calculateTriangularNumber(100000000));       // Интересный эффект при увеличении разрядов
        System.out.println();
        System.out.println(calculateTriangularNumber(20));
        System.out.println(calculateTriangularNumber(200));
        System.out.println(calculateTriangularNumber(2000));
        System.out.println(calculateTriangularNumber(20000));
        System.out.println(calculateTriangularNumber(200000));
        System.out.println(calculateTriangularNumber(2000000));
        System.out.println(calculateTriangularNumber(20000000));
        System.out.println(calculateTriangularNumber(200000000));
        System.out.println();
        System.out.println(calculateTriangularNumber(30));
        System.out.println(calculateTriangularNumber(300));
        System.out.println(calculateTriangularNumber(3000));
        System.out.println(calculateTriangularNumber(30000));
        System.out.println(calculateTriangularNumber(300000));
        System.out.println(calculateTriangularNumber(3000000));
        System.out.println(calculateTriangularNumber(30000000));
        System.out.println(calculateTriangularNumber(300000000));
        System.out.println();
        System.out.println(calculateTriangularNumber(11));
        System.out.println(calculateTriangularNumber(111));
        System.out.println(calculateTriangularNumber(1111));
        System.out.println(calculateTriangularNumber(11111));
        System.out.println(calculateTriangularNumber(111111));
        System.out.println(calculateTriangularNumber(1111111));
        System.out.println(calculateTriangularNumber(11111111));
        System.out.println(calculateTriangularNumber(111111111));
        System.out.println();
    }
}
