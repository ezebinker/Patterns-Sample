﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones_estructurales
{
    class Program
    {/// <summary>
     /// MainApp startup class for Structural
     /// Adapter Design Pattern.
     /// </summary>
        class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>
            static void Main1()
            {
                // Create adapter and place a request
                Target target = new Adapter();
                target.Request();

                // Wait for user
                Console.ReadKey();
            }
        }

        /// <summary>
        /// The 'Target' class
        /// </summary>
        class Target
        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }

        /// <summary>
        /// The 'Adapter' class
        /// </summary>
        class Adapter : Target
        {
            private Adaptee _adaptee = new Adaptee();

            public override void Request()
            {
                // Possibly do some other work
                //  and then call SpecificRequest
                _adaptee.SpecificRequest();
            }
        }

        /// <summary>
        /// The 'Adaptee' class
        /// </summary>
        class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
    }
}
