public class TetrisPalette {
    private int index;
    private int paletteID;
    private string paletteName;
    private string[] paletteColors;
    private bool[] validStarts;

    public TetrisPalette() {
        index = 0;
        paletteID = 0;
        paletteName = "Undefined";
        paletteColors = new string[] { "#000000", "#000000", "#000000" };
        validStarts = new bool[] { true, true, true };
    }

    public TetrisPalette(int index, int paletteID, string paletteName, string[] paletteColors, bool[] validStarts) {
        this.index = index;
        this.paletteID = paletteID;
        this.paletteName = paletteName;
        this.paletteColors = paletteColors;
        this.validStarts = validStarts;
    }

    public int GetIndex() {
        return index;
    }

    public int GetPaletteID() {
        return paletteID;
    }

    public string GetPaletteName() {
        return paletteName;
    }

    public string GetPaletteColor(int i) {
        return paletteColors[i];
    }

    public string[] GetPaletteColors() {
        return paletteColors;
    }

    public bool[] GetValidStarts() {
        return validStarts;
    }
}