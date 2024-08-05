package Homework1.InMemory;

import Homework1.models.Camera;
import Homework1.models.Flash;
import Homework1.models.PoligonalModel;
import Homework1.models.Scene;

import java.util.ArrayList;
import java.util.List;

public class ModelStore implements IModelChanger {
    private List<IModelChangedObserver> observers = new ArrayList<>();
    private List<PoligonalModel> models = new ArrayList<>();
    private List<Flash> flashes = new ArrayList<>();
    private List<Scene> scenes = new ArrayList<>();
    private List<Camera> cameras = new ArrayList<>();


    public void add(PoligonalModel model) {
        models.add(model);
        notifyChange();
    }

    @Override
    public void notifyChange() {
        for (IModelChangedObserver observer : observers) {
            observer.applyUpdateModel();
        }
    }

    @Override
    public void RegisterModelChanger(IModelChangedObserver o) {
        observers.add(o);
    }

    @Override
    public void RemoveModelChanger(IModelChangedObserver o) {
        observers.remove(o);
    }
}
