package Homework5.Layers;

import java.util.Collection;

//Интерфейс БД
public interface Database {
    void load();

    void save();

    Collection<Entity> getAll();
}
