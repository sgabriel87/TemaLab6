/*Scrieti un program care va modela un autoturism. Un autoturism va avea o
marca (string), un numar de inmatriculare (string), precum si o
capacitate cilindrica(int).
Autoturismul va avea:
 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
numarDeInmatriculare, capacitateCilindrica”.
Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
xml pentru metodele publice.
Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
metodele “Tipareste”
*/


Car car1 = new Car("Audi", "bh06lab", 2500);
Car car2 = new Car("Peugeot", "bh02lex", 2000);

car1.Print();
car2.Print();

class Car
{
    private string brand;
    private string registrationNumber;
    private int engineCapacity;
   
    /// <summary>
    /// Car Caracteristics
    /// </summary>
    /// <param name="brand"></param>
    /// <param name="registrationNumber"></param>
    /// <param name="engineCapacity"></param>
    public Car(string brand, string registrationNumber, int engineCapacity)
    {
        this.brand = brand;
        this.registrationNumber = registrationNumber;
        this.engineCapacity = engineCapacity;
    }

    /// <summary>
    /// Prints the description of the car.
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"{brand}, {registrationNumber}, {engineCapacity}");
    }
}


        
        
