using System;
using System.Collections.Generic;
using Codigo.Granja;
using Codigo.Robot;
using Codigo.Cultivos;


namespace Codigo.Granja{

    public class GestorGranja{
        #region Properties

        private Granja granjaSeleccionada;

        #endregion Properties

        #region Methods
        public void DefinirCantRobots(){
            int cant;
            Console.WriteLine("Digite la cantidad de robots que necesita agregar a su granja: ");
            cant = Console.ReadLine();
            for(int i = 0; i < cant; i++){
                granjaSeleccionada.Robots.Add(new crearRobot());
                
            }
        }

        public void MoverCultivosDomo(){
            bool flag = false;
            foreach(Robot tempo in granjaSeleccionada.Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Moviendo Cultivos Dentro Domo");
                    foreach(Cultivo temp in granjaSeleccionada.Cultivos){
                        granjaSeleccionada.Domo.Add(temp);
                    }
                    granjaSeleccionada.Cultivos.clear();
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
            foreach(Robot tempo in granjaSeleccionada.Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Moviendo Cultivos Fuera Domo");
                    foreach(Cultivo temp in granjaSeleccionada.Domo){
                        granjaSeleccionada.Cultivos.Add(temp);
                    }
                    granjaSeleccionada.Domo.clear();
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
            foreach(Robot tempo in granjaSeleccionada.Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Revisando Temperatura");
                    foreach(Cultivo temp in granjaSeleccionada.Cultivos){
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
            foreach(Robot tempo in granjaSeleccionada.Robots){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Arreglando Temperatura Cultivos");
                    foreach(Cultivo temp in granjaSeleccionada.Cultivos){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            temp.setTemperatura(Random.Next(18,25));
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

        public void RegarCultivos(){
            bool flag = false;
            foreach(Robot tempo in granjaSeleccionada.Robots){
                if(tempo.getEstado() == "Disponible" && tempo.getCantAgua() > 10){
                    tempo.setCantAgua(tempo.getCantAgua() - Random.Next(1,10));
                    break;
                }else if(tempo.getEstado() == "Disponible" && tempo.getCantAgua() < 10){
                    Console.WriteLine("El robot no tiene suficiente agua para regar los cultivos");
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
                break;
            }
        }

        public void PlantarSemillas(){
            bool flag = false;
            foreach(Robot tempo in granjaSeleccionada.Robots){
                if(tempo.getEstado() == "Disponible" && tempo.getCantSemillas() > 10){
                    tempo.setCantSemillas(tempo.getCantSemillas() - Random.Next(1,10));


                    //FALTA AGREGAR ELEMENTOS A LA LISTA CULTIVOS EN ESTE PASO



                    break;
                }else if(tempo.getEstado() == "Disponible" && tempo.getCantSemillas() < 10){
                    Console.WriteLine("El robot no tiene suficiente semillas para cultivar mas");
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
                break;
            }
        }
        #endregion Methods
    }

}