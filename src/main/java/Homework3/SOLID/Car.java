package Homework3.SOLID;

import java.awt.Color;

public abstract class Car {

    //region Constructors

    public Car(String make, String model, Color color) {
        this.make = make;
        this.model = model;
        this.color = color;
    }


    //endregion

    //region Private Fields

    //Марка
    private String make;

    //Модель
    private String model;

    //Цвет
    private Color color;

    //Тип
    protected CarType type;

    //Число колес
    private int wheelsCount;

    //Тип топлива
   protected FuelType fuelType;

    //Тип коробки передач
    private GearboxType gearboxType;

    //Объём двигателя
    private double engineCapacity;

    //Противотуманки
    private boolean fogLights = false;

    //endregion

    //region Public Methods

    //Движение
    public abstract void movement();

    //Обслуживание
    public abstract void maintenance();

    //Переключение передач
    public abstract boolean gearShifting();

    //Включение фар
    public abstract boolean switchHeadLights();

    //Включение дворников
    public abstract boolean switchWipers();

    //Включение противотуманок
    public boolean switchFogLights(){
        fogLights= !fogLights;
        return fogLights;
    }
    protected void setWheelsCount(int wheelsCount) {
        this.wheelsCount=wheelsCount;
    }

    public int getWheelsCount() {
        return wheelsCount;
    }

    public FuelType getFuelType() {
        return fuelType;
    }

    public void setFuelType(FuelType fuelType) {
        this.fuelType = fuelType;
    }
    //endregion


}
