using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Enumerations.Domain.Enums;

namespace _04_Enumerations.Domain.Models
{
    internal class Society
    {
        //1
        public List<Person> People { get; set; }
        //3
        public List<Person> OldPeople
        {
            get
            {
                List<Person> oldPeople = new List<Person>();
                foreach (Person person in People)
                {
                    if (person.BirthDate < new DateTime(2001, 1, 1))
                    {
                        oldPeople.Add(person);
                    }
                }
                return oldPeople;
            }
        }
        //4
        public List<Person> Men { get; set; }
        public List<Person> Women { get; set; }
        private ESocietySortBy sortBy;




        //2
        public void FillPeople(List<Person> people)
        {
            People = people;
        }

        //5
        public void FillMen(List<Person> people)
        {
            Men = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == EGenderType.MALE)
                {
                    Men.Add(person);
                }
            }
        }

        public void FillWomen(List<Person> people)
        {
            Women = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == EGenderType.FEMALE)
                {
                    Women.Add(person);
                }
            }
        }

        //6
        public void SortByAge()
        {
            Men.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
            Women.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
        }

        //7
        public Society SortByFirstName()
        {
            sortBy = ESocietySortBy.FirstName;
            return this;
        }

        public Society SortByLastName()
        {
            sortBy = ESocietySortBy.LastName;
            return this;
        }

        public void Asc()
        {
            switch (sortBy)
            {
                case ESocietySortBy.FirstName:
                    People.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
                    break;
                case ESocietySortBy.LastName:
                    People.Sort((a, b) => a.FirstName.CompareTo(b.LastName));
                    break;
                default:
                    break;
            }
        }

        public void Desc()
        {
            switch (sortBy)
            {
                case ESocietySortBy.FirstName:
                    People.Sort((a, b) => b.FirstName.CompareTo(a.FirstName));
                    break;
                case ESocietySortBy.LastName:
                    People.Sort((a, b) => b.FirstName.CompareTo(a.LastName));
                    break;
                default:
                    break;
            }
        }

    }
}
