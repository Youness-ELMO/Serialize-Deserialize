using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class employer
    {
        public int num;
        public string nom;
        public int age;

        public employer() { }

        public employer (int num,string nom,int age)
        {
            if (age > 18 && age < 26)
            {
                this.num = num;
                this.nom = nom;
                this.age = age;
            } else throw new Exception("non valide");

            

        }


        public override string ToString()
        {
            return "le numéro est " + num + "le nom est " + nom + "l'age est " + age;

        }

    }
}
