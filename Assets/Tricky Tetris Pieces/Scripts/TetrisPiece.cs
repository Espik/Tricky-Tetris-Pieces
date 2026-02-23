public class TetrisPiece {
    private int index;
    private int paletteIndex;
    private char shape;
    private int[] tilePositions;

    public TetrisPiece() {
        index = 0;
        paletteIndex = 0;
        shape = 'I';
        tilePositions = new int[] { 0, 1, 2, 3 };
    }

    public TetrisPiece(int index) {
        this.index = index;
        paletteIndex = 0;
        shape = 'I';
        tilePositions = new int[] { 0, 1, 2, 3 };
    }

    public TetrisPiece(int index, char shape, int[] tilePositions) {
        this.index = index;
        paletteIndex = 0;
        this.shape = shape;
        this.tilePositions = tilePositions;
    }

    public TetrisPiece(int index, int paletteIndex, char shape, int[] tilePositions) {
        this.index = index;
        this.paletteIndex = paletteIndex;
        this.shape = shape;
        this.tilePositions = tilePositions;
    }

    public void SetPaletteIndex(int paletteIndex) {
        this.paletteIndex = paletteIndex;
    }

    public void SetShape(char shape) {
        this.shape = shape;
    }

    public void SetTilePositions(int[] tilePositions) {
        this.tilePositions = tilePositions;
    }

    public int GetIndex() {
        return index;
    }

    public int GetPaletteIndex() {
        return paletteIndex;
    }

    public char GetShape() {
        return shape;
    }

    public int[] GetTilePositions() {
        return tilePositions;
    }
}
