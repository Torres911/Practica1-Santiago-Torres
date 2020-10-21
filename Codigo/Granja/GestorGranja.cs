using System;
using System.Collections.Generic;
using Codigo.Granja;
using Codigo.Robot;
using Codigo.Cultivo;


namespace Codigo.Granja{

    public class GestorGranja{
        #region Properties

        private Granja granjaSeleccionada;

        #endregion Properties

        #region Methods
        public void DefinirCantRobots(){
            int cant;
            Console.WriteLine("Digite la cantidad de robots que necesita agregar a su granja: ");
            cant = int.Parse(Console.ReadLine());
            for(int i = 0; i < cant; i++){
                Robot.Robot temp = new Robot.Robot();
                granjaSeleccionada.setRobots(temp);
            }
        }

        public void MoverCultivosDomo(){
            bool flag = false;
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Moviendo Cultivos Dentro Domo");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getCultivos()){
                        granjaSeleccionada.setDomo(temp);
                    }
                    granjaSeleccionada.limpiarCultivos();
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
            }
        }

        public void MoverCultivosFueraDomo(){
            bool flag = false;
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Moviendo Cultivos Fuera Domo");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getDomo()){
                        granjaSeleccionada.setCultivos(temp);
                    }
                    granjaSeleccionada.limpiarDomo();
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
            }
        }

        public void RevisarTemperatura(){
            bool flag = false;
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Revisando Temperatura");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getCultivos()){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            Console.WriteLine("El cultivo de tipo " + temp.getTipoCultivo() + " se encuentra por encima de la temperatura apropiada");
                        }
                    }
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
            }
        }

        public void ArreglarTemperaturaCultivos(){
            bool flag = false;
            Random random = new Random();
            int cant = random.Next(18,25);
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                if(tempo.getEstado() == "Disponible"){
                    tempo.setEstado("Arreglando Temperatura Cultivos");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getCultivos()){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            temp.setTemperatura(cant);
                        }
                    }
                    break;
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
            }
        }

        public void RegarCultivos(){
            bool flag = false;
            Random random  = new Random();
            int cant = random.Next(1,10);
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                if(tempo.getEstado() == "Disponible" && tempo.getCantAgua() > 10){
                    tempo.setCantAgua(tempo.getCantAgua() - cant);
                    break;
                }else if(tempo.getEstado() == "Disponible" && tempo.getCantAgua() < 10){
                    Console.WriteLine("El robot no tiene suficiente agua para regar los cultivos");
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
            }
        }

        public void PlantarSemillas(){
            bool flag = false;
            Random random  = new Random();
            int cant = random.Next(1,10);
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                if(tempo.getEstado() == "Disponible" && tempo.getCantSemillas() > 10){
                    tempo.setCantSemillas(tempo.getCantSemillas() - cant);
                    for (int i = 0; i < cant; i++){
                        Cultivo.Cultivo temp = new Cultivo.Cultivo();
                        granjaSeleccionada.setCultivos(temp);
                    }
                    break;
                }else if(tempo.getEstado() == "Disponible" && tempo.getCantSemillas() < 10){
                    Console.WriteLine("El robot no tiene suficiente semillas para cultivar mas");
                }
            }
            if(flag == false){
                Console.WriteLine("No hay Robots Disponibles");
            }
        }
        /*
        public void llenarSemillasRobot(){
            foreach(Robot.GestorRobot tempo in granjaSeleccionada.getRobots()){
                tempo.LlenarSemillas();
            }
        }

        public void liberarRobots(){
            foreach(Robot.GestorRobot tempo in granjaSeleccionada.getRobots()){
                tempo.LiberarRobot();
            }
        }

        public void llenarAguaRobot(){
            foreach(Robot.GestorRobot tempo in granjaSeleccionada.getRobots()){
                tempo.LlenarAgua();
            }
        }
        */
        #endregion Methods
    }

}