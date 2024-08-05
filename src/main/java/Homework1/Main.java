package Homework1;

import Homework1.InMemory.ModelStore;
import Homework1.InMemory.Observer1;
import Homework1.models.PoligonalModel;
import Homework1.models.Polygon;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        ModelStore store=new ModelStore();

        Observer1 observer1=new Observer1();
        store.RegisterModelChanger(observer1);

        Polygon polygon1=new Polygon();
        List<Polygon> polygons=new ArrayList<>();
        polygons.add(polygon1);
        PoligonalModel poligonalModel=new PoligonalModel(polygons);
        store.add(poligonalModel);

    }
}