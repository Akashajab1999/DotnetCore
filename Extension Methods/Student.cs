public static class Student{

    public static int p=10;
    public static void Dancing(this Person s){
        Console.WriteLine("I like Dancing");
    }

    public static int GetAge(this Person s,int p){
        return p;
    }
}