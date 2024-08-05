package Homework1.models;

public class Angle3D {
    private double alpha,beta,teta;

    public double getAlpha() {
        return alpha;
    }

    public void setAlpha(double alpha) {
        this.alpha = alpha;
    }

    public double getBeta() {
        return beta;
    }

    public void setBeta(double beta) {
        this.beta = beta;
    }

    public double getTeta() {
        return teta;
    }

    public void setTeta(double teta) {
        this.teta = teta;
    }

    public Angle3D(double alpha, double beta, double teta) {
        this.alpha = alpha;
        this.beta = beta;
        this.teta = teta;
    }
}
