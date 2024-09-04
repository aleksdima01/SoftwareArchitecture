package Homework8.MVP.presenters;

import Homework8.MVP.models.Table;

import java.util.Collection;
import java.util.Date;

public interface Model {

    Collection<Table> loadTables();
    int reservationTable(Date reservationDate,int tableNo,String name);
    int changeReservationTable(int oldReservation, Date reservaionDate, int tableNo, String name);
}
