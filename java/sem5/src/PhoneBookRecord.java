public class PhoneBookRecord {
    private String phoneNumber;
    private String description;

    public PhoneBookRecord(String phoneNumber, String description) {
        this.phoneNumber = phoneNumber;
        this.description = description;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Override
    public String toString() {
        return description + ": " + phoneNumber;
    }
}
