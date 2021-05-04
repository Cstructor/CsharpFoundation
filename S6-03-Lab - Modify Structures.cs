//On the deletion you probably want to compact the array elements 
//by moving the elements to the left thus overwritting the old value.
using System;

namespace PetStructure
{
    public struct Pet
    {
        public string Name;
        public string TypeOfPet;
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0;
            var pets = new Pet[10]; // starting point

            while (true)
            {
                Console.Write("A)dd D)elete L)ist pets:");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                    case "a":
                        {
                            // Note:
                            // with add you assume that you only deal with 10 pets for now
                            // in reality you need to check if exceeding capacity
                            // and if so, you need to grow the array
                            // but this is not in the scope of this assignment
                            // at this time
                        
                            Console.Write("Name :");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;
                            pets[numberOfPets].TypeOfPet = typeOfPet;

                            numberOfPets++; // keep track of the count as you add or subtract
                            break;
                        }

                    case "D":
                    case "d":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                            }

                            for (var index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);

                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--;

                            break;
                        }

                    case "L":
                    case "l":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                            }

                            for (int index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}