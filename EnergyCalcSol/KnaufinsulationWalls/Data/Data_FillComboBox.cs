using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls.Data
{
    public static class Data_FillComboBox
    {


        public static bool InitDataForFill()
        {
            var MakeChoiseElement = new CBItem();
            MakeChoiseElement.index = 0;
            MakeChoiseElement.Name = "Выберите тип";
            MakeChoiseElement._intValue = 0;

            //заполняем EI
            cbItem_EI.Clear();
            foreach (var item in Data_WallsType.data)
            {
                foreach (var tp in item.types)
                {
                    var newItm = new CBItem();
                    newItm.Name = tp.EI.ToString();
                    newItm._intValue = tp.EI;

                    cbItem_EI.Add(newItm);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_EI.Distinct<CBItem>(uniCompare);
                cbItem_EI = uniqList.ToList<CBItem>();
                cbItem_EI.Sort(ComprasionByIntValue);
            }
            cbItem_EI.Insert(0, MakeChoiseElement);

            //заполняем Tp

            MakeChoiseElement.Name = "Выберите толщину";

            cbItem_TP.Clear();
            foreach (var item in Data_WallsType.data)
            {
                foreach (var tp in item.types)
                {
                    var newItm = new CBItem();
                    newItm.Name = tp.Tp.ToString();
                    newItm._intValue = tp.Tp;

                    cbItem_TP.Add(newItm);
                }
            }

            {
                var uniCompare = new CBItem_EqualityComparerBy_IntValue();
                var uniqList = cbItem_TP.Distinct<CBItem>(uniCompare);
                cbItem_TP = uniqList.ToList<CBItem>();
                cbItem_TP.Sort(ComprasionByIntValue);

            }
            cbItem_TP.Insert(0, MakeChoiseElement);


            return true;
        }



        public static List<CBItem> cbItem_EI = new List<CBItem>();

        public static List<CBItem> cbItem_TP = new List<CBItem>();


        public static int ComprasionByIntValue(CBItem x, CBItem y)
        {
            if (x._intValue == y._intValue)
                return 0;

            if (x._intValue > y._intValue)
                return 1;
            
            return -1;
        }

        class CBItem_EqualityComparerBy_IntValue : IEqualityComparer<CBItem>
        {
            public bool Equals(CBItem b1, CBItem b2)
            {
                if (b1._intValue == b2._intValue)
                    return true;
                else
                    return false;
            }

            public int GetHashCode(CBItem bx)
            {
                int hCode = bx._intValue ^ 123;
                return hCode.GetHashCode();
            }
            
        }

        public struct CBItem
        {       

            public String Name { get; set; }
            public int index { get; set; }
            public int _intValue { get; set; }
        }        
    }

}
