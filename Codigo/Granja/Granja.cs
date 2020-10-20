using System;
using System.Collections.Generic;
using Codigo.Robot;
using Codigo.Cultivos;


namespace Codigo.Granja{

    public class Granja{
        
        #region Properties
        private List<Robot> robots = new List<Robot>();
        private List<Cultivo> cultivos = new List<Cultivo>();
        private List<Cultivo> domo = new List<Cultivo>();
        #endregion Properties

        #region Getters & Setters
        
        public List<Robot> Robots{
            get { return robots; }
            set { robots = value; }
        }

        public List<Cultivo> Cultivos{
            get { return cultivos; }
            set { cultivos = value; }
        }

        public List<Cultivo> Domo{
            get { return domo; }
            set { domo = value; }
        }

        #endregion Getters & Setters

    }

}