package org.example;

import java.util.Scanner;
import java.util.regex.Pattern;

public class ExpressionRecovery {


    public static void main(String[] args) {
        System.out.println("Введите выражение для вычисления: ");
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        input = input.replaceAll(" ","");
        String[] expressions = input.split("=");

        int sum = Integer.parseInt(expressions[1]);
        String[] addendums = expressions[0].split("\\+");
        String str = splitToDigits(addendums[0]) + "+" + splitToDigits(addendums[1]);
        addendums = str.split("\\+");
        int xQty = 0;
        String inputChecker = "^\\d+$";
        Pattern pattern = Pattern.compile(inputChecker);
        for (int i = 0; i < addendums.length; i++) {
            if (pattern.matcher(addendums[i]).matches()) sum = sum - Integer.parseInt(addendums[i]);
            else xQty = xQty + Integer.parseInt(addendums[i].substring(2));
        }
        if (sum % xQty == 0 && sum/xQty < 10 && sum/xQty > -1) System.out.println(input.replaceAll("\\?",String.valueOf(sum/xQty)));
        else System.out.println("Решения нет");
    }

    private static String splitToDigits (String maskedNumber){
        StringBuilder sb = new StringBuilder();
        char[] digits = maskedNumber.toCharArray();
        for (int i = 0; i < digits.length; i++) {
            String str = (digits[digits.length - 1 - i] == '?' ? "X*" + (int) Math.pow(10, i) : "" + (int)(Character.getNumericValue(digits[digits.length - 1 - i]) * Math.pow(10, i)));
            sb.append(str);
            if (i < digits.length-1) sb.append("+");
        }
        return sb.toString();

    }
}
