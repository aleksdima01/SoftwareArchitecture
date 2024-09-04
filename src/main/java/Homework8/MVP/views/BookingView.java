package Homework8.MVP.views;

import Homework8.MVP.models.Table;
import Homework8.MVP.presenters.View;
import Homework8.MVP.presenters.ViewObserver;

import java.util.Collection;
import java.util.Date;

public class BookingView implements View {

    private ViewObserver observer;

    public void setObserver(ViewObserver observer) {
        this.observer = observer;
    }

    @Override
    public void showReservationTableResult(int reservationNo) {
        if (reservationNo > 0) {
            System.out.printf("Столик успешно забронирован. Номер вашей брони: № %d\n", reservationNo);
        } else {
            System.out.println("Что-то пошло не так, попробуйте позже!");
        }
    }

    public void showTables(Collection<Table> tables) {
        for (Table table : tables) {
            System.out.println(table);
        }
    }

    /**
     * Действие клиента (пользователь нажал на кнопку бронирования), бронирование столика
     *
     * @param orderDate
     * @param tableNo
     * @param name
     */
    public void reservationTable(Date orderDate, int tableNo, String name) {
        if (observer != null) {
            observer.setReservationForTable(orderDate, tableNo, name);
        }
    }

    /**
     * Действие клиента: пользователь нажал на кнопку изменения резерва.
     *  TODO Доработать
     *
     * @param oldReservation
     * @param reservaionDate
     * @param tableNo
     * @param name
     */
    public void changeReservationTable(int oldReservation, Date reservaionDate, int tableNo, String name) {
        if (observer != null) {
            observer.changeReservationTable(oldReservation, reservaionDate, tableNo, name);
        }
    }

}
