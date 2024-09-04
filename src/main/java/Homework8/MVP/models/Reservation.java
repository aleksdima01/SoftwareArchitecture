package Homework8.MVP.models;

import java.util.Date;

public class Reservation {
    private final int id;
    private static int counter = 1000;
    private Table table;
    private Date date;
    private String name;

    {
        id = ++counter;
    }

    public int getId() {
        return id;
    }

    public void setTable(Table table) {
        this.table = table;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Reservation(Table table, Date date, String name) {
        this.table = table;
        this.date = date;
        this.name = name;
    }
}
