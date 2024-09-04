package Homework8.MVP.models;

import Homework8.MVP.presenters.Model;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;

public class TableModel implements Model {

    private Collection<Table> tables;

    /**
     * Получение списка всех столиков
     */


    @Override
    public Collection<Table> loadTables() {
        if (tables == null) {
            tables = new ArrayList<>();

            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
        }
        return tables;
    }

    /**
     * Бронирование столика
     *
     * @param reservationDate Дата бронирования
     * @param tableNo         Номер столика
     * @param name            Имя
     */
    @Override
    public int reservationTable(Date reservationDate, int tableNo, String name) {
        for (Table table : tables) {
            if (table.getNo() == tableNo) {
                Reservation reservation = new Reservation(table, reservationDate, name);
                table.getReservations().add(reservation);
                return reservation.getId();
            }
        }
        throw new RuntimeException("Ошибка бронирования столика. Повторите попытку позже.");
    }


    /**
     * Изменеие столика брони
     *
     * @param oldReservation
     * @param reservationDate
     * @param tableNo
     * @param name
     * @return
     */
    public int changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name) {
        Reservation deleteReservation = null;
        for (Table table : tables) {
            Collection<Reservation> reservationStatus = table.getReservations();
            if (reservationStatus.size() > 0) {
                for (Reservation reservation : reservationStatus) {
                    if (reservation.getId() == oldReservation) {
                        deleteReservation = reservation;
                    }
                }
            }
            table.getReservations().remove(deleteReservation);
        }
        return reservationTable(reservationDate, tableNo, name);
    }
}
