using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLibrary
{
    public class HeroList
    {
        public List<SuperHero> ListOfHeros { get; set; }

        public HeroList()
        {
            ListOfHeros = new List<SuperHero>();
        }

        //add a hero to the list
        public void Add(SuperHero hero)
        {
            ListOfHeros.Add(hero);
        }

        //return a Hero at an index
        public SuperHero Get(int id)
        {
            return ListOfHeros[id];
        }

        //helper class for enumeration
        //got this from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1579?f1url=%3FappId%3Droslyn%26k%3Dk(CS1579)
        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        //helper class for enumeration
        // Declare the enumerator class:  
        public class MyEnumerator
        {
            int nIndex;
            HeroList collection;
            public MyEnumerator(HeroList coll)
            {
                collection = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < collection.ListOfHeros.Count);
            }

            public SuperHero Current => collection.ListOfHeros[nIndex];
        }
    }
}
