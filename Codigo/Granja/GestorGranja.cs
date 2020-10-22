using System;
using System.Collections.Generic;
using Codigo.Granja;
using Codigo.Robot;
using Codigo.Cultivo;


namespace Codigo.Granja{

    public class GestorGranja{
        #region Properties

        private Granja granjaSeleccionada = new Granja();

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
                    Console.WriteLine("Se ha reservado un robot para mover los cutivos al domo");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getCultivos()){
                        granjaSeleccionada.setDomo(temp);
                        flag = true;
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
                    Console.WriteLine("Se ha reservado un robot para mover los cultivos fuera del domo.");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getDomo()){
                        granjaSeleccionada.setCultivos(temp);
                        flag = true;
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
                    Console.WriteLine("Se ha reservado un robot para revisar la temperatura.");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getCultivos()){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            Console.WriteLine("El cultivo de tipo " + temp.getTipoCultivo() + " se encuentra por encima de la temperatura apropiada");
                            flag = true;
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
                    Console.WriteLine("Se ha reservado un robot para arreglar la temperatura de los cultivos afectados.");
                    foreach(Cultivo.Cultivo temp in granjaSeleccionada.getCultivos()){
                        if(temp.getTemperatura() < 18 || temp.getTemperatura() > 25){
                            temp.setTemperatura(cant);
                            flag = true;
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
                    tempo.setEstado("Regando Cultivos");
                    Console.WriteLine("Se ha reservado un robot para regar los cultivos.");
                    flag = true;
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
                    tempo.setEstado("Plantando Semillas");
                    Console.WriteLine("Se ha reservado un robot para regar los cultivos.");
                    for (int i = 0; i < cant; i++){
                        Cultivo.Cultivo temp = new Cultivo.Cultivo();
                        granjaSeleccionada.setCultivos(temp);
                        flag = true;
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

        public void LlenarSemillasRobot(){
            Robot.GestorRobot temp = new Robot.GestorRobot();
            Console.WriteLine("Se ha abastecido a los robots con mas semillas.");
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                temp.LlenarSemillas(tempo);
            }
        }

        public void LiberarRobots(){
            Robot.GestorRobot temp = new Robot.GestorRobot();
            Console.WriteLine("Se han liberado todos los robots de sus trabajos.");
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                temp.LiberarRobot(tempo);
            }
        }

        public void LlenarAguaRobot(){
            Robot.GestorRobot temp = new Robot.GestorRobot();
            Console.WriteLine("Se ha abastecido a los robots con mas agua.");
            foreach(Robot.Robot tempo in granjaSeleccionada.getRobots()){
                temp.LlenarAgua(tempo);
            }
        }

        #endregion Methods
    }
}