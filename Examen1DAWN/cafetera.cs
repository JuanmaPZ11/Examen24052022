
using System;


//namespace EDexamenT6a8
    //<summary>
    //Clase cafeteria donde se va a especificar
    //todo lo relacionado a esta.
    //<remmarks>Recuerda solo utilizar esta clase si va a usar la cafetera</remmarks>
    //</summary>
class cafetera
{
    //<summary>
    //Refactorizacion de codigo, poner esto en privado porque se lo pasamos al constructor.
    //</summary>
    private string marca;
    private string referencia;
    private double cantidadAgua;
    private double totaldecapsulas;
    private const double consumoAgua = 0.1; //<summary>Refactorizacion de constante.</summary>
    //<summary>
    //Constructor de la clase cafetera
    //<param name="marca">La marca de la cafetera</param>
    //<param name="referencia">referencia del modelo de la cafetera</param>
    //<param name="cantidadAgua">La cantidad de agua del recipiente</param>
    //<param name="totaldeCapsulas">Total de capsulas de la cafeteras</param>
    //</summary>
    public cafetera(string marca, string referencia, double cantidadAgua, double totaldecapsulas)
    {
        this.marca = marca; //marca de la máquina cafetera
        this.referencia = referencia; //referencia del modelo
        this.totaldecapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
        this.cantidadAgua = cantidadAgua; //Cantidad de agua en el recipiente. 
    }
    //<summary>
    //Metodo que utilizamos para saber si a partir de un numero de cafés nos va a llegar el agua
    //</summary>
    //<param name="numerodecafe">Nuemro de cafes a hacer.</param>
    //<returns>Esta funcion devuelve un tipo string que nos dice si queda agua o no </returns>
    public string ConsumoAgua(double numerodecafe) //numero de cafés a hacer
    {
        this.cantidadAgua = this.cantidadAgua - numerodecafe * consumoAgua; // Constante de consumo de agua 0.1l por cada unidad de café. 
        if (this.cantidadAgua < 0.1)
        {   
            this.cantidadAgua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else
        { 
            return "Quedan" + this.cantidadAgua + " centilitros";
        }
    }
    //<summary>
    //Metodo que utilizamos para saber si nos van a llegar las capsulas
    //</summary>
    //<param name="numerodecafe">Nuemro de cafes a hacer.</param>
    //<returns>Esta funcion devuelve un tipo string que nos dice si faltan capsulas o el numero que quedan en la cafetera </returns>
    public string ConsumoCapsulas(double numerodecafe) //Hacer un café 
    {
        this.totaldecapsulas = this.totaldecapsulas - numerodecafe;
        if (this.totaldecapsulas < 0)
        {
            this.totaldecapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else 
        {
            return "Quedan" + this.totaldecapsulas + "unidades";
        }
    }
    //<summary>
    //Metodo que utilizamos para reponer capsulas
    //</summary>
    //<param name="cantidadcapsulas">Cantidad de capsulas para reponer</param>
    //<returns>Esta funcion modifica el campo de total de capsulas al numero que nosotros le pasemos </returns>
    public void ReponerCapsulas(double cantidadcapsulas)
    {
        this.totaldecapsulas = this.totaldecapsulas + cantidadcapsulas;
    }
    //<summary>
    //Metodo que utilizamos para llenar el deposito
    //</summary>
    //<param name="litros">Numero de litros a introducir</param>
    //<returns>Esta funcion modifica el campo de cantidad de agua y se suman los litros que nosotros le pasemos. </returns>
    public void LlenarDeposito(double litros)
    {
        this.cantidadAgua = this.cantidadAgua + litros;
    }

}


class ejemplodemicafetera
{
    //<summary>
    //Clase ejemplodemicafetera, donde se va a probar el codigo
    //<remmarks>Recuerda que solo puedes utlizar esta clase para probar el codigo</remmarks>
    //</summary>

    static void main()
    {

        //<summary>
        //Creacion de la cafetera
        //</summary>
        //<param name="mi_cafetera_ejemplo">Cafetera</param>
        cafetera mi_cafetera_ejemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(mi_cafetera_ejemplo.cantidadAgua);//<summary>Mostramos la cantidad de agua</summary>
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5));//<summary>Mostramos y Utilizamos el metodo de consumir capsulas</summary>
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);//<summary>Mostramos el total de capsulas</summary>
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoAgua(5));//<summary>Mostramos y Utilizamos el metodo de consumir agua</summary>
        Console.WriteLine(mi_cafetera_ejemplo.cantidadAgua);
        mi_cafetera_ejemplo.LlenarDeposito(0.5);//<summary>Llenamos el deposito</summary>
        Console.WriteLine(mi_cafetera_ejemplo.cantidadAgua);
        mi_cafetera_ejemplo.ReponerCapsulas(3);//<summary>Utilizamos el metodo de reppner capsulas</summary>
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);//<summary>Mostramos el total de capsulas</summary>


    }

}