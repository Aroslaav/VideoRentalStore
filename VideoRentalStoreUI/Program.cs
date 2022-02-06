using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRentalStore;

namespace VideoRentalStoreUI
{
    static class Program
    {
        [DisplayName("New release")]
        //class ClassA: CFilm
        //{
        //    //public string Property1 { get; set; }
        //    public ClassA() { }
        //    public ClassA(string title) : base(title)
        //    {

        //        filmBonusPoint = 2;
        //    }

        //    public static explicit operator CRegularFilm(ClassA classA)
        //    {
        //        return new CRegularFilm() {  };
        //    }
        //    public override int GetRentDays()
        //    {
        //        return 3;
        //    }
        //    public override decimal CalculateRentalPrice(int days)
        //    {
        //        decimal dPrice = CPrice.BASIC_PRICE;
        //        if (days > GetRentDays())
        //            dPrice += CPrice.BASIC_PRICE * days - GetRentDays();

        //        return dPrice;
        //    }
        //}
        //[DisplayName("New release3")]
        //class ClassB: CFilm
        //{
        //    public ClassB() { }
        //    //public CRegularFilm()
        //    //{ 
        //    //    FilmType
        //    //}
        //    public ClassB(string title) : base(FilmType.RegularFilm, title, 1)
        //    {
        //    }

        //    public override int GetRentDays()
        //    {
        //        return 3;
        //    }
        //    public override decimal CalculateRentalPrice(int days)
        //    {
        //        decimal dPrice = CPrice.BASIC_PRICE;
        //        if (days > GetRentDays())
        //            dPrice += CPrice.BASIC_PRICE * days - GetRentDays();

        //        return dPrice;
        //    }
        public class ISomeInterface
        {
            public string TestString1 { get; set; }
            string TestString2 { get; set; }
        }

        public class FirstClass : ISomeInterface
        {
            public FirstClass()
            {
                TestString1 = "1";
            }
            // implement interface
        }

        public class SecondClass : ISomeInterface,ICloneable
        {

            public object Clone()
            {
                return this.MemberwiseClone();
            }

            public SecondClass()
            {
                TestString1 = "2";
            }
        }

        //}
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ClassA a = new ClassA() ;

            //object aa = Convert.ChangeType(new CRegularFilm(), typeof(CRegularFilm));
            // CRegularFilm b = (CRegularFilm)Convert.ChangeType(aa, typeof(CRegularFilm), null); //(CRegularFilm)a;
            //CFilm inFilm = new CRegularFilm("in");
            //CFilm outfilm = new CNewReleaseFilm("out");
            //CFilm clone = (CNewReleaseFilm)inFilm.Clone();
            //outfilm = (CNewReleaseFilm)clone;
            //CRegularFilm rf = (CRegularFilm)((CFilm)film).Clone();
           // inFilm = outfilm;

            //ISomeInterface obj1 = new FirstClass();
            //ISomeInterface obj2 = new SecondClass();
            //obj1 = (ISomeInterface)((SecondClass)obj2)/*.Clone()*/;
            //obj2 = obj1; // since they are both of the same type

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginDlg = new LoginForm();
            DialogResult result = loginDlg.ShowDialog();
            if(result== DialogResult.OK)
                Application.Run(new MainForm());
        }
    }
}
