package org.example;

import java.util.HashSet;
import java.util.Set;

public class SimpleNumbers {
    public static Set<Integer> sieveEratosthenes(int n){
        Set<Integer> result = new HashSet<>();

        if (n > 2) {
            for (int i = 3; i <= n ; i = i + 2) {
                result.add(i);
            }

            for (int i = 3; i <= n; i += 2) {
                int j = i;
                while (i * j <= n){
                    result.remove(i*j);
                    j = j + 2;
                }
            }
        }
        result.add(2);
        return result;
    }

    public static void main(String[] args) {
        System.out.println(sieveEratosthenes(1000));
    }
}
