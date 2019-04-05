using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace c0732132_Assihnment_4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadKey();

        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            // Read file using StramReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/732132/c0732132-Assignment4/C0732132-Assignment-4/beowulf.txt"))
            {

                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    
                    Beowulf.Add(ln);
                  
                }

                file.Close();
                counter = File.ReadLines("U:/Users/732132/c0732132-Assignment4/C0732132-Assignment-4/beowulf.txt").Count();
                Console.WriteLine($"File has {counter} lines.");
                
            }
        }

        public int FindNumberOfBlankSpaces(string line)
        {
           
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }

                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countSpaces;

        }

    }
    
}

