      public class Student : College{

          // In method overloding there are same methods and different arguments are passed in same class.
        public string AddName(string name,string lastName){
        
        return name +" "+ lastName ;
        }


        public string AddName(string name){


       return name;
        }


        public override string CollegeName(){

        string collageName="Government polyechnic awasari khurd";
          return collageName;
        }


        
      }
