package Homework1.models;

public class Scene {

   private int id;
   private PoligonalModel models;
   private Flash flash;
   private Camera camera;

    public Scene(int id, PoligonalModel models, Flash flash, Camera camera) {
        this.id = id;
        this.models = models;
        this.flash = flash;
        this.camera = camera;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public PoligonalModel getModels() {
        return models;
    }

    public void setModels(PoligonalModel models) {
        this.models = models;
    }

    public Flash getFlash() {
        return flash;
    }

    public void setFlash(Flash flash) {
        this.flash = flash;
    }

    public Camera getCamera() {
        return camera;
    }

    public void setCamera(Camera camera) {
        this.camera = camera;
    }
}
