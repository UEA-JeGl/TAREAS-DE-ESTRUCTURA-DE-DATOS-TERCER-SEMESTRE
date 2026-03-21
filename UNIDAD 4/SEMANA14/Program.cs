using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

class ArbolBST
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = InsertarRec(raiz.Derecho, valor);

        return raiz;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
            return false;

        if (valor == raiz.Valor)
            return true;

        if (valor < raiz.Valor)
            return BuscarRec(raiz.Izquierdo, valor);
        else
            return BuscarRec(raiz.Derecho, valor);
    }

    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo EliminarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
            return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = EliminarRec(raiz.Derecho, valor);
        else
        {
            if (raiz.Izquierdo == null)
                return raiz.Derecho;
            else if (raiz.Derecho == null)
                return raiz.Izquierdo;

            raiz.Valor = Minimo(raiz.Derecho);
            raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor);
        }

        return raiz;
    }

    public int Minimo(Nodo raiz)
    {
        int min = raiz.Valor;
        while (raiz.Izquierdo != null)
        {
            min = raiz.Izquierdo.Valor;
            raiz = raiz.Izquierdo;
        }
        return min;
    }

    public int Maximo(Nodo raiz)
    {
        int max = raiz.Valor;
        while (raiz.Derecho != null)
        {
            max = raiz.Derecho.Valor;
            raiz = raiz.Derecho;
        }
        return max;
    }

    public int Altura(Nodo nodo)
    {
        if (nodo == null)
            return -1;

        int izq = Altura(nodo.Izquierdo);
        int der = Altura(nodo.Derecho);

        return Math.Max(izq, der) + 1;
    }

    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Derecho);
        }
    }

    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    public void Limpiar()
    {
        Raiz = null;
    }
}

class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENÚ BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorridos");
            Console.WriteLine("5. Min, Max, Altura");
            Console.WriteLine("6. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valor) ? "Encontrado" : "No encontrado");
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valor);
                    break;

                case 4:
                    Console.WriteLine("Inorden:");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine("\nPreorden:");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine("\nPostorden:");
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    if (arbol.Raiz != null)
                    {
                        Console.WriteLine("Mínimo: " + arbol.Minimo(arbol.Raiz));
                        Console.WriteLine("Máximo: " + arbol.Maximo(arbol.Raiz));
                        Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    }
                    else
                        Console.WriteLine("El árbol está vacío.");
                    break;

                case 6:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol eliminado.");
                    break;
            }

        } while (opcion != 0);
    }
}