using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSPSS
{
    public class Data
    {
     //   public static  List<ValueCoding> valueCoding = new List<ValueCoding>();
        public static List<VariableView> variableView = new List<VariableView>();
        public static int indexRow;
        public static int[] columnChoosen = new int[100];

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
        public void setValue(double value, string labelValue, int index,int indexRow, string nama,string label,string type)
        {
            //valueCoding[index].value = value;
            //valueCoding[index].label = label;
            variableView[index].nama = nama;
            variableView[index].type = type;
            variableView[index].label = label ;
            variableView[index].valueCoding[indexRow].label = labelValue;
            variableView[index].valueCoding[indexRow].value = value;
        }

        public void init()
        {
            Data data = new Data();
        }
    }

    public class ValueCoding
    {
        public double value
        {
            get; set;
        }
        public string label
        {
            get; set;
        }
    }




    public class VariableView
    {
        public List<ValueCoding> valueCoding { get; set; }
        public string nama { get; set; }
        public string type { get; set; }
        public string label { get; set; }
        public List<string> missing { get; set; }
        public List<string> missingRange { get; set; }
   //     public int Decimal {get;set;}
    }
}
