package Homework3.SOLID;

import java.sql.Ref;

public class RefuelingStation implements Refueling {

    @Override
    public void fuel(FuelType fuelType) {
        switch (fuelType){
            case Diesel -> System.out.println("Заправка дизелем");
            case Gasoline -> System.out.println("Заправка бензином");
            case Gas -> System.out.println("Заправка газом");
        }
    }

}
