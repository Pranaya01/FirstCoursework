using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionCoursework
{
    class Student
    {
        private string _filepath = "student.json";
    
        public int Id { get; set; }
        public string Name { get; set; }
        //public string MName { get; set; }
        //blic string LName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Enroll { get; set; }
        public DateTime RegisterDate { get; set; }



        public void Add(Student info)
        {
            Random r = new Random();
            info.Id = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filepath, data);

        }
        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public void Edit(Student info)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //Using List to select student having the specified id
            Student st = list.Where(x => x.Id == info.Id).FirstOrDefault();
            //removing student object that is to be updated from the list 
            list.Remove(st);
            //adding updated student object to the list
            list.Add(info);
            //converting list of student to string
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of Utility Class
            Utility.WriteToTextFile(_filepath, data, false);
        }
        public void Delete(int id)
        {
            List<Student> list = List();	
            Student st = list.Where(x => x.Id == id).FirstOrDefault();
            list.Remove(st);
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filepath, data, false);
        }
        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public List<Student> List()
        {
            string d = Utility.ReadFromTextFile(_filepath);
            if(d != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(d);
                return lst;
            }
            return null;
        }
    }
}
