package org.example;

import java.math.BigInteger;

public class UnlimitedFactorial {

    public static BigInteger calculateFactorial(int n){
        BigInteger result = new BigInteger("1");

        for (int i = 2; i <= n ; i++) {
            result = result.multiply(new BigInteger(String.valueOf(i)));
            System.out.print (i + " - ");
            System.out.println(result);
        }
        return result;
    }

    public static void main(String[] args) {
        System.out.println();
        calculateFactorial(2000);
    }

}
