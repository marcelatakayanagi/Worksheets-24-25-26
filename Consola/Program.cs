using WorkSheets;
using System;
using WorkSheets.Pets;
using WorkSheets.Worksheet_26;
using WorkSheets.Worksheet_26.Pen;
using WorkSheets.Worksheet_26.Pencil;
using WorkSheets.Worksheet_26.ColoredPencil;
using System.Threading;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // build vehicle
            var v1 = new Vehicle("toyota", "corolla", 2018, 280);

            // test current speed, max speed, speed up and brake
            Console.WriteLine($"Vehicle speed should be 0. It is: {v1.CurrentSpeed}");
            v1.Accelerate(30);
            Console.WriteLine($"Vehicle speed should be 30. It is: {v1.CurrentSpeed}");
            v1.Brake(5);
            Console.WriteLine($"Vehicle speed should be 25. It is: {v1.CurrentSpeed}");
            v1.Accelerate(400);
            Console.WriteLine($"Vehicle speed should be 280. It is: {v1.CurrentSpeed}");
            v1.Brake(400);
            Console.WriteLine($"Vehicle speed should be 0. It is: {v1.CurrentSpeed}");

            // test wheel direction
            Console.WriteLine($"Vehicle wheel direction should be center as it was constructed. It is: {v1.WheelDirection}");
            v1.TurnWheel("right");
            Console.WriteLine($"Vehicle wheel direction should be right. It is: {v1.WheelDirection}");
            v1.TurnWheel("left");
            Console.WriteLine($"Vehicle wheel direction should be left. It is: {v1.WheelDirection}");
            v1.TurnWheel("above");
            Console.WriteLine($"Vehicle wheel direction should not have been changed. Therefore it should be left. It is: {v1.WheelDirection}");
            v1.TurnWheel("center");
            Console.WriteLine($"Vehicle wheel direction should be center. It is: {v1.WheelDirection}");

            // test turning on and off
            Console.WriteLine($"Vehicle should be off as it was constructed. It is: {v1.IsOn}");
            v1.Start();
            Console.WriteLine($"Vehicle should be on. It is: {v1.IsOn}");
            v1.Stop();
            Console.WriteLine($"Vehicle should be off as it was constructed. It is: {v1.IsOn}");

            //test get brand, model, licencePlate
            Console.WriteLine($"The vehicle brand should be toyota. it is: {v1.Brand}");
            Console.WriteLine($"The vehicle model should be corolla. it is: {v1.Model}");
            Console.WriteLine($"The vehicle license plate should be 2018. it is: {v1.LincensePlateYear}");

            //test change of gear
            Console.WriteLine($"The vehicle gear should be N as it was constructed. It is: {v1.Gear}");
            v1.ChangeGear('R');
            Console.WriteLine($"The vehicle gear should be R. It is: {v1.Gear}");
            v1.ChangeGear('1');
            Console.WriteLine($"The vehicle gear should be 1. It is: {v1.Gear}");
            v1.ChangeGear('2');
            Console.WriteLine($"The vehicle gear should be 2. It is: {v1.Gear}");
            v1.ChangeGear('3');
            Console.WriteLine($"The vehicle gear should be 3. It is: {v1.Gear}");
            v1.ChangeGear('4');
            Console.WriteLine($"The vehicle gear should be 4. It is: {v1.Gear}");
            v1.ChangeGear('5');
            Console.WriteLine($"The vehicle gear should be 5. It is: {v1.Gear}");
            v1.ChangeGear('N');
            Console.WriteLine($"The vehicle gear should be N. It is: {v1.Gear}");
            v1.ChangeGear('9');
            Console.WriteLine($"The vehicle gear is: {v1.Gear}");
            */
            /*
            //build motorcycle
            var m1 = new Motorcycle("honda", "XPTO", 2019, 200);

            // tests if is on or off
            Console.WriteLine($"The motorcycle should be off by default. It is: {m1.IsOn}");
            m1.Start();
            Console.WriteLine($"The motorcycle should be on. It is: {m1.IsOn}");
            m1.Stop();
            Console.WriteLine($"The motorcycle should be off. It is: {m1.IsOn}");

            // tests current speed, accelerate, brake, max speed
            Console.WriteLine($"By default current speed should be 0. It is: {m1.CurrentSpeed}");
            m1.Accelerate(30);
            Console.WriteLine($"Current speed should be 30. It is: {m1.CurrentSpeed}");
            m1.Brake(10);
            Console.WriteLine($"Current speed should be 20. It is: {m1.CurrentSpeed}");
            m1.Accelerate(300);
            Console.WriteLine($"Current speed should be 200. It is: {m1.CurrentSpeed}");
            m1.Brake(300);
            Console.WriteLine($"Current speed should be 0. It is: {m1.CurrentSpeed}");

            // test wheel direction
            Console.WriteLine($"Motorcycle handbars direction should be center as it was constructed. It is: {m1.WheelDirection}");
            m1.TurnWheel("right");
            Console.WriteLine($"Motorcycle handbars direction should be right. It is: {m1.WheelDirection}");
            m1.TurnWheel("left");
            Console.WriteLine($"Motorcycle handbars direction should be left. It is: {m1.WheelDirection}");
            m1.TurnWheel("above");
            Console.WriteLine($"Motorcycle handbars direction should not have been changed. Therefore it should be left. It is: {m1.WheelDirection}");
            m1.TurnWheel("center");
            Console.WriteLine($"Motorcycle handbars direction should be center. It is: {m1.WheelDirection}");

            //test get brand, model, licencePlate
            Console.WriteLine($"The motorcycle brand should be honda. it is: {m1.Brand}");
            Console.WriteLine($"The motorcycle model should be XPTO. it is: {m1.Model}");
            Console.WriteLine($"The motorcycle license plate should be 2019. it is: {m1.LincensePlateYear}");

            //test change of gear
            Console.WriteLine($"The motorcycle gear should be N as it was constructed. It is: {m1.Gear}");
            m1.ChangeGear('1');
            Console.WriteLine($"The motorcycle gear should be 1. It is: {m1.Gear}");
            m1.ChangeGear('2');
            Console.WriteLine($"The motorcycle gear should be 2. It is: {m1.Gear}");
            m1.ChangeGear('3');
            Console.WriteLine($"The motorcycle gear should be 3. It is: {m1.Gear}");
            m1.ChangeGear('4');
            Console.WriteLine($"The motorcycle gear should be 4. It is: {m1.Gear}");
            m1.ChangeGear('5');
            Console.WriteLine($"The motorcycle gear should be 5. It is: {m1.Gear}");
            m1.ChangeGear('N');
            Console.WriteLine($"The motorcycle gear should be N. It is: {m1.Gear}");
            m1.ChangeGear('9');
            Console.WriteLine($"The motorcycle gear is: {m1.Gear}");
            */
            /*
            //build boat
            var b1 = new Motorcycle("karnic", "SL702", 2016, 38);

            // tests if is on or off
            Console.WriteLine($"The boat should be off by default. It is: {b1.IsOn}");
            b1.Start();
            Console.WriteLine($"The boat should be on. It is: {b1.IsOn}");
            b1.Stop();
            Console.WriteLine($"The boat should be off. It is: {b1.IsOn}");

            // tests current speed, accelerate, brake, max speed
            Console.WriteLine($"By default current speed should be 0. It is: {b1.CurrentSpeed}");
            b1.Accelerate(30);
            Console.WriteLine($"Current speed should be 30. It is: {b1.CurrentSpeed}");
            b1.Brake(10);
            Console.WriteLine($"Current speed should be 20. It is: {b1.CurrentSpeed}");
            b1.Accelerate(45);
            Console.WriteLine($"Current speed should be 200. It is: {b1.CurrentSpeed}");
            b1.Brake(45);
            Console.WriteLine($"Current speed should be 0. It is: {b1.CurrentSpeed}");

            // test wheel direction
            Console.WriteLine($"Boat wheel direction should be center as it was constructed. It is: {b1.WheelDirection}");
            b1.TurnWheel("right");
            Console.WriteLine($"Boat wheel direction should be right. It is: {b1.WheelDirection}");
            b1.TurnWheel("left");
            Console.WriteLine($"Boat wheel direction should be left. It is: {b1.WheelDirection}");
            b1.TurnWheel("above");
            Console.WriteLine($"Boat wheel direction should not have been changed. Therefore it should be left. It is: {b1.WheelDirection}");
            b1.TurnWheel("center");
            Console.WriteLine($"Boat wheel direction should be center. It is: {b1.WheelDirection}");

            //test get brand, model, licencePlate
            Console.WriteLine($"The boat brand should be karnic. it is: {b1.Brand}");
            Console.WriteLine($"The boat model should be SL702. it is: {b1.Model}");
            Console.WriteLine($"The boat year should be 2016. it is: {b1.LincensePlateYear}");

            //test change of gear
            Console.WriteLine($"The boat gear should be N as it was constructed. It is: {b1.Gear}");
            b1.ChangeGear('1');
            Console.WriteLine($"The boat gear should be 1. It is: {b1.Gear}");
            b1.ChangeGear('2');
            Console.WriteLine($"The boat gear should be 2. It is: {b1.Gear}");
            b1.ChangeGear('3');
            Console.WriteLine($"The boat gear should be 3. It is: {b1.Gear}");
            b1.ChangeGear('4');
            Console.WriteLine($"The boat gear should be 4. It is: {b1.Gear}");
            b1.ChangeGear('5');
            Console.WriteLine($"The boat gear should be 5. It is: {b1.Gear}");
            b1.ChangeGear('N');
            Console.WriteLine($"The boat gear should be N. It is: {b1.Gear}");
            b1.ChangeGear('R');
            Console.WriteLine($"The boat gear should be R. It is: {b1.Gear}");
            b1.ChangeGear('9');
            Console.WriteLine($"The boat gear is: {b1.Gear}");
               */
            /*
         var p1 = new Catalog("apple", "grocery", 1);
         Console.WriteLine($"The product shoud be apple. It is: {p1.Product}");
         Console.WriteLine($"The category shoud be grocery. It is: {p1.Category}");
         Console.WriteLine($"The price shoud be 1. It is: {p1.Price}");
         Console.WriteLine($"The discount by default should be false: It is:{p1.HasDiscount}");
         p1.Discount();
         Console.WriteLine($"The discount should be true: It is:{p1.HasDiscount}");
         p1.NoDiscount();
         Console.WriteLine($"The discount should be false: It is:{p1.HasDiscount}");
         p1.Categories("beverages");
         Console.WriteLine($"The category should be beverages. It is: {p1.Category}");
         p1.Categories("hygiene");
         Console.WriteLine($"The category should be hygiene. It is: {p1.Category}");
         p1.Categories("grocery");
         Console.WriteLine($"The category should be grocery. It is: {p1.Category}");
         p1.Categories("pets");
         Console.WriteLine($"The category should be unavailable and retrun the previous one. It is: {p1.Category}");
         */

            /*var dog1 = new DogsAdoption("Noodles", 2, "barbado da terceira", "cinzento");
            dog1.makeAvailable();
            Console.WriteLine($"The dog should be available. It is: {dog1.IsAvailable}");
            dog1.FriendlyDog();
            Console.WriteLine($"The dog should be friendly. It is: {dog1.Sociability}");
            dog1.BadAssDog();
            Console.WriteLine($"The dog should not be friendy. It is: {dog1.Sociability}");
            dog1.Neuter();
            Console.WriteLine($"The dog should be neutered. It is: {dog1.Neutered}");*/


            /*Paper paper = new Paper();
            Pen redPen = new Pen(ConsoleColor.Red);
            Pencil pencil = new Pencil();
            paper.Write("testepen", redPen);
            paper.DisplayText();
            paper.Write("testepencil", pencil);
            paper.Erase();
            paper.DisplayText();*/

            //FICHA 26 GRUPOII EX3,4
            List<object> lists = new List<object>();
            lists.Add(new Pencil());
            lists.Add(new Pen(ConsoleColor.Red));
            lists.Add(new ColoredPencil(ConsoleColor.Yellow));
            lists.Add(new Vehicle("honda", "jazz", 2014, 280));
            lists.Add(new Motorcycle("kawasaki", "ninja", 2013, 300));
            lists.Add(new Boat("hanse yachts", "hanse 345", 2016, 50));
            lists.Add(new DogsAdoption("Pongo", 2, "bodeguero", "branco"));
            lists.Add(new Catalog("maça", "fruits", 1));











        }
    }
}
