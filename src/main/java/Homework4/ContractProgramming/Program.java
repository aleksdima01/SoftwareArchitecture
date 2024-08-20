package Homework4.ContractProgramming;

import java.nio.charset.Charset;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;
import java.util.Random;

public class Program {
    public static void main(String[] args) {
        Core core = new Core();
        MobileApp mobileApp = new MobileApp(core.getTicketProvider(), core.getCustomerProvider());
        BusStation busStation = new BusStation(core.getTicketProvider());
        Date date = new Date();
        if (mobileApp.buyTicket("34234234234", date)) {
            System.out.println("Клиент успешно купил билет.");
            mobileApp.searchTicket(date);
            Collection<Ticket> tickets = mobileApp.getTickets();
            busStation.checkTicket(tickets.stream().findFirst().get().getQrcode());
            System.out.println("Клиент успешно прошел в автобус.");
        }
    }
}


class Core {
    private final CustomerProvider customerProvider;
    private final TicketProvider ticketProvider;
    private final PaymentProvider paymentProvider;
    private final Database database;

    public Core() {
        database = new Database();
        customerProvider = new CustomerProvider(database);
        paymentProvider = new PaymentProvider();
        ticketProvider = new TicketProvider(database, paymentProvider);
    }

    public CustomerProvider getCustomerProvider() {
        return customerProvider;
    }

    public TicketProvider getTicketProvider() {
        return ticketProvider;
    }
}

/**
 * Покупатель
 */
class Customer {
    private static int counter;
    private final int id;

    {
        id = ++counter;
    }

    private Collection<Ticket> tickets;

    public Collection<Ticket> getTickets() {
        return tickets;
    }

    public void setTickets(Collection<Ticket> tickets) {
        this.tickets = tickets;
    }

    public int getId() {
        return id;
    }
}

/**
 * Билет
 */
class Ticket {
    private int id;
    private int customerId;
    private Date date;
    private String qrcode;
    private boolean enable = true;

    public void setEnable(boolean enable) {
        this.enable = enable;
    }

    public int getId() {
        return id;
    }

    public int getCustomerId() {
        return customerId;
    }

    public void setCustomerId(int customerId) {
        this.customerId = customerId;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public String getQrcode() {
        return qrcode;
    }

    public void setQrcode(String qrcode) {
        this.qrcode = qrcode;
    }

    public boolean isEnable() {
        return enable;
    }
}

/**
 * База данных
 */
class Database {
    private static int counter;
    private Collection<Ticket> tickets = new ArrayList<>();

    public Collection<Ticket> getTickets() {
        return tickets;
    }

    public void setTickets(Ticket ticket) {

        tickets.add(ticket);
    }

    public Collection<Customer> getCustomers() {
        return customers;
    }

    private Collection<Customer> customers = new ArrayList<>();

    // Получить актуальную стоимость билета
    public double getTicketAmount() {
        return 45;
    }

    // Получить идентификатор заявки на покупку билета
    public int createTicketOrder(int clientId) {
        return ++counter;
    }
}

class PaymentProvider {
    public boolean buyTicket(int orderId, String cardNo, double amount) {
        // Обращение к платежному шлюзу, попытка выполнить списание средств...
        return true;
    }
}

/**
 * Мобильное приложение
 */
class MobileApp {
    private final Customer customer;
    private final TicketProvider ticketProvider;
    private final CustomerProvider customerProvider;

    public MobileApp(TicketProvider ticketProvider, CustomerProvider customerProvider) {
        this.ticketProvider = ticketProvider;
        this.customerProvider = customerProvider;
        customer = customerProvider.getCustomer("<login>", "<password>");
    }

    public Collection<Ticket> getTickets() {
        return customer.getTickets();
    }

    public void searchTicket(Date date) {
        Collection<Ticket> a = ticketProvider.searchTicket(customer.getId(), date);
        customer.setTickets(a);
    }

    public boolean buyTicket(String cardNo, Date date) {
        return ticketProvider.buyTicket(customer.getId(), cardNo, date);
    }
}

class TicketProvider {
    private Database database;
    private final PaymentProvider paymentProvider;

    private String qrCode;

    public TicketProvider(Database database, PaymentProvider paymentProvider) {
        this.database = database;
        this.paymentProvider = paymentProvider;
    }

    public String getQrCode() {
        return qrCode;
    }

    public Collection<Ticket> searchTicket(int clientId, Date date) {
        Collection<Ticket> tickets = new ArrayList<>();
        for (Ticket ticket : database.getTickets()) {
            if (ticket.getCustomerId() == clientId && ticket.getDate().equals(date))
                tickets.add(ticket);
        }
        return tickets;
    }

    public String generateQr() {
        byte[] array = new byte[7]; // length is bounded by 7
        new Random().nextBytes(array);
        String generatedString = new String(array, Charset.forName("UTF-8"));
        return generatedString;
    }

    public boolean buyTicket(int clientId, String cardNo, Date date) {
        int orderId = database.createTicketOrder(clientId);
        double amount = database.getTicketAmount();
        if (paymentProvider.buyTicket(orderId, cardNo, amount)) {
            Ticket ticket = new Ticket();
            ticket.setCustomerId(clientId);
            ticket.setDate(date);
            String qr=generateQr();
            ticket.setQrcode(qr);
            qrCode=qr;
            database.setTickets(ticket);
            return true;
        }
        return false;
    }

    public boolean checkTicket(String qrcode) {
        for (Ticket ticket : database.getTickets()) {
            if (ticket.getQrcode().equals(qrcode))
                ticket.setEnable(false);
            // Save database...
            return true;
        }
        return false;
    }
}

class CustomerProvider {
    private Database database;

    public CustomerProvider(Database database) {
        this.database = database;
    }

    public Customer getCustomer(String login, String password) {
        return new Customer();
    }
}

class BusStation {
    private final TicketProvider ticketProvider;

    public BusStation(TicketProvider ticketProvider) {
        this.ticketProvider = ticketProvider;
    }

    public boolean checkTicket(String qrCode) {
        return ticketProvider.checkTicket(qrCode);
    }
}