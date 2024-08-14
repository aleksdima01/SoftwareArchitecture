package Homework3.SOLID;

import java.awt.*;

public class Harvester extends Car implements Fueling, CarWash {

    private Refueling refueling;
    private VipeStation vipeStation;


    public Harvester(String make, String model, Color color) {
        super(make, model, color);
        setWheelsCount(6);
    }

    public void setRefuelingStation(Refueling refueling) {
        this.refueling = refueling;
    }

    public void setVipeStation(VipeStation vipeStation) {
        this.vipeStation = vipeStation;
    }


    @Override
    public void fuel() {
        if (refueling != null) {
            refueling.fuel(fuelType);
        }
    }

    @Override
    public void wash(boolean body,boolean windShield,boolean headLight) {
        if (vipeStation != null) {
            if (body){
                vipeStation.vipeBody();
            }
            if (windShield){
                vipeStation.vipeWindshield();
            }  if (headLight){
                vipeStation.vipeHeadlights();
            }
        }
    }

    @Override
    public void movement() {

    }

    @Override
    public void maintenance() {

    }

    @Override
    public boolean gearShifting() {
        return false;
    }

    @Override
    public boolean switchHeadLights() {
        return false;
    }

    @Override
    public boolean switchWipers() {
        return false;
    }

    public void sweeping() {
        System.out.println("Автомобиль подметает улицу.");
    }
}
