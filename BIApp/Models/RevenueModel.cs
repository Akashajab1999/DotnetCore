using System.Collections.Generic;
namespace BIApp.Models{
    public class RevenueModel{
        public string Name {get;set;}
        public int RevenueYear2020 {get;set;}

        public int RevenueYear2010 {get;set;}

        public int RevenueYear2000 {get;set;}

        public int RevenueYear1990 {get;set;}
    }

    public class RevenueDataAccessLayer{
        public static List<RevenueModel>GetCityRevenueList(){
            var list = new List<RevenueModel>();
            list.Add(new RevenueModel{Name="Nashik" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Nashik" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Nashik" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Nashik" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Nashik" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            return list;
        }

        public static List<RevenueModel>GetStateRevenueList(){
            var list = new List<RevenueModel>();
            list.Add(new RevenueModel{Name="Chennai" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Delhi" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Kolkata" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="kochi" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            list.Add(new RevenueModel{Name="Goa" ,RevenueYear2020=28000,RevenueYear2010=45000,RevenueYear2000=20000,RevenueYear1990=27000});
            return list;
        }
    }
}