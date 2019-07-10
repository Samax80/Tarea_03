using System;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        if (sortedArray[0] >= lessThan) return 0;//Si el array inicia con valor mayor o igual a lessThan retorna cero debido a que  no existen valores menores  a lessThan.

        int lengthOfArray = sortedArray.Length;//se asigna el valor entero de el tamaño del array "sortedArray"
        if (lengthOfArray == 0) return 0;//si el tamaño del arreglo  es  cero (vacio) retorna 0.
        if (sortedArray[lengthOfArray - 1] < lessThan) return lengthOfArray;//si en la posicion [lengthOfArray - 1] el valor es menor que "lessThan" retorna lengthOfArray,debido a que es la maxima cantidad de elementos menores que lessthan.

        int index_delarray = Array.BinarySearch(sortedArray, lessThan);//Array.BinarySearch busca en el array sortedArray el valor lessthan y retorna su posicion
        if (index_delarray < 0)//si la posicion es negativa quiere decir que  lessthan no exsite, no se encuentra en el array sortedArray 
        return ~index_delarray;//destruye el index al no haber encontrado el valor  lessthan  en el array.

        return index_delarray;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1,2,3,4 }, 4));//Esta funcion busca si existen valores menores a lessThan=4 en el array={ 1,2,3,4 },y devuelve la cantidad de elemntos menores a 4 si los encuentra        

        Console.ReadLine();
    }
}