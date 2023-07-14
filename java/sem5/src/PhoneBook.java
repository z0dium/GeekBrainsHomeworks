import java.sql.SQLOutput;
import java.util.*;
import java.util.stream.Collectors;

public class PhoneBook {
    private Map<FIO,Set<PhoneBookRecord>> phonebook = new HashMap<>();

    public Set<PhoneBookRecord> getPhoneNumbersForFio(FIO fio){
        return phonebook.get(fio);
    }

    public void saveContact (FIO fio,PhoneBookRecord record){
        Set<PhoneBookRecord> records = phonebook.get(fio);
        if (records != null) {
            records.add(record);
        } else {
            Set<PhoneBookRecord> set = new HashSet<>();
            set.add(record);
            phonebook.put(fio,set);
        }
    }

    public void printPhoneBook(){
        HashMap<Integer,List<String>> map = new HashMap<>();
        phonebook.keySet().forEach(key->{
            Integer count = phonebook.get(key).size();
            if (map.get(count) == null) {
                map.put(count,phonebook.get(key).stream().map(record -> new String(key + ": " + record)).toList());
            } else {
                List<String> result= map.get(count);
                result.addAll(phonebook.get(key).stream().map(record -> new String(key + ": " + record)).toList());
                map.put(count,result);
            }
        });
        List<Integer> list = new ArrayList<>(map.keySet().stream().toList());
        list.sort(((o1, o2) -> o2-o1));
        for (Integer key:list) {
            map.get(key).forEach(System.out::println);
        }



    }

}
