package Homework1.InMemory;

public class Observer2 implements IModelChangedObserver{
    @Override
    public void applyUpdateModel() {
        System.out.println("Была добавлена новая полигонадьная модель-observer 2");
    }
}
