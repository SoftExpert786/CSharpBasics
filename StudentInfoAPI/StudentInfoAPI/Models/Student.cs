﻿namespace StudentInfoAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string F_Name { get; set; }  
        public int Age { get; set; }
        public DateTime AdmissionDate { get; set; }= DateTime.Now;
    }
}
