using System;

namespace Domain
{
    public class value
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}



/*

NOTE: 

* because we will be using Entity Framework ,
-  EF is convention base :  when we use a prop called Id inside our entity , will automatically be used as our pramary key .
! we will be using Code First Staregy ...



*/