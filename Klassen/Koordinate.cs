namespace Klassen
{
    class Koordinate
    {
        //Mitglieder, member --> Alle Elemente einer Klasse

        //Felder, fields, Attribute (UML)
        public int x; // default 0
        public int y;
        public string farbe; // default ""
        public string name;

        // Konstruktor, constructor
        // Snippet ctor
        public Koordinate(int xWert,int yWert)
        {
            x = xWert;
            y = yWert;
        }

        //Methoden
        public void Verschiebe(int DeltaX, int DeltaY)
        {
            x += DeltaX;
            if (x < 0) x = 0;
            y += DeltaY;
        }
    }
}
