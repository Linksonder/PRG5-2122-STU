using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using WieIsDeMol.domain;

namespace WieIsDeMol
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new GameController();
            controller.Start();


        }
    }
}
