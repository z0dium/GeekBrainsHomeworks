import java.util.HashMap;
import java.util.Map;

public class Main {
    public static void main(String[] args) {

        PhoneBook phoneBook = new PhoneBook();

        phoneBook.saveContact(new FIO("Федоров", "Иван", "Иванович"),new PhoneBookRecord("+75462534242","Личный"));
        phoneBook.saveContact(new FIO("Иванов", "Иван", "Иванович"),new PhoneBookRecord("+754625242","Рабочий"));
        phoneBook.saveContact(new FIO("Михненков", "Павел", "Андреевич"),new PhoneBookRecord("+754625242","Сотовый"));
        phoneBook.saveContact(new FIO("Михненков", "Павел", "Андреевич"),new PhoneBookRecord("+75555242","Рабочий"));
        phoneBook.saveContact(new FIO("Смирнова", "Ольга", "Ивановна"),new PhoneBookRecord("+754625242","Рабочий"));
        phoneBook.saveContact(new FIO("Смирнова", "Ольга", "Ивановна"),new PhoneBookRecord("+7541115242","Личный"));

        System.out.println();
        phoneBook.getPhoneNumbersForFio(new FIO("Михненков", "Павел", "Андреевич"));
        System.out.println();
        phoneBook.getPhoneNumbersForFio("Смирнова", "Ольга", "Ивановна");
        System.out.println();
        phoneBook.printPhoneBook();
        System.out.println();
        phoneBook.findAllContactsByPhoneNumber("+754625242");
    }
}