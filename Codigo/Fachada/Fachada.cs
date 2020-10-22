using System;
using System.Collections.Generic;
using Codigo.Granja;


namespace Codigo.Fachada{

    public class Fachada{
        #region Properties
        private Granja.GestorGranja GranjaFachada = new Granja.GestorGranja();
        #endregion Properties

        #region Methods

        public void Menu(){
            int opc;
            do{
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("                Bienvenido a la Granja de Robots Kogami");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Opciones");
                Console.WriteLine("1. Agregar Robots a la granja.");
                Console.WriteLine("2. Sembrar cultivos en la granja.");
                Console.WriteLine("3. Liberar Robots de sus tareas.");
                Console.WriteLine("4. Revisar la temperatura de los cultivos y generar un reporte.");
                Console.WriteLine("5. Arreglar la temperatura de los cultivos con temperaturas irregulares.");
                Console.WriteLine("6. Regar todos los cultivos.");
                Console.WriteLine("7. Mover todos los cultivos a un Domo de seguridad desde el campo.");
                Console.WriteLine("8. Mover todos los cultivos al campo desde el Domo de seguridad.");
                Console.WriteLine("9. Abastecer a los Robots con mas agua.");
                Console.WriteLine("10. Abastecer a los Robots con mas semillas.");
                Console.WriteLine("11. Salir.");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Digite la opcion que desea realizar dentro de la granja de robots:");
                opc = int.Parse(Console.ReadLine());
                Console.WriteLine("***************************************************************************");
                
                switch (opc){
                    case 1:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.DefinirCantRobots();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 2:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.PlantarSemillas();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 3:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.LiberarRobots();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 4:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.RevisarTemperatura();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 5:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.ArreglarTemperaturaCultivos();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 6:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.RegarCultivos();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 7:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.MoverCultivosDomo();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 8:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.MoverCultivosFueraDomo();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 9:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.LlenarAguaRobot();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 10:
                        Console.WriteLine("***************************************************************************");
                        GranjaFachada.LlenarSemillasRobot();
                        Console.WriteLine("***************************************************************************");
                        break;
                    case 11:
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("           ¡Gracias por usar la Granja de Robots Kogami!");
                        Console.WriteLine("***************************************************************************");
                        break;
                    default:
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("                ¡Digite una opcion apropiada del menu!");
                        Console.WriteLine("***************************************************************************");
                        break;
                }
                
            } while (opc != 11);
        }

        #endregion Methods
    }

}