using System;
using Codigo.Robot;


namespace Codigo.Robot{

    public class GestorRobot{

        #region Properties

        private Robot robotSeleccionado;

        #endregion Properties

        #region Methods

        public crearRobot(){
            robotSeleccionado.setEstado("Disponible");
            robotSeleccionado.setCantAgua(1000);
            robotSeleccionado.setCantSemillas(1000);
        }

        public void LiberarRobot(){
            robotSeleccionado.setEstado("Disponible");
        }

        public void LlenarAgua(){
            robotSeleccionado.setCantAgua(1000);
        }

        public void LlenarSemillas(){
            robotSeleccionado.setCantSemillas(1000);
        }

        #endregion Methods
        
    }

}