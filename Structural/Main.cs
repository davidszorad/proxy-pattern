using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Structural
{
    /*
    Provide a surrogate or placeholder for another object to control access to it.
        
    This structural code demonstrates the Proxy pattern which provides 
    a representative object (proxy) that controls access to another similar object.
        
    OUTPUT:
    Called RealSubject.Request()
    */

    /// <summary>
    /// MainApp startup class for Structural
    /// Proxy Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainApp()
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
