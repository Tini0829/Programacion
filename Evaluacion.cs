using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;

class Evaluacion {

    public Evaluacion(string[] names, string[] ids, int[] ages, double[] gpas) {
        this.names = names;
        this.ids = ids;
        this.ages = ages;
        this.gpas = gpas;
    }

    // ----- PARCIAL -----

    // Espacio para declaración de variables
    string[] names;
    string[] ids;
    int[] ages;
    double[] gpas;


    public int PrimerPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int salida = 0;
        int x = 0;
        
        for (int i=0; i < ages.Length; i++)
        {
            x += ages[i];
        }
        
        x = x / ages.Length - 2;

        for(int i=0; i<ages.Length; i++)
        {
           if (ages[i]<=x && gpas[i] >= 3)
           {
            salida += 1;
           }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        //string[] salida = new string[0]; // Puede cambiarse por una lista si se considera pertinente
        List<string> salida = new List<string>();

        double x = 0;

        for (int i = 0; i < ages.Length; i++)
        {
            x += ages[i];
        }

         x = x / ages.Length-2;

        for(int i = 0; i < ages.Length; i++)
        {
            if(gpas[i]>=3 && ages[i] <= x)
            {
                salida.Add(names[i]);
            }
        }


        //- Arriba de esta línea va su código --------
        return Extras.To(salida);
    }

    public string[] TercerPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string[] salida = new string[3]; // Puede cambiarse por una lista si se considera pertinente
        

        //- Arriba de esta línea va su código --------
        return Extras.To(salida);
    }

    public string[] CuartoPunto() {
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        //string[] salida = new string[0]; // Puede cambiarse por una lista si se considera pertinente

        List<string> salida = new List<string>();

        for (int i = 0; i < names.Length; i++)
        {
            for (int j = 0; j < names[i].Length; j++)
            {
                double y = Char.GetNumericValue(ids[i][5]);

                if (y < 8 && names[i][j] == 'a' || names[i][j] == 'A')
                {
                    salida.Add(names[i]);
                    break;
                }
            }
        }


        //- Arriba de esta línea va su código --------
        return Extras.To(salida);
    }
}
