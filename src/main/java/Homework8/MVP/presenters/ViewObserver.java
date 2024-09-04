package Homework8.MVP.presenters;

import java.util.Date;

public interface ViewObserver {
    void setReservationForTable(Date orderDate, int tableNo, String name);
    void changeReservationTable(int oldReservation,Date reservaionDate,int tableNo,String name);
}
