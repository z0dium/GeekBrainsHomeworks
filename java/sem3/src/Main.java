import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {

        List<Integer> list = new ArrayList<>();
        System.out.println();
        System.out.print("Начальный список: ");
        for (int i = 0; i < (int) (Math.random() * 20) + 5; i++) {
            list.add((int) (Math.random() * 100));
        }
        System.out.println(list);

        System.out.print("Задание №1 (Убрать все четные числа): ");
        System.out.println(removeEven(list));
        System.out.print("Задание №2 (Найти минимальное значение): ");
        System.out.println(findMinimal(list));
        System.out.print("Задание №3 (Найти максимальное значение): ");
        System.out.println(findMaximal(list));
        System.out.print("Задание №4 (Найти среднее значение): ");
        System.out.println(findAverage(list));
    }

    static List<Integer> removeEven(List<Integer> list){
        return list.stream().filter(number -> number % 2 != 0)
                .collect(Collectors.toList());
    }

    static int findMinimal(List<Integer> list){
        return list.stream().min(Comparator.naturalOrder()).get();
    }

    static int findMaximal(List<Integer> list){
        return list.stream().max(Comparator.naturalOrder()).get();
    }

    static double findAverage(List<Integer> list){
        return ((double) list.stream().mapToInt(Integer::intValue).sum())/ list.size();
    }


}