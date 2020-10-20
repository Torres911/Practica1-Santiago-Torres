using System;
using System.Collections.Generic;
using Codigo.Granja;
using Codigo.GestorGranja;


namespace Codigo.Fachada{

    public class Fachada{
        #region Properties
        private Granja GranjaFachada;
        #endregion Properties

        #region Methods

        public void Menu(){
            int opc;
            do{
                Console.WriteLine("***************************************************************************\n");
                Console.WriteLine("                Bienvenido a la Granja de Robots Kogami\n");
                Console.WriteLine("***************************************************************************\n");
                Console.WriteLine("Opciones\n");
                Console.WriteLine("1. Agregar Robots a la granja.\n");
                Console.WriteLine("2. Sembrar cultivos en la granja.\n");
                Console.WriteLine("3. Liberar Robots de sus tareas.\n");
                Console.WriteLine("4. Revisar la temperatura de los cultivos y generar un reporte.\n");
                Console.WriteLine("5. Arreglar la temperatura de los cultivos con temperaturas irregulares.\n");
                Console.WriteLine("6. Regar todos los cultivos.\n");
                Console.WriteLine("7. Mover todos los cultivos a un Domo de seguridad desde el campo.\n");
                Console.WriteLine("8. Mover todos los cultivos al campo desde el Domo de seguridad.\n");
                Console.WriteLine("9. Abastecer a los Robots con mas agua.\n");
                Console.WriteLine("10. Abastecer a los Robots con mas semillas.\n");
                Console.WriteLine("11. Salir.");
                Console.WriteLine("***************************************************************************\n");
                Console.WriteLine("Digite la opcion que desea realizar dentro de la granja de robots:\n");
                opc = Console.ReadLine();
                Console.WriteLine("***************************************************************************\n");
                
                switch (opc){
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("           ¡Gracias por usar la Granja de Robots Kogami!");
                        Console.WriteLine("***************************************************************************");
                        break;
                    default:
                }
                
            } while (opc != 11);
        }

        #endregion Methods
    }

}