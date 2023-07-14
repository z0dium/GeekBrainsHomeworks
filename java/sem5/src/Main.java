import java.util.HashMap;
import java.util.Map;

public class Main {
    public static void main(String[] args) {

        PhoneBook phoneBook = new PhoneBook();


        phoneBook.saveContact(new FIO("Иванов", "Иван", "Иванович"),new PhoneBookRecord("+754625242","Личный"));
        phoneBook.saveContact(new FIO("Михненков", "Павел", "Андреевич"),new PhoneBookRecord("+7523455242","Сотовый"));
        phoneBook.saveContact(new FIO("Михненков", "Павел", "Андреевич"),new PhoneBookRecord("+75555242","Личный"));

        phoneBook.printPhoneBook();
    }
}