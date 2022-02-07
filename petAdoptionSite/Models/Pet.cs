using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petAdoptionSite.Models
{
    public class Pet
    {
        /// <summary>
        /// the given name of the pet (can be null)
        /// </summary>
        public string PetName { get; set; }
        /// <summary>
        /// The given location of pet current place of resdence or shealter.
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Given age of pet.
        /// </summary>
        public int PetAge { get; set; }
        /// <summary>
        /// Given discription of pet being notes of their pysical or behavrol traits.
        /// </summary>
        public string PetDescription { get; set; }
        /// <summary>
        /// The breed of the pet EX: golden retriever(breed of dog)
        /// </summary>
        public string PetBreed { get; set; }
        /// <summary>
        /// male or female (replace with binary?)
        /// </summary>
        public string PetGender { get; set; }
        /// <summary>
        /// value declaring if it is dog, cat, or other type of pet.
        /// </summary>
        public string PetType { get; set; }
    }
}
