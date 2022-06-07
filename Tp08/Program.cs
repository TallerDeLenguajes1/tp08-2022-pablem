
// Console.WriteLine("Ingrese la ruta: ");
// string ruta = Console.ReadLine();
string ruta = @"C:\Users\Alumno\Documents\root";


crearArchivo(ruta, mostrarDirectorio(ruta));


static List<string> mostrarDirectorio(string ruta)
{
    var listaCarpetas = Directory.GetDirectories(ruta).ToList();
    var listasArchivos = new List<string>();
    string nombre;

    foreach (var carpeta in listaCarpetas)
    {
        Console.WriteLine(@"Carpeta: "+carpeta);
        int i=1;
        foreach (var archivo in Directory.GetFiles(carpeta))
        {
            nombre = archivo.ToString().Split(@"\").Last();
            listasArchivos.Add(nombre);
            Console.WriteLine("   Archivo "+i+++") "+nombre); //usar $
        }
    }
    return listasArchivos;
}

static void crearArchivo(string ruta, List<string> lista)
{
    string nombre;
    string extencion;
    int i=1;
    if(!File.Exists(ruta+@"\index.csv")) {
        StreamWriter sw = new StreamWriter(ruta+@"\index.csv");
    } else {
        // FileStream archiv = new File.Open(ruta+@"\index.csv", FileMode.Append);
        StreamWriter sw = new StreamWriter(ruta+@"\index.csv",true);
    }
    foreach (var archivo in lista) {
        nombre = archivo.Split('.')[0];
        extencion = archivo.Split('.')[1];
        sw.WriteLine(i+++";"+nombre+";"+extencion);
    }
    sw.Close();
}


