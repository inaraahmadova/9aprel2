using _9aprel2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9aprel2
{
    internal class Group
    {
        static Group[] Groups;
        public static int GroupCount { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Student[] Students=new Student[0];


        public Group(int groupId, string groupName, Student[] students)
        {
            GroupId = groupId;
            GroupName = groupName;
            Students = students;
        }

        public void GetGroupInfo() 
        {
            Console.WriteLine($"Group ID: {GroupId}, Group Name: {GroupName}");
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }


        public string GetStudent(int Id)
        {
            foreach (var student in Students)
            {
                GroupId=Id;
                return GroupName;
            }
            return null;
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }


        public void Search(string searchString)
        {
            foreach (var student in Students)
            {
                if (student.Name == searchString || student.Surname == searchString)
                {
                    student.GetInfo();
                }
            }
        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }


        public override string ToString()
        {
            return $"Group ID: {GroupId}, Group Name: {GroupName},  Group Count: {Students.Length}";
        }


        private static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }


        public static void RemoveGroup(int id)
        {
            foreach (var group in Groups)
            {
                if (group.GroupId == id)
                {
                    continue;
                    Group[] NewGroups = new Group[Groups.Length - 1];
                    Groups = NewGroups;
                }
            }
        }
        public static Group GetGroup(int id)
        {
            foreach (var group in Groups)
            {
                if (group.GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }
    }
}

