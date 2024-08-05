package Homework1.models;

import java.awt.*;

public class Flash {
    private Angle3D angle;
    private Point3D location;
    private Color color;
    private float power;

    public Flash(Angle3D angle, Point3D location, Color color, float power) {
        this.angle = angle;
        this.location = location;
        this.color = color;
        this.power = power;
    }


    public void setColor(Color color) {
        this.color = color;
    }

    public void setPower(float power) {
        this.power = power;
    }

    public Angle3D getAngle() {
        return angle;
    }

    public Point3D getLocation() {
        return location;
    }

    public Color getColor() {
        return color;
    }

    public float getPower() {
        return power;
    }

    void move(Point3D point) {
        this.location = point;
    }

    void rotate(Angle3D angle) {
        this.angle = angle;
    }
}
