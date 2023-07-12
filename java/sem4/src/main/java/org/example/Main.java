package org.example;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Main {

    /*
        Task 1
     */
    static LinkedList<Integer> reverseList(LinkedList<Integer> list){
        LinkedList<Integer> result = new LinkedList<>();
        while (list.peekLast() != null){
            result.add(list.pollLast());
        }
        return result;
    }
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        System.out.println();
        System.out.print("Начальный список: ");
        for (int i = 0; i < (int) (Math.random() * 20) + 5; i++) {
            list.add((int) (Math.random() * 100));
        }
        System.out.println(list);
        System.out.println();
        System.out.print("Перевернутый лист: ");
        System.out.println(reverseList(list));

    }


}