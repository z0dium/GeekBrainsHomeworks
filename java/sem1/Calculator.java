package org.example;

import java.util.*;
import java.util.regex.Pattern;


public class Calculator {

    public static void main(String[] args) {
        System.out.println();
        System.out.println("Простой калькулятор для вычисления выражений содержащих произвольное количество действий из списка (+,-,*,/)");
        System.out.println("Допускается использование отрицательных значений и скобок. Пример: -34/(45+3) - 7 * ((28-17) * 3)");
        System.out.println("Введите выражение для вычисления: ");
        Scanner scanner = new Scanner(System.in);
        String input;
        do {
            System.out.print("X = ");
            input = scanner.nextLine();
        } while (input.length() == 0 || !(checkForCorrectBracketUsage(input) && checkForCorrectUsageOfActions(input)));
        input = input.replaceAll(" ","");
        System.out.println("X = " + calculate(maskBracketsInExpression(input)));
    }
    public static double calculate(String input) {
        String[] strAddendum = input.split("(?!^)([+-])",2);
        if (strAddendum.length == 1 ) return calculateMultiplication(strAddendum[0]);
        String action = input.substring(strAddendum[0].length(),strAddendum[0].length()+1);
        double addedndum1 = calculateMultiplication(strAddendum[0]);
        double addedndum2 = calculate(strAddendum[1]);
        return action.equals("+") ? addedndum1 + addedndum2 : addedndum1 - addedndum2;
    }
    private static double calculateMultiplication(String input){
        String inputChecker = "^-?\\d+\\.?\\d*([/*](-?\\d+\\.?\\d*))+";
        Pattern pattern = Pattern.compile(inputChecker);
        if (!pattern.matcher(input).matches()) return Double.parseDouble(input);
        String[] multiplicators = input.split("[*/]");
        String[] actions = input.split("[^*/]+");
        double result = Double.parseDouble(multiplicators[0]);
        for (int i = 1; i < multiplicators.length; i++) {
            result = actions[i].equals("*") ? result * calculateMultiplication(multiplicators[i]) : result / calculateMultiplication(multiplicators[i]);
        }
        return result;
    }

    private static String maskBracketsInExpression(String input) {
        int indexLeft = input.indexOf("(");
        int indexRight = input.indexOf(")");
        if (indexLeft == indexRight) return input;
        else{
            StringBuilder sb = new StringBuilder();
            char[] chars = input.toCharArray();
            indexRight = -1;

            for (int i = indexLeft; i < chars.length; i++) {
                if (chars[i] == '(') indexLeft = i;
                if (chars[i] == ')') indexRight = i;
                if (indexLeft < indexRight){
                    sb.append(input, 0, indexLeft);
                    if (indexLeft == 0 && indexRight == input.length()-1) {
                        String result = input.substring(1,input.length()-1);
                        return result;
                    }
                    sb.append(calculate(input.substring(indexLeft+1,i))).append(input.substring(i+1));
                    System.out.println(sb);
                    break;
                }
            }
            return maskBracketsInExpression(sb.toString());
        }
    }

    private static boolean checkForCorrectBracketUsage(String input){
        int leftCounter = 0;
        int rightCounter = 0;
        char[] chars = input.toCharArray();

        int firstLeft = input.indexOf("(");
        int firstRight = input.indexOf(")");
        int lastLeft = input.lastIndexOf("(");
        int lastRight = input.lastIndexOf(")");
        if (firstRight == firstLeft) return true;
        if (firstLeft < firstRight && lastLeft < lastRight){
            for (int i = 0; i < chars.length; i++) {
                if (chars[i] == '(') leftCounter++;
                if (chars[i] == ')') rightCounter++;
            }
            if (leftCounter != rightCounter) System.out.println("Количество открывающих и закрывающих скобок не совпадает. Попробуйте еще раз.");

            return leftCounter == rightCounter;
        }else {
            System.out.println("В выражении неверно использованы скобки. Попробуйте еще раз.");
            return false;
        }
    }

    private static boolean checkForCorrectUsageOfActions(String input){
        Pattern pattern = Pattern.compile(".*[+/*-][+/*-].*");
        if (pattern.matcher(input).matches()) System.out.println("Неправильное использование арифметических знаков. Попробуйте еще раз.");
        return !(pattern.matcher(input).matches());
    }
}