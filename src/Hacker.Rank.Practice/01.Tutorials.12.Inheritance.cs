using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials12Inheritance
    {

        public static void Answer()
        {
            Inheritance();
        }

        static void Inheritance()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
                scores[i] = Convert.ToInt32(inputs[i]);
            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
        }

    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        public Student(string firstname, string lastname, int i, int[] scores)
        {
            firstName = firstname;
            lastName = lastname;
            id = i;
            testScores = scores;
        }

        public string calculate()
        {
            var sum = 0;
            for (int i = 0; i < testScores.Length; i++)
                sum += testScores[i];
            var average = testScores.Length == 0 ? 0 : sum / testScores.Length;
            if (average >= 90) return "O";
            else if (average >= 80) return "E";
            else if (average >= 70) return "A";
            else if (average >= 55) return "P";
            else if (average >= 40) return "D";
            return "T";

        }
    }

}
