void adivina()
{
    const int oportunidades = 4;
    int numeroCPU, numerousuario;
    byte intentos, banderacontrol;
    string linea;

    Random rand=new Random();

 
        numeroCPU=Convert.ToInt32(rand.Next(1,20));
        //Console.WriteLine(numeroCPU);
    //proceso

    intentos = 1;
    banderacontrol=0;
    do
    {
        Console.Write("Hola estoy pensando en un numero, cual crees que es?: ");
        numerousuario=Convert.ToInt32(Console.ReadLine());
        if ((numerousuario==numeroCPU))
        {
            Console.WriteLine("Yes! adivinastes");
            banderacontrol = 1;
        }
        else
        {
            if (numerousuario>numeroCPU)
            {
                Console.WriteLine("Me pase");
            }
            else
            {
                Console.WriteLine("Me quedo corto");
            }
        }
        intentos++;
    } while (((intentos <= oportunidades) & (banderacontrol == 0)));

    if (banderacontrol==0)
    {
        Console.WriteLine("El numero que pense era: " + numeroCPU);
    }
}

void buscamayor()
{
    int mayor = 0,mayor1=100;
    int numero = 0;
    Random rand = new Random();
    for (int i=0;i<5;i++)
    {
        numero=rand.Next(100);
        if (numero>mayor)
        {
            mayor = numero;
        }
        if (numero<mayor1)
        {
            mayor1 = numero;
        }
        Console.WriteLine("numero random: "+numero);
    }
    Console.WriteLine("El numero mayor es: "+mayor);
    Console.WriteLine("El numero menor es: " + mayor1);
}

void arreglos()
{
    int[] notas = new int[15];
    Random rand= new Random();
    int promedio = 0;
    for (int i=0;i<notas.Length;i++)
    {
        notas[i] = rand.Next(100);
        promedio = (notas[i] + notas[i]) / notas.Length;
    }
    Console.WriteLine("Desplegando informacion: ");
    int mayor = 0;
    int menor = 100;
    for (int i=0;i<notas.Length;i++)
    {
        Console.WriteLine(notas[i]);
        if (notas[i] > mayor) 
        {
            mayor = notas[i];
        }
        if (notas[i]<menor)
        {
            menor = notas[i];
        }
        
    }
    Console.WriteLine("Nota mas alta: "+mayor);
    Console.WriteLine("Nota mas baja: "+menor);
    Console.WriteLine("Promedio: " + promedio);
    //ejercicio hacer notas mas alta y baja, en el segundo for de este metodo,
}
void nombre()
{
    int numero=0;
    string[] nombre=new string[10];
    nombre[0] = "jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Helen";
    nombre[7] = "Jonatan";
    nombre[8] = "Melki";
    nombre[9] = "Luis fer";
    Random random= new Random();
    for (int i=0;i<nombre.Length;i++)
    {
        numero = random.Next(10);
        Console.WriteLine(i + ": " + nombre[i] + ":" + numero);
        if (numero==2)
        {
            Console.WriteLine("Ganador pierna de cerdo");
        }
        if (numero==3)
        {
            Console.WriteLine("ganador cerdo sin pierna");
        }
    }
}
nombre();
//arreglos();
//buscamayor();
//adivina();