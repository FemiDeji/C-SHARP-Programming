
namespace Learning 
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student (string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }
        public bool HasHonors()
        {
            if (gpa >= 4.5)
            {
                return true;
            }
            return false;
        }
        
    }
}       