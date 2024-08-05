package Homework1.models;

public class Camera {
    private Angle3D angle;
    private Point3D location;

    public Camera(Angle3D angle, Point3D location) {
        this.angle = angle;
        this.location = location;
    }

    public Angle3D getAngle() {
        return angle;
    }

    public Point3D getLocation() {
        return location;
    }

    void move(Point3D point) {
        this.location = point;
    }

    void rotate(Angle3D angle) {
        this.angle = angle;
    }

}
