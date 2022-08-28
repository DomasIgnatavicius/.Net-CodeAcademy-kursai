using _05_Data_Reading.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Data_Reading.Domain.Services
{
    public class FileService
    {
        public FileService(string filePath)
        {
            this._filePath = filePath;
        }
        readonly string _filePath;

        public string ReadTextFromFile() => File.ReadAllText(_filePath);

        public string[] ReadFileLines() => File.ReadAllLines(_filePath);

        public  List<Animals> FetchAnimalRecords()
        {
            int animalColumnCount = 2;
            List<Animals> animals = new List<Animals>();

            using StreamReader sr = new StreamReader(_filePath);

            string animalLine;

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animals newAnimal = new Animals(animalData);
                animals.Add(newAnimal);
            }
            return animals;
        }
    }
}
