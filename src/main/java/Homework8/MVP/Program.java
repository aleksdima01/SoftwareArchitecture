package Homework8.MVP;

import Homework8.MVP.models.TableModel;
import Homework8.MVP.presenters.BookingPresenter;
import Homework8.MVP.presenters.Model;
import Homework8.MVP.presenters.View;
import Homework8.MVP.views.BookingView;

import java.util.Date;

public class Program {
    public static void main(String[] args) {
        View view=new BookingView();
        Model model=new TableModel();
        BookingPresenter presenter=new BookingPresenter(model,view);

        presenter.updateUIShowTables();

         view.reservationTable(new Date(),5,"Дмитрий");
         view.reservationTable(new Date(),4,"Дмитрий");
         view.changeReservationTable(1001,new Date(),1,"Федор");

    }
}
