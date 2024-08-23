package Homework5.Layers;

import java.util.ArrayList;
import java.util.Collection;

public class Texture implements Entity {
    private int id;

    private static int counter = 50000;

    {
        id = ++counter;
    }

    @Override
    public int getId() {
        return id;
    }

    @Override
    public String toString() {
        return String.format("Texture #%s",id);
    }
}
