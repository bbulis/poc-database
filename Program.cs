using System;
using System.Diagnostics;

namespace poc_database {
    public class Program {
        public static void Main() {
            using (var db = new DatabaseContext()) {

                var tire = new Tire(){
                    TireId = Guid.NewGuid().ToString(),
                    Brand = "Falken",
                    Width = 195,
                    Height = 65,
                    RimSize = 15,
                    LoadIndex = 91,
                    SpeedIndex = 'H',
                    Description = "HS01",
                    Price = 93.72
                };
                db.Tires.Add(tire);
                db.SaveChanges();

                var tires = db.Tires;
                foreach(var _tire in tires) {
                    Console.WriteLine(_tire.ToString());
                }
            }
        }
    }
}