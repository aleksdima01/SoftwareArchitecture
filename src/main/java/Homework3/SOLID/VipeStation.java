package Homework3.SOLID;

public class VipeStation implements Viping{
    @Override
    public void vipeBody() {
        System.out.println("Помыли кузов");
    }

    @Override
    public void vipeWindshield() {
        System.out.println("Помыли лобовое стекло");
    }

    @Override
    public void vipeHeadlights() {
        System.out.println("Помыли фары");
    }
}
