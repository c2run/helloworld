namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          var paisesUE = new List<string>() {"España", "Austria", "Italia", "Alemania", "Dinamarca","Suecia", "Finlandia"};
          var paisesUEL = new List<string>();
          
          //recorro todos los paises de la lista
          foreach(var p in paisesUE)
          {
            //verifico si la longitud es mayor a 6 caracteres y añado a la lista p
            if(p.Length > 6)
            paisesUE.Add(p);
          }
        //se puede hacer lo mismo con linq de manera reducida
        var paisesUELLinq = paisesUE.Where(p => p.Length > 6);
        }
    }
}