import java.util.Objects;

class FIO implements Comparable{
    private String surname;
    private String name;
    private String secondName;

    public FIO(String surname, String name, String secondName) {
        this.surname = surname;
        this.name = name;
        this.secondName = secondName;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        FIO fio = (FIO) o;
        return surname.equals(fio.surname) && name.equals(fio.name) && secondName.equals(fio.secondName);
    }

    @Override
    public int compareTo(Object o) {
        return this.equals(o)?0:1;
    }

    @Override
    public int hashCode() {
        return Objects.hash(surname, name, secondName);
    }

    @Override
    public String toString() {
        return surname + " " + name + " " + secondName;
    }
}