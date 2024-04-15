using APBD_4.Animals;
namespace APBD_4.Visits;

public class DataBase
{
        public static List<Animal> Animals { get; set; } = new List<Animal>
        {
            new Animal { Id = 1, Name = "Dog", Category = "Mammal", Weight = 15.5, FurColor = "Brown" },
            new Animal { Id = 2, Name = "Cat", Category = "Mammal", Weight = 8.2, FurColor = "White" },
            new Animal { Id = 3, Name = "Bird", Category = "Bird", Weight = 0.3, FurColor = "Multi-colored" },
            new Animal { Id = 4, Name = "Snake", Category = "Reptile", Weight = 2.5, FurColor = "None" },
            new Animal { Id = 5, Name = "Rabbit", Category = "Mammal", Weight = 3.1, FurColor = "Gray" }

        };

        public static List<Visit> Visits { get; set; } = new List<Visit>
        {
            new Visit
            {
                Id = 1, AnimalId = 1, VisitDate = DateTime.Now.AddDays(-10), VisitDescription = "Routine checkup",
                VetFee = 50.0
            },
            new Visit
            {
                Id = 2, AnimalId = 2, VisitDate = DateTime.Now.AddDays(-5), VisitDescription = "Vaccination",
                VetFee = 30.0
            },
            new Visit
            {
                Id = 3, AnimalId = 1, VisitDate = DateTime.Now.AddDays(-2), VisitDescription = "Injury treatment",
                VetFee = 80.0
            },
            new Visit
            {
                Id = 4, AnimalId = 3, VisitDate = DateTime.Now.AddDays(-7), VisitDescription = "Wing examination",
                VetFee = 40.0
            },
            new Visit
            {
                Id = 5, AnimalId = 4, VisitDate = DateTime.Now.AddDays(-3), VisitDescription = "Skin shedding check",
                VetFee = 25.0
            } 
        };

} 