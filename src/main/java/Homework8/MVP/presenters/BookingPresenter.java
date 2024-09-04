package Homework8.MVP.presenters;

import Homework8.MVP.models.Table;

import java.util.Collection;
import java.util.Date;

public class BookingPresenter implements ViewObserver {

    private final Model model;
    private final View view;

    public BookingPresenter(Model model, View view) {
        this.model = model;
        this.view = view;
        this.view.setObserver(this);
    }

    /**
     * Получение списка столиков
     */
    public Collection<Table> loadTables() {
        return model.loadTables();
    }

    /**
     * Отображение списка столиков на представлении
     */
    public void updateUIShowTables() {
        view.showTables(loadTables());
    }

    public void updateUIShowReservationTableResult(int reservationNo) {
        view.showReservationTableResult(reservationNo);
    }

    /**
     * Произошло событие, пользователь нажал на кнопку резерва столика
     *
     * @param orderDate Дата резерва
     * @param tableNo   номер столика
     * @param name      имя клиента
     */
    @Override
    public void setReservationForTable(Date orderDate, int tableNo, String name) {
        try {
            int reservationNo = model.reservationTable(orderDate, tableNo, name);
            updateUIShowReservationTableResult(reservationNo);
        } catch (RuntimeException e) {
            e.printStackTrace();
            //updateUIShowReservationTableResult(-1);
        }
    }

    @Override
    public void changeReservationTable(int oldReservation, Date reservaionDate, int tableNo, String name) {
        try {
            int reservationNo = model.changeReservationTable(oldReservation,reservaionDate, tableNo, name);
            updateUIShowReservationTableResult(reservationNo);
        } catch (RuntimeException e) {
            updateUIShowReservationTableResult(-1);
        }
    }
}
