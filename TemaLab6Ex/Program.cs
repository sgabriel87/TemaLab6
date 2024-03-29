/*Ex 1
Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.
Folositi o clasa care va modela un dulap.
 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
afisati rezultatul.*/



Closet myCloset = new Closet(2, 3, 4);

int volume = myCloset.CalculateVolume();
Console.WriteLine("The volume of the closet is: " + volume);


class Closet
{
    private int length;
    private int width;
    private int height;

    public Closet(int length, int width, int height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public int CalculateVolume()
    {
        int volume = length * width * height;
        return volume;
    }
}


