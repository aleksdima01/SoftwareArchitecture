package Homework1.models;

import java.util.List;

public class PoligonalModel {

    private List<Polygon> poligons;
    private List<Texture> textures;

    public List<Polygon> getPoligons() {
        return poligons;
    }

    public List<Texture> getTextures() {
        return textures;
    }
    public PoligonalModel(List<Polygon> poligons) {
        this.poligons = poligons;
    }

    public PoligonalModel(List<Polygon> poligons, List<Texture> textures) {
        this.poligons = poligons;
        this.textures = textures;
    }


}
