package Homework1.InMemory;

public class Observer1 implements IModelChangedObserver{
    @Override
    public void applyUpdateModel() {
        System.out.println("Была добавлена новая полигонадьная модель-observer 1");
    }
}
