package Homework5.Layers;

import java.util.Collection;

// Интерфейс для слоя Data Access Layer
public interface DatabaseAccess {

    void addEntity(Entity entity);
    void removeEntity(Entity entity);
    Collection<Texture> getAllTextures();
    Collection<Model3D> getAllModels();
}
