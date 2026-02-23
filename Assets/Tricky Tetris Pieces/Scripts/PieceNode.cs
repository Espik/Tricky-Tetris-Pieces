public class PieceNode  {
    private int index;
    private float[] coords;
    private double distance;

    public PieceNode() {
        index = 0;
        coords = new float[] { 0.0f, 0.0f };
        distance = 0.0f;
    }

    public PieceNode(int index, float[] coords, double distance) {
        this.index = index;
        this.coords = coords;
        this.distance = distance;
    }

    public int GetIndex() {
        return index;
    }

    public float GetCoord(int i) {
        return coords[i];
    }

    public float[] GetCoords() {
        return coords;
    }

    public double GetDistance() {
        return distance;
    }
}
