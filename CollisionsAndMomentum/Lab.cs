using System;
using System.Collections.Generic;
using VectorClassLab;

namespace CollisionsAndMomentum
{
    /// <summary>
    /// @Author: Andrew Seba
    /// @Description: Models a reflection off of a plane.   
    /// </summary>
    class Lab
    {

        /*
         * Simple Test Cases:
         * M = mass
         * V = velocity
         * 
         * Collisions:                             * Reflections:                   
         *  M1 = 10                                *<Vi> = <10,10, -10>         
         *  M2 = 10                                *Plane defined by            
         *  e = 1                                  *<1, 0, 0>, <0, 1, 0>        
         *  V1i = 10                               *                            
         *  V2i = 0                                *e = 1, <Vf> = <10, 10, 10>  
         *                                         *e = 0, <Vf> = <10, 10, 0>   
         *  V1f = 0, V2f = 10   V1f = V2f = 5      *                            
         */

        public void DoReflection()
        {
            Console.WriteLine("Collision and Momentum");

            Console.Write("What is the initial velocity vector for the object (Rectangular Coordinates)?");

            Vector3D velocity = GetVector("Velocity Vector");

            Console.WriteLine("What is the coefficient of restitution?");
            float coeff = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Plane definitionVectors: ");
            Vector3D p1 = GetVector("Vector1 of the Plane");
            Vector3D p2 = GetVector("Vector2 of the Plane");

            Vector3D N = p1.Cross(p2);

            Vector3D reflection = velocity - (N & (N * velocity) & (1 + coeff));

            reflection.PrintRect();

            Console.ReadLine();
        }

        public void DoCollision()
        {
            Console.WriteLine("1D Collision");
            Console.Write("Velocity 1: ");
            float velocity1i = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Velocity 2: ");
            float velocity2i = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Mass 1: ");
            float mass1 = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Mass 2: ");
            float mass2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Coefficient of Restitution: ");
            float coeff = (float)Convert.ToDouble(Console.ReadLine());


            float velocity1f = ((mass1 - coeff * mass2) * velocity1i + (1 + coeff) * mass2 * velocity2i) / (mass1 + mass2);
            float velocity2f = velocity1f + (coeff * (velocity1i - velocity2i));
            Console.WriteLine("V1f: " + velocity1f.ToString("F2"));
            Console.WriteLine("V2f: " + velocity2f.ToString("F2"));

            Console.ReadKey();

        }

        #region Getters
        /// <summary>
        /// Gets a vector from the user in x,y,z coordinates.
        /// </summary>
        /// <returns>New Vector</returns>
        private Vector3D GetVector()
        {
            Console.Write("\nx: ");
            float x = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            float y = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("z: ");
            float z = (float)Convert.ToDouble(Console.ReadLine());

            return new Vector3D(x, y, z);
        }


        /// <summary>
        /// Gets a vector from the user in x,y,z coordinates. with a message
        /// parameter to tell the user what the vector is for.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private Vector3D GetVector(string message)
        {
            Console.WriteLine(message);
            Console.Write("x: ");
            float x = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            float y = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("z: ");
            float z = (float)Convert.ToDouble(Console.ReadLine());

            return new Vector3D(x, y, z);
        }

        #endregion
    }
}
