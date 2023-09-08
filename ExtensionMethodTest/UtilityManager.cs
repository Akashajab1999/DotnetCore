public static class UtilityManger
    {
        public static int Multiplication(this MathsHelper m,int num1,int num2){
            return num1*num2;
        }
        public static int Division(this MathsHelper m ,int num1,int num2){
            return num1/num2;
        }
        public static string GetNationlityDetails(this Person p){
            return "Indian";
        }
        public static string GetStarPrefix(this string name){
            return "******"+name;
        } 
    }