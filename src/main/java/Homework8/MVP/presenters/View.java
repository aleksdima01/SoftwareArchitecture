package Homework8.MVP.presenters;

import Homework8.MVP.models.Table;

import java.util.Collection;
import java.util.Date;

public interface View {
    /**
     * Отображение списка столиков в приложении
     *
     * @param tables
     */

    void showTables(Collection<Table> tables);

    /**
     * Установить наблюдателя для представления
     *
     * @param observer
     */
    void setObserver(ViewObserver observer);

    /**
     * Отобразить результат бронирования столика
     *
     * @param reservationNo
     */
    void showReservationTableResult(int reservationNo);

    /**
     * Событие: клиент нажал на кнопку резерва столика
     * @param orderDate
     * @param tableNo
     * @param name
     */
    void reservationTable(Date orderDate, int tableNo, String name);

    void changeReservationTable(int oldReservation,Date reservaionDate,int tableNo,String name);
}