using System;
using Codigo.Robot;


namespace Codigo.Robot{

    public class GestorRobot : Robot{

        #region Methods

        public crearRobot(){
            Estado = "Disponible";
            CantAgua = 1000;
            CantSemillas = 1000;
        }

        public void LiberarRobot(){
            Estado = "Disponible";
        }

        public void LlenarAgua(){
            CantAgua = 1000;
        }

        public void LlenarSemillas(){
            CantSemillas = 1000;
        }

        #endregion Methods
        
    }

}