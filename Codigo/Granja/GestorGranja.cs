using System;
using System.Collections.Generic;
using Codigo.Granja;
using Codigo.Robot;
using Codigo.Cultivos;


namespace Codigo.Granja{

    public class GestorGranja : Granja{

        public void DefinirCantRobots(){
            int cant;
            Console.WriteLine("Digite la cantidad de robots que necesita agregar a su granja: ");
            cant = Console.ReadLine();
            for(int i = 0; i < cant; i++){
                Robots.Add(new crearRobot());
            }
        }

        public void MoverCultivosDomo(){
            bool flag = false;
            foreach(Robot tempo in Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Moviendo Cultivos Dentro Domo");
                    foreach(Cultivo temp in Cultivos){
                        Domo.Add(temp);
                    }
                    Cultivos.clear();
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
                break;
            }
        }

        public void MoverCultivosFueraDomo(){
            bool flag = false;
            foreach(Robot tempo in Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Moviendo Cultivos Fuera Domo");
                    foreach(Cultivo temp in Domo){
                        Cultivos.Add(temp);
                    }
                    Domo.clear();
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
                break;
            }
        }

        public void RevisarTemperatura(){
            bool flag = false;
            foreach(Robot tempo in Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Revisando Temperatura");
                    foreach(Cultivo temp in Cultivos){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            Console.WriteLine("El cultivo " + temp.getTipoCultivo() + " se encuentra por encima de la temperatura apropiada");
                        }
                    }
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
                break;
            }
        }

        public void ArreglarTemperaturaCultivos(){
            bool flag = false;
            foreach(Robot tempo in Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Arreglando Temperatura Cultivos");
                    foreach(Cultivo temp in Cultivos){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            temp.setTemperatura(random.Next(18,25));
                        }
                    }
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
                break;
            }
        }

    }

}