using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Creator
    {

        public static IActors Actors(int actor)
        {
            switch (actor)
            {
                case 1:
                    return new Students();
                case 2:
                    return new Teachers();
                case 3:
                    return new Administratives();
                case 4:
                    return Director.GetDirector();
                case 5:
                    return new Parents();
                default:
                    return null;
            }
        }
    }
}
