package Homework5.Layers;

import java.util.ArrayList;
import java.util.Collection;

// 3D Модель
public class Model3D implements Entity {

    private static int counter = 10000;

    {
        id = ++counter;
    }

    private int id;
    private Collection<Texture> textures = new ArrayList<>();

    public Model3D() {
    }

    public Model3D(Collection<Texture> textures) {
        this.textures = textures;
    }

    public Collection<Texture> getTextures() {
        return textures;
    }

    @Override
    public int getId() {
        return id;
    }

    @Override
    public String toString() {
        return String.format("3D Model #%s", id);
    }
}
