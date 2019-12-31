using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCourseWork
{
    class StudentRegister
    {
    private string path = "studenregister.json";
    //making Getter and Setter Properties in order to carries data into our application
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string ContactNo { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string CourseEnroll { get; set; }
    public DateTime RegisterDate { get; set; }
    
    public void Add(StudentRegister info)
        {
            Random randomID = new Random();
            info.StudentId = randomID.Next(1000, 9999);
            string input = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(path, input);
        }
    public StudentRegister Edit(int studentId)
        {
            
            StudentRegister studRegister = new StudentRegister();
            return studRegister;
        }
     public void Edit(StudentRegister info)
    {
            //calling the list method of Student Register Class in order to get the student register data
            List<StudentRegister> list = List();
            //selecting the student with specified id using List
            StudentRegister studReg = list.Where(x => x.StudentId == info.StudentId).FirstOrDefault();
            //code that will remove the student object which is updated via list
            list.Remove(studReg);
            //code will add the student object to the list
            list.Add(studReg);
            //below code will convert the list of student to string
            string input = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(path, input, false);

     }
     public void Delete(int id)
        {
            //calling the list method of Student Register Class in order to get the student register data
            List<StudentRegister> list = List();
            //selecting the student with specified id using List
            StudentRegister studReg = list.Where(x => x.StudentId == id).FirstOrDefault();
            //code that will remove the student object which is updated via list
            list.Remove(studReg);
            //code will add the student object to the list
            //list.Add(studReg);
            //below code will convert the list of student to string
            string input = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(path, input, false);

        }
        public StudentRegister Detail(int id)
    {
            StudentRegister studRegister = new StudentRegister();
            return studRegister;
     }

        public List<StudentRegister> List()
        {
            string data = Utility.ReadFromTextFile(path);
            if(data != null)
            {
                List<StudentRegister> lst = JsonConvert.DeserializeObject<List<StudentRegister>>(data);
                return lst;

            }
            return null;

        }

    }
}
