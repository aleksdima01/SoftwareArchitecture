package Homework8.MVP.models;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Locale;

public class Table {
    private final int no;
    private static int counter;

    private final Collection<Reservation> reservations =new ArrayList<>();


    {
        no = ++counter;
    }

    public int getNo() {
        return no;
    }


    public Collection<Reservation> getReservations() {
        return reservations;
    }

    @Override
    public String toString() {
        return String.format(Locale.getDefault(),"Столик № %d",no);
    }
}

