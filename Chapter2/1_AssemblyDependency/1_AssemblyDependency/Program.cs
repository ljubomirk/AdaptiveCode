﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePrinter;

namespace _1_AssemblyDependency {
    class Program {
        static void Main(string[] args) {
            Console.ReadKey();
            MessagePrinterService service = new MessagePrinterService();
            service.PrintMessage();
        }
    }
}
